<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DepartmentUI.aspx.cs" Inherits="StudentInfo.UI.DepartmentUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td colspan="2" align="center">
            <asp:Label ID="messageLabel" runat="server" ></asp:Label>
        </td>
    </tr>
    <tr>
        <td>Department Name</td>
        <td>
            <asp:TextBox ID="deptNameTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2" align="right">
            <asp:Button ID="saveButton" runat="server" Text="Save" 
                onclick="saveButton_Click" />
        </td>
    </tr>
</table>
</asp:Content>
