<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ucChecking.ascx.cs"
    Inherits="Web.Controls.ucChecking" %>
<div class="tblCheckingItem">
    <asp:Image ID="ibCommodity" runat="server" Width="168px" Height="198px" ImageAlign="AbsMiddle" />
    <div class="transparent_class" style="width: 168px; margin: 0px; padding: 0px; background-color: White;
        height: 100px; margin-top: -100px">
        <div style="padding-top: 30px; padding-left: 100px;">
            <asp:Label ID="Label2" runat="server" Text="心愿价"></asp:Label><br />
            <asp:Label ID="lblWishPrice" runat="server" Text="" CssClass="lblWishPrice"></asp:Label>
        </div>
    </div>
</div>
