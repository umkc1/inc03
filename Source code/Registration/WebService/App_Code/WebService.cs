using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]

public class WebService : System.Web.Services.WebService {

    SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename='C:\Users\sudheer\Documents\Visual Studio 2010\WebSites\WebService\App_Data\Database.mdf';Integrated Security=True;User Instance=True");
    
    public WebService () {

    
    
    }
    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]

    public int insertdetails(string fname,string lname,string uname,string password,int age,string uniqueid,string phone)
    {
       


        SqlCommand cmd = new SqlCommand("insert into Registration(fname,lname,uname,password,age,uniqid,PhoneNumber) values ('" + fname + "','" + lname + "','" + uname + "','" + password + "'," + age + ",'"+uniqueid+"','" + phone + "')",con);
        cmd.CommandType = CommandType.Text;


        con.Open();

        int result = cmd.ExecuteNonQuery();


        con.Close();


        return result;
    }

      [WebMethod]
    public int checkuname(string uname)
    {



        SqlCommand cmd = new SqlCommand("select count(*) from Registration where uname='"+uname+"'", con);
        cmd.CommandType = CommandType.Text;


        con.Open();

        int result =Convert.ToInt32(cmd.ExecuteScalar());


        con.Close();


        return result;
    }

      [WebMethod]
      public int chklogin(string uname,string password)
      {

          int id=0;
          SqlCommand cmd = new SqlCommand("select Id from Registration where uname='" + uname + "' and Password='" + password + "'", con);

          SqlDataAdapter da = new SqlDataAdapter(cmd);

          DataSet ds = new DataSet();

          da.Fill(ds);

          if (ds.Tables[0].Rows.Count>0)
          {
              id =Convert.ToInt32(ds.Tables[0].Rows[0]["Id"]);
              return id;
          }

          else
          {
              return id;
          }
      

         
      }
      [WebMethod]
      public DataSet gettotaldetails(int Id)
      {

     
          SqlCommand cmd = new SqlCommand("select * from Registration where Id=" + Id , con);

          SqlDataAdapter da = new SqlDataAdapter(cmd);

          DataSet ds = new DataSet();

          da.Fill(ds);

          if (ds.Tables[0].Rows.Count > 0)
          {
              return ds;
          }

          else
          {
              return null;
          }



      }

    
}
