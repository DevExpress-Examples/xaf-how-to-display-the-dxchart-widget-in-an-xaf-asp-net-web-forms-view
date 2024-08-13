<%@ Page Language="C#" AutoEventWireup="true" Inherits="Default" EnableViewState="false"
    ValidateRequest="false" CodeBehind="Default.aspx.cs" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v23.1, Version=23.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" 
    Namespace="DevExpress.ExpressApp.Web.Templates" TagPrefix="cc3" %>
<%@ Register Assembly="DevExpress.ExpressApp.Web.v23.1, Version=23.1.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.ExpressApp.Web.Controls" TagPrefix="cc4" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Main Page</title>
    <meta http-equiv="Expires" content="0" />
      <link rel="stylesheet" type="text/css" href="css/dx.common.css" />
    <link rel="stylesheet" type="text/css" href="css/dx.dark.css" />    
    <script type="text/javascript" src="Scripts/jquery-1.12.3.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.validate.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.validate.unobtrusive.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.unobtrusive-ajax.min.js"></script>
    <script type="text/javascript" src="Scripts/cldr.min.js"></script>
    <script type="text/javascript" src="Scripts/cldr/event.min.js"></script>
    <script type="text/javascript" src="Scripts/cldr/suplemental.min.js"></script>
    <script type="text/javascript" src="Scripts/globalize.min.js"></script>
    <script type="text/javascript" src="Scripts/globalize/message.min.js"></script>
    <script type="text/javascript" src="Scripts/globalize/number.min.js"></script>
    <script type="text/javascript" src="Scripts/globalize/currency.min.js"></script>
    <script type="text/javascript" src="Scripts/globalize/date.min.js"></script>
    <script type="text/javascript" src="Scripts/dx.viz-web.js"></script>
    <style type="text/css">
        .dxm-item.accountItem.dxm-subMenu .dx-vam
        {
            padding-left: 10px;
        }
        .dxm-item.accountItem.dxm-subMenu .dxm-image.dx-vam
        {
            border-radius: 32px;
            -moz-border-radius: 32px;
            -webkit-border-radius: 32px;
            padding-right: 0px !important;
            padding-left: 0px !important;
            max-height: 32px;
            max-width: 32px;
        }
    </style>
</head>
<body class="VerticalTemplate">
    <form id="form2" runat="server">
    <cc4:ASPxProgressControl ID="ProgressControl" runat="server" />
    <div runat="server" id="Content" />
    </form>
</body>
</html>