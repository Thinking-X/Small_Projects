<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="NewsPublishSystem.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <h1 style="text-align:center;">
        <asp:label ID="label1" runat="server">
        </asp:label>
    </h1>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br /><br />
    <p style="text-indent:50px; font-size:20px;">
        <asp:label ID="label2" runat="server" >
        </asp:label>
    </p>
    <br />
    <div class="desc">15k阅读 1k评论</div>
    <br />
</asp:Content>
