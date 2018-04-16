using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemTiket.model;
using MySql.Data.MySqlClient;
using System.Data;
namespace SistemTiket.dao
{
    class StatusPegawaiDao
    {
        //Create Configuration
        string conf = "server=127.0.0.1;" +
                      "port=3306;" +
                      "UID=root;" +
                      "PWD=;" +
                      "database=db_ticket";
        MySqlConnection conn = new MySqlConnection();

        //construct
        public StatusPegawaiDao() {
            conn.ConnectionString = conf;
        }

        public string status(Login obj_login) {
            
            string status_pegawai = "";
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT jabatan FROM users WHERE id = '" + obj_login.id_pegawai + "'";

            MySqlDataReader reader = query.ExecuteReader();
            while(reader.Read()){
                if(reader.GetString(0).ToString() == "Supervisior"){
                    status_pegawai = "SPV";
                }
                else if (reader.GetString(0).ToString() == "Kasir"){
                    status_pegawai = "KSR";
                }     
            }
            conn.Close();
            return status_pegawai;
        }
    }
}
