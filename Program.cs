Console.WriteLine("<<  Assalomu alayukum SuperCalculator dasturiga hush kelibsiz  >>\n");
Console.WriteLine("Bizning dasturimizda 2 ta bo'lim mavjud: ");
Console.WriteLine("1. Oddiy bo'lim              2. Pro bo'lim");
Console.WriteLine("1) qo'shish (+)              1) darajaga");
Console.WriteLine("2) ayirish  (-)              2) kvadrat ildiz");
Console.WriteLine("3) ko'paytirish  (-)         3) logarifm");
Console.WriteLine("4) bo'lish  (-)              4) faktorial\n");
Console.Write("Bo'limni tanlang >> ");
Console.WriteLine();
int bolimTanla = int.Parse(Console.ReadLine());
if(bolimTanla == 1)
{
    Console.Write("birinchi son: a = ");
    double a = double.Parse(Console.ReadLine());
    
    Console.Write("amalni kiriting(+ , - , * , /): >> ");
    char amal = char.Parse(Console.ReadLine());
    Console.Write("ikkinchi son: b = ");
    double b = double.Parse(Console.ReadLine());
    if(amal == '+') Console.WriteLine($"{a} {amal} {b} = {a + b}");
    else if(amal == '-') Console.WriteLine($"{a} {amal} {b} = {a - b}");
    else if(amal == '*') Console.WriteLine($"{a} {amal} {b} = {a * b}");
    else if(amal == '/')
    {
        if(b == 0) Console.WriteLine("Sonni 0 ga bo'lsih mumkun emas");
        else Console.WriteLine($"{a} {amal} {b} = {a / b}");
    }
    else Console.WriteLine("Bunday amal majud emas!!!");
}
else if(bolimTanla == 2)
{
    Console.WriteLine("Pro bo'limimizga xush kelibsiz!!!\n");
    Console.WriteLine("Qanday amal bajaramiz..? \n1.Darajaga ko'tarish\n2.Kvadrat ildiz topish\n3.Logarifm hisoblash\n4.Faktorial hisoblash\n");
    Console.Write(">>> ");
    int amal = int.Parse(Console.ReadLine());
    if(amal == 1)
    {
        Console.Write("LET'S GO!!! a ning b darajasini hisoblaymiz \n");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"{a}^{b} = {Math.Pow(a , b)}");
    }
    
}
