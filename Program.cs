Console.WriteLine("");

byte b = 5;      //1 byte deger kaplar
sbyte c= 5;      //1 byte deger kaplar

short s = 5;     //2 byte deger kaplar
ushort us = 5;   //2 byte deger kaplar

Int16 i16 = 2;   //2 byte deger kaplar
int i = 2;       //4 byte deger kaplar
Int32 i32 = 2;   //4 byte deger kaplar
Int64 i64 = 2;   //8 byte deger kaplar
 
uint ui = 2;     //4 byte deger kaplar
long l = 4;      //8 byte deger kaplar
ulong ul = 4;    //8 byte deger kaplar

//reel sayılar için kullanılır
float f = 5;     //4 byte deger kaplar
double d = 5;    //8 byte deger kaplar
decimal de = 5;  //16 byte deger kaplar

char ch = '2';   //2 byte deger kaplar
string str = "onur";  //sınırsız yer kaplar

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;

Console.WriteLine(dt);

object o1 = "x";
object o2 = 'y';
object o3 = 4; 
object o4 = 4.3;

//string ifadeler

string strl = string.Empty;
strl = "Onur Avan";
string ad  = "Onur";
string soyad = "Avan";
string tamisim = ad + " " + soyad;

//integer tanımlama şekilleri

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 * integer2;


// boolen 

bool bool1 = 10>2;


// Degişken Dönüşümleri

string str20 = "20";
int int20 = 20;
string yeniDeger = str20 + int20.ToString();
Console.WriteLine(yeniDeger); // Çıktısı 2020

int int21 = int20 + Convert.ToInt32(str20);
Console.WriteLine(int21); // Çıktısı 40

int int22 = int20 + int.Parse(str20); // Çıktısı 40

// datetime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datettime2 = DateTime.Now.ToString("dd-MM-yyyy");
Console.WriteLine(datettime2);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);



