# BELAJAR.DOTNET.EF
 
## PENGENALAN ENTITY FRAMEWORK 

### Apa itu Entity Framework?
EF adalah framework open source ORM untuk .Net apps yang memungkinan programmer berkerja dengan relational data menggunakan domain-specific object tanpa harus fokus ke table dan kolom dimana data itu di simpan.
EF mengurangin code yang biasanya di tulis oleh programmer untuk akses database.

### Apa itu ORM?
ORM adalah Object Relational Mapping (ORM) Framework yang secara otomatis akan meng-generate class berdasarkan table pada database atau sebalik nya.

### Contoh Kasus
Untuk menampilkan data, misal menampilkan data Department dan Employee, kita harus:
1. membuat class Department dan Employee
2. kita harus menulis code ADO.NET untuk memanggil dan menampilkan data dari database.
3. setelah data di panggil, kita harus membuat object Department dan Emplyee lalu mengisi object2 tersebut dengan data yang sudah di panggil.

Tetapi, EF dapat melakukan itu semua dengan otomatis.

### Feature-Feature EF
1. Cross Platform : bisa jalan di windows, linux atau mac os.
2. Modeling : EF mambuat EDM berdasarkan POCO entities dengan property get/set dari berbagai tipe data, ini juga di gunakan utuk melakukan query atau simpan data ke database.
3. Querying : dengan EF kita dapat menggunakan LINQ queries untuk mengambil data dari DB. 
4. Change Tracking: EF dapat melacak perubahan yg terjadi pada entitas kami yang perlu dikirimkan ke DB.
5. Saving : EF menjalankan perintah INSERT, UPDATE and DELETE ke database.
6. Concurrency : EF mengoptimalkan konkurensi secara default untuk menghindari duplikasi data yang di buat oleh user lain.
7. Transactions : EF melakukan otomatisasi transaction management saat query insert data.
8. Caching : EF sudah include first level of caching, sehingga saat pengulangan query akan mengembalikan data dari cache.
9. Built-in Conventions : 
10. Configurations : EF allows us to configure the EF model by using data annotation attributes or Fluent API to override default conventions.

## ARSITEKTUR EF

### Arsitektur EF
Arsitektur EF itu terdiri dari komponen2 di bawah ini:
1. EDM (Entity Data Model)
EDM adalah mengabstraksi logic dan relational.
2. LINQ to Entities
3. Entity SQL
4. Object Service Layer
5. Entity Client Data Provider
6. ADO.NET Data Provider

## EF CONTEXT CLASS

### Apa itu Context Class di EF?
Class utama yang bertugas untuk melakukan interaksi antara data dengan object adalah System.Data.Entity.DbContext.

### Apa itu entity di EF?
Sebuah class yang di masukan sebagai tipe properti DbSet<TEntity> di class context.
EF me-mapping masing-masing entity ke masing table di database beserta relasi-relasi nya.

Di dalam entity ada:
- Scalar property : nama nama column untuk menghubungkan dengan column2 yang ada di table pada database.
- Navigation property: relasi dari table tersebut ke table lain

Ada dua tipe entity di EF.
- POCO Entities
- Dynamic Proxy Entities

### Entity States
EF membuat status untuk masing-masing entity selama entity itu di pakai dan digunakan menggunakan context class.
Added: The entity is marked as added.
Deleted: The entity is marked as deleted.
Modified: The entity has been modified.
Unchanged: The entity hasn’t been modified
Detached: The entity isn’t tracked.

## DATABASE FIRST APPROACH

### Pengenalan DB First 
- coding

### Eager Loading
Eager Loading adalah sebuah proses dimana EF memuat entity-entity yang berhubungan dengan entity utama.
Sehingga kita tidak perlu membuat query baru lagi untuk entity-entity yang berhubungan dengan entity utama.

### Lazy Loading
Lazy loading adalah sifat default dari EF, yaitu menampilkan entity child atau related entity ketika entity tersebut di tentukan/di panggil.
Lazy loading bisa di non aktifkan dengan beberapa cara.