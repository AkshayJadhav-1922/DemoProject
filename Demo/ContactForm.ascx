<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ContactForm.ascx.cs" Inherits="Demo.ContactForm" %>
    <table>
        <tr>
            <td><strong>Name</strong></td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <td><strong>Message</strong></td>
        <td>
            <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </table>