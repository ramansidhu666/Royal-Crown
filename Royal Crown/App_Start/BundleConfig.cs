using System.Web;
using System.Web.Optimization;

namespace Royal_Crown
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));
            bundles.Add(new ScriptBundle("~/bundles/jquery")

                        .Include(@"~/Scripts/jquery.prettyPhoto.js")
                        .Include(@"~/Scripts/modernizr.js")
                        .Include(@"~/Scripts/wow.min.js")
                        .Include(@"~/Scripts/masterslider.min.js")
                        .Include(@"~/Scripts/owl.carousel.js")
                        .Include(@"~/Scripts/owl-slider.js")
                        .Include(@"~/Scripts/bootstrap.min.js")
                        .Include(@"~/Scripts/jquery_007.js")
                        .Include(@"~/Scripts/plugins.js")
                        .Include(@"~/Scripts/respond.js")
                        .Include(@"~/Scripts/jquery_003.js")
                        .Include(@"~/Scripts/jquery.js")
                        .Include(@"~/Scripts/jquery_006.js")

                        .Include(@"~/Scripts/owl.js")
                        .Include(@"~/Scripts/jquery_002.js")
                        .Include(@"~/Scripts/twitter.js")
                        .Include(@"~/Scripts/jquery_005.js")
                        .Include(@"~/Scripts/jquery_004.js")
                        .Include(@"~/Scripts/jquery.waypoints.js")
                        .Include(@"~/Scripts/jquery.mixitup.js")
                        .Include(@"~/Scripts/custom.js")
                        .Include(@"~/Scripts/jquery.prettyPhoto.js")

                        );

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/css_003.css",
                "~/Content/css/css_002.css",
                "~/Content/css/css.css",
                "~/Content/css/bootstrap.min.css",
                "~/Content/css/theme.css",
                "~/Content/css/theme-animate.css",
                "~/Content/css/theme-elements.css",
                          
                "~/Content/css/plugins.css",
                "~/Content/css/sun.css",
                "~/Content/css/font-awesome.css",
                "~/Content/css/skeleton.css",
                "~/Content/css/flexslider.css",
                "~/Content/css/isotope.css",

                "~/Content/css/owl.css",
                "~/Content/css/prettyPhoto.css",
                "~/Content/css/settings.css",
                "~/Content/css/owl.carousel.css",
                "~/Content/css/owl.theme.css",

                  "~/Content/css/theme-responsive.css",
                "~/Content/css/ms-style/masterslider.css",
                "~/Content/css/ms-style/ms-layers-style.css",
                "~/Content/css/ms-skins/light-3/style.css",
                "~/Content/css/ms-skins/black-2/style.css",

                "~/Content/css/owl.theme.css",
                "~/Content/css/owl.transitions.css",
                "~/Content/css/loader.css"
                

                ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}