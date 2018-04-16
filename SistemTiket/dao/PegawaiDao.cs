using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using SistemTiket.model;

namespace SistemTiket.dao
{
    class PegawaiDao
    {
        string conf = "server=127.0.0.1;" +
                      "port=3306;" +
                      "UID=root;" +
                      "PWD=;" +
                      "database=db_ticket";
      MySqlConnection conn = new MySqlConnection();

        public PegawaiDao() {
            conn.ConnectionString = conf;
        }
        // Query Show Data
        public DataSet ShowEmployee() {
            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM users";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds,"users");

            conn.Close();
            return ds;
        }

        //Query Insert Data
        public bool InsertData(Pegawai p) {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "INSERT INTO users VALUES ('"+p.no+"','"+p.id_pegawai+"','"+p.nama_pegawai+"','"+p.status+"','"+p.passwords+"')";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }

        public bool UpdateData(Pegawai p) {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "UPDATE users "+
                                "SET no='" +p.id_pegawai+"'," +
                                "nama_pegawai='" +p.nama_pegawai+ "',"+
                                "jabatan='"+p.status+"',"+
                                "passwords='"+p.passwords+"'"+
                                "WHERE id='"+p.id_pegawai+"'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }

        public bool DeleteData(Pegawai p){
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "DELETE FROM users WHERE `id`='"+p.id_pegawai+"'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }

        public DataSet FindById(Pegawai p) {
            
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM users WHERE `id`='" + p.id_pegawai + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "users");         
            conn.Close();
            return ds;
        }

        public DataSet FindByName(Pegawai p) {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM users WHERE `nama_pegawai`= '" + p.nama_pegawai + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "users");
            conn.Close();
            return ds;
        }
    }
}
