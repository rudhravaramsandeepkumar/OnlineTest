﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Adminmaster.Master" CodeBehind="StudentFeedBack.aspx.cs" Inherits="OnlineTest.StudentFeedBack" %>

<asp:Content ID="content3" ContentPlaceHolderID="head" runat="server">
    <body>
        <form runat="server">
            <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="False" >
                <Columns>
                   
                    <asp:BoundField HeaderText="Name" DataField="name"  ReadOnly="true" />
                        <asp:BoundField HeaderText="Mobile" DataField="mobile" ReadOnly="true" />
                        <asp:BoundField HeaderText="Email" DataField="email" ReadOnly="true" />
                        <asp:BoundField HeaderText="Batch No" DataField="batchno" ReadOnly="true" />
                        <asp:BoundField HeaderText="Discription" DataField="disc" ReadOnly="true" />
                    
                </Columns>
            </asp:GridView>
        </form>
    </body>
</asp:Content>