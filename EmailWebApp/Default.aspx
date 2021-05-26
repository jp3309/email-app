<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EmailWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        
        <asp:Panel runat="server" BackColor="White" Height="300px" Width="600px" style="background-color: lightblue;margin-top: 100px;padding-top:40px;">
            <asp:Label ID="RecipientLabel" runat="server" Text="To:" style="margin-left:100px;"></asp:Label>
            <asp:TextBox ID="ToTextBox" runat="server" Height="25px" Width="320px" style="margin-left:40px;"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="SenderLabel" runat="server" Text="From:" style="margin-left:85px;"></asp:Label>
            <asp:TextBox ID="FromTextBox" runat="server" Height="25px" Width="320px" style="margin-left:40px;"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="SubjectLabel" runat="server" Text="Subject:" style="margin-left:70px;"></asp:Label>
            <asp:TextBox ID="SubjectTextBox" runat="server" Height="25px" Width="320px" style="margin-left:40px;"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="MessageLabel" runat="server" Text="Message:" style="margin-left:60px;"></asp:Label>
            <asp:TextBox ID="MessageTextBox" runat="server" Height="70px" Width="320px" style="margin-left:40px;"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="SendEmailButton" runat="server" OnClick="SendEmailButton_Click" Text="Send Email" style="margin-left:250px;" />
        </asp:Panel>
    </div>

    

</asp:Content>
