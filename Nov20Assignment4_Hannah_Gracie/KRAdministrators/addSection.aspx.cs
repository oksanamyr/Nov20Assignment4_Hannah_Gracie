using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nov20Assignment4_Hannah_Gracie.KRAdministrators
{
    public partial class addSection : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Graci\\Source\\Repos\\Nov20Assignment4_Hannah_Gracie\\Nov20Assignment4_Hannah_Gracie\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // KarateDataContext instance
                KarateDataContext dataConnection = new KarateDataContext(connectionString);

                // LINQ query
                var result1 = from item in dataConnection.Members
                              orderby item.Member_UserID
                              select new
                              {
                                  Member_UserID = item.Member_UserID,
                                  MemberFirstName = item.MemberFirstName,
                                  MemberLastName = item.MemberLastName,
                                  MemberPhoneNumber = item.MemberPhoneNumber,
                                  MemberDateJoined = item.MemberDateJoined
                              };

                // Set GridViewView's DataSource propery to result of query and bind
                GridView1.DataSource = result1;
                GridView1.DataBind();

                var updatedData = from item in dataConnection.Instructors
                                  orderby item.InstructorID
                                  select new
                                  {
                                      InstructorID = item.InstructorID,
                                      InstructorFirstName = item.InstructorFirstName,
                                      InstructorLastName = item.InstructorLastName
                                  };

                // Set GridViewView's DataSource propery to result of query and bind
                GridView2.DataSource = updatedData;
                GridView2.DataBind();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            KarateDataContext dataConnection = new KarateDataContext(connectionString);


            int memberId = Convert.ToInt32(GridView1.SelectedDataKey[0]);
            int instructorId = Convert.ToInt32(GridView2.SelectedDataKey[0]);

            string sectionName = TextBox1.Text;
            string start = TextBox2.Text;
            decimal sectionFee = (Convert.ToDecimal(TextBox3.Text)) / 100;

            Section section = new Section
            {
                SectionName = sectionName,
                SectionStartDate = Convert.ToDateTime(start),
                Member_ID = memberId,
                Instructor_ID = instructorId,
                SectionFee = sectionFee,
            };

            dataConnection.Sections.InsertOnSubmit(section);

            // Submit changes to the database
            dataConnection.SubmitChanges();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/KRAdministrators/administrator.aspx");

        }
    }
}