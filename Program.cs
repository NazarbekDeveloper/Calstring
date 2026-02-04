using Microsoft.VisualBasic.FileIO;

Console.WriteLine("<<  Assalomu alayukum SuperCalculator dasturiga hush kelibsiz  >>\n");
int qaytaIshlat;
do
{
    Console.WriteLine("Bizning dasturimizda 2 ta bo'lim mavjud: ");
    Console.WriteLine("1. Oddiy bo'lim              2. Pro bo'lim");
    Console.WriteLine("1) qo'shish (+)              1) darajaga");
    Console.WriteLine("2) ayirish  (-)              2) kvadrat ildiz");
    Console.WriteLine("3) ko'paytirish  (*)         3) logarifm");
    Console.WriteLine("4) bo'lish  (/)              4) faktorial\n");
    Console.Write("Bo'limni tanlang >> ");
    int bolimTanla = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (bolimTanla == 1)
    {
        OddiyAmallarBajar();
    }
    else if (bolimTanla == 2)
    {
        Console.WriteLine("Pro bo'limimizga xush kelibsiz!!!\n");
        Console.WriteLine("Qanday amal bajaramiz..? \n1.Darajaga ko'tarish\n2.Kvadrat ildiz topish\n3.Logarifm hisoblash\n4.Faktorial hisoblash\n");
        Console.Write(">>> ");
        int amal = int.Parse(Console.ReadLine());
        if (amal == 1)
        {
            DarajagaKotar();
        }
        else if (amal == 2)
        {
            IldizTop();
        }
        else if (amal == 3)
        {
            LogarifmHisobla();
        }
        else if (amal == 4)
        {
            FaktorialHisobla();
        }
        else Console.WriteLine("Bunday amal xattoki PRO Max calculyatorda ham yo'qku bratim...!!!");
    }
    else
    {
        System.Console.WriteLine("Bunaqa bo'lim yo'de oka. Keyingi safar qo'shib qo'yamiza..!!!");
    }
    Console.WriteLine("Qaytadan bosvorovuzami oka?(1.ha 0.yo'q)");
    qaytaIshlat = int.Parse(Console.ReadLine());
} while (qaytaIshlat == 1);
Console.WriteLine("SuperCalculyator dasturidan foydalanganiz uchun Thank You Bro...!!!");

static void OddiyAmallarBajar()
{
    Console.Write("birinchi son: a = ");
    double a = double.Parse(Console.ReadLine());

    Console.Write("amalni kiriting(+ , - , * , /): >> ");
    char amal = char.Parse(Console.ReadLine());
    Console.Write("ikkinchi son: b = ");
    double b = double.Parse(Console.ReadLine());
    if (amal == '+') Console.WriteLine($"{a} {amal} {b} = {a + b}");
    else if (amal == '-') Console.WriteLine($"{a} {amal} {b} = {a - b}");
    else if (amal == '*') Console.WriteLine($"{a} {amal} {b} = {a * b}");
    else if (amal == '/')
    {
        if (b == 0) Console.WriteLine("Sonni 0 ga bo'lsih mumkun emas");
        else Console.WriteLine($"{a} {amal} {b} = {a / b}");
    }
    else Console.WriteLine("Bunday amal majud emas!!!");
}
static void DarajagaKotar()
{
    Console.Write("LET'S GO!!! a ning b darajasini hisoblaymiz \n");
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine($"{a}^{b} = {Math.Pow(a, b)}");
}
static void IldizTop()
{
    Console.Write("LET'S GO!!! a ning kvadrat ildizini topamiz\n");
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());
    if (a < 0) Console.WriteLine("Manfiy sonning kvadrat ildizini topish mumkun emas!!!");
    Console.WriteLine($"{a} ning kvadrat ildizi {Math.Sqrt(a)} ga teng");
}
static void LogarifmHisobla()
{
    Console.Write("LET'S GO!!! Logarif a asosga ko'ra b ni hisoblaymiz \n");
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());
    if (a > 0 && a != 1 && b > 0) Console.WriteLine($"log {a} asosga ko'ra {b} ning natijasi {Math.Log(b) / Math.Log(a)} ga teng");
    else Console.WriteLine("Siz xato son kiritdingiz!!!\na va b nomanfiy sonlar va (a != 1) bo'lishi kerak");
}
static void FaktorialHisobla()
{
    Console.Write("Qaysi sonning faktorialini hisoblaymiz..?\n a = ");
    double a = double.Parse(Console.ReadLine());
    double P = 1;
    if (a < 0) Console.Write("Manfiy sonning faktorialini hisoblash mumkun emas!!!");
    else
    {
        if (a == 0) Console.WriteLine("0! = 1");
        else
        {
            for (int i = 1; i <= a; i++)
            {
                P *= i;
            }
            Console.WriteLine($"{a}! = {P}");
        }

    }
}