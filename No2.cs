using System;

class Program
{
    static void Main()
    {
        string str = Console.ReadLine();

        for(int i=0;i<str.Length;i++){
          if(str[i] == 'A'){
              Console.Write("4");
          }
          else if(str[i] == 'E'){
              Console.Write("3");
          }
          else if(str[i] == 'G'){
              Console.Write("6");
          }
          else if(str[i] == 'I'){
              Console.Write("1");
          }
          else if(str[i] == 'O'){
              Console.Write("0");
          }
          else if(str[i] == 'S'){
              Console.Write("5");
          }
          else if(str[i] == 'Z'){
              Console.Write("2");
          }
          else{
              Console.Write(str[i]);
          }
        }

        Console.Write("\n");
    }
}
