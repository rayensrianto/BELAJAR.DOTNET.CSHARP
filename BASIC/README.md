# DATA TYPES

## Kenapa kita butuh DATA TYPES ?
Datatypes di c# pada dasar nya digunakan untuk menyimpan temporary data ke komputer melalui program.
Di dunia nyata kita membutuhkan berbagai macam tipe data seperti integer, floating-point, string dsbg.
Untuk menyimpan tipe data yang beragam tersebut ke sebuah program kita membutuhkan datatypes.

## Apa yang dimaksud dengan DATA TYPES di C#?
DATATYPES adalah sesuatu yang memberikan informasi tentang:
    1. size of the memory 
    2. range data yang bisa di simpan  ke memory
    3. menentuan operator apa saja yang bisa digunakan 
    4. types of results

## Jenis-jenis Datatypes yang tersedia di C#
Ada 3 jenis datatypes di C#
    1. Value Data Type
        * Predefined Data Types
            - Integer, Boolean, Float
        * User Defined Data Types
            - Enumerations, Structures
            
    2. Reference Data Type
        * Predefined Data Types
            - Objects, Strings
        * User Defined Data Types
            - Classes, Interfaces
    
    3. Pointer Data Type

### Apa itu value data type ?
Datatypes yang menyimpan value nya secara langsung disebut Value Data Type.
Mereka di turunkan dari System.ValueType. Contoh nya adalah: int, char, float.

### Apa itu reference data type ?
Datatypes yang digunakan untuk menyimpan reference dari sebuah variable disebut reference data type.
Dengan kata lain, tipe ini tidak menyimpan data yang sesungguhnya ke variable, tetapi menyimpan reference nya ke variable.
Kita akan bahas konsep ini lebih lanjut di article lain.

### Apa itu pointer data type ?
Pointer pada C# adalah variable, atau juga bisa disebut lokasi/indikator yang menunjuk ke alamat dari sebuah value.
Kita akan bahas konsep ini lebih lanjut di article lain.

### Datatypes bawaan dari C#.
    1. Boolean type - true atau false
    2. Integral types - sbyte, byte, short, ushort, int, uint, long, ulong, char
    3. Floating Types – float and double
    4. Decimal Types
    5. String Type 

<hr>

# STRING LEBIH DALAM DI C#
Memahami String lebih dalam pada C# sangat penting, karena kita pasti menggunakan string di semua project yang kita akan buat.

## String adalah reference type di C#
C# Strings adalah object, bukan data types yang normal. Contoh jika mendefinisikan variable menggunakan int atau double seperti dibawah ini:
````csharp
int i = 10;
double d = 0.24;
````
Maka, ketika kita go to definition pada data type di atas, maka kita akan melihat bahwa mereka adalah stuct.
Dan struct berarti value data type.
````csharp
public struct Double : IComparable, IFormattable, IConvertible, IComparable<Double>, IEquatable<Double>
````
Beda halnya dengan String, misal kita mendefinisikan sebuah string seperti dibawah ini.
````csharp
string str = "";
````
Maka, ketika kita go to definition pada data type di atas, maka kita akan melihat bahwa mereka adalah sebuah class.
Class berarti reference data type

Jadi point pertama yang harus di ingat adalah, bahwa strings adalah reference data types sedang tipe data primitive lainya adalah ber tipe struct.

## String VS string
Sebenarnya, string adalah sebuah nama alias dari String. Jadi tidak ada beda nya, sama-sama mengarah ke class yang sama jika kita menggunakan fitur go to definition. (public sealed class String)
Tetapi, sesuai dengan convetion name, maka string digunakan untuk membuat variable, tapi jika ingin memanggil method yang ada di string maka gunakan String.
````csharp
string str = String.Concat("");
````

## String itu immutable.
Mutable adalah bisa berubah, sedangkan immutable adalah tidak bisa berubah.
C# String adalah imutable.
Perhatikan code dibawah ini:
````csharp
string str = "Ryan Ganteng"; //membuat sebuah object string dengan value Ryan Ganteng
str = "Ryan Keren"; //membuat sebuah object baru string dengan value Ryan Keren
````
Pada code di atas, saat statement pertama di execute, maka akan membuat satu object yang value nya Ryan Ganteng.
Tapi ketika statement kedua di execute, maka tidak akan menghilangkan object yang pertama sudah terbuat.
Object pertama tetap ada dan untuk garbage collection lalu membuat object baru dengan value Ryan Keren.

Jadi, ketika kedua statement tersebut di execute, maka akan membuat dua memory location.
Satu bernilai Ryan Ganteng, dan yang terakhir bernilai Ryan Keren dan menjadi reference nya.
Jadi setiap kita meng-assign value baru di sebuah string, kita membuat object baru, maka dari kenapa string itu immutable.


# STATIC DAN NON-STATIC MEMBERS DI C#

## Apa itu static dan non-static members di C#?
Di dalam sebuah class terdapat member, yaitu method dan variable.
Member dari sebuah class di bagi menjadi dua kategori.
    1. Static members : member class yang TIDAK membutuhkan sebuah instance untuk initialization or execution
    2. Non-static members : member class yang membutuhkan sebuah instance untuk initialization or execution

## Static dan Non-Static variable di C#
Setiap kita membuat variable dengan modifier static atau membuat variable di dalam sebuah function/class yang modifier nya static maka variable tersebut di namakan static variable, selain dari itu di sebut non-static variable.

Jika kita ingin sebuah variable yang nilai nya selalu sama meskipun class tersebut diinisialisasi berkali-kali maka kita bisa mendeklarasikan static variable.

Static variable diinisialisasi segera mungkin dan hanya sekali ketika class tersebut di eksekusi, sedang kan non static variable diinisialisasi berkali kali tergantung berapa kali class tersebut diinisialisasi (dibuat objectnya)

Untuk mengakses static members dari sebuah class kita hanya butuh memanggil nama class nya sedang kan untuk mengakses non static members pada sebuah class kita harus membuat object.

Contoh: Static_NonStatic.cs

## Scope dari non-static variable.
Non-static variable terbuat ketika object nya terbuat, dan akan destroyed juga jika object nya destroyed.
Object akan ter-destroyed jika reference variable nya destroyed atau ter inisianilasisi dengan null.
Jadi scope sebuah object sama dengan scope sebuah non-static variable.

## Static dan Non-Static method di C#
Static method adalah method yang memiliki modifier static, selain itu disebut non-static method.
Kita tidak bisa memanggil non-static members secara langsung ke dalam static method, untuk melakukan itu kita membutuhkan object, dan melalui object tersebut kita bisa memanggil non-static members ke dalam static method.
Dengan kata lain, kita bisa memanggil static members secara langsung ke dalam static method tanpa batasan apapun.

## Aturan-aturan static dan non-static members
1. Non Static -> Static : bisa di consumed menggunakan object
2. Static -> Static : bisa digunakan secara langsung menggunakan nama class
3. Static -> Non Static : bisa digunakan secara langsung menggunakan nama class
4. Non static -> Non Static : bisa digunakan secara langsung menggunakan keyword "this"

Contoh: Static_NonStatic_2.cs

## Mengerti Static dan Non-Static Constructor.
Static Constructor adalah custructor yang memiliki modifier static, selain itu disebut non-static constructor.
Yang paling penting untuk di ingat adalah static construtor meruapakan bagian yang paling cepat di execute di sebuah class, dan hanya sekali di execute meskipun class tersebut di buat object nya berulang kali.
Dengan kata lain, non-static constructor hanya di execute jika object telah di buat dan akan berulang kali di execute tergantung berapa kali object nya terbuat.

Static Constructor tidak bisa disisipkan parameter karena static constructor merupakan block code pertama yang di execute, sehingga tidak ada peluang untuk mengirim nilai ke parameter static constructor.

Contoh: Static_Constructor.cs

## Mengerti Static dan Non-Static Class.
Static class adalah class yang memiliki modifier static, selain itu disebut non-static class.
Static class hanya bisa memiliki static members.
Static class tidak mungkin bisa dibikin objectnya, karena hanya memiliki member static, sementara untuk mengakses static member kita tidak memerlukan object.

<hr>

# CONST & READ ONLY
Constans adalah immutable values yang di ketahui saat waktu kompilasi dan value nya tidak akan pernah berubah sepanjang program berjalan.
Read only adalah juga immutable values tetapi di ketahui saat proses runtime dan juga tidak akan pernah berubah sepanjang program berjalan.
Dengan pengertian di atas, mari kita bahas lebih lanjut dengan contoh.

## Const Variable
    1. Keyword "const" digunakan untuk membuat constant variable, artinya value pada variable ini tidak akan pernah berubah.
    2. Secara default constant ber tipe static
    3. Variable constant langsung ter-inisialisasi saat deklarasi nya.
    4. Perlakuan constant variable sama dengan static variable, yaitu di execute pertama kali saat class di jalan kan dan hanya sekali. (tidak membutuhkan object dan tidak tergantung berapa kali object terbuat)
    5. Perbedaan static variable dengan constant adalah static variable masih bisa di modified value nya.
Contoh: Constant_Variable.cs

## Read Only Variable
    1. Readonly variable di deklarasi dengan keyword "readonly"
    2. Tidak langsung di inisialisasi saat deklarasi seperti constant, kita bisa insialisasi dengan constructor, tetapi setelah di inisialisasi value tidak bisa di modified
    3. Perilaku readonly mirip dengan non-static variable, di execute berkali-kali tergantung berapa kali object di buat. 
    4. Perbedaan readonly dengan non-static variable adalah non-static masih di modified valuenya.
    5. Constant variable adalah fixed value dari sebuah class, sedangkan readonly adalah fix value untuk sebuah object.
Contoh: Readonly_Variable.cs

Misalkan kita punya class lain dimana memiliki readonly yang di assign dengan value yang berbeda tergantung kondisi nya.
Kita bisa lakukan itu karna readonly di ketahui saat proses runtime.
Contoh: Readonly_Variable_2.cs

Berikut contoh code untuk memahami Const, Readonly, Static dan Non-static variable dengan satu contoh.

# PROPERTIES

## Kenapa Kita Butuh Properties ?
Sebelum memahami Properties, kita harus mengerti basic dari enkapsulasi.
Enkapsulasi adalah konsep pengamanan data yang dapat dilakukan dengan:
    1. mendeklarasikan variable sebagai private
    2. menyediakan method public yaitu method get dan method set melalui properties untuk bisa mengakses value pada private variable tersebut.

Pada enkapsulasi dan proteksi data member(fields), kita menggunakan properties. 
Properties di gunakan untuk mekanisme set dan get values

## Apa itu Properties?
Properties adalah member class yang digunakan untuk melakukan set and get data dari field pada class tersebut.
Hal penting yang harus di ingat adalah, properties tidak pernah digunakan untuk store data, tapi hanya sebagai interface untuk transfer data.
Kita menggunakan properties sebagai data member yang public, padahal sebenernya properties adalah special method yang disebut accessor.

Ada dua jenis accessor.
    1. Set Accessor
        digunakan untuk menge-set data ke data field, berisi sebuah fixed variable bernama "value", setiap kita memanggil properti untuk melakukan set data, data akan di simpan ke variable "value"
        syntax: set { Data_Field_Name = value; }
    2. Get Accessor
        digunakan untuk mengambil data dari data field, accessor ini tidak bisa digunakan untuk set data.
        syntax: get { return Data_Field_Name }

## Tipe-tipe Properties di C#
Di C# ada 4 jenis properties:
    1. Read-only properties
    2. Write-only properteis
    3. Read Write properties
    4. Auto-implemented properties.

### Read-only
Digunakan untuk membaca data dari data field.
Kita tidak bisa melakukan set data dengan property ini.
Di read-only hanya ada get accessor
Syntax: AccessModifier DataType PropertyName { get { return DataFieldName; }}

### Write-only
Kebalikan dari read only, disini kita hanya bisa melakukan set data dan tidak bisa membaca data.
Hanya ada set accessor
Syntax: AccessModifier DataType PropertyName { set { DataFieldName = value; }}

### Read-write
Di sini kita bisa membaca dan mengatur data dari data field menggunakan set dan get accessor.
Syntax:
```csharp
AccessModifier DataType PropertyName
{
    set { DataFieldName = value; }
    get { Return DataFieldName; }
}
```
Note: Setiap kita membuat property, tipe data property harus sama dengan tipe data pada data field/member nya. Property tidak pernah bisa menerima argument apapun.

Contoh code: Read_Write_Property.cs
Pada contoh code di atas, kita memiliki class yang berisi field private sehingga kita tidak bisa mengakses field tersebut dari luar class.
Tapi kita masih bisa mengakses field tersebut dengan menggunakan property.

### Auto-Implemented Properties di C#
Jika kita tidak memiliki logic/validasi saat melakukan set and get data dari data field maka kita bisa menggunakan auto-implemented property yang dikenalkan pada C# 3.0.
Auto-implemented mengurangi code yang harus kita tulis, saat kita menggunakan nya, C# compiler secara implisit membuat private, anonymous field di belakang layar yang digunakan untuk menampung data.
Contoh Code: Auto_implemented_property.cs

## Kenapa Kita Butuh Property Pada Aplikasi ?
Tanpa property, kita harus menggunakan data member public agar bisa di akses dari luar class secara langsung.
Dan mengakses data member secara langsung dari luar class adalah hal yang buruk, karena kita tidak bisa mengkontrol data seperti apa yang akan dikirim dan diterima.
Dengan property, kita bisa menggunakan data member yang private dan tetap bisa di akses dari luar class, plus kita juga bisa membuat validasi untuk data member tersebut.


