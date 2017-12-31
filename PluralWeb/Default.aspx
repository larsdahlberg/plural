<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PluralWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead">PluralWebApp - type in a word and you will get its plural form...</p>
        <p><a href="http://www.asp.net">Pluralize</a></p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="1105px" Height="74px" Rows="2" TextMode="MultiLine"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pluralize..." />
        </p>
    </div>

    

</asp:Content>
