
# C#初心者の練習コード


## No1.cs  
  NとMを入力させて N÷10×M　を出力させる。  
  
  
    
## No2.cs  
  入力された文字列を以下の表にしたがって置換した文字列を出力する。  
  >    A → 4  
      E → 3  
      G → 6  
      I → 1  
      O → 0  
      S → 5  
      Z → 2  
  
  
    
## No3.cs  
  入力された英単語を複数形に変換する。  
    
  ### 1.listを使ってN個の英単語を入力させる。  
  以下を先頭部分につけることでリストの利用が可能。  
  >using System.Collections.Generic;  
     
  以下のコードで空のリストを作成。  
  >List<string> list =new List<string>();  
     
  以下のコードで文字列strをlistに追加できる。  
  >list.Add(str);  
  
  ### 2.String.Substringで文字列の指定部分を抜き出す。
   以下で文字列str1の0からa文字目までを抜き出す。　　
   >Console.Write(str1.Substring(0, a));   
