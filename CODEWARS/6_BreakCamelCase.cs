public class Kata
{
  public static string BreakCamelCase(string str)
  {
    string result = "";
    for (int i = 0; i < str.Length; i++)
    {
        var a = str[i];
        if (char.IsUpper(a))
        {
            result += " ";
        }
        result += a;
    }
    return result;
  }

  public static void Main(string[] args)
  {
    System.Console.WriteLine(Kata.BreakCamelCase("iAmlegendRight"));
  }
}