using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemTiket.model;
using MySql.Data.MySqlClient;
using System.Data;

namespace SistemTiket.dao
{
    class DtlTransasksiDao
    {
        //Create Configuration
        string conf = "server=127.0.0.1;" +
                      "port=3306;" +
                      "UID=root;" +
                      "PWD=;" +
                      "database=db_ticket";
        MySqlConnection conn = new MySqlConnection();

        //Construct
        public DtlTransasksiDao(){
            conn.ConnectionString = conf;
        }

        //Show Transaksi
        public DataSet ShowTransaction(){
            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT dtl.`id_detail_transaksi`, dtl.id_transaksi, dtl.`tgl_transaksi`,dtl.id_pegawai, g.`id_games`, g.nama_games ,g.harga, dtl.`jumlah` ,dtl.`jumlah`*g.`harga` FROM dtl_transaksi dtl INNER JOIN games g ON dtl.`id_games`= g.`id_games`";
           

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_ticket"); 
           

            conn.Close();
            return ds;
        }

        public bool InsertData(DtlTransaksi dtl) {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "INSERT INTO dtl_transaksi (id_transaksi,tgl_transaksi, id_pegawai, id_games, jumlah) VALUES ('"+dtl.id_transaksi+"','"+dtl.tgl_transaksi+"','"+dtl.id_pegawai+"','"+dtl.id_games+"','"+dtl.jumlah+"')";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }
        public bool UpdateData(DtlTransaksi dtl)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "UPDATE dtl_transaksi " +
                                "SET tgl_transaksi='" + dtl.tgl_transaksi + "'," +
                                "id_pegawai='" + dtl.id_pegawai + "'," +
                                "id_games='" + dtl.id_games + "'," +
                                "jumlah='" + dtl.jumlah + "'" +
                                "WHERE id_detail_transaksi='" + dtl.id_dtl_transaksi + "'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }

        public bool DeleteData(DtlTransaksi dtl)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "DELETE FROM dtl_transaksi WHERE `id_transaksi`='" + dtl.id_transaksi + "'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }

        public DataSet FindById(DtlTransaksi dtl_transaksi) {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM dtl_transaksi WHERE id_transaksi ='"+dtl_transaksi.id_transaksi+"' ";
            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "dtl_transaksi");
            conn.Close();
            return ds;
        }

        public DataSet FindByCategory(DtlTransaksi dtl_transaksi) {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM dtl_transaksi WHERE `id_games`= '" + dtl_transaksi.id_games + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "dtl_transaksi");
            conn.Close();
            return ds;
        }

        public DataSet FindByDate(DtlTransaksi dtl_transaksi) {
            DataSet ds = new DataSet();
            conn.Open();
            
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM dtl_transaksi WHERE tgl_transaksi BETWEEN '"+dtl_transaksi.tgl_transaksi_awal+"' AND '"+dtl_transaksi.tgl_transaksi_akhir+"' ";
            
           
            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "dtl_transaksi");
            conn.Close();
            return ds;
        }

        public DataSet CountTicket(DtlTransaksi dtl) {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT dtl.`id_transaksi` ,dtl.`tgl_transaksi`, g.`id_games`, g.nama_games ,g.harga, dtl.`jumlah` ,dtl.`jumlah`*g.`harga` FROM dtl_transaksi dtl INNER JOIN games g ON dtl.`id_games`= g.`id_games` INNER JOIN master_transaksi mstr_trns ON mstr_trns.`id_transaksi` = dtl.`id_transaksi`WHERE mstr_trns.`status_transaksi` = 0";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_ticket");
            conn.Close();

            return ds;
        }

        public DataSet GrandTotal(DtlTransaksi dtl)
        {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT SUM(dtl.`jumlah` * g.`harga`) FROM dtl_transaksi dtl INNER JOIN games g ON dtl.`id_games` = g.`id_games`";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "db_ticket");
            conn.Close();

            return ds;
        }
    }
}
