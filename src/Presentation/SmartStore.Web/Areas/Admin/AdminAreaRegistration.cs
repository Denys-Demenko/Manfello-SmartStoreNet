//using System.Web.Mvc;

//namespace SmartStore.Web.Areas.Admin
//{
//    public class AdminAreaRegistration : AreaRegistration 
//    {
//        public override string AreaName 
//        {
//            get { return "Admin"; }
//        }

//        public override void RegisterArea(AreaRegistrationContext context) 
//        {
//            // Was done by RouteProvider before

//            var route = context.MapRoute(
//                "Admin_default",
//                "{controller}/{action}/{id}",
//                new { controller = "Home", action = "Index", area = "Admin", id = UrlParameter.Optional },
//                new[] { "SmartStore.Web.Areas.Admin.Controllers" }
//            );

//            route.DataTokens["area"] = "Admin";
//        }
//    }
//}