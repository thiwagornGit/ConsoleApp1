
using System;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Body mass index (BMI)");
            line("*", 40);
            Console.WriteLine("Develop by Thiwagorn");
            line("-", 40);
            Console.WriteLine("Please input you information");

            //input รับข้อมูล น้ำหนักส่วนสูง
            double weight = 0.0;
            double height = 0.0;
            Console.WriteLine("Input your weight (kg) : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input your height (cm) : ");
            height = Convert.ToDouble(Console.ReadLine());
            line("#", 40);

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
            Console.WriteLine("Your Body mass index (BMI) is " + bmi.ToString("F2"));
            Console.WriteLine("From your body mass index, you are " + result);
            line("%", 40);
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
    }
}