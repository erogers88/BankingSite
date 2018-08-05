using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Database;

namespace Submit
{
    public class CreateNewUser
    {
        private string firstNameV;
        private string lastNameV;
        private string userNameV;
        private string emailV;

        public CreateNewUser(string fName, string lName, string uName, string e)
        {
            firstNameV = fName;
            lastNameV = lName;
            userNameV = uName;
            emailV = e;
        }

        public void SubmitNewRegistration()
        {
            using (System.Data.SqlClient.SqlConnection dbConnection = new System.Data.SqlClient.SqlConnection(DB.connectionString))
            {
                string commandText = "dbo.CreateUser";
                System.Data.SqlClient.SqlCommand dbCommand = new System.Data.SqlClient.SqlCommand(commandText, dbConnection);
                dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@firstName", firstNameV);
                dbCommand.Parameters.AddWithValue("@lastName", lastNameV);
                dbCommand.Parameters.AddWithValue("@userName", userNameV);
                dbCommand.Parameters.AddWithValue("@email", emailV);
                dbConnection.Open();
                dbCommand.ExecuteNonQuery();
                dbConnection.Close();
            }
        }
    }
}