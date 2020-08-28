<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="OrdersChart.ascx.cs" Inherits="DxSample.Web.OrdersChart" %>
<%@ Register Assembly="DevExpress.Web.v16.2, Version=16.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>
<dx:ASPxPanel ID="ASPxPanel1" runat="server">
    <ClientSideEvents Init="function(s, e) {
	DxSample.OrdersChart.createWidgets(s);
}" />
    <PanelCollection>
<dx:PanelContent runat="server">
    <div class="dxsample-orderschart-chart"></div>
    <div class="dxsample-orderschart-range"></div>
</dx:PanelContent>
</PanelCollection>
</dx:ASPxPanel>
