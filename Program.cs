using Calstring;
using Microsoft.VisualBasic.FileIO;

OddiyBolim oddiyAmal = new OddiyBolim();
ProBolim proAmal = new ProBolim();
Printer printer = new Printer();

printer.PrintLine("<<  Assalomu alayukum SuperCalculator dasturiga hush kelibsiz  >>\n");

int qaytaIshlat;
do
{
    printer.PrintLine("Bizning dasturimizda 2 ta bo'lim mavjud: ");
    printer.PrintLine("1. Oddiy bo'lim              2. Pro bo'lim");
    printer.PrintLine("1) qo'shish (+)              1) darajaga");
    printer.PrintLine("2) ayirish  (-)              2) kvadrat ildiz");
    printer.PrintLine("3) ko'paytirish  (*)         3) logarifm");
    printer.PrintLine("4) bo'lish  (/)              4) faktorial\n");
    printer.Print("Bo'limni tanlang >> ");
    int bolimTanla = int.Parse(Reader.ReadFromConsole());
    printer.PrintLine();
    if (bolimTanla == 1)
    {
        oddiyAmal.Hisobla();
    }
    else if (bolimTanla == 2)
    {
        printer.PrintLine("Pro bo'limimizga xush kelibsiz!!!\n");
        printer.PrintLine("Qanday amal bajaramiz..? \n1.Darajaga ko'tarish\n2.Kvadrat ildiz topish\n3.Logarifm hisoblash\n4.Faktorial hisoblash\n");
        printer.Print(">>> ");
        int amal = int.Parse(Reader.ReadFromConsole());
        if (amal == 1)
        {
            proAmal.DarajagaKotar();
        }
        else if (amal == 2)
        {
           proAmal.IldizTop();
        }
        else if (amal == 3)
        {
            proAmal.LogarifmHisobla();
        }
        else if (amal == 4)
        {
            proAmal.FaktorialHisobla();
        }
        else printer.PrintLine("Bunday amal xattoki PRO Max calculyatorda ham yo'qku bratim...!!!");
    }
    else
    {
        printer.PrintLine("Bunaqa bo'lim yo'de oka. Keyingi safar qo'shib qo'yamiza..!!!");
    }
    printer.PrintLine("Qaytadan bosvorovuzami oka?(1.ha 0.yo'q)");
    qaytaIshlat = int.Parse(Reader.ReadFromConsole());
} while (qaytaIshlat == 1);
printer.PrintLine("SuperCalculyator dasturidan foydalanganiz uchun Thank You Bro...!!!");