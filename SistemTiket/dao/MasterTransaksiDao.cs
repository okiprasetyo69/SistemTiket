using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemTiket.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemTiket.dao
{
    class MasterTransaksiDao
    {
        //Create Configuration
        string conf = "server=127.0.0.1;" +
                      "port=3306;" +
                      "UID=root;" +
                      "PWD=;" +
                      "database=db_ticket";
        MySqlConnection conn = new MySqlConnection();

        //Construct
        public MasterTransaksiDao() {
            conn.ConnectionString = conf;
        }

        public bool GetStatusAda(MasterTransaksi mstr_trns)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT status_transaksi FROM master_transaksi WHERE status_transaksi = 1";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }
        public bool GetStatusKosong(MasterTransaksi mstr_trns)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT status_transaksi FROM master_transaksi WHERE status_transaksi = 0";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }
        public DataSet GetStatusTransaksiAda(MasterTransaksi mstr_trns)
        {
            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT status_transaksi FROM master_transaksi WHERE status_transaksi = 1 ";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "master_transaksi");

            conn.Close();
            return ds;
        }
        public bool UpdateData(MasterTransaksi mstr_trns)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "UPDATE master_transaksi SET status_transaksi=1, total='"+mstr_trns.total+"' WHERE id_transaksi='"+mstr_trns.id_transaksi+"'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }
        public DataSet GetStatusTransaksiKosong(MasterTransaksi mstr_trns)
        {
            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT status_transaksi FROM master_transaksi WHERE status_transaksi = 0";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "master_transaksi");

            conn.Close();
            return ds;
        }

        public bool InsertData(MasterTransaksi mstr_trns) {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "INSERT INTO master_transaksi VALUES ('" + mstr_trns.id_transaksi + "','" + mstr_trns.status + "', '"+mstr_trns.total+"')";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }
    }
}
