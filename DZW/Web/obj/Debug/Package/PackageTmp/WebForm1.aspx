<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Web.WebForm1" %>
<%@ Register src="Controls/ucCommodity.ascx" tagname="ucCommodity" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles/Commodity.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:DataList ID="dlJacket" runat="server" RepeatColumns="4" CellPadding="0" CellSpacing="0">
            <ItemTemplate>                
                <uc1:ucCommodity ID="ucCommodity1" runat="server" ImageUrl='<%#Bind("ImageUrl") %>' 
                CommodityID='<%#Bind("CommodityID") %>' CurrentPrice='<%#Bind("SalePrice") %>' OrginalPrice='<%#Bind("Price") %>' />                
            </ItemTemplate>
        </asp:DataList>
    </div>
    </form>
</body>
</html>
