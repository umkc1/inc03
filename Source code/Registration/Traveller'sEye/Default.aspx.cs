using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ServiceReference1;

public partial class _Default : System.Web.UI.Page
{

    WebServiceSoapClient proxy = new WebServiceSoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {
       
    }

    public void clear()
    {
        txtfname.Text = string.Empty;
        txtuname.Text = string.Empty;
         txtlname.Text= string.Empty;
             txtpassword.Text= string.Empty;
                 txtage.Text= string.Empty;
                 txtuniqueid.Text = string.Empty;
                 txtphone.Text = string.Empty;
                 txtemail.Text = string.Empty;
                 lblexist.Text = string.Empty;
                         

    }

    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        

        try
        {
            int check = proxy.checkuname(txtuname.Text);

            if (check == 1)
            {

            }
            {

                int result = proxy.insertdetails(txtfname.Text, txtlname.Text, txtuname.Text, txtpassword.Text, Convert.ToInt32(txtage.Text), txtuniqueid.Text, txtphone.Text);

                if (result > 0)
                {

                    string msg = "<script>alert('Inserted Success')</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", msg, false);
                    clear();

                }
                else
                {
                    string msg = "<script>alert('Error')</script>";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alert", msg, false);

                }
            }
        }
        catch
        { }


    }
    protected void txtuname_TextChanged(object sender, EventArgs e)
    {
        int check = proxy.checkuname(txtuname.Text);

        if (check == 1)
        {

            lblexist.Text = "UserName already exists try another one";
        }
        else
        {
            if (txtuname.Text == "")
            {
                lblexist.Text = "";
            }
            else
            {
                lblexist.Text = "OK";
            }
        }

    }
    protected void btnclear_Click(object sender, EventArgs e)
    {
        clear();
    }
}
