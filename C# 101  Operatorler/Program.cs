


int a = 7;
int b = 8;

//atama işlemi

a++;
b--;

a*=a;
b+=b;

//mantık
bool b1=true;
bool b2=false;
if(b1&&b2)
    Console.WriteLine("iki koşulda sağlandı");
if(b1||b2)
    Console.WriteLine("iki koşuldan biri sağlandı");
//ilişki

if(a>b)
    Console.WriteLine("a b den büyük");
if(b*b>a)
    Console.WriteLine("b'nin karesi a dan büyük");

// matematik
int sayi1= 10 ;
int sayi2 = 11;
int toplam= sayi1+sayi2;

Console.WriteLine("toplam :" + toplam);