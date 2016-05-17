using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace We2Client
{
    public partial class command : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
               var documentList = getDocument();
               bindDocumentData(documentList);
            }
        }

        
        public List<document> getDocument()
        {
            var doc = Directory.GetFiles(@"C:\inetpub\wwwroot\DocumentArchive");

            var documentList = new List<document>();
            int id_number = 0;
            foreach (var d in doc)
            {
                id_number++;
                var fileName = d.Substring(d.LastIndexOf(("\\")) + 1);
                documentList.Add(new document { docName = fileName, id = id_number });
            }
            return documentList;
        }

        public void bindDocumentData(List<document>d)
        {
            rprDocTable.DataSource = d;
            rprDocTable.DataBind();
        }




        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            
            
            Button button = (sender as Button);
            string commandArgument = button.CommandArgument;

            string sourceDir = @"C:\inetpub\wwwroot\DocumentArchive";
            string[] myDocList = Directory.GetFiles(sourceDir, commandArgument);

            foreach (string d in myDocList)
            {
                File.Delete(d);
            }

            var documentList = getDocument();
            bindDocumentData(documentList);

        }

        protected void copyBtn_Click(object sender, EventArgs e)
        {
            //Button button = (sender as Button);
            //string commandArgument = button.CommandArgument;

            //string sourceDir = @"C:\inetpub\wwwroot\DocumentArchive";
            //string[] myDocList = Directory.GetFiles(sourceDir, commandArgument);

            //foreach (string d in myDocList)
            //{
              
              
            //}

            //var documentList = getDocument();
            //bindDocumentData(documentList);


        }

        public class document
        {
            public int id { get; set; }
            public string docName { get; set; }
        }

        protected void createBtn_Click(object sender, EventArgs e)
        {
           
        }
    }
    
}