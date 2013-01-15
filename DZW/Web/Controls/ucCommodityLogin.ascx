<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCommodityLogin.ascx.cs"
    Inherits="Web.Controls.ucCommodityLogin" %>
<table class="tblComLogin">
    <tr>
        <td colspan="2" class="tdTitle">商品信息登录
        </td>
    </tr>
    <tr class="trComLogin">
        <td>
            <asp:Label ID="Label1" runat="server" Text="品牌名"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="trComLogin">
        <td>
            <asp:Label ID="Label2" runat="server" Text="牌号"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="trComLogin">
        <td>
            <asp:Label ID="Label3" runat="server" Text="心愿价"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr class="trComLogin">
        <td>
            <asp:Label ID="Label6" runat="server" Text="图片上传"></asp:Label>
        </td>
        <td>
            <asp:FileUpload ID="FileUpload1" runat="server" Width="155px" />
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            <img alt="" src="" class="imgComLogin" />
            <asp:Button ID="btnUpload" runat="server" Text="上传" CssClass="btn1" />
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Text="备注"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:Button ID="btnConfirm" runat="server" Text="确认" />
        </td>
    </tr>
</table>
