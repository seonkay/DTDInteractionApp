using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.SqlClient;

namespace DTDInteractionWindowsFormApp
{
    class DTDSqlClient
    {

        private string hostName = "local";
        private string dbName = "SyntheticMass";
        public string baseQuery = "SELECT CODE FROM medications where PATIENT =\'";
        public string patientID { get; set; }
        public SqlConnection conn = null;


        public DTDSqlClient()
        {
            patientID = String.Empty;
            string sqlString = "Data Source = (" + hostName + "); Database=" + dbName + ";Integrated Security=SSPI;";
            conn = new SqlConnection("Data Source = (local); Database=SyntheticMass;Integrated Security=SSPI;");
        }

        public string makeQuery() {

            string sqlResult = string.Empty;
            conn.Open();
            string queryString = baseQuery + patientID + "'";
            SqlCommand cmd = new SqlCommand(queryString, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    //do work here
                    if(sqlResult != null) 
                        sqlResult = sqlResult + reader.GetInt32(0).ToString() + Environment.NewLine;
                    else 
                        sqlResult = reader.GetInt32(0).ToString() + Environment.NewLine;
                    Console.WriteLine("Result: " + reader.GetInt32(0).ToString());
                    Console.WriteLine("\t{0}", reader.GetInt32(0));
                    Console.WriteLine(sqlResult);

                }
                reader.NextResult();
            }

            conn.Close();
            Console.WriteLine(sqlResult);
            return sqlResult;
        }

        public List<string> getPatientIDList()
        {

            var patientList = new List<string>();

            conn.Open();
            string queryString = "SELECT ID FROM patients";
            SqlCommand cmd = new SqlCommand(queryString, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.HasRows)
            {
                while (reader.Read())
                {
                        patientList.Add(reader.GetString(0));
                }
                reader.NextResult();
            }

            conn.Close();

            return patientList;
        }

        public string getMedicationsWithPatientID(string pID)
        {

            string sqlResult = string.Empty;
            conn.Open();
            string queryString = baseQuery + pID + "'";
            SqlCommand cmd = new SqlCommand(queryString, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(sqlResult))
                        sqlResult = sqlResult + "+" + reader.GetInt32(0).ToString();
                    else
                        sqlResult = reader.GetInt32(0).ToString();
                 }
                reader.NextResult();
            }

            conn.Close();
            // Console.WriteLine(sqlResult);
            return sqlResult;
        }

        public string getRxNormCodeString(string patientID)
        {
            string rxNormCodes = string.Empty;
            return rxNormCodes;
        }
    }
}
