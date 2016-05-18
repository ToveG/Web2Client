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

        public void bindDocumentData(List<document> d)
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

        protected void submitCreateDocument_Click(object sender, EventArgs e)
        {

        }
  
        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            var name = Request.Form["tb3"];
            string newFileName = "";
            string fileName = "";
            string sourcePath = @"C:\inetpub\wwwroot\DocumentArchive\Mallar";
            string targetPath = @"C:\inetpub\wwwroot\DocumentArchive\";

            if (Word.Checked)
            {
                fileName = "Untitled 1.odt";
                newFileName = name + ".odt";
                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, newFileName);
                File.Copy(sourceFile, destFile);

            }
            else if (PowerPoint.Checked)
            {
                newFileName = name + ".odp";
                fileName = "Untitled 1.odp";
                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, newFileName);
                File.Copy(sourceFile, destFile, true);

                //if (!File.Exists(newPath))
                //{
                //}
            }
            else if (Excel.Checked)
            {
                fileName = "Untitled 1.ods";
                newFileName = name + ".ods";
                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, newFileName);
                File.Copy(sourceFile, destFile, true);
                //if (!File.Exists(newPath))
                //{
                //}
            }
            var documentList = getDocument();
            bindDocumentData(documentList);
        }
    }

}
//string newPath = "";
//int number = 0;
//number++;
//            string path = @"C:\inetpub\wwwroot\DocumentArchive\";
//            if (Radio1.Checked)
//            {
//                //måste fånga om användaren skriver in fel filnamn.
//                //samt aggera om användaren skriver in nått som redan finns. 
//                newPath = path + name + ".odt";
//                if (!File.Exists(newPath))
//                {
//                        File.CreateText(newPath);
//                }
            
//            }
//            else if (Radio2.Checked)
//            {
//                newPath = path + name + ".ods";
//                if (!File.Exists(newPath))
//                {
//                    // Create a file to write to.
//                    File.CreateText(newPath);
//                }
//            }
//            else if (Radio3.Checked)
//            {
//                newPath = path + name + ".odp";
//                if (!File.Exists(newPath))
//                {
//                    // Create a file to write to.
//                    File.CreateText(newPath);
//                }
//            }