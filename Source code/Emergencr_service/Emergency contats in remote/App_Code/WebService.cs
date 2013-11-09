using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Configuration;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string queryTable(string country)
    {

        //Declare Connection by passing the connection string from the web config file
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);

        //Open the connection
        conn.Open();

        string country2 = "";
        string ambulance = "";
        string fire = "";
        string police = "";
        SqlCommand cmd = new SqlCommand("Select * From Table1 where country='" + country + "'", conn);
        SqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            country2 = country2 + "" + reader["country"];
            ambulance = ambulance + "" + reader["ambulance"].ToString();
            fire = fire + "" + reader["fire"].ToString();
            police = police + "" + reader["police"].ToString();
        }
        reader.Close();
        //close the connection
        conn.Close();

        return "AMBULANCE :" + ambulance+ "FIRE: " +fire+ "POLICE :" +police;

    }

    [WebMethod]
    public string insertTable(string country, string ambulance, string fire, string police)
    {
        //Declare Connection by passing the connection string from the web config file
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);

        //Open the connection
        conn.Open();

        //Declare the sql command
        SqlCommand cmd = new SqlCommand
            ("Insert into Table1(country,ambulance,fire,police)values('" + country + "','" + ambulance + "','" + fire + "','" + police + "')", conn);

        //Execute the insert query
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //close the connection
        conn.Close();

        return "Success insert";

    }
    [WebMethod]
    public string deleteTable(string country)
    {
        //Declare Connection by passing the connection string from the web config file
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["dbString"].ConnectionString);

        //Open the connection
        conn.Open();

        //Declare the sql command
        SqlCommand cmd = new SqlCommand("Delete From Table1 Where name= '" + country + "'", conn);

        //Execute the insert query
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        //close the connection
        conn.Close();

        return "Success delete";
    }
}


