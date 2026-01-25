Console.WriteLine("<<  Assalomu alayukum SuperCalculator dasturiga hush kelibsiz  >>");
Console.WriteLine("Bizning dasturimizda 2 ta bo'lim mavjud: ");
Console.WriteLine("1. Oddiy bo'lim              2. Pro bo'lim");
Console.WriteLine("1) qo'shish (+)              1) darajaga");
Console.WriteLine("2) ayirish  (-)              2) kvadtar ildiz");
Console.WriteLine("3) ko'paytirish  (-)         3) logarifm");
Console.WriteLine("4) bo'lish  (-)              4) faktorial");
Console.Write("Bo'limni tanlang >> ");
int bolimTanla = int.Parse(Console.ReadLine());
if(bolimTanla == 1)
{
    Console.Write("a = ");
    double a = double.Parse(Console.ReadLine());
    
    Console.Write("amalni kiriting(= , - , * , /): >> ");
    char amal = char.Parse(Console.ReadLine());
    Console.Write("b = ");
    double b = double.Parse(Console.ReadLine());
    if(amal == '+') Console.WriteLine($"{a} {amal} {b} = {a + b}");
    else if(amal == '-') Console.WriteLine($"{a} {amal} {b} = {a - b}");
    else if(amal == '*') Console.WriteLine($"{a} {amal} {b} = {a * b}");
    else if(amal == '/')
    {
        if(b == 0) Console.WriteLine("Sonni 0 ga bo'lsih mumkun emas");
        else Console.WriteLine($"{a} {amal} {b} = {a / b}");
    }
}
