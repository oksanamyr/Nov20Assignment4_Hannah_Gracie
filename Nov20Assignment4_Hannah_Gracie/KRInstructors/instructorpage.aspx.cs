using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nov20Assignment4_Hannah_Gracie.KRInstructors
{
    public partial class instructorpage : System.Web.UI.Page
    {
        KarateDataContext dbcon;
        string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\16123\\Source\\Repos\\Nov20Assignment4_Hannah_Gracie\\Nov20Assignment4_Hannah_Gracie\\App_Data\\KarateSchool.mdf;Integrated Security=True;Connect Timeout=30";

        protected void Page_Load(object sender, EventArgs e)
        {
            dbcon = new KarateDataContext(conn);
            string myUserName = User.Identity.Name;
            
            NetUser myUser = (from x in dbcon.NetUsers
                              where x.UserName == myUserName
                              select x).First();

         

          Instructor curInstructor = (from item in dbcon.Instructors
                             where item.InstructorID==myUser.UserID
                             select item).FirstOrDefault();
            Label1.Text = curInstructor.InstructorFirstName+ " "+ curInstructor.InstructorLastName;

            var query = from section in dbcon.Sections
                        join member in dbcon.Members on section.Member_ID equals member.Member_UserID
                        join instructor in dbcon.Instructors on section.Instructor_ID equals instructor.InstructorID
                        where instructor.InstructorID == instructor.InstructorID
                        select new
                        {
                            section.SectionName,
                            member.MemberFirstName,
                            member.MemberLastName
                        };

            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}