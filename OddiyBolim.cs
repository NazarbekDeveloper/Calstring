namespace Calstring
{
    public class OddiyBolim
    {
        public void Hisobla()
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
                if (b == 0) Console.WriteLine("Sonni 0 ga bo'lish mumkun emas");
                else Console.WriteLine($"{a} {amal} {b} = {a / b}");
            }
            else Console.WriteLine("Bunday amal majud emas!!!");
        }
    }
}