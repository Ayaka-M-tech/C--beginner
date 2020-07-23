using System;
/*listが使えるようになる*/
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        /*空のlist作成*/
        List<string> list =new List<string>();

        string str;

        for (int i = 0; i < n; i++){
            str = Console.ReadLine();
            list.Add(str);
        }

        for(int i=0;i<n;i++){
          /*listから配列に*/
          string str1=list[i];
          var a = str1.Length-1;
          var b = str1.Length-2;
          if(str1[a]=='s'||(str1[a]=='h'&&str1[b]=='s')||(str1[a]=='h'&&str1[b]=='c')||str1[a]=='o'||str1[a]=='x'){
              Console.Write(str1);
              Console.Write("es\n");
          }
          else if(str1[a]=='f'){
              Console.Write(str1.Substring(0, a));
              Console.Write("ves\n");
          }
          else if(str1[a]=='e'&& str1[b]=='f'){
              Console.Write(str1.Substring(0, b));
              Console.Write("ves\n");
          }
          else if(str1[a]=='y'&&str1[b]!='a'&&str1[b]!='i'&&str1[b]!='u'&&str1[b]!='e'&&str1[b]!='o'){
              Console.Write(str1.Substring(0, a));
              Console.Write("ies\n");
          }
          else{
              Console.Write(str1);
              Console.Write("s\n");
          }
        }

    }
}
