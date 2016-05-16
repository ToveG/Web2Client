using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace We2Client
{
    public partial class commandClient : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           var doc = Directory.GetFiles(@"C:\inetpub\wwwroot\DocumentArchive");
   

            foreach (var d in doc)
           {
                //var fileName = d.Substring(d.LastIndexOf(("\\")) + 1);

                //Button deleteButton = new Button();
                //Button copyButton = new Button();
                //deleteButton.Text = "Ta bort";
                //copyButton.Text = "Kopiera";

                //TableRow row = new TableRow();
                //TableCell cell1 = new TableCell();
                //TableCell cell2 = new TableCell();
                //TableCell cell3 = new TableCell();
                //cell2.Controls.Add(deleteButton);
                //cell3.Controls.Add(copyButton);
                //cell1.Text = fileName;
                //row.Cells.Add(cell1);
                //row.Cells.Add(cell2);
                //row.Cells.Add(cell3);
                //myTable.Rows.Add(row);
                

            }
        }
    }
}