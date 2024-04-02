// string str = "Hello world!";
// System.Console.WriteLine(str[0]);

// string s1 = "hello";

// char[] ch_array = { 'w', 'o', 'r', 'l', 'd' };
// string s2 = new String(ch_array);

// string s3 = new String('a', 6); //результатом будет строка "аааааа"

// string GetLettersFromString(string s)
//  {
//      string letters ="";
//      foreach(char e in s)
//      {
//          if(char.IsAsciiLetter(e) == true)
//          {
//              letters = letters + e;
//          }
//      }
//      return letters;
//  }

// string str = System.Console.ReadLine();
// string result = GetLettersFromString(str);
// System.Console.WriteLine(result);

// int[,] table = { {-2, 2, 3},
//                  {4, 4, 9},
//                  {6, 7, -10} };

// for (int i = 0; i < table.GetLength(0); i++)
// {
//     for (int j = 0; j < table.GetLength(1); j++)
//     {
//         if (table[i,j] < 0)
//         {
//             System.Console.WriteLine($"Es sind negative Elemente in der Zeile {i}");
//             break;
//         } 
//     }
// }

// int i = 0;
// while (i < 5)
// {
//     System.Console.WriteLine($"Iteration:{i}");
//     i++;
// }

for (int i = 1; i<=5; i++)
{
    System.Console.Write($"Iteration {i}: ");
    if(i == 3)
    {
        System.Console.WriteLine("Skip");
        continue;
    }
    System.Console.WriteLine("Some processing");
}
