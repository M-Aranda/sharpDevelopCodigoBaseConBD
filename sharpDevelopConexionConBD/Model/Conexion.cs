/*
 * Created by SharpDevelop.
 * User: Marcelo Aranda

 * Date: 9/13/2018
 * Time: 5:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace sharpDevelopConexionConBD.Model
{
	/// <summary>
	/// Description of Conexion.
	/// </summary>
	 public class Conexion
    {
        private SqlConnection con; 
        private SqlCommand sen;	
        public SqlDataReader rs; 

        public Conexion(String bd)
        {
            con = new SqlConnection(
                    "Data Source=localhost;" +
                    "Initial Catalog=" + bd + "; " +
                    "User id=sa; " +
                    "Password=;"
                );

        }

        public DataTable Ejecutar(String query)
        {
            Console.WriteLine("QUERY=" + query);
            DataTable dt = null;

            con.Open();
            sen = new SqlCommand(query, con);

            if (query.ToLower().Contains("select"))
            {
                rs = sen.ExecuteReader();
                dt = new DataTable();
                dt.Load(rs);
            }
            else
            {
                sen.ExecuteNonQuery();
            }
            Cerrar();
            return dt;
        }

        public void Cerrar()
        {
            con.Close();
        }
    }
}
