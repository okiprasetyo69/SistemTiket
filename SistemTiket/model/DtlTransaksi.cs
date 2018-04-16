using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemTiket.model
{
    class DtlTransaksi
    {
        private int __id_dtl_transaksi;
        public int id_dtl_transaksi
        {
            get { return __id_dtl_transaksi; }
            set { __id_dtl_transaksi = value; }
        }

        private string __id_transaksi;
        public string id_transaksi
        {
            get { return __id_transaksi; }
            set { __id_transaksi = value; }
        }

        private string __id_pegawai;
        public string id_pegawai
        {
            get { return __id_pegawai; }
            set { __id_pegawai = value; }
        }

        private string __id_games;
        public string id_games
        {
            get { return __id_games; }
            set { __id_games = value; }
        }

        private int __jumlah;
        public int jumlah
        {
            get { return __jumlah; }
            set { __jumlah = value; }
        }

        private string __tgl_transaksi_awal;
        public string tgl_transaksi_awal
        {
            get { return __tgl_transaksi_awal; }
            set { __tgl_transaksi_awal = value; }
        }
        private string __tgl_transaksi_akhir;
        public string tgl_transaksi_akhir {
            get { return __tgl_transaksi_akhir; }
            set { __tgl_transaksi_akhir = value; }
        }

             

        private string __tgl_transaksi;
        public string tgl_transaksi {
            get { return __tgl_transaksi; }
            set { __tgl_transaksi = value; }
        }

        

    }
}
