using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your sentence.");
            string text = Console.ReadLine();  // کاربر جمله رو وارد میکنه

            Console.WriteLine("Please Enter a number.");
            int value = int.Parse(Console.ReadLine());  // یک عدد برای تغییر جمله وارد میکنه

            Console.Clear();

            ICode c1 = new Leter();  // یک نمونه از کلاس لتر ساختم با توجه به اینترفیس

            string code = c1.Code(text, value);  // و اینجا جمله اصلی و عدد وارد شده رو میریزه داخل کلاس لتر
            Console.WriteLine("New sentence : " + code);

            // FiggleFonts.Standard

            Console.WriteLine("Press the keyword to see the main sentence.");
            Console.ReadKey();

            Console.WriteLine(text);

            Console.ReadKey();
        }
    }
}
