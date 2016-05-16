using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace We2Client
{
    public partial class command : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var doc = Directory.GetFiles(@"C:\inetpub\wwwroot\DocumentArchive");

            foreach (var d in doc)
            {
                var fileName = d.Substring(d.LastIndexOf(("\\")) + 1);

                Button deleteButton = new Button();
                Button copyButton = new Button();
                deleteButton.Text = "Ta bort";
                copyButton.Text = "Kopiera";
                deleteButton.Attributes.Add("class", "btn btn-info xx ");
                copyButton.Attributes.Add("class", "btn btn-info xx ");
                HtmlTableRow row = new HtmlTableRow();
                HtmlTableCell cell1 = new HtmlTableCell();
                HtmlTableCell cell2 = new HtmlTableCell();
              //  HtmlTableCell cell3 = new HtmlTableCell();
                cell2.Controls.Add(deleteButton);
                cell2.Controls.Add(copyButton);
                cell1.InnerHtml = fileName;
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
               // row.Cells.Add(cell3);
                myTable.Rows.Add(row);
                }
        }



    }
}