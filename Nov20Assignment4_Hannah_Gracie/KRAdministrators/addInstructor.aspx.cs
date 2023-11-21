using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nov20Assignment4_Hannah_Gracie.KRAdministrators
{
    public partial class addInstructor : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Graci\\Source\\Repos\\Nov20Assignment4_Hannah_Gracie\\Nov20Assignment4_Hannah_Gracie\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";
        public void RefreshData()
        {
            // KarateDataContext instance
            KarateDataContext dataConnection = new KarateDataContext(connectionString);
            // LINQ query
            var updatedData = from item in dataConnection.Instructors
                              orderby item.InstructorID
                              select new
                              {
                                  InstructorID = item.InstructorID,
                                  InstructorFirstName = item.InstructorFirstName,
                                  InstructorLastName = item.InstructorLastName
                              };

            // Set GridViewView's DataSource propery to result of query and bind
            GridView1.DataSource = updatedData;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            KarateDataContext dataConnection = new KarateDataContext(connectionString);
            // LINQ query
            var data = from item in dataConnection.Instructors
                       orderby item.InstructorID
                       select new
                       {
                           InstructorID = item.InstructorID,
                           InstructorFirstName = item.InstructorFirstName,
                           InstructorLastName = item.InstructorLastName
                       };

            // Set GridViewView's DataSource propery to result of query and bind
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            KarateDataContext dataConnection = new KarateDataContext(connectionString);

            string instructor = "Instructor";

            NetUser user = new NetUser
            {
                UserName = TextBox4.Text,
                UserPassword = TextBox5.Text,
                UserType = instructor.ToString()
            };

            dataConnection.NetUsers.InsertOnSubmit(user);

            // Submit changes to the database
            dataConnection.SubmitChanges();

            var result2 = (from item in dataConnection.NetUsers
                           where item.UserName == TextBox4.Text
                           select item.UserID).Single();

            Instructor instructor1 = new Instructor
            {
                InstructorID = Convert.ToInt32(result2),
                InstructorFirstName = TextBox1.Text,
                InstructorLastName = TextBox3.Text,
                InstructorPhoneNumber = TextBox2.Text
            };

            dataConnection.Instructors.InsertOnSubmit(instructor1);

            // Submit changes to the database
            dataConnection.SubmitChanges();

            RefreshData();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/KRAdministrators/administrator.aspx");

        }
    }
}