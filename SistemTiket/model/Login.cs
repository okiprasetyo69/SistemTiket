using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemTiket.model
{
    class Login
    {
        private string __id_pegawai;
        public string id_pegawai{
            get { return __id_pegawai; }
            set { __id_pegawai = value; }
        }

        private string __passwords;
        public string passwords {
            get { return __passwords; }
            set { __passwords = value; }
        }

        private string __jabatan;
        public string jabatan {
            get { return __jabatan; }
            set { __jabatan = value; }
        }
    }
}
