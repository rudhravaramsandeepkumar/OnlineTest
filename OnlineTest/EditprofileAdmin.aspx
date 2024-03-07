<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Adminmaster.Master" CodeBehind="EditprofileAdmin.aspx.cs" Inherits="OnlineTest.EditprofileAdmin" %>

<asp:Content ID="content3" ContentPlaceHolderID="head" runat="server">
     <form id="form2" runat="server" >
        <h2 style="text-align:center">View Profile</h2>
       <table>
            <thead>
                <tr>
                    <th><h2 style="text-align:left">Id Number :</h2></th>
                    <th><h2 style="text-align:center">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                   </h2></th>
                   </tr>

                <tr>
                    <th><h2 style="text-align:left">Name :</h2></th>
                    <th><h2 style="text-align:center">
                        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                   </h2></th>
                   </tr>
                <tr>
                    <th><h2 style="text-align:left">Email :</h2></th>
                    <th><h2>
                  <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>  </h2></th>
                   </tr>
                <tr>
                    <th><h2 style="text-align:left">Mobile :</h2></th>
                    <th><h2>
                     <asp:TextBox ID="txtmobile" runat="server"></asp:TextBox></h2></th>
                   </tr>
                <tr>
                    <th><h2 style="text-align:left">Batch No :</h2></th>
                    <th><h2>
                   <asp:TextBox ID="txtbatchno" runat="server"></asp:TextBox> </h2></th>
                   </tr>
            </thead>
        </table>
         <center>
    <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
        </center>
         <asp:Label ID="lblmessage" runat="server" Text=""></asp:Label>
    </form>
    
</asp:Content>
