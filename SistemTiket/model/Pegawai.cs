using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemTiket.model
{
    class Pegawai
    {
        private int __no;
        public int no {
            get { return __no; }
            set { __no = value; }
        }
    
        private string __id_pegawai;
        public string id_pegawai{
            get{return __id_pegawai;}
            set{__id_pegawai= value;}
        }

        private string __nama_pegawai;
        public string nama_pegawai {
            get { return __nama_pegawai; }
            set { __nama_pegawai = value; }
        }

        private string __status;
        public string status {
            get { return __status; }
            set { __status = value; }
        }

        private string __passwords;
        public string passwords {
            get { return __passwords; }
            set { __passwords = value; }
        }
          
    }
}
