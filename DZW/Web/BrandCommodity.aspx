<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" StylesheetTheme="SkinDefault"
    CodeBehind="BrandCommodity.aspx.cs" Inherits="Web.BrandCommodity" %>

<%@ Register src="Controls/ucCommodity.ascx" tagname="ucCommodity" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Commodity.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bcom">
        <div class="bctop">
            <div class="brandlogo">
                <asp:Image ID="imgBLogo" runat="server" Width="150px" Height="130px" ImageUrl="~/Info/Brand/asos.jpg" />
                <br />
                <asp:Label ID="lblBrandName" runat="server" Text="ASOS"></asp:Label>
            </div>
            <div class="brandad">
                <asp:Image ID="imgBAd" runat="server" Width="100%" Height="100%" ImageUrl="~/Styles/Image/ad.jpg" />
            </div>
        </div>
        <div class="comTitle">
            <asp:Label ID="Label13" runat="server" Text="女装 |" CssClass="lblTitle"></asp:Label>
            <asp:Label ID="Label1" runat="server" Text="上衣 &nbsp; 下装 &nbsp; 连衣裙"></asp:Label>
        </div>
        
        <div class="uplog">
            &nbsp;上衣
        </div>
        <asp:DataList ID="dlJacket" runat="server" RepeatColumns="4" CellPadding="0" CellSpacing="0">
            <ItemTemplate>                
                <uc1:ucCommodity ID="ucCommodity1" runat="server" ImageUrl='<%#Bind("ImageUrl") %>'
                CommodityID='<%#Bind("CommodityID") %>' CurrentPrice='<%#Bind("SalePrice") %>' OrginalPrice='<%#Bind("Price") %>' />                
            </ItemTemplate>
        </asp:DataList>
        <div class="moreCom">
            <asp:Button ID="Button2" runat="server" Text="更多" CssClass="btnMore" /></div>
        <div class="uplog">
            &nbsp;下装</div>
        <asp:DataList ID="dlbottoms" runat="server" RepeatColumns="4" CellPadding="0" CellSpacing="0">
            <ItemTemplate>                
                <uc1:ucCommodity ID="ucCommodity2" runat="server" ImageUrl='<%#Bind("ImageUrl") %>' 
                CommodityID='<%#Bind("CommodityID") %>' CurrentPrice='<%#Bind("SalePrice") %>' OrginalPrice='<%#Bind("Price") %>' />                
            </ItemTemplate>
        </asp:DataList>
        <div class="moreCom">
            <asp:Button ID="Button1" runat="server" Text="更多"  CssClass="btnMore"/></div>
        <div class="uplog">
            &nbsp;连衣裙</div>
        <asp:DataList ID="dldress" runat="server" RepeatColumns="4" CellPadding="0" CellSpacing="0">
            <ItemTemplate>                
                <uc1:ucCommodity ID="ucCommodity3" runat="server" ImageUrl='<%#Bind("ImageUrl") %>' 
                CommodityID='<%#Bind("CommodityID") %>' CurrentPrice='<%#Bind("SalePrice") %>' OrginalPrice='<%#Bind("Price") %>' />                
            </ItemTemplate>
        </asp:DataList>
        <div class="moreCom">
            <asp:Button ID="Button3" runat="server" Text="更多" CssClass="btnMore" /></div>
        <div>
        
        </div>
    </div>
    <asp:HiddenField ID="hfBrandID" runat="server" />
</asp:Content>
