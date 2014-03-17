<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NearbyNowWebFormsExample._Default" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Nearby Now ASP.NET City Page Examples:</h3>
    <ol class="round">
        <li class="one">
            <h5>City Page One</h5>
            <a runat="server" href="~/CityPageOne.aspx">View</a>
        </li>
        <li class="one">
            <h5>City Page Two</h5>
            <a runat="server" href="~/CityPageTwo.aspx">View</a>
        </li>
    </ol>
</asp:Content>
