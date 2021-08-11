using System;
using System.Text;

public class Program
{
    public static void Main()
    {

        while (true) {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToRoman(number));
        }
    }

    public static string DecimalToRoman(int number)
    {
        StringBuilder sb = new StringBuilder();
        string[] units = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tens = new string[] { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] hundreds = new string[] { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] thousands = new string[] { "M", "MMM", "MMM","MMMM" };
        int module = 1;
        int selectedIndex = 0;
        while (module != 0)
        {
            if (number >= 1000)
            {
                if (number > 4999) { 
                    sb.Append("Please insert a number between 1 and 4999");
                    break;
                }
                module = number % 1000;
                selectedIndex = number / 1000;
                sb.Append(thousands[selectedIndex - 1]);              
            }
            else if (number >= 100)
            {
                module = number % 100;
                selectedIndex = number / 100;
                sb.Append(hundreds[selectedIndex - 1]);
            }
            else if (number >= 10)
            {
                module = number % 10;
                selectedIndex = number / 10;
                sb.Append(tens[selectedIndex - 1]);
            }
            else
            {
                module = 0;
                selectedIndex = number;
                sb.Append(units[selectedIndex - 1]);
            }
            number = module;
        }
        return sb.ToString();
    }
}
