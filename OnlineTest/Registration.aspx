<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Adminmaster.Master" CodeBehind="Registration.aspx.cs" Inherits="OnlineTest.Registration" %>
<asp:Content ID="content3" ContentPlaceHolderID="head" runat="server">
  <form runat="server">
      <h2 style="text-align:center">Registration Page</h2>
      <table>
          <tr>
              <title>hi </title>
              <asp:TextBox ID="txtname" placeholder="Enter the Name" runat="server"></asp:TextBox> </tr>
           <tr>
              <asp:TextBox ID="txtemail" placeholder="Enter the email" runat="server"></asp:TextBox> </tr>
           <tr>
              <asp:TextBox ID="txtmobilenumber" placeholder="Enter the phone number" runat="server"></asp:TextBox> </tr>
           <tr>
              <asp:TextBox ID="txtpassword" placeholder="Enter the password" runat="server"></asp:TextBox> </tr>
           <tr>
              <asp:TextBox ID="txtbatchnumber" placeholder="Enter the Batch Number" runat="server"></asp:TextBox> </tr>
          <tr>
              <asp:RadioButtonList ID="RadioButtonList1" RepeatDirection="Horizontal" runat="server">
                  <asp:ListItem>Admin</asp:ListItem>
                  <asp:ListItem>Student</asp:ListItem>
              </asp:RadioButtonList> </tr>
      </table>
      <center>
      <asp:Button ID="btnaddcandidate" runat="server" Text="Add Candidate" OnClick="btnaddcandidate_Click" />
          </center>
      <asp:Label ID="Lblname" runat="server" Text=""></asp:Label>
  </form>
</asp:Content>
