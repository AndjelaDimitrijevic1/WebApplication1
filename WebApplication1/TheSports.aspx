<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TheSports.aspx.cs" Inherits="WebApplication1.TheSports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1><b>Stay up to date with Hogwarts Quidditch - six games a year, six adrenaline filled days!</b></h1>
    <br /><br />
    <asp:Label ID="Label1" runat="server" Text="Label">Sign up for an anual Quidditch match pass!</asp:Label>
    <br /><br />
    <asp:Label ID="Label2" runat="server" Text="First name:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Label ID="Label3" runat="server" Text="Last name:"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br /><br />
    <asp:Button ID="Button1" runat="server" Text="Sign up" OnClick="Button1_Click"/>
    <br /><br /><br />
    <asp:ImageButton ID="ImageButton1" runat="server" OnClick="ImageButton1_Click" Height="250px" Width="200px" ImageUrl="~/HousesPcs/Gryffindor-Logo.png" />
    <asp:ImageButton ID="ImageButton2" runat="server" OnClick="ImageButton2_Click" Height="260px" Width="210px" ImageUrl="~/HousesPcs/HARRY_POTTER-_SLYTHERIN_CREST.png" />
    <asp:ImageButton ID="ImageButton3" runat="server" OnClick="ImageButton3_Click" Height="250px" Width="200px" ImageUrl="~/HousesPcs/7fd273912c5104ca81124464b8f73937.jpg" />
    <asp:ImageButton ID="ImageButton4" runat="server" OnClick="ImageButton4_Click" Height="250px" Width="200px" ImageUrl="~/HousesPcs/e0e2bca469b63385d89ec2f1250e4ca5.png" />
    <br /><br /><br /><br />
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
    <br /><br />
</asp:Content>
