# Sistem Informasi Manajemen Distribusi Buah 🍎🚛

---

## 🛡️ Fitur Keamanan (Fokus UCP 2)
Aplikasi ini telah menerapkan standar keamanan database sesuai dengan modul praktikum:

1. **Implementasi VIEW:** Semua proses pembacaan data (`SELECT`) pada setiap form menggunakan VIEW untuk menyembunyikan struktur asli tabel dari *frontend*.
2. **Implementasi Stored Procedure:** Proses manipulasi data (`INSERT`, `UPDATE`, `DELETE`) difilter menggunakan Stored Procedure berparameter untuk mencegah kebocoran data.
3. **Data Binding & Sinkronisasi:** Menggunakan `BindingSource` dan `BindingNavigator` untuk menjaga integritas data antara UI dan database.
4. **Skenario Uji SQL Injection:** Terdapat satu fitur khusus pada **Form Petani** (tombol *Test SQL Injection*) yang sengaja dibuat rentan untuk mendemonstrasikan serangan tipe *Tautology* menggunakan payload `' OR 1=1 --`.

---

## 📦 Fitur Aplikasi
* **Master Data:** Kelola data Petani, Mitra Pembeli, dan jenis Buah.
* **Input Panen:** Pencatatan hasil panen dan manajemen stok.
* **Distribusi:** Pencatatan transaksi pengiriman buah (stok panen terpotong otomatis).
* **Laporan:** Rekapitulasi transaksi, cetak invoice, dan riwayat distribusi.

---

## 🚀 Cara Menjalankan Aplikasi
1. Buka SQL Server Management Studio (SSMS).
2. Buat database baru bernama `ManajemenBuah`.
3. Jalankan *script* SQL yang mencakup pembuatan Tabel, View, dan Stored Procedure.
4. Buka file `.sln` menggunakan Visual Studio.
5. Sesuaikan `connectionString` pada setiap form dengan nama server lokal Anda.
6. Tekan **Start** (F5) untuk menjalankan aplikasi.