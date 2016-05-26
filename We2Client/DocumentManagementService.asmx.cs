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
        string path = @"C:\inetpub\wwwroot\DocumentArchive\";
        string filePath;

        [WebMethod]
        public int downloadDocumentLen(string fileName)
        {
            filePath = path + fileName;

            FileStream objfilestream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            int length = (int)objfilestream.Length;
            objfilestream.Close();

            return length;
        }

        [WebMethod]
        public byte[] downloadDocument(string fileName)
        {
            filePath = path + fileName;

            FileStream objfilestream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            int length = (int)objfilestream.Length;
            Byte[] documentcontents = new Byte[length];
            objfilestream.Read(documentcontents, 0, length);
            objfilestream.Close();

            return documentcontents;
        }

    }
    [Serializable]
    public class DocumentArchiveFiles
    {
        public int id { get; set; }
        public string fileNamne { get; set; }

    }
}
