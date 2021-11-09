using System;

namespace Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string men;

            int c = 0;

            bool passed = true;

            Console.WriteLine("skriv antal ord det ska vara (1-5)");

            int antal = int.Parse(Console.ReadLine());

            int[] split = new int[antal];

            Console.WriteLine("skriv in meningen");

            do{
                men = Console.ReadLine();

                for(int i = 0; i <= men.Length - 1; i++){
                    if(men[i].ToString() == (" ")){
                        split[c] = i;
                        c++;
                    }
                }

                for(int i = 0; i <= split.Length-2; i++){
                    if(split[i+1] - split[i] > 10){
                        passed = false;
                    }
                }

                if(!passed){
                    Console.WriteLine("meningen följde inte kraven");
                }

            }while(!passed);

            string vokal = "aAeEiIoOuUyY";
            string kons = "bBcCdDfFgGhHjJkKlLmMnNpPqQrRsStTvVwWxXzZ";

            char[] stupid = new char[men.Length];

            for(int i = 0; i <= men.Length-1; i++){
                stupid[i] = men[i];
            }

            for(int i = 0; i <=stupid.Length-2; i++){
                if(vokal.Contains(stupid[i])){
                    if(kons.Contains(men[i+1]) && kons.Contains(men[i+2])){
                        stupid[i] = '!';
                    }
                }
            }

            men = new string(stupid);

            for(int i = 0; i <=men.Length-1; i++){
                if(men[i].ToString() == ("!")){
                    men = men.Remove(i, 1);
                }
            }

            char[] no = men.ToCharArray();
            Array.Reverse(no);
            men = new string(no);

            Console.WriteLine(men);

        }
    }
}
