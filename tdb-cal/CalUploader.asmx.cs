using System;
using System.IO;
using System.Web.Services;

namespace tdb_cal
{
    /// <summary>
    /// Summary description for CalUploader
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalUploader : WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string UploadFile(byte[] f, string fileName, string teamName, string teamID)
        {
            // the byte array argument contains the content of the file
            // the string argument contains the name and extension
            // of the file passed in the byte array
            try
            {
                // instance a memory stream and pass the
                // byte array to its constructor
                var ms = new MemoryStream(f);

                // instance a filestream pointing to the
                // storage folder, use the original file name
                // to name the resulting file
                //FileStream fs = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath
                //            ("~/TransientStorage/") + fileName, FileMode.Create);

                if (Directory.Exists(System.Web.Hosting.HostingEnvironment.MapPath("~/cals/teams/" + teamID + "/")))
                {
                    //we already have a calendar file, delete it
                    File.Delete(System.Web.Hosting.HostingEnvironment.MapPath("~/cals/teams/" + teamID + "/") + fileName);
                }
                else
                {
                    Directory.CreateDirectory(
                        System.Web.Hosting.HostingEnvironment.MapPath("~/cals/teams/" + teamID + "/"));
                }

                var fs = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath("~/cals/teams/" + teamID + "/") + fileName, FileMode.Create);

                // write the memory stream containing the original
                // file as a byte array to the filestream
                ms.WriteTo(fs);

                // clean up
                ms.Close();
                fs.Close();
                fs.Dispose();

                // return OK if we made it this far
                return "OK";
            }
            catch (Exception ex)
            {
                // return the error message if the operation fails
                return ex.Message;
            }
        }
    }
}
