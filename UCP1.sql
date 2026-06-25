CREATE DATABASE ManajemenBuah;
GO
USE ManajemenBuah;
GO

CREATE TABLE Admin
(
	id_admin INT IDENTITY(1,1) PRIMARY KEY,
	username VARCHAR(50) UNIQUE NOT NULL,
	password VARCHAR(255) NOT NULL
);

CREATE TABLE Buah (
    id_buah INT IDENTITY(1,1) PRIMARY KEY,
    nama_buah VARCHAR(100) NOT NULL,
    jenis_buah VARCHAR(20) NOT NULL,
    harga_per_kg FLOAT NOT NULL,
    
    CONSTRAINT CHK_NamaBuah CHECK (nama_buah NOT LIKE '%[^a-zA-Z ]%'),
    CONSTRAINT CHK_JenisBuah CHECK (jenis_buah IN ('Lokal', 'Impor')),
    CONSTRAINT CHK_Harga CHECK (harga_per_kg >= 0)
);

CREATE TABLE Petani (
    id_petani INT IDENTITY(1,1) PRIMARY KEY,
    nama_petani VARCHAR(100) NOT NULL,
    alamat VARCHAR(100),

	CONSTRAINT CHK_NamaPetani CHECK (nama_petani NOT LIKE '%[^a-zA-Z ]%'),
	CONSTRAINT CHK_AlamatValid CHECK (alamat LIKE '%[a-zA-Z ]%')
);

CREATE TABLE Mitra_Pembeli (
    id_mitra INT IDENTITY(1,1) PRIMARY KEY,
    nama_mitra VARCHAR(100) NOT NULL,
    no_mitra VARCHAR(50) UNIQUE NOT NULL,
    kategori VARCHAR(10) CHECK (kategori IN ('Hotel', 'Resto', 'RM', 'UMKM')) NOT NULL,

	CONSTRAINT CHK_NamaMitra CHECK (nama_mitra NOT LIKE '%[^a-zA-Z ]%'),
	CONSTRAINT CHK_NoMitra CHECK (no_mitra LIKE '%[a-zA-Z]%')
);

CREATE TABLE Hasil_Panen (
    id_panen INT IDENTITY(1,1) PRIMARY KEY,
    id_petani INT NOT NULL,
    id_buah INT NOT NULL,
    tgl_panen DATE NOT NULL,
    stok_tersisa FLOAT NOT NULL,

    CONSTRAINT FK_Panen_Petani FOREIGN KEY (id_petani) REFERENCES Petani(id_petani),
    CONSTRAINT FK_Panen_Buah FOREIGN KEY (id_buah) REFERENCES Buah(id_buah),
    CONSTRAINT CHK_TglPanen CHECK (tgl_panen <= CAST(GETDATE() AS DATE)),
    CONSTRAINT CHK_StokPanen CHECK (stok_tersisa >= 0)
);

CREATE TABLE Distribusi (
    id_distribusi INT IDENTITY(1,1) PRIMARY KEY,
    id_panen INT NOT NULL,
    id_mitra INT NOT NULL,
    tgl_distribusi DATE NOT NULL,
    qty_kg FLOAT NOT NULL,

    CONSTRAINT FK_Distribusi_Panen FOREIGN KEY (id_panen) REFERENCES Hasil_Panen(id_panen),
    CONSTRAINT FK_Distribusi_Mitra FOREIGN KEY (id_mitra) REFERENCES Mitra_Pembeli(id_mitra),
	CONSTRAINT CHK_TglDistribusi CHECK (tgl_distribusi <= CAST(GETDATE() AS DATE)),
	CONSTRAINT CHK_Qty CHECK (qty_kg > 0)
);

INSERT INTO Admin (username, password) VALUES 
('admin', 'AdminTest123');

INSERT INTO Buah (nama_buah, jenis_buah, harga_per_kg) VALUES 
('Mangga Arum Manis', 'Lokal', 15000),
('Jeruk Bali', 'Lokal', 20000),
('Anggur Shine Muscat', 'Impor', 85000),
('Apel Fuji', 'Impor', 35000),
('Kurma Ajwa', 'Impor', 120000);

INSERT INTO Petani (nama_petani, alamat) VALUES 
('Pak Tono', 'Wates Kota, Kulon Progo'),
('Pak Paryono', 'Desa Banaran, Kulon Progo');

INSERT INTO Mitra_Pembeli (nama_mitra, no_mitra, kategori) VALUES 
('Hotel Abadi', 'MTR-001', 'Hotel'),
('Restoran Bumbu Desa Kita', 'MTR-002', 'Resto'),
('RM Padang', 'MTR-003', 'RM'),
('Keripik Buah', 'MTR-004', 'UMKM');

INSERT INTO Hasil_Panen (id_petani, id_buah, tgl_panen, stok_tersisa) VALUES 
(1, 1, '2023-01-18', 150.5),
(2, 4, '2023-03-12', 80.0);

INSERT INTO Distribusi (id_panen, id_mitra, tgl_distribusi, qty_kg) VALUES 
(1, 1, '2026-04-15', 20.5);

SELECT * FROM Distribusi;

-- 1. View untuk Form Petani
CREATE VIEW vw_Petani AS
SELECT id_petani AS 'ID', nama_petani AS 'Nama Petani', alamat AS 'Alamat' 
FROM Petani;
GO

-- 2. View untuk Form Mitra
CREATE VIEW vw_Mitra AS
SELECT id_mitra AS 'ID', nama_mitra AS 'Nama Mitra', no_mitra AS 'No. Mitra', kategori AS 'Kategori' 
FROM Mitra_Pembeli;
GO

-- 3. View untuk Form Buah (Master Buah yang baru)
CREATE VIEW vw_Buah AS
SELECT id_buah AS 'ID', nama_buah AS 'Nama Buah', jenis_buah AS 'Jenis', harga_per_kg AS 'Harga/Kg' 
FROM Buah;
GO

-- 4. View untuk Form Hasil Panen (Otomatis JOIN)
CREATE VIEW vw_Panen AS
SELECT hp.id_panen AS 'ID', p.nama_petani AS 'Nama Petani', b.nama_buah AS 'Nama Buah', 
       hp.tgl_panen AS 'Tanggal Panen', hp.stok_tersisa AS 'Stok (Kg)'
FROM Hasil_Panen hp
JOIN Petani p ON hp.id_petani = p.id_petani
JOIN Buah b ON hp.id_buah = b.id_buah;
GO

-- 5. View untuk Form Distribusi & Laporan (Otomatis JOIN)
CREATE VIEW vw_Distribusi AS
SELECT d.id_distribusi AS 'ID', d.tgl_distribusi AS 'Tanggal', p.nama_petani AS 'Asal Petani',
       b.nama_buah AS 'Jenis Buah', m.nama_mitra AS 'Tujuan Mitra', d.qty_kg AS 'Jumlah (Kg)'
FROM Distribusi d
JOIN Hasil_Panen hp ON d.id_panen = hp.id_panen
JOIN Petani p ON hp.id_petani = p.id_petani
JOIN Buah b ON hp.id_buah = b.id_buah
JOIN Mitra_Pembeli m ON d.id_mitra = m.id_mitra;
GO

-- 1. SP Insert Petani
CREATE PROCEDURE sp_InsertPetani
    @nama VARCHAR(100),
    @alamat VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Petani (nama_petani, alamat) VALUES (@nama, @alamat);
END
GO

-- 2. SP Update Petani
CREATE PROCEDURE sp_UpdatePetani
    @id INT,
    @nama VARCHAR(100),
    @alamat VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Petani SET nama_petani = @nama, alamat = @alamat WHERE id_petani = @id;
END
GO

-- 3. SP Delete Petani
CREATE PROCEDURE sp_DeletePetani
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Petani WHERE id_petani = @id;
END
GO

-- 4. SP Search Petani
CREATE PROCEDURE sp_SearchPetani
    @cari VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT * FROM vw_Petani WHERE [Nama Petani] LIKE '%' + @cari + '%';
END
GO

------- UCP 3 ------- 
USE ManajemenBuah;
GO

ALTER TABLE Buah 
ADD foto VARBINARY(MAX);
GO

-- 2. Stored Procedure Insert Buah
CREATE PROCEDURE sp_InsertBuah
    @nama VARCHAR(100),
    @jenis VARCHAR(20),
    @harga FLOAT,
    @foto VARBINARY(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Buah (nama_buah, jenis_buah, harga_per_kg, foto) 
    VALUES (@nama, @jenis, @harga, @foto);
END
GO

-- 3. Stored Procedure Update Buah
CREATE PROCEDURE sp_UpdateBuah
    @id INT,
    @nama VARCHAR(100),
    @jenis VARCHAR(20),
    @harga FLOAT,
    @foto VARBINARY(MAX)
AS
BEGIN
    SET NOCOUNT ON;
    UPDATE Buah 
    SET nama_buah = @nama, jenis_buah = @jenis, harga_per_kg = @harga, foto = @foto 
    WHERE id_buah = @id;
END
GO

-- 4. Stored Procedure Delete Buah
CREATE PROCEDURE sp_DeleteBuah
    @id INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Buah WHERE id_buah = @id;
END
GO

-- 5. TRIGGER: Otomatis kurangi stok panen saat ada transaksi distribusi
CREATE TRIGGER trg_KurangiStokPanen
ON Distribusi
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;
    -- Kurangi stok_tersisa di tabel Hasil_Panen berdasarkan qty_kg yang baru diinput di Distribusi
    UPDATE hp
    SET hp.stok_tersisa = hp.stok_tersisa - i.qty_kg
    FROM Hasil_Panen hp
    INNER JOIN inserted i ON hp.id_panen = i.id_panen;
END
GO