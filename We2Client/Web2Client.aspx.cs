using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace We2Client
{
    public partial class Web2Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Client2Web:05");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client2Web:01");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client2Web:02");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client2Web:03");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Client2Web:04");
        }
    }
}