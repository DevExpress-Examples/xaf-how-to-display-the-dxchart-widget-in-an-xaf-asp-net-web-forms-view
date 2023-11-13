<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T381904)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to display the dxChart widget in an XAF ASP.NET WebForms view

This example illustrates how to show a chart control with many points. The built-in [Charts module](https://docs.devexpress.com/eXpressAppFramework/113302/analytics/chart-module) draws all points on the same screen at once, and this can affect readability. To improve usability, you can implement real-time zooming and scrolling, for example, the `dxChart` widget from the DevExtreme library. This example shows how to use this widget in an XAF application.

![8c96f11b-1ea3-11e6-80bf-00155d62480c](https://github.com/DevExpress-Examples/XAF_how-to-display-the-dxchart-widget-in-an-xaf-view-Web-t381904/assets/14300209/9ee6502a-ead2-4fe0-978f-42fcfaaa88d9)

## Implementation Details

The approach used in this example is based on the technique of [displaying a custom data bound control](https://docs.devexpress.com/eXpressAppFramework/114160/ui-construction/using-a-custom-control-that-is-not-integrated-by-default/how-to-show-a-custom-data-bound-control-in-an-xaf-view-asp-net). The example demonstrates how to use this technique with client-side components that do not have server-side implementation. 

1. Register client libraries. For details, refer to the corresponding section of the [How to use DevExtreme Widgets in an XAF application](https://supportcenter.devexpress.com/ticket/details/t380965/how-to-use-devextreme-widgets-in-an-xaf-asp-net-webforms) Knowledge Base article.

2. Create the content. In the **YourSolutionName.Web** project, create [a custom ASP.NET user control (*.ascx)](https://learn.microsoft.com/en-us/previous-versions/dotnet/netframework-3.0/26db8ysc(v=vs.85)?redirectedfrom=MSDN) and add [ASPxPanel](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPanel) to it that acts as the container for DevExtreme widgets. It is convenient to keep client-side scripts in a separate file. Add a JavaScript file and declare the `createWidgets` function in it. Implement this function using the approach described in the following topic: [Zooming and Panning](https://js.devexpress.com/Documentation/21_2/Guide/UI_Components/Chart/Zooming_and_Panning/).

	```js
	window.DxSample = window.DxSample || {};
	window.DxSample.OrdersChart = {
	    createWidgets: function (panel) {
		var $mainElement = $(panel.GetMainElement());
			$mainElement.dxChart({..});
	    }
	};
	```
	
	Using the client-side [Init](https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.control.init?view=netframework-4.8.1) event of the ASPxPanel component, call the `createWidgets` function and pass the first event argument as this function parameter. 

3. Register your JavaScript files. In code behind for your user control (e.g., _YourSolutionName.Web/YourUserControlName.ascx.xx_ file), handle the [UserControl.Load](https://learn.microsoft.com/en-us/dotnet/api/system.web.ui.control.load?view=netframework-4.8.1&redirectedfrom=MSDN) event and call the [WebWindow.RegisterClientScriptInclude](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Web.WebWindow.RegisterClientScriptInclude(System.String-System.String)) method to include your JavaScript file into the web page.

4. Load data and pass it to the client side. To supply data for client-side widgets, use the approach described in the following article: [Passing Values Between Client and Server Sides](https://docs.devexpress.com/AspNet/11816/common-concepts/client-side-functionality/passing-values-between-client-and-server-sides). For this purpose, implement the [IComplexControl](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.IComplexControl) interface in your _UserControl_ class. Within the [IComplexControl.Setup](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Editors.IComplexControl.Setup(DevExpress.ExpressApp.IObjectSpace-DevExpress.ExpressApp.XafApplication)) method, load data from the database, convert it to an array of plain objects, and add it to the [JSProperties](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxPanelBase.JSProperties) dictionary.

5. Add your user control to the Application Model using the approach demonstrated in the following article: [How to: Show a Custom Data-Bound Control in an XAF View (ASP.NET Web Forms)](https://docs.devexpress.com/eXpressAppFramework/114160/ui-construction/using-a-custom-control-that-is-not-integrated-by-default/how-to-show-a-custom-data-bound-control-in-an-xaf-view-asp-net).

## Files to Review

* [OrdersChart.ascx](CS/WebChart/WebChart.Web/OrdersChart.ascx) 
* [OrdersChart.ascx.cs](CS/WebChart/WebChart.Web/OrdersChart.ascx.cs)
* [orders-chart.js](CS/WebChart/WebChart.Web/Scripts/Controls/orders-chart.js)

## Documentation

* [How to use DevExtreme Widgets in an XAF application](https://supportcenter.devexpress.com/ticket/details/t380965/how-to-use-devextreme-widgets-in-an-xaf-asp-net-webforms)
* [Passing Values Between Client and Server Sides](https://docs.devexpress.com/AspNet/11816/common-concepts/client-side-functionality/passing-values-between-client-and-server-sides)
* [How to: Show a Custom Data-Bound Control in an XAF View (ASP.NET Web Forms)](https://docs.devexpress.com/eXpressAppFramework/114160/ui-construction/using-a-custom-control-that-is-not-integrated-by-default/how-to-show-a-custom-data-bound-control-in-an-xaf-view-asp-net)
