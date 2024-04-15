<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subjects.aspx.cs" Inherits="WebApplication1.Subjects" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Every young wizard must know a lot of different areas of magic. That's why we offer the best and most diverse subjects!</h3>
    <br /><br />
    <asp:GridView ID="GridView1" runat="server" Visible="false"></asp:GridView>
    <br /><br /><br />
    <footer>Warning: The restricted section of the library <i>might</i> teach your chldren dark magic, but we cannot confirm that. Also, the Defense Against The Dark Arts teaching postion <i>may</i> be cursed, but that's not been confirmed</footer>
</asp:Content>
