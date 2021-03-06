﻿#region

using System;
using System.Web.Optimization;

#endregion

namespace SocialNetwork.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {

//            Script bundles
            bundles.Add(new ScriptBundle("~/Scripts/modernizr").Include(
                "~/Scripts/modernizr-2.6.2.js"));
            bundles.Add(new ScriptBundle("~/Scripts/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Scripts/bootstrap").Include(
                "~/Scripts/bootstrap.js"));
            bundles.Add(new ScriptBundle("~/Scripts/site").Include(
                "~/Scripts/site*"));

            bundles.Add(new ScriptBundle("~/Scripts/bootstrap-datepicker").Include(
                "~/Scripts/bootstrap-datepicker*"));

            bundles.Add(new ScriptBundle("~/Scripts/validation").Include(
                "~/Scripts/jquery.validate*"));


//            Style bundles
            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/bootstrap").Include(
                "~/Content/bootstrap/bootstrap.css",
                "~/Content/bootstrap/bootstrap-responsive.css"));

            bundles.Add(new StyleBundle("~/Content/css-admin").Include(
                "~/Areas/admin/Content/admin.css"));

            bundles.Add(new StyleBundle("~/Content/datepicker").Include("~/Content/datepicker.css"));
        }
    }
}