<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AdminProfesssor.aspx.cs" Inherits="WebApplication1.AdminProfesssor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>As the fat Lady would say: 'Password?'. Don't worry, this one doesn't change every week. In fact, you don't even need a wand to log into here! </h3>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="Username:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="Password:"></asp:Label> 
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Log in" OnClick="Button1_Click" />
    <br /><br />
    <asp:Label ID="MessageLabel" runat="server" Text=""></asp:Label>
    <br /><br /><br /><br />
    <asp:Label ID="HeaderLabel" runat="server" Text="Search Professors:" Font-Bold="True" Visible="False"></asp:Label>
    <br /><br />
    <asp:Label ID="Label4" runat="server" Text="Last Name:" Visible="False"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label5" runat="server" Text="First Name:" Visible="False"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
    <br /><br />
    <asp:Button ID="Button2" runat="server" Text="search" OnClick="Button2_Click" Visible="False" />
    <br /><br />
    <asp:GridView ID="GridView1" runat="server" CssClass="table" Width="100%"></asp:GridView>
    <br />
</asp:Content>
