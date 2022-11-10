using System;

public class Kata
{
    public static void Main(string []args) 
    {
        System.Console.WriteLine(Kata.ToCamelCase("The_Stealth_Warrior"));
    }

    public static string ToCamelCase(string str)
    {
        string a = str;
        string[] b = new string[a.Length];

        bool isStripDash = false;

        for (int i = 0; i < a.Length; i++)
        {
            string currentChar = a[i].ToString();

            if (i != 0)
            {
                if (isStripDash)
                {
                    currentChar = currentChar.ToUpper();
                }
                else
                {
                    currentChar = currentChar.ToLower();
                }
            }

            b[i] = currentChar;

            if (currentChar == "-" || currentChar == "_")
            {
                isStripDash = true;
            }
            else
            {
                isStripDash = false;
            }
        }

         foreach (string c in b)
        {
            System.Console.WriteLine(c);
        }

        a = string.Join("", b);
        a = a.Replace("-", "");
        a = a.Replace("_", "");

        return a;
    }
}