<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Learn about our most famous alumni</h1>
    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Last Name:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="First Name:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label6" runat="server" Text="Hogwarts House:" ></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server" >
        <asp:ListItem>Gryffindor</asp:ListItem>
        <asp:ListItem>Ravenclaw</asp:ListItem>
        <asp:ListItem>Slytherin</asp:ListItem>
        <asp:ListItem>Hufflepuff</asp:ListItem>
    </asp:DropDownList>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="search" OnClick="Button1_Click" />
    <br /><br />
    <asp:GridView ID="GridView1" runat="server" CssClass="table" Width="100%"></asp:GridView>
</asp:Content>
