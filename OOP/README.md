# OBJECT ORIENTED di C SHARP

## Masalah-masalah yang ada pada Functional Programming
- Tidak Reusability
	* Di functional programming, kita menulis code atau logic yang sama di banyak tempat, sehingga kemungkinan redudant code sangat mungkin terjadi.
- Tidak Extensbility.
	* Extensiblity sulit di lakukan, contoh ketika memiliki sebuah function dan ingin memodifikasi function tersebut, itu tidak bisa di lakukan
	* Kita harus membuat function baru untuk menambahkan feature yang ingin kita tambahkan.
- Tidak Simplicity.
	* Karena tidak mendukung Reusability dan Extensbility, maka kita akan memiliki begitu banyak function dan code yang tersebar.
- Tidak Maintenability.
	* Karena tidak Reusbality, Extensibiity dan Simplicity, maka akan sulit untuk di lakukan maintenance.

Bagiaman kita mengatasi masalah-masalah yang ada pada functional programming, yaitu dengan menggunakan konsep OOP.

## Apa itu OOP?
- OOP adalah sebuah design yang pendekatannya adalah lebih ke object dunia nyata dibanding function atau method.
- Tidak seperti functional progamming, di OOP sebuah program lebih di atur oleh object dan data di banding action atau logic.

OOP mendukung konsep di bawah ini:
- Reusability
	* Untuk mendukung reusability, OOP menyediakan class dan objects.
	* Dengan class dan object, kita tidak perlu lagi melakukan copy paste code yang sama di banyak tempat, hanya perlu membuat sebuah class dan membuat object untuk menggunakan code di dalam class secara ber ulang.
- Extensibility
	* Misalkan kita punya sebuah function dan ingin menambahkan beberapa fitur baru di function tersebut, maka itu tidak bisa dilakukan di functional programming. Kita harus membuat function baru.
	* Di OOP, masalah tersebut dapat di atas dengan menggunakan Inheritance, Aggregation dan Composition.
- Simplicity
	* Di OOP, simplicity dapat di lakukan dengan menggunakan konsep Abstraction, Encapsulation dan Polymorphism.
- Maintainability
	* Maintanability pada OOP dapat dilakukan karena OOP mampu menyediakan Reusability, Extensibility dan Simplicity.

## Prinsip OOP di C SHARP
- Empat prinsip dasar OOP adalah abstraction, encapsulation, polymorphism dan inheritance.

### Abstraction dan Encapsulation
#### Apa itu Abstraction dan Encapsulation?
- Abstraction adalah hanya menampilkan fiture utama tanpa detail yang ada di belakangan nya di sebut abstraction.
- Abstaraction adalah, membuat sebuah class dengan memberikan kebutuhan-kebutuhan yang di perlukan untuk menggunakan member-member yang ada di dalam nya.
- Encapsulation adalah, proses pemanggilan data dan function secara bersamaan.
- Encapsulation juga bisa dibilang, membuat sebuah class dengan menyembuntikan internal data member nya dari luar class, sehingga untuk mengakses data member ini hanya melalui public method atau property.
- Data Encapsulation juga disebut data hiding, karena secara prinsip adalah menghindari akses data secara langsung dari luar class.

### Inheritance
- Inheritance adalah member-member yang ada di sebuah class di transfer ke class lain sehingga class lain dapat menggunakan member tersebut.
- Juga sering disebut pewarisan.
- Class yang mentransfer member nya disebut Parent class, sedangkan class yang menggunakan member dari class lain disebut child class.
- Dengan ini maka dapat mendukung extensibility.

### Polymorphism
- Secara bahasa, polymorphsim artinya banyak bentuk.
- Ada dua tipe polymorphism.
	1) Static polymorphism/compile-time polymorphism /early binding (using function overloading and operator overloading)
	2) Dynamic polymorphism / Run time polymorphism / Late binding (using function overriding)

# CLASS DAN OBJECT
>> SKIP : class dan object di skip dulu nyak

# CONSTRUCTOR
## Apa itu Constructor?
- Constructor adalah tipe method yang spesial dari sebuah class yang secara otomatis di jalankan ketika kita membuat sebuah object dari class tersebut.
- Constructor memiliki dua tanggung jawab, pertama inisilasisasi object dan kedua memory allocation. 
- Keyword "new" digunakan untuk membuat object.

## Aturan-aturan Pembuatan Constructor
- Nama constructor harus sama dengan nama class
- Tidak memiliki return type meskipun void also
- Seharusnya tidak memiliki modifier

## Berapa Jenis Tipe Constructor yang ada di C# ?
- Default Constructor
- Parameterized Constructor
- Copy Constructor
- Static Constructor
- Private Constructor

## Default Constructor
- Default Constructor di bagi menjadi dua, yaitu system-defined dan user-defined default constructor.

### System-Defined Default Constructor
- System-defined default constructor adalah ketika kita tidak membuat constructor secara explisit pada sebuah class, maka secara default system akan menyediakan satu constructor saat compilation.
- Default constructor akan meng- assign default values ke data members(non static)

>> SKIP : skip dulu sisaan constructo rnya

# DESTRUCTOR
>> SKIP : skip dulu 

# ACCESS SPESIFIERS
>> SKIP : skip dulu 

# ENCAPSULATION
## Encapsulation Adalah?
- Sebuah proses pemanggilan data dan method secara bersamaan ke dalam satu unit/class disebut ecanpsulation.
- Encapsulation juga bisa di bilang sebagai pembuatan sebuah class yang menyembunyikan internal data member nya agar tidak bisa di akses dari luar class secara langsung, tetapi hanya bisa di akses melalui public method atau setter getter(properties) dengan validasi yang baik.

## Cara Implementasi Encapsulation
- Cara implementasi encapsulation di C#
	1. deklarasi variable sebagai private(untuk mencegah di akses secara langsung dari luar class)
	2. membuat sepasang method getter setter atau properties untuk mengakses variable private
- Kita mendeklarasi variable sebagai private agar tidak bisa di akses secara langsung dari luar class, dan membuat properties untuk mengakses variable tersebut dari class dengan validation yang valid.
- Jika kita menyediakan variable yang bisa di akses langsung dari luar class, maka kita tidak bisa membuat validation untuk data yang akan di store ke variable.

>> SKIP : skip dulu contoh2 nya, yang penting udah dapet gambarannya

# ABSTRACTION
- Abstraction adalah lawan dari Encapsulation, yaitu menampilkan member yang hanya di butuhkan saja.

>> SKIP: skip dulu, inti nya abstraction itu lawan nya encapsulation.

# INTERFACE VS ABSTRACT CLASS

- Abstract Class	: sebuah class yang hanya sebagian saja di implementasi, sehingga bisa membuat method yang konkrit dan method abstract
- Interface 		: sebuah class yang seluruh nya blm di implementasi, sehingga hanya bisa membuat abstract method

- Abstract Class	: menggunakan keyword abstract untuk membuat class dan method di dalam nya
- Interface 		: menggunakan keyword intrface untuk membuat class, dan secara optional menggunakan keyword abstract untuk method, secara default method di interface akan menjadi abstract method saat di compile

- Abstract Class	: sebuah class yang hanya sebagian saja di implementasi, sehingga bisa membuat method yang konkrit dan method abstract
- Interface 		: sebuah class yang seluruh nya blm di implementasi, sehingga hanya bisa membuat abstract method

- Abstract Class	: bisa deklarasi data fields
- Interface 		: tidak bisa deklarasi data fields

# INTERFACE
## Kenapa Kita Butuh Interface?
- .Net tidak bisa melakukan multiple inheritance menggunakan class, tapi bisa menggunakan interface.

## Apa Itu Interface?
- Interface adalah sebuah class yang semua member di dalam nya belum di implement.
- Interface juga bisa di katakan sebagai sebuah abstract class yang murni karena hanya bisa membuat abstract method di dalam interface.
- Abstract method adalah sebuah method yang di implement body nya, alias kosong.

## Kenapa Masih Butuh Interface Sedangkan Ada Abstract Class Untuk Menampung Abstract Method?
- Karena .Net tidak mendukung multiple inheritance menggunakan class sehingga kita harus menggunakan interface sebagai superclass untuk membuat multiple inheritance.