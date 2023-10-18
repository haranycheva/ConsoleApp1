using System;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        int numb = int.Parse(Console.ReadLine());
        int hundreds = numb/100;
        int dozens = numb/10 - hundreds*10;
        int units = numb - (hundreds*100 + dozens*10);
        if(hundreds >= dozens & hundreds >= units){
            if(dozens >= units){ 
                Console.WriteLine(hundreds*100 + dozens*10 + units);
            }
            else{
                Console.WriteLine(hundreds*100 + units*10 + dozens);
            }
          }
          else if(dozens>=units){
            if(hundreds >= units){ 
                Console.WriteLine(dozens*100 + hundreds*10 + units);
            }else{
                Console.WriteLine(dozens*100 + units*10 + hundreds);
            }
            }
            else{
               if(hundreds >= dozens){ 
                Console.WriteLine(units*100 + hundreds*10 + dozens);
               }
            else{
                Console.WriteLine(units*100 + dozens*10 + hundreds);
                }
            }
        }
    }