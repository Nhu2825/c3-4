
using System.Linq;
using System;

public class Ex2 
{
    public static void Main()
    {
        //Example1();
        //Example2();
        //Example3();
        Ex1_ss3();
        Console.ReadKey();
    }
    /// examlpe 1,2,3 are exercises of chapter 3. The others are exercises of chapter4 
    public static void Example1()
    {
        Console.Write("Nhap do C: ");
        double c = double.Parse(Console.ReadLine());
        double k = c + 273;
        double f = c * 18 / 10 + 32;
        Console.WriteLine($"kenvin = {k}");
        Console.WriteLine($"fahrenheit = {f}");
    }
    public static void Example2()
    {
        Console.Write("Nhap ban kinh: ");
        float r = float.Parse(Console.ReadLine());
        double s = 4 * Math.PI * Math.Sqrt(r);
        double v = (4 / 3) * Math.PI * Math.Pow(r, 3);
        Console.WriteLine($"Surface: {s}");
        Console.WriteLine($"Volume: {v}");
    }
    public static void Example3()
    {
        Console.Write("Nhap so thu nhat: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Nhap so thu hai: ");
        double b = double.Parse(Console.ReadLine());
        double tong = a + b;
        double tich = a * b;
        double hieu = a - b;
        double thuong = a / b;
        double mod = a % b;
        Console.WriteLine($"{a} + {b} = {tong}");
        Console.WriteLine($"{a} - {b} = {hieu}");
        Console.WriteLine($"{a} * {b} = {tich}");
        Console.WriteLine($"{a} / {b} = {thuong}");
        Console.WriteLine($"{a} mod {b} = {mod}");
    }
    public static void Ex1_ss3()
    {
        //x=y2+2y+1
        Console.WriteLine("voi x = y2 + 2y + 1");
        for (int i = -5; i <= 5; i++)
        {
            Console.WriteLine($"y = {i}, x = {i * i + 2 * i + 1}");
        }
    }
    public static void Ex2_ss3()
    {
        Console.Write("Nhap so gio: ");
        byte h = byte.Parse(Console.ReadLine());
        Console.Write("Nhap so phut: ");
        double m = double.Parse(Console.ReadLine());
        Console.Write("Nhap so giay: ");
        double s = double.Parse(Console.ReadLine());
        Console.Write("Nhap khoang cach (km): ");
        double l = double.Parse(Console.ReadLine());
        Console.WriteLine($"van toc la {l / (h + m / 60 + s / 3600)} km/h");
        Console.WriteLine($"van toc la {(l / (h + m / 60 + s / 3600)) * 0.621371192} km/h");
    }
    public static void Ex3_ss03()
    {
        Console.Write("Input a character: ");
        char inputChar = Console.ReadLine()[0];
        if ("aeiouAEIOU".Contains(inputChar))
        {
            Console.WriteLine("The character is a vowel.");
        }
        else if ((int)inputChar >= 48 && (int)inputChar <= 57)
        {
            Console.WriteLine("The character is a digit.");
        }
        else
        {
            Console.WriteLine("The character is another symbol.");
        }
    }
    public static void Ex5_ss03()
    {
        Console.WriteLine("Enter a character: ");
        char a = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Check if the input is a vowel
        if ("aeiouAEIOU".Contains(a))
        {
            Console.WriteLine($"{a} is a vowel.");
        }
        // Check if the input is a digit
        else if (char.IsDigit(a))
        {
            Console.WriteLine($"{a} is a digit.");
        }
        // Check if the input is any other symbol
        else if (char.IsLetter(a))
        {
            Console.WriteLine($"{a} is a consonant.");
        }
        else
        {
            Console.WriteLine($"{a} is a symbol.");
        }
    }
}