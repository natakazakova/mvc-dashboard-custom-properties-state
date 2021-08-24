<!-- default file list -->
*Files to look at*:

* [DashboardConfig.cs](./CS/App_Start/DashboardConfig.cs)
* [Index.cshtml](./CS/Views/Home/Index.cshtml)
* [DashboardStateExtension.js](./CS/Scripts/DashboardStateExtension.js)
* [dashboard1.xml](./CS/App_Data/Dashboards/dashboard1.xml)

<!-- default file list end -->

# Dashboard for MVC - How to store dashboard state in the dashboard layout

This example illustrates how to impelemt a [Custom Property](https://docs.devexpress.com/Dashboard/401702/web-dashboard/ui-elements-and-customization/create-custom-properties) to save the [Dashboard State](https://docs.devexpress.com/Dashboard/119765/web-dashboard/aspnet-mvc-dashboard-extension/manage-dashboard-state) along with the dashboard layout (XML).

The `DashboardState` Custom Property is defined at the Dashboard level. You can find a basic example of this usage scenario in this article: [Dashboard Description - Custom Property](https://docs.devexpress.com/Dashboard/401710/web-dashboard/ui-elements-and-customization/create-custom-properties/dashboard-description-custom-property). The only specificy of this example is that the following extra events are handled on the client side:

* [DashboardControl.onDashboardInitialized](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions#js_devexpress_dashboard_dashboardcontroloptions_ondashboardinitialized) - to initialize the dashboard state from a custom property.
* [DashboardControl.onDashboardStateChanged](https://docs.devexpress.com/Dashboard/js-DevExpress.Dashboard.DashboardControlOptions#js_devexpress_dashboard_dashboardcontroloptions_ondashboardstatechanged) - to save the changed dashboard state to a custom property.

## Documentation

- [Create Custom Properties](https://docs.devexpress.com/Dashboard/401702/web-dashboard/ui-elements-and-customization/create-custom-properties)
- [Dashboard Description - Custom Property](https://docs.devexpress.com/Dashboard/401710/web-dashboard/ui-elements-and-customization/create-custom-properties/dashboard-description-custom-property)
- [Manage Dashboard State in ASP.NET MVC Dashboard](https://docs.devexpress.com/Dashboard/119765/web-dashboard/aspnet-mvc-dashboard-extension/manage-dashboard-state)

## More Examples

- [Dashboard for MVC - Custom Properties](https://github.com/DevExpress-Examples/asp-net-mvc-dashboard-custom-properties-sample)
- [Dashboard for ASP.NET Core - How to implement dependent custom properties in a custom item](https://github.com/DevExpress-Examples/CustomItemDependentProperties)
- [Dashboard for MVC - How to customize a dashboard before displaying it in a browser](https://github.com/DevExpress-Examples/how-to-customize-a-dashboard-before-displaying-it-in-a-browser-t596822)