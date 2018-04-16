using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemTiket.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemTiket.dao
{
    class LoginDao
    {
        //Create Configuration
        string conf = "server=127.0.0.1;" +
                      "port=3306;" +
                      "UID=root;" +
                      "PWD=;" +
                      "database=db_ticket";
        MySqlConnection conn = new MySqlConnection();

        //construct
        public LoginDao(){
            conn.ConnectionString = conf;
        }

        public string login_pegawai(Login obj_login) {
            
            string status = "gagal";
            obj_login.passwords = obj_login.passwords.ToUpper();

            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM users ";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read())
            {
                if ((reader.GetString(1).ToString() == obj_login.id_pegawai)&&(reader.GetString(4).ToString().ToUpper() == obj_login.passwords))
                {
                    status = "sukses";
                }
            }

            conn.Close();
            return status;
        }
    }
}
