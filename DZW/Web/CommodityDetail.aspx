<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    StylesheetTheme="SkinDefault" CodeBehind="CommodityDetail.aspx.cs" Inherits="Web.CommodityDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Commodity.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="bcom">
        <div class="bctop">
            <div class="brandlogo">
                <asp:Image ID="imgBLogo" runat="server" Width="150px" Height="130px" ImageUrl="~/Info/Brand/asos.jpg" />
                <br />
                ASOS
            </div>
            <div class="brandad">
                <asp:Image ID="imgBAd" runat="server" Width="100%" Height="100%" ImageUrl="~/Styles/Image/ad.jpg" />
            </div>
        </div>
        <div class="comTitle">
            <asp:Label ID="Label13" runat="server" Text="商品详情" CssClass="lblTitle"></asp:Label></div>
        <div class="bComm">
            <div class="bCommImg">
                <asp:Image ID="imgCommodity" ImageUrl="~/Styles/Image/defaultimg.png" Width="100%"
                    Height="100%" runat="server" />
            </div>
            <div class="bCommInfo">
                <table cellpadding="0" cellspacing="0" border="0" width="300px" style="background-image: url('Image/comborder.png');">
                    <tr class="trInfo">
                        <td class="tbLeft">
                            <asp:Label ID="Label1" runat="server" Text="商品名称"></asp:Label>
                        </td>
                        <td class="tbRight">
                            <asp:Label ID="lblComName" runat="server" Text="XXXXXXXXX"></asp:Label>
                        </td>
                    </tr>
                    <tr class="trInfo">
                        <td class="tbLeft">
                            <asp:Label ID="Label4" runat="server" Text="牌号"></asp:Label>
                        </td>
                        <td class="tbRight">
                            <asp:Label ID="lblComCode" runat="server" Text="XXXXXXXXX"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="tbLeft">
                            <asp:Label ID="Label6" runat="server" Text="价格"></asp:Label>
                        </td>
                        <td class="tbRight">
                            <asp:Label ID="lblComPrice" runat="server" Text="XXXXXXXXX"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="tbLeft">
                            <asp:Label ID="Label8" runat="server" Text="心愿价"></asp:Label>
                        </td>
                        <td class="tbRight">
                            <asp:Label ID="lblWishPrice" runat="server" Text="300"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="tbLeft">
                            <asp:Label ID="Label10" runat="server" Text="备注"></asp:Label>
                        </td>
                        <td class="tbRight">
                            <asp:Label ID="lblRemark" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td style="height: 20px;">
                        </td>
                    </tr>
                    <tr>
                        <td class="tbLeft">
                        </td>
                        <td class="tbRight" style="text-align: right;">
                            <asp:Button ID="tbnAdd" runat="server" Text="加入清单" CssClass="btn2" />
                        </td>
                    </tr>
                    <tr>
                        <td class="tbLeftNoLine" style="padding-top: 5px">
                            <asp:Label ID="Label11" runat="server" Text="商铺名称"></asp:Label>
                        </td>
                        <td class="tbRightNoLine">
                            <asp:Label ID="Label12" runat="server" Text="xxxxxxx"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="tbLeftNoLine">
                            <asp:Label ID="Label14" runat="server" Text="商铺地址"></asp:Label>
                        </td>
                        <td class="tbRightNoLine">
                            <asp:Label ID="Label15" runat="server" Text="xxxxxxx"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="tbLeftNoLine">
                            <asp:Label ID="Label16" runat="server" Text="联系电话"></asp:Label>
                        </td>
                        <td class="tbRightNoLine">
                            <asp:Label ID="Label17" runat="server" Text="xxxxxxxx"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="bComSend">
            <asp:Button ID="Button1" runat="server" Text="短信发送至手机" CssClass="btnSend" /></div>
        <div class="bComSend">
        <a href="#">修改</a></div>
    </div>
</asp:Content>
