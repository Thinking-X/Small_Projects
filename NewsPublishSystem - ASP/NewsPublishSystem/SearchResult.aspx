<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="NewsPublishSystem.SearchResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
            <h1>搜索结果</h1>
            <div class="list">
        </HeaderTemplate>
        <ItemTemplate>
            <div class="item">
                <div class="title">
                    <a href="WebForm1.aspx?id=<%# ((Hashtable)Container.DataItem)["NewsID"] %>" class="title"><%# ((Hashtable)Container.DataItem)["Title"] %></a>
                </div>
                <div class="desc">15k阅读 1k评论</div>
            </div>    
        </ItemTemplate>
        <FooterTemplate>
            </div>
        </FooterTemplate>
     </asp:Repeater>
</asp:Content>
