<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucCommodity.ascx.cs" Inherits="Web.Controls.ucCommodity" %>

<div class="bComItem">
    <div class="bComItemImg">
        <asp:ImageButton ID="imgCom" runat="server" Width="100%" Height="100%" 
            onclick="imgCom_Click" />
    </div>
    <div class="bComItemInfo">
        <div class="bciOriPrice">
            <asp:Label ID="lblOrigialPrice" runat="server" Text="Label"></asp:Label></div>
        <div class="bciCurPrice">
            <asp:Label ID="lblCurrentPrice" runat="server" Text="Label"></asp:Label></div>
    </div>
</div>
