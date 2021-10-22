using System;
using System.Configuration;

namespace SARASPNETTest
{
    public partial class Report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Remote;
            ReportViewer1.ServerReport.ReportServerUrl = new Uri(ConfigurationManager.AppSettings["SARReportServerUrl"]);
            ReportViewer1.ServerReport.ReportPath = ConfigurationManager.AppSettings["SARReportPath"];
            ReportViewer1.ServerReport.ReportServerCredentials = new ReportServerCredentials();
        }
   }
}