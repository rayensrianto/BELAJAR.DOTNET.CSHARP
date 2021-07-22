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

