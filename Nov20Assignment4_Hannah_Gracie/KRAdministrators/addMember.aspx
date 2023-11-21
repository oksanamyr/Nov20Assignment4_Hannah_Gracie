<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="addMember.aspx.cs" Inherits="Nov20Assignment4_Hannah_Gracie.KRAdministrators.addMember" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p style="margin-left: 80px" class="text-decoration-underline">
        <strong>Add Member</strong></p>
    <p style="margin-left: 160px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
    <p style="margin-left: 160px">
        First Name:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Last Name:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        Date Joined:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    <p style="margin-left: 160px">
        Phone Number:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 160px">
        &nbsp;Username:
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Password:&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 160px">
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Member" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Admin Home" />
&nbsp;&nbsp;
    </p>
    <p style="margin-left: 160px">
        &nbsp;</p>
    <p style="margin-left: 160px">
        &nbsp;</p>
</asp:Content>
