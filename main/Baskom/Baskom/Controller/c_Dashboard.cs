using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_Dashboard
    {
        protected object data_akun_pengguna = null;
        protected object m_DataAkunDosen;
        protected object m_DataAkunMahasiswa;
        protected object m_DataAkunTimmbkm;
        protected object m_DataDetailMitra;
        protected object m_DataDetailProgram;
        protected object m_DataKonversiNilai;
        protected object m_DataKonversiSks;
        protected object m_DataMataKuliah;
        protected object m_DataMataKuliahTempuh;
        protected object m_DataPenerimaan;
        protected object m_DataProgram;
        private object v_ManajemenProfilDosen;
        private object v_ManajemenProfilMahasiswa;
        private object v_MemvalidasiPengajuanMitra;
        private object v_PembagianTugas;
        private object v_TambahKonversiNilai;
        private object v_TambahKonversiSks;
        private object v_TambahMataKuliahTempuh;
        private object v_TambahMitra;
        private object v_TambahPengajuanMitra;

        public c_Dashboard()
        {
            // cons
        }

        public void logout() { }
        public void setMelihatKonversiNilai() { }
        public void setTambahKonversiNilai() { }
        public void setLogin() { }
        public void setManajemenProfilDosen() { }
        public void setManajemenProfilMahasiswa() { }
        public void setMataKuliah() { }
        public void setMelihatKonversiSks() { }
        public void setPengajuanMitra() { }
        public void setValidasiPengajuanMitra() { }
        public void setProfil(object data_akun_pengguna) { }
        public void setTambahKonversiSks() { }
        public void setTambahMitra() { }
        public void setPembagianTugas() { }
        public void showDataAkun(string nama_mahasiswa, string nim) { }
    }
}
