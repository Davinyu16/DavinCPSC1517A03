<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SqlQuery.aspx.cs" Inherits="WebApp.SamplePages.SqlQuery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>SqlQuery: Secondary Queries in BLL</h1>
    <div class="offset-2">
        <asp:Label ID="Label1" runat="server" Text="Select a Category:"></asp:Label>&nbsp;&nbsp;
        <asp:DropDownList ID="CategoryList" runat="server"></asp:DropDownList>&nbsp;&nbsp;
        <asp:Button ID="Fetch" runat="server" Text="Fetch" />
        <br /><br />
        <asp:Label ID="MessageLabel" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="ProductList" runat="server">
            <Columns>
                <asp:TemplateField HeaderText="ID"></asp:TemplateField>
                    <itemstyle horizontalalign="Center"></itemstyle>
                    <ItemTemplate>
                        <%# Eval("ProductID") %>
                    </ItemTemplate>    
                <asp:TemplateField HeaderText="Name"></asp:TemplateField>
                    <itemstyle horizontalalign="Left"></itemstyle>
                    <ItemTemplate>
                        <asp:Label ID="Lavel2" runat="server" 
                             Text='<%# Eval("ProductID") %>'></asp:Label>
                    </ItemTemplate>
                <asp:TemplateField HeaderText="$">
                    <ItemStyle HorizontalAlign="Right"></ItemStyle>
                    <ItemTemplate>
                        <%# string.Format("{0:0.00}",Eval("UnitPrice")) %>
                    </ItemTemplate>
                </asp:TemplateField>

                <asp:TemplateField HeaderText="Disc">
                    <ItemStyle HorizontalAlign="Center"></ItemStyle>
                    <ItemTemplate>
                        <asp:CheckBox ID="CheckBox1" runat="server" />
                            checked='<%# Eval("Discontinued")%>
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            <EmptyDataTemplate>
                No data to display
            </EmptyDataTemplate>
        </asp:GridView>
    </div>
</asp:Content>
