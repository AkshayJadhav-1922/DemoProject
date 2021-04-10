<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="Demo.Contact" %>
<%@ Register TagPrefix="uc" TagName="ContactForm" Src="~/ContactForm.ascx" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
    <h3>Contact Us</h3>
    <uc:ContactForm ID="cfMessage" runat="server"></uc:ContactForm>
    <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click" />
    <br />
    <asp:Label ID="lblLabel" runat="server"></asp:Label>
</asp:Content>
