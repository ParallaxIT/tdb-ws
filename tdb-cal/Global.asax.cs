using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace tdb_cal
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var watermarkImagePath = HttpContext.Current.Server.MapPath("~/img/watermark.jpeg");

            if (!File.Exists(watermarkImagePath))
            {
                throw new Exception("Watermark image not found.");
            }

            // put the byte array in application state
            Application["waterMarkImageByteArray"] = File.ReadAllBytes(watermarkImagePath);
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}