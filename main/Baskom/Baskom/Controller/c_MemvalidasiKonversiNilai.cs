using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_MemvalidasiKonversiNilai
    {
        m_DataAkunDosen m_DataAkunDosen;
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataKonversiNilai m_DataKonversiNilai;
        m_DataProdi m_DataProdi;
        m_DataPenerimaanMitra m_DataPenerimaanMitra;
        m_DataMitra m_DataMitra;
        m_DataProgram m_DataProgram;
        m_DataPembagianTugas m_DataPembagianTugas;
        object[] data_akun_pengguna;
        public c_MemvalidasiKonversiNilai(m_DataKonversiNilai m_DataKonversiNilai, m_DataAkunDosen m_DataAkunDosen, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi, m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataPembagianTugas m_DataPembagianTugas, m_DataAkunTimmbkm data_akun_pengguna)
        {
            this.m_DataKonversiNilai = m_DataKonversiNilai;
            this.m_DataAkunDosen = m_DataAkunDosen;
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataProdi = m_DataProdi;
            this.m_DataPenerimaanMitra = m_DataPenerimaanMitra;
            this.m_DataMitra = m_DataMitra;
            this.m_DataProgram = m_DataProgram;
            this.m_DataPembagianTugas = m_DataPembagianTugas;
            this.data_akun_pengguna = data_akun_pengguna.getAttributes();

        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();
            List<object[]> data_konversi_nilai = m_DataKonversiNilai.getAllKonversiNilai();
            foreach (object[] konversi_nilai in data_konversi_nilai)
            {
                object[] pembagian_tugas = m_DataPembagianTugas.getPembagianTugasByIdNilai((int)konversi_nilai[0]);
                if ((int)pembagian_tugas[4] == (int)this.data_akun_pengguna[0])
                {
                    object[] items = new object[5];
                    object[] dosen = m_DataAkunDosen.getDosenById((int)konversi_nilai[3]);
                    object[] penerimaan_mitra = m_DataPenerimaanMitra.getPenerimaanMitraByIdMhs((int)konversi_nilai[4]);
                    object[] mahasiswa = m_DataAkunMahasiswa.getMahasiswaById((int)konversi_nilai[4]);
                    object[] mitra = m_DataMitra.getMitraById((int)penerimaan_mitra[6]);
                    object[] program = m_DataProgram.getProgramById((int)penerimaan_mitra[9]);
                    string nama_prodi = m_DataProdi.getNamaProdiById((int)mahasiswa[9]);
                    items[0] = mahasiswa[2];
                    items[1] = mahasiswa[1];
                    items[2] = nama_prodi;
                    items[3] = mitra[1];
                    items[4] = program[1];
                    result.Add(items);
                }
            }
            return result;
        }
    }
}
