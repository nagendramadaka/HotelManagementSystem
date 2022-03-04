using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAcessLayer
{
    class HotelDAL
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbcon"].ToString());
    }
}
