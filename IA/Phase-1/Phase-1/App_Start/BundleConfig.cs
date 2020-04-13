using System.Web;
using System.Web.Optimization;

namespace Phase_1
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Project Script Bundels
            bundles.Add(new ScriptBundle("~/bundles/ProjectScripts").Include(
                        "~/Scripts/ProjectScripts/jquery-1.12.1.min.js",
                        "~/Scripts/ProjectScripts/popper.min.js",
                        "~/Scripts/ProjectScripts/bootstrap.min.js",
                        "~/Scripts/ProjectScripts/jquery.magnific-popup.js",
                        "~/Scripts/ProjectScripts/swiper.min.js",
                        "~/Scripts/ProjectScripts/mixitup.min.js",
                        "~/Scripts/ProjectScripts/owl.carousel.min.js",
                        "~/Scripts/ProjectScripts/jquery.nice-select.min.js",
                        "~/Scripts/ProjectScripts/slick.min.js",
                        "~/Scripts/ProjectScripts/jquery.counterup.min.js",
                        "~/Scripts/ProjectScripts/waypoints.min.js",
                        "~/Scripts/ProjectScripts/contact.js",
                        "~/Scripts/ProjectScripts/jquery.ajaxchimp.min.js",
                        "~/Scripts/ProjectScripts/jquery.form.js",
                        "~/Scripts/ProjectScripts/jquery.validate.min.js",
                        "~/Scripts/ProjectScripts/mail-script.js",
                        "~/Scripts/ProjectScripts/custom.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // Project StyleSheets Bundle
            bundles.Add(new StyleBundle("~/Content/ProjectCss").Include(
                "~/Content/ProjectCss/bootstrap.min.css",
                "~/Content/ProjectCss/animate.css",
                "~/Content/ProjectCss/owl.carousel.min.css",
                "~/Content/ProjectCss/all.css",
                "~/Content/ProjectCss/flaticon.css",
                "~/Content/ProjectCss/themify-icons.css",
                "~/Content/ProjectCss/magnific-popup.css",
                "~/Content/ProjectCss/slick.css",
                "~/Content/ProjectCss/style.css",
                "~/Content/ProjectCss/style.map",
                "~/Content/ProjectCss/aos.css",
                "~/Content/ProjectCss/lightslider.min.css",
                "~/Content/ProjectCss/nice-select.css",
                "~/Content/ProjectCss/price_rangs.css",
                "~/Content/ProjectCss/slick.min.css",
                "~/Content/ProjectCss/slick-theme.min.css",
                "~/Content/ProjectCss/swiper.min.css"));
        }
    }
}
