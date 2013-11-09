using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


namespace emergencylocalcommu
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MyWebService.WebService s1 = new MyWebService.WebService();
            s1.Credentials = System.Net.CredentialCache.DefaultCredentials;
            string a;
            a = s1.queryTable(TextBox1.Text);
            Label4.Visible = true;
            Label4.Text = a;
            

        }
    }
}