<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false"
    CodeBehind="PersonalPage.aspx.cs" Inherits="Web.PersonalPage" StylesheetTheme="SkinDefault" %>

<%@ Register Src="Controls/ucCheckedCommodity.ascx" TagName="ucCheckedCommodity"
    TagPrefix="uc1" %>
<%@ Register Src="Controls/ucChecking.ascx" TagName="ucChecking" TagPrefix="uc3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%">
        <div style="width: 550px; margin: 0px auto 0px auto;">
            <table style="width: 550px">
                <tr>
                    <td class="tdTitle20">
                        <asp:Label ID="Label1" runat="server" Text="我等折的宝贝" CssClass="lblTitle"></asp:Label>
                    </td>
                    <td style="text-align: right;">
                    </td>
                </tr>
            </table>
            <asp:DataList ID="dlChecked" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <uc1:ucCheckedCommodity ID="ucCheckedCommodity1" runat="server" OriginalPrice='<%#Bind("Price") %>' CID='<%#Bind("ID") %>' 
                        CurrentPrice='<%#Bind("SalePrice") %>' WishPrice='<%#Bind("WishPrice") %>' ImageUrl='<%#Bind("ImageUrl") %>' />
                    <asp:Image ID="imgAdd" ImageUrl="~/Styles/Image/defaultimg.png" runat="server" Height="295px"
                        Visible="false" Width="170px" /></SeparatorTemplate>
                </ItemTemplate>
            </asp:DataList>
            <table style="width: 100%; border-bottom: dotted 1px gray; border-bottom-style: dashed">
                <tr>
                    <td style="height: 10px">
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td style=" text-align:right; height: 50px;">
                        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Styles/Image/btn1.png"
                            Width="60px" Height="22px" />
                    </td>
                </tr>
            </table>
            <div style="height: 20px; width: 620px; border-bottom: dashed 1px siliver; margin-bottom: 10px;
                display: block">
            </div>
            <table style="width: 600px; background-image: url('url('Style/Image/line.png')')">
                <tr>
                    <td class="tdTitle20">
                        <asp:Label ID="Label3" runat="server" Text="我的心愿卡" CssClass="lblTitle"></asp:Label>
                    </td>
                    <td style="text-align: right;">
                    </td>
                </tr>
            </table>
            <asp:DataList ID="dlChecking" runat="server" RepeatColumns="3" RepeatDirection="Horizontal">
                <ItemTemplate>
                    <uc3:ucChecking ID="ucChecking1" runat="server" ImageUrl='<%#Bind("ImageUrl") %>'
                        WishPrice='<%#Bind("WishPrice") %>' />
                </ItemTemplate>
            </asp:DataList>
            <div style="width: 100%; text-align: right">
                <asp:ImageButton ID="ibtnContact" runat="server" ImageUrl="~/Styles/Image/contact1.png" />
                <asp:ImageButton ID="ibtnMoreChecking" runat="server" ImageUrl="~/Styles/Image/btn1.png"
                    Width="60px" Height="22px" />
            </div>
        </div>
    </div>
</asp:Content>
