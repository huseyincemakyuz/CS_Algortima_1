using System;
using System.Collections;

namespace koleksiyonlar_soru_1 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("20 adet sayı giriniz:");
            for(int i=0;i<20;i++)
            {
                Console.Write("{0}. sayıyı giriniz: ",i+1);
                string n = Console.ReadLine();
                InputCheck(n,i);

            }           
        }

        static void InputCheck(string n,int i)
        {
            bool isNumeric = int.TryParse(n, out int number);
            int  rank = i+1;
            
            
            ArrayList primeNumbers = new ArrayList();
            ArrayList notPrimeNumbers = new ArrayList();

            if(isNumeric && number>=0)
            {   
                int primeCheck = 0;
                for(int j=1; j<=number; j++)
                {
                    if(number%j == 0)
                    {
                        primeCheck++;
                    }
                }

                if(primeCheck == 2)
                {
                    primeNumbers.Add(number);
                }
                else
                {
                    notPrimeNumbers.Add(number);
                }
                
            }else{
                Console.WriteLine("Geçersiz bir girdi yaptınız!");
                Console.Write("{0}. sayıyı tekrar giriniz: ",rank);
                InputCheck(Console.ReadLine(),rank-1);
            }
        }
    }
}
