using System;
using System.Collections;

namespace koleksiyonlar_soru_1 
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumbers = new ArrayList();
            ArrayList notPrimeNumbers = new ArrayList();
            
            int sumPrime = 0;
            int sumNotPrime = 0;


            Console.WriteLine("20 adet sayı giriniz:");
            for(int i=0;i<20;i++)
            {
                Console.Write("{0}. sayıyı giriniz: ",i+1);
                string n = Console.ReadLine();

                bool isNumeric = int.TryParse(n, out int number);
                int primeCheck = 0;

                while(!isNumeric || number<0)
                {
                    Console.WriteLine("Geçersiz bir girdi yaptınız!");
                    Console.Write("{0}. sayıyı tekrar giriniz: ",i+1);
                    n=Console.ReadLine();

                    isNumeric = int.TryParse(n, out int m);
                    number=m;
                }

                for(int j=1; j<=number; j++)
                {
                    if(number%j == 0)
                    {
                        primeCheck++;
                    }
                }

                if(primeCheck == 2)
                {
                    primeNumbers.Add(Convert.ToInt32(n));
                    sumPrime+=Convert.ToInt32(Convert.ToInt32(n));
                }
                else{
                    notPrimeNumbers.Add(Convert.ToInt32(Convert.ToInt32(n)));
                    sumNotPrime += Convert.ToInt32(Convert.ToInt32(n));
                }
            } 

            primeNumbers.Sort();
            primeNumbers.Reverse();
            
            notPrimeNumbers.Sort();
            notPrimeNumbers.Reverse();


            Console.WriteLine("******Asal Sayılar**********");
            foreach (var prime in primeNumbers)
            {
                Console.Write(prime+",");
            }
            Console.WriteLine();
            Console.WriteLine("Dizinin Eleman Sayısı: "+primeNumbers.Count);
            Console.WriteLine("Dizinin Ortalaması: "+sumPrime/primeNumbers.Count);
            
            Console.WriteLine("******Asal Olmayan Sayılar**********");
            foreach (var notPrime in notPrimeNumbers)
            {
                Console.Write(notPrime+",");
            }
            Console.WriteLine();
            Console.WriteLine("Dizinin Eleman Sayısı: "+notPrimeNumbers.Count);
            Console.WriteLine("Dizinin Ortalaması: "+sumNotPrime/notPrimeNumbers.Count);
        }
    }
}
