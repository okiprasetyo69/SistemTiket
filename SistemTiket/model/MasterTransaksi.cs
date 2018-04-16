using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemTiket.model
{
    class MasterTransaksi
    {
        private string __id_transaksi;
        public string id_transaksi {
            get { return __id_transaksi; }
            set { __id_transaksi = value; }
        }

        private int __status;
        public int status {
            get { return __status; }
            set { __status = value; }
        }

        private double __total;
        public double total {
            get { return __total; }
            set { __total = value; }
        }
    }
}
