using System;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        int[,] values = new int[n,n];
        int sum=0,sum1=0;
        int wa=0,a=0;

        /*stringを1行で読み取り、スペースで区切って配列に格納、整数に変換し、二次元配列にいれる*/
        for (int i = 0; i < n; i++){
          string line = Console.ReadLine();
          string[] str = line.Split(' ');
          for(int j=0;j<n;j++){
            values[i,j] = int.Parse(str[j]);
            sum1+=values[i,j];
          }
          if(sum1>sum){
            sum=sum1;
          }
          sum1=0;
        }

        for(int i=0;i<n;i++){
          for(int j=0;j<n;j++){
            wa=0;
            if(values[i,j]==0){
              int h=j;
              a=0;
              while(h<n){
                if(h!=j && values[i,h]==0){
                  a=1;
                }
                h++;
              }
              if(a!=1){
                for(int k=0;k<n;k++){
                  wa+=values[i,k];
                }
                values[i,j]=sum-wa;
              }
              else{
                wa=0;
                for(int k=0;k<n;k++){
                  wa+=values[k,j];
                }
                values[i,j]=sum-wa;
              }
            }
          }
        }

        for (int i = 0; i < n; i++){
          for(int j=0;j<n-1;j++){
            Console.Write(values[i,j]);
            Console.Write(" ");
          }
          Console.Write(values[i,n-1]);
          Console.Write("\n");
        }
    }
}
