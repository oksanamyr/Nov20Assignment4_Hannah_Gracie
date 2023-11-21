using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nov20Assignment4_Hannah_Gracie.KRMembers
{
    public partial class memberpage : System.Web.UI.Page
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



            Member curMember = (from item in dbcon.Members
                                where item.Member_UserID == myUser.UserID
                                select item).FirstOrDefault();
            Label1.Text = curMember.MemberFirstName + " " + curMember.MemberLastName;


            var query = from section in dbcon.Sections
                        join member in dbcon.Members on section.Member_ID equals member.Member_UserID
                        join instructor in dbcon.Instructors on section.Instructor_ID equals instructor.InstructorID
                        where instructor.InstructorID == instructor.InstructorID
                        select new
                        {
                            section.SectionName,
                            instructor.InstructorFirstName,
                            instructor.InstructorLastName,
                            section.SectionFee,
                            section.SectionStartDate,

                        };

            GridView1.DataSource = query.ToList();
            GridView1.DataBind();
        }
    }
}