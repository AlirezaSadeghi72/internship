using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DataLayer
{
    public class adoTest
    {
        private string connectionString =
            "Data Source=.;Initial Catalog=Atiran2;Integrated Security=true";

        public void insertQuery(string code, string special, string MONAME, int group_rdf
            , int vis_rdf, string addre, string tell1, decimal cred, int? check_eteb,
            int? just_naghdi, int? MaxManFactor, string sharh)
        {
            string queryString =
                "INSERT INTO[dbo].[CUSTOMERS](code, special, MONAME, group_rdf, vis_rdf, addre, tell1" +
                ", cred, check_eteb, just_naghdi, MaxManFactor, sharh, BANKNAME, tell2, cell, active, man, rdf_city, rdf_region" +
                ", hesab_status, result_m) VALUES(@code, @special, @MONAME, @group_rdf, @vis_rdf, @addre, @tell1" +
                ", @cred, @check_eteb, @just_naghdi, @MaxManFactor, @sharh, N'--', N'', N'', 't', 0, 29, 42, 1, N'ذکر نشد')";

            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@code", code);
                command.Parameters.AddWithValue("@special", special);
                command.Parameters.AddWithValue("@MONAME", MONAME);
                command.Parameters.AddWithValue("@group_rdf", group_rdf);
                command.Parameters.AddWithValue("@vis_rdf", vis_rdf);
                command.Parameters.AddWithValue("@addre", addre);
                command.Parameters.AddWithValue("@tell1", tell1);
                command.Parameters.AddWithValue("@cred", cred);
                command.Parameters.AddWithValue("@check_eteb", check_eteb);
                command.Parameters.AddWithValue("@just_naghdi", just_naghdi);
                command.Parameters.AddWithValue("@MaxManFactor", MaxManFactor); 
                command.Parameters.AddWithValue("@sharh", sharh); 

                connection.Open();
                command.ExecuteNonQuery();
            }

        }

        public void insertSP(string code, string special, string MONAME, int group_rdf
            , int vis_rdf, string addre, string tell1, decimal cred, int? check_eteb,
            int? just_naghdi, int? MaxManFactor,string sharh)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("USP_alireza_insert_Customer_test", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add("@code", SqlDbType.NVarChar).Value = code;
                    command.Parameters.Add("@special", SqlDbType.Char).Value = special;
                    command.Parameters.Add("@MONAME", SqlDbType.NVarChar).Value = MONAME;
                    command.Parameters.Add("@group_rdf", SqlDbType.Int).Value = group_rdf;
                    command.Parameters.Add("@vis_rdf", SqlDbType.Int).Value = vis_rdf;
                    command.Parameters.Add("@addre", SqlDbType.NVarChar).Value = addre;
                    command.Parameters.Add("@tell1", SqlDbType.NVarChar).Value = tell1;
                    command.Parameters.Add("@cred", SqlDbType.Money).Value = cred;
                    command.Parameters.Add("@check_eteb", SqlDbType.Int).Value = check_eteb;
                    command.Parameters.Add("@just_naghdi", SqlDbType.Int).Value = just_naghdi;
                    command.Parameters.Add("@MaxManFactor", SqlDbType.NVarChar).Value = MaxManFactor;
                    command.Parameters.Add("@sharh", SqlDbType.NVarChar).Value = sharh;


                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
