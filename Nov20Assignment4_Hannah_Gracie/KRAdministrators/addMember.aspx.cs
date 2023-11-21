using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Nov20Assignment4_Hannah_Gracie.KRAdministrators
{
    public partial class addMember : System.Web.UI.Page
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
                              
                               MemberFirstName = item.MemberFirstName,
                               MemberLastName = item.MemberLastName
                           };

            // Set GridViewView's DataSource propery to result of query and bind
            GridView1.DataSource = updated1;
            GridView1.DataBind();

        }
        protected void Page_Load(object sender, EventArgs e)
        {

            KarateDataContext dataConnection = new KarateDataContext(connectionString);

            var result2 = from item in dataConnection.Members
                          orderby item.Member_UserID
                          select new
                          {
                              MemberFirstName = item.MemberFirstName,
                              MemberLastName = item.MemberLastName
                          };

            // Set AutoTypesLIST's DataSource propery to result of query and bind
            GridView1.DataSource = result2;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            KarateDataContext dataConnection = new KarateDataContext(connectionString);

            string member = "Member";

            NetUser user = new NetUser
            {
                UserName = TextBox6.Text,
                UserPassword = TextBox7.Text,
                UserType = member.ToString()
            };

            dataConnection.NetUsers.InsertOnSubmit(user);

            // Submit changes to the database
            dataConnection.SubmitChanges();

            var result2 = (from item in dataConnection.NetUsers
                           where item.UserName == TextBox6.Text
                           select item.UserID).Single();

            Member member1 = new Member
            {
                Member_UserID = Convert.ToInt32(result2),
                MemberFirstName = TextBox1.Text,
                MemberLastName = TextBox2.Text,
                MemberDateJoined = Convert.ToDateTime(TextBox3.Text),
                MemberPhoneNumber = TextBox4.Text,
                MemberEmail = TextBox5.Text
            };

            dataConnection.Members.InsertOnSubmit(member1);

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