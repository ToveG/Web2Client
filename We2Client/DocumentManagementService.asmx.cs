using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.Web.Script.Services;

namespace We2Client
{
    /// <summary>
    /// Summary description for DocumentManagementService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class DocumentManagementService : System.Web.Services.WebService
    {


        //[WebMethod]
        //[ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        //public DocumentArchiveFiles View()
        //{
          
        //    var fileList = new List<DocumentArchiveFiles>();
        //    var doc = Directory.GetFiles(@"C:\inetpub\wwwroot\DocumentArchive");
        //    foreach(var d in doc)
        //    {
        //        var file = new DocumentArchiveFiles();
        //        file.fileNamne = d;
        //        fileList.Add(file);                
        //    }

        //    //    return new JavaScriptSerializer().Serialize(fileList);
        //    return ;

        //}

        [WebMethod]
        public string Paste()
        {
            return "Paste document";
        }

        [WebMethod]
        public string Create()
        {
            return "Create document";
        }

        [WebMethod]
        public string Delete()
        {
            return "Delete document";
        }

        

    }
    [Serializable]
    public class DocumentArchiveFiles
    {
        public int id { get; set; }
        public string fileNamne { get; set; }

    }
}
