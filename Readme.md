<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128589875/16.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T381904)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->


# How to display the dxChart widget in an XAF view


This example illustrates how to show a chart control with a lot of points. The built-in <a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument113302">Charts module draws all points on the same screen at once, which may be inconvenient for an end-user. The built-in Charts module draws all points on the same screen at once, which may be inconvenient for an end-user. To achieve better usability, it is possible to implement real-time zooming and scrolling capabilities.
The dxChart widget from the DevExtreme library perfectly fits this scenario. This example demonstrates how to utilize this widget in an XAF application.


## Implementation Details
he approach used in this example is based on the well-known technique of displaying a custom data bound control described in our online documentation: <a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument114160">How to: Show a Custom Data-Bound Control in an XAF View (ASP.NET). The example demonstrates how to use this technique with client-side components that do not have server-side implementation. Refer to the following Knowledge Base article for more details and concepts: <a href="https://www.devexpress.com/Support/Center/p/T380965">How to use DevExtreme Widgets in an XAF application.

1. Register client libraries The details are provided in the corresponding section of the <a href="https://www.devexpress.com/Support/Center/p/T380965">How to: Use DevExtreme Widgets in an XAF Application Knowledge Base article.

2. Create content. In the YourSolutionName.Web project, create <a href="https://msdn.microsoft.com/en-us/library/26db8ysc%28v=vs.85%29.aspx">a custom ASP.NET User Control (*.ascx) and add <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxPaneltopic">ASPxPanel to it. This panel will be a container for DevExtreme widgets. It is convenient to keep client-side scripts in a separate file. Add a JavaScript file and declare the createWidgets function in it. Implement this function using the approach described in the <a href="https://js.devexpress.com/Documentation/21_2/Guide/UI_Components/Chart/Zooming_and_Panning/">Zooming and Panning article.


```js
window.DxSample = window.DxSample || {};
window.DxSample.OrdersChart = {
    createWidgets: function (panel) {
        var $mainElement = $(panel.GetMainElement());
		$mainElement.dxChart({..});
    }
};
```


Using the client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientControl_Inittopic">Init event of the ASPxPanel component, call the createWidgets function passing the first event argument as a parameter. 

3. Register your JavaScript files. In code behind for your UserControl (e.g., YourSolutionName.Web/YourUserControlName.ascx.xx file), handle the <a href="https://msdn.microsoft.com/en-us/library/system.web.ui.control.load%28v=vs.100%29.aspx">UserControl.Load event and call the <a href="https://documentation.devexpress.com/#eXpressAppFramework/DevExpressExpressAppWebWebWindow_RegisterClientScriptIncludetopic">WebWindow.RegisterClientScriptInclude method to include your JavaScript file into the web page.

4. Load data and pass it to the client side. To provide data for client-side widgets, use the approach described in the following article: <a href="https://documentation.devexpress.com/#AspNet/CustomDocument11816">How to: Access Server Data on the Client Side. For this purpose, implement the <a href="https://documentation.devexpress.com/#eXpressAppFramework/clsDevExpressExpressAppEditorsIComplexControltopic">IComplexControl interface in your UserControl class. Within the <a href="https://documentation.devexpress.com/#eXpressAppFramework/DevExpressExpressAppEditorsIComplexControl_Setuptopic">IComplexControl.Setup method, load data from the database, convert it into an array of plain objects (you can use anonymous types in <a href="https://msdn.microsoft.com/en-us/library/bb397696.aspx">C# and <a href="https://msdn.microsoft.com/en-us/library/bb384767.aspx">VB.NET for this purpose), and add it to the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPanelBase_JSPropertiestopic">JSProperties dictionary.

5. Add your UserControl to the Application Model using the approach demonstrated in the following article: <a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument114160">How to: Show a Custom Data-Bound Control in an XAF View (ASP.NET).



## Files to Review

* [OrdersChart.ascx](CS/WebChart/WebChart.Web/OrdersChart.ascx) 
* **[OrdersChart.ascx.cs](CS/WebChart/WebChart.Web/OrdersChart.ascx.cs)**
* [orders-chart.js](CS/WebChart/WebChart.Web/Scripts/Controls/orders-chart.js)


