CREATE TABLE "Data_Mitra"(
	id_mitra serial primary,
    nama_mitra varchar(255),
    deskripsi_mitra text
	)
CREATE TABLE "Data_Penerimaan"(
	id_penerimaan serial primary,
    status_pkl smallint,
    no_wa varchar(13) unique,
    jumlah_sks varchar(13),
    bukti_penerimaan varchar(255),
    Data_BKP_id_bkp int,
    Data_Mitra_id_mitra int,
    Data_Akun_Dosen_id_dosen int,
    Data_Akun_Mahasiswa_id_mahasiswa int
	)
CREATE TABLE "Data_Mata_Kuliah_Tempuh"(
	Data_Mata_Kuliah_id_matkul int,
    Data_Akun_Mahasiswa_id_mahasiswa int
	)
CREATE TABLE "Data_Konversi_SKS"(
	kompetensi text,
    deskripsi_kompetensi text,
    Data_Akun_Dosen_id_dosen int,
    Data_Akun_Mahasiswa_id_mahasiswa int
	)
CREATE TABLE "Data_Akun_Mahasiswa"(
	id_mahasiswa serial primary,
    nim varchar(12),
    nama_mahasiswa varchar(115),
    program_studi varchar(50),
    tahun_masuk int,
    status_mahasiswa smallint,
    no_wa varchar(13) unique,
    batch_mbkm int,
    email varchar(64) unique,
    kata_sandi varchar(64),
    Data_Prodi_id_proi int
	)