<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Adminmaster.Master" CodeBehind="StudentResults.aspx.cs" Inherits="OnlineTest.StudentResults" %>

<asp:Content ID="content5" ContentPlaceHolderID="head" runat="server">

    <body>
        <form runat="server">
            <asp:GridView ID="gridview" runat="server" AutoGenerateColumns="False" >
                <Columns>
                   
                    <asp:BoundField HeaderText="Name" DataField="name"  ReadOnly="true" />
                        <asp:BoundField HeaderText="Mobile" DataField="mobile" ReadOnly="true" />
                        <asp:BoundField HeaderText="Batch No" DataField="batchno" ReadOnly="true" />
                     <asp:BoundField HeaderText="Question-1" DataField="que1" ReadOnly="true" />
                     <asp:BoundField HeaderText="Question-2" DataField="que2" ReadOnly="true" />
                        <asp:BoundField HeaderText="Question-3" DataField="que3" ReadOnly="true" />
                     <asp:BoundField HeaderText="Question-4" DataField="que4" ReadOnly="true" />
                    
                </Columns>
            </asp:GridView>
        </form>
    </body>
</asp:Content>