using System;

public static class Kata
{
  public static string Likes(string[] name)
  {
    string likes = " likes this";
    string like = " like this";
    string result = "no one" + likes;
    int lengthName = name.Length;

    if (lengthName == 1)
    {
        result = name[0].ToString() + likes;
    }
    else if (lengthName == 2)
    {
        result = name[0].ToString() + " and " + name[1].ToString() + like;
    }
    else if (lengthName == 3)
    {
        result = name[0].ToString() + ", " + name[1].ToString() + " and " + name[2].ToString() + like;
    }
    else if (lengthName > 3)
    {
        result = name[0].ToString() + ", " + name[1].ToString() + " and " + (lengthName - 2).ToString() + " others" + like;
    }

    return result;
  }

  public static void Main(string[] args)
  {
    string[] name = {};
    System.Console.WriteLine(Kata.Likes(name));

    string[] name2 = {"Ryan"};
    System.Console.WriteLine(Kata.Likes(name2));

    string[] name3 = {"Ryan", "Darmaji"};
    System.Console.WriteLine(Kata.Likes(name3));

    string[] name4 = {"Ryan", "Darmaji", "Debora"};
    System.Console.WriteLine(Kata.Likes(name4));

    string[] name5 = {"Ryan", "Darmaji", "Debora", "Kurt"};
    System.Console.WriteLine(Kata.Likes(name5));

    string[] name6 = {"Ryan", "Darmaji", "Debora", "Kurt", "Ryan", "Darmaji", "Debora", "Kurt"};
    System.Console.WriteLine(Kata.Likes(name6));
  }
}