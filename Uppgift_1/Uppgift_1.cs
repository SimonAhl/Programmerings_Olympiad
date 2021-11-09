using System;

namespace progUpp
{
    class Program
    {
        static void Main(string[] args)
        {

            double kGram;
            double aGram;
            double bGram;

            Console.WriteLine("skriv 3 heltal mellan 50 och 200");

            while(true){

                kGram = int.Parse(Console.ReadLine());

                if(kGram >= 50 && kGram <= 200){
                    break;
                }else{
                    Console.WriteLine("Nej, ett heltal mellan 50 och 200");
                }
            }

            while(true){

                aGram = int.Parse(Console.ReadLine());

                if(aGram >= 50 && aGram <= 200){
                    break;
                }else{
                    Console.WriteLine("Nej, ett heltal mellan 50 och 200");
                }
            }

            while(true){

                bGram = int.Parse(Console.ReadLine());

                if(bGram >= 50 && bGram <= 200){
                    break;
                }else{
                    Console.WriteLine("Nej, ett heltal mellan 50 och 200");
                }
            }

            double kVikt = kGram * (2*229*324) / 1000000;
            double aVikt = aGram * (2*297*420) / 1000000;
            double bVikt = bGram * (210*297) / 1000000;

            Console.WriteLine(kVikt + aVikt + bVikt);
        }
    }
}
