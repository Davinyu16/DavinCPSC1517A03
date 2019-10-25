<%@ Page Title="Basic Controls" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BasicControls.aspx.cs" Inherits="WebApp.SamplePages.BasicControls" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1 id="NumberChoice">Common Basic Controls<table align="center" class="nav-justified">
        <tr>
            <td style="width: 681px; height: 61px">Enter a value from 1-4</td>
            <td style="height: 61px">
                <asp:TextBox ID="TextBox1" runat="server" Height="51px" ToolTip="Enter a number between 1-4" Width="314px"></asp:TextBox>
                <asp:Button ID="SubmitNumberChoice" runat="server" Text="Submit" />
            </td>
        </tr>
        <tr>
            <td style="width: 681px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 681px; height: 39px">
                <asp:Label ID="AlterLabel" runat="server" Text="Course Choices"></asp:Label>
            </td>
                
            <td style="height: 39px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server">

                    <asp:ListItem Value="1">COMP1088</asp:ListItem>
                    <asp:ListItem Value="2">CPSC1517</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td style="width: 681px">
                <asp:Literal ID="Literal1" runat="server" Text="Programing Course"></asp:Literal>
            </td>
            <td>
                <asp:CheckBox ID="ProgrammingCourseActive" runat="server" />
            </td>
        </tr>
        <tr>
            <td style="width: 681px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 681px">
                <asp:Label ID="Label3" runat="server" Text="Selection of Course"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="CollectionChoiceList" runat="server"></asp:DropDownList>
                <asp:LinkButton ID="CollectionSubmit" runat="server">CollectionSubmit</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 681px" colspan="2"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="MessageLabel" runat="server" ></asp:Label>
            </td>
        </tr>
        </table>
    </h1>
    
</asp:Content>
