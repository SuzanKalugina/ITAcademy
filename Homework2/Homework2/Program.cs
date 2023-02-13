//task a
Console.WriteLine("Enter number sbyte type:");
sbyte a = Convert.ToSByte(Console.ReadLine());
Console.WriteLine(a);
Console.WriteLine("Enter number short type:");
short a2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(a2);
Console.WriteLine("Enter number int type:");
int a3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a3);
Console.WriteLine("Enter number long type:");
long a4 = long.Parse(Console.ReadLine());
Console.WriteLine(a4);
Console.WriteLine("Enter number byte type:");
byte a5 = Convert.ToByte(Console.ReadLine());
Console.WriteLine(a5);
Console.WriteLine("Enter number ushort type:");
ushort a6 = Convert.ToUInt16(Console.ReadLine());
Console.WriteLine(a6);
Console.WriteLine("Enter number char type:");
char a7 = Convert.ToChar(Console.ReadLine());
Console.WriteLine(a7);
Console.WriteLine("Enter number uint type:");
uint a8 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine(a8);
Console.WriteLine("Enter number ulong type:");
ulong a9 = Convert.ToUInt64(Console.ReadLine());
Console.WriteLine(a9);
Console.WriteLine("Enter number float type:");
float a10 = Convert.ToSingle(Console.ReadLine());
Console.WriteLine(a10);
Console.WriteLine("Enter number double type:");
double a11 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(a11);
Console.WriteLine("Enter number decimal type:");
decimal a12 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine(a12);
Console.WriteLine("Enter number bool type:");
bool a13 = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine(a13);
Console.WriteLine("Enter number char type:");
ushort a14 = Convert.ToUInt16(Console.ReadLine());
Console.WriteLine(a14);
Console.WriteLine("Enter number string type:");
string a15 = Console.ReadLine();
Console.WriteLine(a15);
Console.WriteLine("Enter number object type:");
object a16 = Console.ReadLine();
Console.WriteLine(a16);

//task b
//b1
byte b1 = 50;
int bb1 = b1;
Console.WriteLine(bb1);
byte bbb1 = (byte)(bb1 + 300);
Console.WriteLine(bbb1);

//b2
float b2 = 10.3f;
double bb2 = b2;
Console.WriteLine(bb2);
float bbb2 = (float)bb2;
Console.WriteLine(bbb2);

//b3
uint b3 = 15000000;
ulong bb3 = b3;
Console.WriteLine(bb3);
uint bbb3 = (uint)(bb3);
Console.WriteLine(bbb3);

//b4
ushort b4 = 50000;
short bb4 = (short)(b4);
Console.WriteLine(bb4);
ushort bbb4 = (ushort)(bb4);
Console.WriteLine(bbb4);

//b5
int b5 = 350000;
long bb5 = b5;
Console.WriteLine(bb5);
int bbb5 = (int)(bb5);
Console.WriteLine(bbb5);

//task c
int c1 = 500;
object cc1 = c1;
c1 = (int)cc1;
Console.WriteLine(c1);

sbyte c2 = 10;
object cc2 = c2;
c2 = (sbyte)cc2;
Console.WriteLine(c2);

short c3 = 100;
object cc3 = c3;
c3 = (short)cc3;
Console.WriteLine(c3);

ushort c4 = 200;
object cc4 = c4;
c4 = (ushort)cc4;
Console.WriteLine(c4);

uint c5 = 300;
object cc5 = c5;
c5 = (uint)cc5;
Console.WriteLine(c5);

long c6 = 400;
object cc6 = c6;
c6 = (short)cc6;
Console.WriteLine(c6);

ulong c7 = 500;
object cc7 = c7;
c7 = (ulong)cc7;
Console.WriteLine(c7);

float c8 = 600;
object cc8 = c8;
c8 = (float)cc8;
Console.WriteLine(c8);

double c9 = 700;
object cc9 = c9;
c9 = (double)cc9;
Console.WriteLine(c9);

char c10 = 'a';
object cc10 = c10;
c10 = (char)cc10;
Console.WriteLine(c10);

bool c11 = true;
object cc11 = c11;
c11 = (bool)cc11;
Console.WriteLine(c11);

decimal c12 = 123.3m;
object cc12 = c12;
c12 = (decimal)cc12;
Console.WriteLine(c12);

//task d
var count = 10;
var sum = count + 10;
Console.WriteLine(sum);

//task e
int? val = null;
Console.WriteLine(val);
int val1 = 0;
Console.WriteLine(val1);

//task f
var e = 10;        // 10 - int, поэтому e стало int, а в int уже нельзя присвоить нецелочисленный тип,
//e = 10.1;          // т.е. после этой строчки е подразумевается, как int, компилятор для е выбрал тип int

// task g

// extra task
var sm = 530;
var m = sm / 100;
Console.WriteLine(m);
var balabce = sm % 100;
Console.WriteLine(balabce);