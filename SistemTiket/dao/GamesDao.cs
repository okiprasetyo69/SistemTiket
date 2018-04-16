using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemTiket.model;
using MySql.Data.MySqlClient;
using System.Data;


namespace SistemTiket.dao
{
    class GamesDao
    {
        //Create Configuration
        string conf = "server=127.0.0.1;" +
                      "port=3306;" +
                      "UID=root;" +
                      "PWD=;" +
                      "database=db_ticket";
        MySqlConnection conn = new MySqlConnection();

        //Construct
        public GamesDao(){
            conn.ConnectionString = conf;
        }

        //Method Show Data Games
        public DataSet ShowGames(){
            DataSet ds = new DataSet();

            conn.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM games";

            MySqlDataAdapter data = new MySqlDataAdapter(query);
            data.Fill(ds, "games");

            conn.Close();
            return ds;
        }

        //Method Insert Data
        public bool InsertData(Games g)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "INSERT INTO games VALUES ('"+g.no+"','" + g.id_games + "','" + g.nama_games + "','" + g.harga + "')";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }

        //Method Update Data
        public bool UpdateData(Games g)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "UPDATE games " +
                                "SET id_games='" + g.id_games + "'," +
                                "nama_games='" + g.nama_games + "'," +
                                "harga='" + g.harga + "'" +
                                "WHERE id_games='" + g.id_games + "'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }

        //Method Delete Data
        public bool DeleteData(Games g)
        {
            bool stat = false;
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "DELETE FROM games WHERE `id_games`='" + g.id_games + "'";
            query.ExecuteNonQuery();
            stat = true;
            conn.Close();
            return stat;
        }

        public DataSet FindById(Games g) {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM games WHERE `id_games`='" + g.id_games + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "games");
            conn.Close();
            return ds;
        }

        public DataSet FindByName(Games g) {
            DataSet ds = new DataSet();
            conn.Open();

            MySqlCommand query = new MySqlCommand();
            query.Connection = conn;
            query.CommandText = "SELECT * FROM games WHERE `nama_games`='" + g.nama_games + "'";
            MySqlDataAdapter data = new MySqlDataAdapter(query);

            data.Fill(ds, "games");
            conn.Close();
            return ds;
        }
    }
}
