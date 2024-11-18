//thiwagorn 66040249144
using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                headProgram("");

                //input รับข้อมูล น้ำหนักส่วนสูง
                double weight = 0.0;
                double height = 0.0;
                Console.WriteLine("Input your weight (kg) : ");
                weight = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input your height (cm) : ");
                height = Convert.ToDouble(Console.ReadLine());
                line("-", 40);
                bmi(weight, height);
                line("-", 40);

                Console.WriteLine("Do you want to Calcltate BMI. agian ? (y/n) : ");
                string answer = Console.ReadLine().ToLower();
                if (answer != "y")
                {
                    break;
                }

            }
            line("-", 40);
            Console.WriteLine("Thank you");
        }
        static void line(string letter, int width)
        {
            string str = "";
            for (int i = 0; i < width; i++)
            {
                str += letter;
            }
            Console.WriteLine(str);
        }

        static void headProgram(string programerName)
        {
            WriteLineColor("Develop by thiwagorn " + programerName, ConsoleColor.Red, ConsoleColor.Black);
            WriteLineColor("Udonthani Rajabhat University", ConsoleColor.DarkBlue, ConsoleColor.Black);
            line("-", 40);
            WriteLineColor("Please input you information", ConsoleColor.DarkYellow, ConsoleColor.Black);
        }

        static void WriteLineColor(string text, ConsoleColor fg, ConsoleColor bg)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bg;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

        static void bmi(double weight, double height)
        {
            //process ประมวลผล
            double bmi = weight / Math.Pow(height / 100, 2);
            string result = "";
            if (bmi < 18.5)
            {
                result = "Underweight";
            }
            else if (bmi < 25.0)
            {
                result = "Normal weight";
            }
            else if (bmi < 30)
            {
                result = "Overweight";
            }
            else
            {
                result = "Obesity";
            }
            lable3.text ="Your Body mass index (BMI) is " + bmi.ToString("0.00"));
            lable4.text = "From your body mass index, you are " + result);
        }
    }
}
