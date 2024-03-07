<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Studentmaster.Master" CodeBehind="ViewprofileStudent.aspx.cs" Inherits="OnlineTest.ViewprofileStudent" %>

<asp:Content ID="content6" ContentPlaceHolderID="head" runat="server">
    <form id="form6" runat="server" >
        <h2 style="text-align:center">View Profile</h2>
       <table>
            <thead>
                <tr>
                    <th><h2 style="text-align:left">Name :</h2></th>
                    <th><h2 style="text-align:center">
                    <asp:Label ID="lblname" runat="server" Text=""></asp:Label></h2></th>
                   </tr>
                <tr>
                    <th><h2 style="text-align:left">Email :</h2></th>
                    <th><h2>
                    <asp:Label ID="lblemail" runat="server" Text=""></asp:Label></h2></th>
                   </tr>
                <tr>
                    <th><h2 style="text-align:left">Mobile :</h2></th>
                    <th><h2>
                    <asp:Label ID="lblmobile" runat="server" Text=""></asp:Label></h2></th>
                   </tr>
                <tr>
                    <th><h2 style="text-align:left">Batch No :</h2></th>
                    <th><h2>
                    <asp:Label ID="lblbatchno" runat="server" Text=""></asp:Label></h2></th>
                   </tr>
            </thead>
        </table>
    </form>
</asp:Content>
