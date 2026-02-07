using System.Reflection.Metadata.Ecma335;

namespace Calstring
{
    public class ProBolim
    {
        Printer printer;
        public ProBolim(Printer printer)
        {
            this.printer = printer;
        }
        public void DarajagaKotar()
        {
            printer.Print("LET'S GO!!! a ning b darajasini hisoblaymiz \n");
            printer.Print("a = ");
            double a = double.Parse(Reader.ReadFromConsole());
            printer.Print("b = ");
            double b = double.Parse(Reader.ReadFromConsole());
            printer.PrintLine($"{a}^{b} = {Math.Pow(a, b)}");
        }
        public void IldizTop()
        {
            printer.Print("LET'S GO!!! a ning kvadrat ildizini topamiz\n");
            printer.Print("a = ");
            double a = double.Parse(Reader.ReadFromConsole());
            if (a < 0) printer.PrintLine("Manfiy sonning kvadrat ildizini topish mumkun emas!!!");
            printer.PrintLine($"{a} ning kvadrat ildizi = {Math.Sqrt(a)}");
        }
        public void LogarifmHisobla()
        {
            printer.Print("LET'S GO!!! Logarif a asosga ko'ra b ni hisoblaymiz \n");
            printer.Print("a = ");
            double a = double.Parse(Reader.ReadFromConsole());
            printer.Print("b = ");
            double b = double.Parse(Reader.ReadFromConsole());
            if (IsValidToLogarifm(a, b)) printer.PrintLine($"log {a} asosga ko'ra {b} = {Math.Log(b) / Math.Log(a)}");
            else printer.PrintLine("Siz xato son kiritdingiz!!!\na va b nomanfiy sonlar va (a != 1) bo'lishi kerak");
        }
        public void FaktorialHisobla()
        {
            printer.Print("Qaysi sonning faktorialini hisoblaymiz..?\n a = ");
            double a = double.Parse(Reader.ReadFromConsole());
            if (a < 0) printer.Print($"Manfiy sonning faktorialini hisoblash mumkun emas!!!");
            else
            {
                double P = 1;
                if (a == 0) printer.PrintLine($"{a}! = {1}");
                else
                {
                    for (int i = 1; i <= a; i++)
                    {
                        P *= i;
                    }
                    printer.PrintLine($"{a}! = {1}");
                }
            }

        }
        static bool IsValidToLogarifm(double a, double b)
        {
            return (a > 0 && a != 1 && b > 0);
        }

    }
}