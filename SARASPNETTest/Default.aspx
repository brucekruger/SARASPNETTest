<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="SARASPNETTest._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Welcome to SQL Azure and SQL Azure Reporting!
    </h2>
    <p>
        To learn more about SQL Azure visit <a href="https://www.windowsazure.com/en-us/home/tour/sql-azure/" title="SQL Azure Website">https://www.windowsazure.com/en-us/home/tour/sql-azure/</a>.
    </p>
    <p>
        You can also find 
        <a href="http://msdn.microsoft.com/en-us/library/windowsazure/ee336279.aspx"
            title="MSDN ASP.NET Docs">documentation on SQL Azure on MSDN</a>.
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
