CREATE TABLE "Data_Mitra"(
	id_mitra serial primary key NOT NULL,
    nama_mitra varchar(255) UNIQUE NOT NULL,
    deskripsi_mitra text NOT NULL
);

CREATE TABLE "Program"(
	id_program serial PRIMARY KEY NOT NULL,
	nama_program varchar(64) UNIQUE NOT NULL
);

CREATE TABLE "Detail_Program" (
	id_matkul int NOT NULL,
	id_program int REFERENCES "Program"(id_program) NOT NULL
);

CREATE TABLE "Detail_Mitra" (
	id_program int REFERENCES "Program"(id_program) NOT NULL,
	id_mitra int REFERENCES "Data_Mitra"(id_mitra) NOT NULL
);

CREATE TABLE "Data_Mata_Kuliah" (
	id_matkul serial PRIMARY KEY NOT NULL,
	kode_matkul varchar(7) UNIQUE NOT NULL,
	nama_matkul varchar(50) UNIQUE NOT NULL,
	sks int NOT NULL
);

CREATE TABLE "Data_Prodi" (
	id_prodi serial PRIMARY KEY NOT NULL,
	nama_prodi varchar(24) UNIQUE NOT NULL
);

CREATE TABLE "Data_Akun_Mahasiswa"(
	id_mahasiswa serial primary key NOT NULL,
    nim varchar(12) UNIQUE NOT NULL,
    nama_mahasiswa varchar(115) NOT NULL,
    tahun_masuk int NOT NULL,
    status_mahasiswa smallint NOT NULL,
    no_wa varchar(13) UNIQUE NOT NULL,
    batch_mbkm int NOT NULL,
    email varchar(64) UNIQUE NOT NULL,
    kata_sandi varchar(64) NOT NULL,
    id_prodi int REFERENCES "Data_Prodi"(id_prodi) NOT NULL
);

CREATE TABLE "Data_Mata_Kuliah_Tempuh"(
	id_matkul int REFERENCES "Data_Mata_Kuliah"(id_matkul) NOT NULL,
    id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL
);

CREATE TABLE "Data_Pengajuan_Mitra"(
	id_pengajuan serial primary key NOT NULL,
	nama_mitra varchar(64) UNIQUE NOT NULL,
	deskripsi_mitra text NOT NULL,
	status_validasi smallint NOT NULL,
	id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL
);

CREATE TABLE "Data_Akun_Admin"(
	id_admin serial primary key NOT NULL,
	email varchar(18) UNIQUE NOT NULL,
	kata_sandi varchar(64) NOT NULL
);


CREATE TABLE "Data_Akun_Dosen"(
	id_dosen serial primary key NOT NULL,
	nip varchar(18) UNIQUE NOT NULL,
	nidn varchar(10) UNIQUE NOT NULL,
	nama_dosen varchar(115) NOT NULL,
	no_wa varchar(13) UNIQUE NOT NULL,
	email varchar(64) UNIQUE NOT NULL,
	kata_sandi varchar(64) NOT NULL
);

CREATE TABLE "Data_Akun_Timmbkm"(
	id_timmbkm serial primary key NOT NULL,
	nidn varchar(10) UNIQUE NOT NULL,
	id_dosen int REFERENCES "Data_Akun_Dosen"(id_dosen) NOT NULL
);

CREATE TABLE "Data_Konversi_SKS"(
	kompetensi text NOT NULL,
    deskripsi_kompetensi text NOT NULL,
    id_dosen int REFERENCES "Data_Akun_Dosen" NOT NULL,
    id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL
);


CREATE TABLE "Data_Konversi_Nilai" (
	file_laporan_akhir varchar(100) NOT NULL,
	status_validasi smallint NOT NULL,
	id_matkul int REFERENCES "Data_Mata_Kuliah"(id_matkul) NOT NULL,
	id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL
);


CREATE TABLE "Data_BKP"(
	id_bkp serial primary key NOT NULL,
	bkp varchar(64) NOT NULL,
	deskripsi_bkp text NOT NULL
);

CREATE TABLE "Data_Penerimaan"(
	id_penerimaan serial primary key NOT NULL,
    status_pkl smallint NOT NULL,
    no_wa varchar(13) UNIQUE NOT NULL,
    jumlah_sks varchar(13) NOT NULL,
    bukti_penerimaan varchar(255) NOT NULL,
    id_bkp int REFERENCES "Data_BKP"(id_bkp) NOT NULL,
    id_mitra int REFERENCES "Data_Mitra"(id_mitra) NOT NULL,
    id_dosen int REFERENCES "Data_Akun_Dosen"(id_dosen) NOT NULL,
    id_mahasiswa int REFERENCES "Data_Akun_Mahasiswa"(id_mahasiswa) NOT NULL
);

CREATE TABLE "Data_Pembagian_Tugas"(
	id_tugas serial primary key NOT NULL,
	id_penerimaan int REFERENCES "Data_Penerimaan"(id_penerimaan) NOT NULL,
	id_dosen int REFERENCES "Data_Akun_Dosen"(id_dosen) NOT NULL
);



INSERT INTO "Data_Mitra"(nama_mitra, deskripsi_mitra)
VALUES ('GoTo Impact Foundation', 'GoTo Impact Foundation (GIF) adalah organisasi akselerator dampak yang menggabungkan jiwa empati filantropi dengan semangat berinovasi sociopreneur'),
('Alterra Academy', 'Alterra Academy (ALTA) is a tech talent accelerator who helps potential tech talents to be the best version of themselves and help organization findin'),
('B-One Corporation', 'B One Corporation adalah perusahaan yang bergerak dalam kegiatan pelayanan di bidang Teknologi Informasi dan Komunikasi, yang telah berdiri sejak tahun 2009'),
('Direktorat Jenderal Pendidikan Tinggi', 'Direktorat Jenderal Pendidikan Tinggi (Ditjen Dikti) merupakan salah satu unit utama di Kementerian Pendidikan dan Kebudayaan'),
('Dicoding Indonesia', 'Dicoding hadir sebagai platform pendidikan teknologi yang membantu menghasilkan talenta digital berstandar global.'),
('GreatEdu', 'GreatEdu merupakan platform belajar online untuk upskilling dan reskilling'),
('Bangkit Academy', 'Bangkit adalah program kesiapan karier yang didesain oleh Google untuk memberikan mahasiswa Indonesia paparan langsung dengan praktisi industri'),
('Dinas Komunikasi dan Informatika Kota Surabaya', 'Dinas Komunikasi dan Informatika Kota Surabaya adalah Dinas yang mempunyai tugas melaksanakan kewenangan daerah di bidang pengelolaan Teknologi'),
('Data Academy', 'Data Academy is a study center for data professionals together with education, industry, government and community in building skills in Data Science and Artificial Intelligence (AI)'),
('Binar Academy', 'Binar Academy merupakan pelopor startup edtech yang fokus pada pengembangan skil dan talenta digital dengan meningkatkan pengalaman belajar');
INSERT INTO "Program" (nama_program) 
VALUES ('Front-End Engineer Career with ReactJS'), 
('Digital Marketing with Adobe International Certification'), 
('Android Learning Path'),
('Backend Javascript'), 
('Data Analyst'), 
('Machine Learning'), 
('Instruktur Pembelajaran TIK'),
('Product Manager'),
('Fullstack Engineering'),
('UI/UX Design');
INSERT INTO "Data_Mata_Kuliah"(kode_matkul, nama_matkul, sks)
VALUES ('KMU1018', 'Pemrograman Back-End', 3),
('KMU1001', 'Komunikasi Kerja', 2),
('KMU1002', 'Critical Thinking and Problem Solving', 3),
('KIU1047', 'System Enterprise', 2),
('KIU1051', 'Soft Skill TI', 3),
('KMU1017', 'Pemrograman Front-End', 3),
('KMU1010', 'UI/UX Design', 4),
('KIU1052', 'Hard Skill TI', 3),
('KMU1016', 'Pemrograman Aplikasi Mobile', 3),
('KMU1013', 'Digital Marketing', 3);
INSERT INTO "Data_Prodi" (nama_prodi)Values ('Sistem Informasi');
INSERT INTO "Data_Prodi" (nama_prodi)Values ('Teknologi Informasi');
INSERT INTO "Data_Prodi" (nama_prodi)Values ('Informatika');
INSERT INTO "Data_Akun_Admin" (email, kata_sandi) VALUES ('rehan22@gmail.com','rehanganteng');
INSERT INTO "Data_Akun_Dosen" (nip, nidn, nama_dosen, no_wa, email, kata_sandi) VALUES 
('197709290123458678', '988543210', 'Budi Santoso', '087648629084', 'budisantosoomail.com', 'budi123'),
('197308112022078008', '2222222222', 'Siti Rahayu', '081234567891', 'siti.rahayu@gmail.com', 'siti1234'),
('198708142012045004', '4444444444', 'Ahmad Hidayat', '085678901434', 'ahmad.hidayat@gmail.com', 'ahmadpass'),
('198903112022078008', '6666666666', 'Dewi Lestari', '087654321098', 'dewi.lestari@gmail.com', 'dewipass123'),
('777777777777777777', '8888888888', 'Fauzi Abdullah', '081234267890', 'fauzi.abdullah@gmail.com', 'fauzipass'),
('999999999999999999', '0000000000', 'Indah Puspita', '085678501234', 'indah.puspita@gmail.com', 'indahpass'),
('123123123123123123', '4564564567', 'Joko Susilo', '087654331098', 'joko.susilo@gmail.com', 'joko123'),
('789789789789789789', '0120120123', 'Lina Wijaya', '081234568890', 'lina.wijaya@gmail.com', 'lina456'),
('456456456456456456', '7897897890', 'Rudi Hermawan', '085378901234', 'rudi.hermawan@gmail.com', 'rudipass789'),
('987987987987987987', '6546546543', 'Santi Kartika', '087659321098', 'santi.kartika@gmail.com', 'santipass987'),
('196906151997021002', '0015066902', 'Anang Andrianto', '081234567890', 'anang.uptti@unej.ac.id', 'anangpass123'),
('199110172020121002', '0017109102', 'Beny Prasetyo', '081234566453', 'beny.pssi@unej.ac.id', 'bennypass123'),
('198511282015041002', '0028118503', 'Fajrin Nurman Arifin', '08123456932', 'fajrin.pssi@unej.ac.id', 'farjrinpass123'),
('760015717', '0013118806', 'Gama Wisnu Fajarianto', '081234564435', 'gamawisnuf@unej.ac.id', 'gamapass123'),
('199301312022031005', '0031039301', 'Januar Adi Putra', '081234565437', 'januaradi.putra@unej.ac.id', 'januarpass123'),
('199512092022032023', '0009129501', 'Karina Nine Amalia', '08123453590', 'karina@unej.ac.id', 'karinapass123'),
('198101232010121003', '0023018108', 'Muhamad Arief Hidayat', '08123458984', 'arief.hidayat@unej.ac.id', 'ariefpass123'),
('198410242009122008', '0024108405', 'Nelly Oktavia Adiwijaya', '08123456903', 'nelly.oa@unej.ac.id', 'nellypass123'),
('198301312015041001', '003108303', 'Priza Pandunata', '08123458944', 'priza@unej.ac.id', 'prizapass123');
INSERT INTO "Detail_Mitra"(id_program, id_mitra)
VALUES (1, 2),
(2, 3),
(3, 7),
(4, 10),
(5, 9),
(6, 5),
(7, 8),
(8, 4),
(9, 1),
(10, 6);
INSERT INTO "Detail_Program" (id_matkul, id_program) 
VALUES (1, 4), 
(2, 7),
(3, 9),
(4, 5),
(5, 6),
(6, 1),
(7, 10),
(8, 3),
(9, 8),
(10, 2);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101005','Ayu Qomariya Putri Edyta',2022,1,'085853850540',1,'222410101005@mail.unej.ac.id','Ayu_1005',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101012','Rinda Indriyani Shindi Shantika',2022,1,'087756252568',1,'222410101012@mail.unej.ac.id','Rinda_1012',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101020','Shavira Febynadia',2022,1,'08113068789',1,'222410101020@mail.unej.ac.id','Shavira_1020',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101035','Fatimatuz Zahra',2022,1,'082302526002',1,'222410101035@mail.unej.ac.id','Fatimatuz_1035',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101037','Muhammad Faqih',2022,1,'083156922092',1,'222410101037@mail.unej.ac.id','Muhammad_1037',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101042','Millatul Azizah',2022,1,'081231978858',1,'222410101042@mail.unej.ac.id','Millatul_1042',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101043','Vaneca Raditya Fendyani',2022,1,'083143158444',1,'222410101043@mail.unej.ac.id','Vaneca_1043',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101044','Abd. Muiz Samsul Arifin',2022,1,'0895606158031',1,'222410101044@mail.unej.ac.id','Abdul_1044',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101050','Raka Febrian Syahputra',2022,1,'081233405169',1,'222410101050@mail.unej.ac.id','Raka_1050',1);
INSERT INTO "Data_Akun_Mahasiswa" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi)
VALUES ('222410101051','Nadilia Dwi Oktavia',2022,1,'082236685213',1,'222410101051@mail.unej.ac.id','Nadilia_1051',1);
INSERT INTO "Data_Akun_Timmbkm" (nidn, id_dosen) VALUES 
('1230987688', 1),
('0015066902', 2),
('0017109102', 3),
('0028118503', 4),
('003108303', 19),
('0013118806', 6),
('0031039301', 7),
('0023018108', 8),
('0009129501', 9),
('0024108405', 10);
INSERT INTO "Data_Mata_Kuliah_Tempuh"(id_matkul, id_mahasiswa)
VALUES (3, 4),
(5, 6),
(7, 8),
(9, 9),
(3, 10),
(8, 2),
(10, 1),
(4, 8),
(9, 3),
(10, 4);
INSERT INTO "Data_Konversi_SKS"(kompetensi, deskripsi_kompetensi, id_dosen, id_mahasiswa)
VALUES ('Proyek Kolaborasi', 'Mampu mengelola proyek yang ditugaskan kepada pemagang secara kelompok',1 ,10 ),
('Perencanaan Proyek Riset', 'Mampu membuat rancangan proyek riset yang sesuai dengan permasalahan yang dialami di Bukit Vista', 2, 9),
('Programming', 'Menguasai programming menggunakan Python, mySQL', 3, 7),
('Pengelolaan Klien', 'Mampu memenuhi permintaan klien atas proyek yang dipegang', 4, 6),
('Realisasi dan Pengelolaan Proyek', 'Mampu mengeksekusikan rencana proyek yang sebelumnya direncanakan dengan baik', 5, 5),
('UI/UX', 'Mampu menerapkan UI/UX pada project rill industri yang dibuuktikan dengan Sertifikasi Internasional', 6, 4),
('Digital Marketing', 'Mengenal pemasaran digital, mampu membuat pemasaran digital dengan tools digital yang dibuktikan dengan Sertifikasi Internasional', 7, 3),
('Design Principle', 'Mampu membuat desain menarik sesuai dengan prinsip desain yang dibuktikan dengan Sertifikasi Internasional', 8, 2),
('Content Creator', 'Mampu membuat Content dan writer untuk berbagai media dan produk yang dibuktikan dengan Sertifikasi Internasional', 9, 1),
('Bisnis Digital', 'Mengenal bisnis digital atau industri startup yang eksis di Indonesia, Mengenal trend bisnis startup dunia Mampu menganalisa bisnis startup yang dibuktikan dengan Sertifikasi Internasional', 10, 1);
INSERT INTO "Data_Konversi_Nilai"(file_laporan_akhir, status_validasi, id_matkul, id_mahasiswa)
VALUES ('https://kampusmerdeka.kemdikbud.go.id/','0',1,5),
('https://pusatinformasi.kampusmerdeka.kemdikbud.go.id','1',2,3),
('https://grow.google/intl/id_id/bangkit/?tab=machine-learning','1',3,7),
('https://kampusmerdeka.kemdikbud.go.id/program','0',4,5),
('https://kampusmerdeka.kemdikbud.go.id/program/mengajar','1',6,8),
('https://kampusmerdeka.kemdikbud.go.id/program/magang/detail','1',7,9),
('https://kampusmerdeka.kemdikbud.go.id/program/studi-independen/detail','1',8,2),
('https://pmm.kampusmerdeka.kemdikbud.go.id/pages/info/program/pmm_4/','1',9,10),
('https://wirausahamerdeka.kampusmerdeka.kemdikbud.go.id/info/','1',10,4),
('https://praktisimengajar.id/','0',5,7);
INSERT INTO "Data_Pengajuan_Mitra" (nama_mitra,deskripsi_mitra,status_validasi,id_mahasiswa)
VALUES ('PT Hacktivate Teknologi Indonesia (Hacktiv8)','PT Hacktivate Teknologi Indonesia (Hacktiv8) adalah sebuah Lembaga Pendidikan dan Pelatihan bidang teknologi yang telah berdiri sejak tahun 2016, yang dibangun oleh Ronald Ishak dan Riza Fahmi',1,1),
('PT BISA ARTIFISIAL INDONESIA','PT. Bisa Artifisial Indonesia (BISA AI) merupakan perusahaan yang bergerak dibidang IT khususnya pada pengembangan Artificial Intelligence',0,2),
('Binakarir (PT Care Indonesia Solusi)','Binakarir (PT Care Indonesia Solusi) adalah perusahaan yang bergerak di bidang konsultan HRD, yang berlokasi di Bandung. Kami unggul dalam mengembangkan asesmen online dan inovasi layanan lainnya dalam asesmen psikologis dan sumber daya manusia',0,3),
('PT Mitra Integrasi Informatika (Metrodata Academy)','PT Mitra Integrasi Informatika (Metrodata Academy) adalah  perusahaan Teknologi Informasi terbesar di Indonesia berkomitmen ikut serta dalam mencerdaskan kehidupan bangsa, khususnya pengembangan potensi talenta digital, baik untuk IT Professional maupun mahasiswa',1,4),
('PT. Trisakti Pilar Persada','PT. Trisakti Pilar Persada adalah perusahaan yang bergerak pada bidang Kajian Kebijakan, Perancangan Pembangunan, Media Literasi, Pengembangan SDM dan Jasa survey',0,5),
('PT GITS Indonesia','PT GITS Indonesia adalah perusahan yang bergerak dalam bidang pengembangan aplikasi android',1,6),
('PT Orbit Ventura Indonesia','PT Orbit Ventura Indonesia (OVI) telah didirikan pada tahun 2015 untuk memfasilitasi pemahaman yang lebih baik tentang bagaimana ilmu pengetahuan dan teknologi dapat meningkatkan kehidupan negara berkembang',0,7),
('PT Widya Inovasi Indonesia','PT Widya Inovasi Indonesia adalah perusahaan Informasi dan Teknologi yang fokus menghadirkan teknologi masa depan',1,8),
('PT Ruang Raya Indonesia (Ruang Guru)','PT Ruang Raya Indonesia (Ruang Guru) adalah sebuah perusahaan rintisan digital asal Indonesia yang bergerak di bidang pendidikan nonformal',1,9),
('PT Zona Edukasi Nusantara (Zenius)','PT Zona Edukasi Nusantara (Zenius Education) adalah perusahaan pendidikan berbasis teknologi asal Indonesia',0,10);
INSERT INTO "Data_BKP" (bkp, deskripsi_bkp) 
VALUES ('Magang', 'hari ini magang di sini'),
('Pertukaran Pelajar', 'hari ini pertukaran pelajar di UNAIR'),
('KKN Tematik', 'melakukan kkn tematik di sana dengan berbagai hal'),
('Studi Independen', 'melaksanakan studi independent dengan baik dan benar'),
('Asistensi Mengajar', 'memulai hari awal dengan mengajar di sana'),
('KKN Tematik', 'melaksanakan kegiatan itu di sana dengan baik dan benar'),
('Magang', 'melakukan hari awal dengan melaksanakan magang'),
('Studi Independen', 'Lagi hari ini melakukan studi independent seperti biasa'),
('Asistensi mengajar', 'hari ini mulai mengajar huruf'),
('Riset', 'melakukan penelitian dimana dilaksanakan riset');
INSERT INTO "Data_Penerimaan" (id_penerimaan, status_pkl, no_wa, jumlah_sks, bukti_penerimaan, id_bkp, id_mitra, id_dosen, id_mahasiswa)
VALUES (1, 1, '085854606084', '20', 'diterima dengan baik karena ya bagus', 1, 2, 4, 3),
(2, 1, '083456789034', '20', 'diterima dengan bagus karena ya baik', 5, 2, 4, 7),
(3, 0, '081234567834', '20', 'belum bisa karena masih ada yang kurang jadi perlu perbaikan', 4, 3, 2, 8),
(4, 1, '086783459023', '20', 'diterima namun harus diperbaiki lagi agar bagus', 1, 6, 4, 9),
(5, 0, '083245678234', '20', 'bagus namun ditingkatkan lagi', 8, 2, 10, 6),
(6, 1, '085234721478', '20', 'bisa diterima dengan tetap mempertahankan prestasi', 1, 5, 7, 4),
(7, 1, '089754673456', '20', 'perlu ditingkatkan dan nanti diterima', 6, 7, 4, 9),
(8, 1, '087865227430', '20', 'sudah diterima dengan baik dan berprestasi', 2, 2, 6, 2),
(9, 0, '086789045678', '20', 'Belum bisa dan perlu ditingkatkan lagi', 1, 3, 7, 1),
(10, 1, '086543890234', '20', 'harus mempertahankan agar tetap di sini diterima', 8, 3, 6, 6);
INSERT INTO "Data_Pembagian_Tugas"(id_tugas, id_penerimaan, id_dosen)
VALUES (1,2,3),(2,3,4),(3,4,5),(4,5,6),(5,6,7),(6,7,8),(7,8,9),(8,9,10),(9,10,1),(10,1,2);