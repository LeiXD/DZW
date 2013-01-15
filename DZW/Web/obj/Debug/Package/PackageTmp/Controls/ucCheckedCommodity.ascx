<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCheckedCommodity.ascx.cs"
    Inherits="Web.Controls.ucCheckedCommodity" %>
<table class="tblCheckedCommodity" cellpadding="0" cellspacing="0">
    <tr class="trCheckedCommodity">
        <td colspan="2" class="tdCheckedImage">
            <asp:ImageButton ID="ibCommodity" runat="server" CssClass="imgCheckedImage" 
                Width="170px" Height="200px" ImageAlign="NotSet" onclick="ibCommodity_Click" /></td>
    </tr>
    <tr style="height:30px;">
        <td class="tdCCCaption">
            <asp:Label ID="Label1" runat="server" Text="原价"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblOriginal" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr style="height:30px;">
        <td class="tdCCCaption">
            <asp:Label ID="Label2" runat="server" Text="现价"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblCurrent" runat="server" Text=""></asp:Label>
        </td>
    </tr>
    <tr style="height:30px;">
        <td class="tdCCCaption">
            <asp:Label ID="Label3" runat="server" Text="心愿价"></asp:Label>
        </td>
        <td>
            <asp:Label ID="lblWish" runat="server" Text="" CssClass="lblWishPrice"></asp:Label>
        </td>
    </tr>
</table>
<%--<table class="tblCheckedCommodity" cellpadding="0" cellspacing="0">
    <tr>
        <td>
            <asp:Image ID="imgAdd" ImageUrl="~/Styles/Image/defaultimg.png" runat="server" Height="295px"
                Width="170px" /></SeparatorTemplate>
        </td>
    </tr>
</table>--%>
