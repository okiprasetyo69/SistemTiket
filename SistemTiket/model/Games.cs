using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemTiket.model
{
    class Games
    {
        private string __no;
        public string no {
            get { return __no; }
            set { __no = value; }
        }
        private string __id_games;
        public string id_games
        {
            get { return __id_games; }
            set { __id_games = value; }
        }

        private string __nama_games;
        public string nama_games
        {
            get { return __nama_games; }
            set { __nama_games = value; }
        }

        private double __harga;
        public double harga
        {
            get { return __harga; }
            set { __harga = value; }
        }
    }
}
