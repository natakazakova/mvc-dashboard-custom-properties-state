using DevExpress.DashboardCommon;
using DevExpress.DashboardWeb;
using DevExpress.DashboardWeb.Mvc;
using DevExpress.DataAccess.Web;
using System.Web.Routing;

namespace MVCDashboard {
    public static class DashboardConfig {
        public static void RegisterService(RouteCollection routes) {
            routes.MapDashboardRoute("api/dashboard");

            DashboardConfigurator.Default.SetConnectionStringsProvider(new ConfigFileConnectionStringsProvider());
            DashboardConfigurator.Default.SetDashboardStorage(new DashboardFileStorage(@"~/App_Data/Dashboards"));
            DashboardConfigurator.Default.SetDataSourceStorage(CreateDataSourceStorage());
        }

        public static DataSourceInMemoryStorage CreateDataSourceStorage() {
            DataSourceInMemoryStorage dataSourceStorage = new DataSourceInMemoryStorage();
            DashboardObjectDataSource objDataSource = new DashboardObjectDataSource("ObjectDataSource", typeof(ProductSales));
            objDataSource.DataMember = "GetProductSales";
            dataSourceStorage.RegisterDataSource("objectDataSource", objDataSource.SaveToXml());
            return dataSourceStorage;
        }
    }
}