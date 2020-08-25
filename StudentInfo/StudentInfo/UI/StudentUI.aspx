<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentUI.aspx.cs" Inherits="StudentInfo.UI.StudentUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
    <tr>
        <td colspan="2" align="center">
            <asp:Label ID="messageLabel" runat="server" ></asp:Label>
            <asp:TextBox ID="studentIdTextBox" Type="hidden" runat="server" Visible="False"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td>Department Name</td>
        <td>
            <asp:DropDownList ID="dptNameDropDownList" runat="server" Height="16px" 
                Width="126px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>Student Name</td>
        <td>
            <asp:TextBox ID="studentNameTextBox" runat="server" Width="125px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Roll No</td>
        <td>
            <asp:TextBox ID="rollNoTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Reg No</td>
        <td>
            <asp:TextBox ID="regNoTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Age</td>
        <td>
            <asp:TextBox ID="ageTextBox" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td><asp:Button ID="addButton" runat="server" Text="Add" 
                onclick="addButton_Click" /></td>
        <td><asp:Button ID="saveButton" runat="server" Text="Save" 
                onclick="saveButton_Click" /></td>
        <td><asp:Button ID="updateButton" runat="server" Text="Update" 
                onclick="updateButton_Click" /></td>

                <td>
                    <asp:Button ID="deleteButton" runat="server" Text="Delete" 
                        onclick="deleteButton_Click" /></td>
        
    </tr>
    <tr>
       <td colspan="2" align="center">
           <asp:GridView ID="studentGridView" runat="server" AutoGenerateColumns="False" 
               onselectedindexchanged="studentGridView_SelectedIndexChanged">
               <Columns>
                   <asp:TemplateField HeaderText="StudentId" Visible="False">
                       <EditItemTemplate>
                           <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("StudentId") %>'></asp:TextBox>
                       </EditItemTemplate>
                       <ItemTemplate>
                           <asp:Label ID="Label1" runat="server" Text='<%# Bind("StudentId") %>'></asp:Label>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="StudentName">
                       <EditItemTemplate>
                           <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("StudentName") %>'></asp:TextBox>
                       </EditItemTemplate>
                       <ItemTemplate>
                           <asp:Label ID="Label2" runat="server" Text='<%# Bind("StudentName") %>'></asp:Label>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="RollNo">
                       <EditItemTemplate>
                           <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("RollNo") %>'></asp:TextBox>
                       </EditItemTemplate>
                       <ItemTemplate>
                           <asp:Label ID="Label3" runat="server" Text='<%# Bind("RollNo") %>'></asp:Label>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="RegNo">
                       <EditItemTemplate>
                           <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("RegNo") %>'></asp:TextBox>
                       </EditItemTemplate>
                       <ItemTemplate>
                           <asp:Label ID="Label4" runat="server" Text='<%# Bind("RegNo") %>'></asp:Label>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:TemplateField HeaderText="Age">
                       <EditItemTemplate>
                           <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("Age") %>'></asp:TextBox>
                       </EditItemTemplate>
                       <ItemTemplate>
                           <asp:Label ID="Label5" runat="server" Text='<%# Bind("Age") %>'></asp:Label>
                       </ItemTemplate>
                   </asp:TemplateField>
                   <asp:CommandField ShowSelectButton="True" />
               </Columns>
           </asp:GridView>
       </td> 
    </tr>
</table>
</asp:Content>
