using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nov20Assignment4_Hannah_Gracie.KRAdministrators
{
    public partial class administrator : System.Web.UI.Page
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Graci\\Source\\Repos\\Nov20Assignment4_Hannah_Gracie\\Nov20Assignment4_Hannah_Gracie\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

        public void RefreshData()
        {
            // KarateDataContext instance
            KarateDataContext dataConnection = new KarateDataContext(connectionString);

            var updated1 = from item in dataConnection.Members
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
            GridView1.DataSource = updated1;
            GridView1.DataBind();

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
            GridView2.DataSource = updatedData;
            GridView2.DataBind();
        }
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

                // Set GridViewView2's DataSource propery to result of query and bind
                // LINQ query
                var result2 = from item in dataConnection.Instructors
                              orderby item.InstructorID
                              select new
                              {
                                  InstructorID = item.InstructorID,
                                  InstructorFirstName = item.InstructorFirstName,
                                  InstructorLastName = item.InstructorLastName
                              };

                // Set AutoTypesLIST's DataSource propery to result of query and bind
                GridView2.DataSource = result2;
                GridView2.DataBind();
            }
        }

        //Redirect admin to the add member page
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addMember.aspx");
        }

        //Redirect admin to the add instructor page

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("addInstructor.aspx");
        }

        //Delete selected instructor and member using LINQ queries
        protected void Button3_Click(object sender, EventArgs e)
        {

            if (GridView1.SelectedIndex != -1)
            {
                // KarateDataContext instance
                KarateDataContext dataConnection = new KarateDataContext(connectionString);

                // Get the memberID of the selected member
                int memberId = Convert.ToInt32(GridView1.SelectedDataKey[0]);

                // Get the user to delete using LINQ query
                NetUser userToDelete = (from item in dataConnection.NetUsers
                                        where item.UserID == memberId
                                        select item).SingleOrDefault();

                // Get the member to delete using LINQ query
                Member memberToDelete = (from item in dataConnection.Members
                                         where item.Member_UserID == memberId
                                         select item).SingleOrDefault();

                // Get the selction to delete using LINQ query
                Section sectionToDelete = (from item in dataConnection.Sections
                                           where item.Member_ID == memberId
                                           select item).SingleOrDefault();

                // Delete user, member, and section 
                dataConnection.NetUsers.DeleteOnSubmit(userToDelete);

                dataConnection.Members.DeleteOnSubmit(memberToDelete);

                dataConnection.Sections.DeleteOnSubmit(sectionToDelete);


                // Submit changes to the database
                dataConnection.SubmitChanges();

                RefreshData();

            }

            // Check to make sure an entry is selected in GridViewView
            if (GridView2.SelectedIndex != -1)
            {
                // KarateDataContext instance
                KarateDataContext dataConnection = new KarateDataContext(connectionString);

                // Get the instructorID of the selected model
                int instructorId = Convert.ToInt32(GridView2.SelectedDataKey[0]);

                //Get the user to delete
                NetUser userToDelete = (from item in dataConnection.NetUsers
                                        where item.UserID == instructorId
                                        select item).SingleOrDefault();


                // Get the instructor to delete using LINQ query
                Instructor instructorToDelete = (from item in dataConnection.Instructors
                                                 where item.InstructorID == instructorId
                                                 select item).SingleOrDefault();

                dataConnection.NetUsers.DeleteOnSubmit(userToDelete);

                // Delete instructor 
                dataConnection.Instructors.DeleteOnSubmit(instructorToDelete);

                // Submit changes to the database
                dataConnection.SubmitChanges();

                RefreshData();

            }
        }

        //Redirects to the add selection page
        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("addSection.aspx");
        }
    }
}