using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace We2Client
{
    public partial class command : System.Web.UI.Page
    {
        string mainPath = @"C:\inetpub\wwwroot\DocumentArchive";

        public void updateList()
        {
            var documentList = getDocument();
            bindDocumentData(documentList);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                updateList();
            }
        }

        public List<document> getDocument()
        {
            var doc = Directory.GetFiles(mainPath); 

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

        public string getExtentionType(string document)
        {
            string doc = document;
            string word = "odt";
            string pp = "odp";
            string excel = "ods";
            if (doc.Contains(word))
            {
                return ".odt";
            }
            else if (doc.Contains(pp))
            {
                return ".odp";
            }
            else if (doc.Contains(excel))
            {
                return ".ods";
            }
            else return "false";
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
            string sourceDir = mainPath;
            string[] myDocList = Directory.GetFiles(sourceDir, commandArgument);

            foreach (string d in myDocList)
            {
                try
                {
                    File.Delete(d);
                }
                catch (Exception exe)
                {
                    Console.WriteLine("An error occurred: '{0}'", exe);
                }
            }
            updateList();
        }
          
        public class document
        {
            public int id { get; set; }
            public string docName { get; set; }
        }
   
        private static string numberPattern = "({0})";
        public static string NextAvailableFilename(string path)
        {
            // Short-cut if already available
            if (!File.Exists(path))
                return path;

            // If path has extension then insert the number pattern just before the extension and return next filename
            if (Path.HasExtension(path))
                return GetNextFilename(path.Insert(path.LastIndexOf(Path.GetExtension(path)), numberPattern));

            // Otherwise just append the pattern to the path and return next filename
            return GetNextFilename(path + numberPattern);
        }

        private static string GetNextFilename(string pattern)
        {
            string tmp = string.Format(pattern, 1);
            if (tmp == pattern)
                throw new ArgumentException("The pattern must include an index place-holder", "pattern");
            if (!File.Exists(tmp))
                return tmp; // short-circuit if no matches
            int min = 1, max = 2; // min is inclusive, max is exclusive/untested
            while (File.Exists(string.Format(pattern, max)))
            {
                min = max;
                max *= 2;
            }
            while (max != min + 1)
            {
                int pivot = (max + min) / 2;
                if (File.Exists(string.Format(pattern, pivot)))
                    min = pivot;
                else
                    max = pivot;
            }
            return string.Format(pattern, max);
        }
        

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            var name = Request.Form["tb3"];
            string newFileName = "";
            string fileName = "";
            string sourcePath = @"C:\inetpub\wwwroot\DocumentArchive\Mallar";
            string targetPath = mainPath;

            if (Word.Checked)
            {
                fileName = "Untitled 1.odt";
                newFileName = name + ".odt";
                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, newFileName);
                string newName = NextAvailableFilename(destFile);
                File.Copy(sourceFile, newName);
            }
            else if (PowerPoint.Checked)
            {
                newFileName = name + ".odp";
                fileName = "Untitled 1.odp";
                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, newFileName);
                string newName = NextAvailableFilename(destFile);
                File.Copy(sourceFile, destFile);
            }
            else if (Excel.Checked)
            {
                fileName = "Untitled 1.ods";
                newFileName = name + ".ods";
                string sourceFile = Path.Combine(sourcePath, fileName);
                string destFile = Path.Combine(targetPath, newFileName);
                string newName = NextAvailableFilename(destFile);
                File.Copy(sourceFile, destFile);

            }
            updateList();
        }

        protected void copyBtn_Click1(object sender, EventArgs e)
        {
            Button button = (sender as Button);
            string commandArgument = button.CommandArgument;

            string filePath = mainPath;
            string sourceFile = Path.Combine(filePath, commandArgument);
            string newName = NextAvailableFilename(sourceFile);
            File.Copy(sourceFile, newName);
            updateList();
        }

        protected void RenameFile_Click(object sender, EventArgs e)
        {
            string existingFileName = valueOfClickedDocument.Value;
            string userInput = valueOfNewDocumentName.Value;
            string extentionType = getExtentionType(existingFileName);
            string filePath = mainPath; 
            string fileName = userInput + extentionType;
            string sourceFile = Path.Combine(filePath, existingFileName);
            
            string newDocumentName = Path.Combine(filePath, fileName);
            string newName = NextAvailableFilename(newDocumentName);
            File.Move(sourceFile, newName);

            updateList();
        }
    }
}
