<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Singup.aspx.cs" Inherits="OnlineTest.Singup" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <h2 style="text-align:center">Login Page</h2>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtusername" placeholder="Enter User Name"  runat="server"></asp:TextBox> &nbsp;
        
        <asp:TextBox ID="txtpassword" placeholder="Enter PAssword" Type="password"  runat="server"></asp:TextBox> &nbsp;
        <center>
        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" /> &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btncancel" runat="server" Text="Cancel" OnClick="btncancel_Click" />
            </center>
            
        <asp:Label ID="lblmessage"  runat="server" Text="" BorderStyle="Ridge"></asp:Label>
            
    </form>
   </asp:Content>

