using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using System.Net.Http;
using ReportServerIntegration.Models;
using ReportServerIntegration.Services;
using DevExpress.XtraReports.Localization;
using ReportServerIntegration.Repositories;
using System.Configuration;
namespace ReportServerIntegration
{
    public class HomeController : Controller
    {


        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        private string connectionStringThreshold = ConfigurationManager.ConnectionStrings["DatabaseConnectionThreshold"].ConnectionString;


        readonly IApiService apiService;
        readonly IReportService reportService;
        readonly IDashboardService dashboardService;
        
        public HomeController(IApiService apiService, IReportService reportService, IDashboardService dashboardService)
        {
            this.apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
            this.reportService = reportService ?? throw new ArgumentNullException(nameof(reportService));
            this.dashboardService = dashboardService ?? throw new ArgumentNullException(nameof(dashboardService));
        }


        //public ActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        public async Task<ActionResult> Index(string dashboardId)
        {
            dashboardId = "2134";
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }








        [HttpGet]
        public async Task<ActionResult> DashboardViewerAlarmDistribution(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewerStanding(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewerKPITrends(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewerShelved(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> ReportViewer(string reportId)
        {
            var model = await reportService.GetViewerModel(reportId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewer(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }


        [HttpGet]
        public async Task<ActionResult> DashboardViewerAlarm(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewerAction(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }


        [HttpGet]
        public async Task<ActionResult> DashboardViewerTimeAlarm(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewerBad(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewerALarmPrio(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        public async Task<ActionResult> DashboardViewerALarmCount(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewerTimeAction(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> DashboardViewerOperatorActivity(string dashboardId)
        {
            var model = await dashboardService.GetViewerModel(dashboardId);
            return View(model);
        }

        public ActionResult SideMenu()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetData();

            return PartialView("SideMenu", list);
        }

        public ActionResult _LayoutAlarm()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataAlarmPerformance();

            return PartialView("_LayoutAlarm", list);
        }

        public ActionResult sideMenuAlarm()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuAlarm();

            return PartialView("sideMenuAlarm", list);
        }

        public ActionResult sideMenuAlarmPrio()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuAlarmPrio();

            return PartialView("sideMenuAlarmPrio", list);
        }

        public ActionResult sideMenuAlarmDistribution()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuAlarmDistribution();

            return PartialView("sideMenuAlarmDistribution", list);
        }
        public ActionResult sideMenuReport()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuReport();

            return PartialView("sideMenuReport", list);
        }



        public ActionResult sideMenuBadActor()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuBadActor();

            return PartialView("sideMenuBadActor", list);
        }

        public ActionResult sideMenuAlarmCount()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuAlarmCount();

            return PartialView("sideMenuAlarmCount", list);
        }


        public ActionResult sideMenuTimeAlarm()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuTimeAlarm();

            return PartialView("sideMenuTimeAlarm", list);
        }


        public ActionResult sideMenuAction()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuTimeAction();

            return PartialView("sideMenuAction", list);
        }

        public ActionResult sideMenuKPITrends()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuKPITrends();

            return PartialView("sideMenuKPITrends", list);
        }


        public ActionResult sideMenuStanding()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuStanding();

            return PartialView("sideMenuStanding", list);
        }

        public ActionResult sideMenuShelved()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataSideMenuShelved();

            return PartialView("sideMenuShelved", list);
        }

        public ActionResult sideMenuOperatorActivity()
        {

            List<DOCUMENTBASE> list = new List<DOCUMENTBASE>();

            DOCUMENTBASERepository rep = new DOCUMENTBASERepository(connectionString);
            list = rep.GetDataOperatorActiv();

            return PartialView("sideMenuOperatorActivity", list);
        }

        public ActionResult MenuConfiguration()
        {
            return View();
        }


        public ActionResult Threshold()
        {

            ViewThreshold viewThresholds = new ViewThreshold();

            List<METRIC_THRESHOLD> list = new List<METRIC_THRESHOLD>();

            METRIC_THRESHOLDRepository rep = new METRIC_THRESHOLDRepository(connectionStringThreshold);
            list = rep.GetData();

            List<ACTIVE_THRESHOLD> listActiveThreshold = new List<ACTIVE_THRESHOLD>();
            ACTIVE_THRESHOLDRepository repActiveThreshold = new ACTIVE_THRESHOLDRepository(connectionStringThreshold);
            listActiveThreshold = repActiveThreshold.GetData();


            viewThresholds.allMetricThreshold = rep.GetData();

             viewThresholds.allActiveThreshold= repActiveThreshold.GetData();

            return View(viewThresholds);
        }


        public ActionResult UserConfiguration()
        {
            return View();
        }

    }
}