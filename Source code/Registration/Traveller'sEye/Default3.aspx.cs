using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;
using System.Data;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WebServiceSoapClient proxy = new WebServiceSoapClient();

        if (!IsPostBack)
        {

            if (Session["Id"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {

                int Id = Convert.ToInt32(Session["Id"].ToString());


                DataSet ds = proxy.gettotaldetails(Id);


                if (ds.Tables[0].Rows.Count > 0)
                {

                    lblusername.Text = "Welcome : " + ds.Tables[0].Rows[0]["uname"].ToString();
                    lblname.Text = ds.Tables[0].Rows[0]["fname"] + " " + ds.Tables[0].Rows[0]["lname"].ToString();
                    lblage.Text = ds.Tables[0].Rows[0]["age"].ToString();
                    lblphone.Text = ds.Tables[0].Rows[0]["PhoneNumber"].ToString();
                }

            }

        }


    }



    protected void lnklogout_Click(object sender, EventArgs e)
    {

        Session.Remove("Id");
        Server.Transfer("Login.aspx");
    }
}