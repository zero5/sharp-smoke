using System;
using System.Web;

namespace Smoke
{
    public partial class xss2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["text"] == "test" && Request.Form["text2"] == "test")
            {
                string name = Request.Form["name"];

                Response.Write(name);
            }
        }

        public void Button1_Click(object sender, EventArgs e)
        {
            if (Request.Form["text"] == "test" && Request.Form["text2"] == "test")
            {
                string name = Request.Form["name"];

                Response.Write(name);
            }
        }
    }
}