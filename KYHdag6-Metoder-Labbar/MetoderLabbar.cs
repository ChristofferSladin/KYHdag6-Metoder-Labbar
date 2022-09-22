using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHdag6_Metoder_Labbar
{
    internal class MetoderLabbar
    {
        public string FindLongestWord(string[] listOfStrings)
        {
            for (int i = 0; i < listOfStrings.Length; i++)
            {
                listOfStrings[i].Max();
            }

            return
        }
        public void Lab5()
        {
            Console.WriteLine("Ange hur många ord du vill lägga in");
            int antalStrings = int.Parse(Console.ReadLine());

            string[] listOfStrings = new string[antalStrings];
            FindLongestWord(listOfStrings);



        }
        public bool OfAge(int age)
        {
            if (age < 18)
            {
                return false;
            }
            else
                return true;
        }
        public void Lab4()
        {
            Console.WriteLine("Ange din ålder");
            int age = int.Parse(Console.ReadLine());

            bool showAge = OfAge(age);

            Console.WriteLine($"Are you of age? {showAge}");
        }

        public float Moms(int summa)
        {
            float moms = 0.25f;

            float outputSumma = moms * summa;

            return outputSumma;
        }

        public void Lab3()
        {
            Console.WriteLine("Ange en summa");
            int  summa = int.Parse(Console.ReadLine());

            float klarSumma = Moms(summa);

            Console.WriteLine($"Momsen är: {klarSumma}");
        }

        public string Plussa(string str1, string str2)
        {
            string denSammansattaStringen = str1 + str2;

            return denSammansattaStringen;
        }
        public void Lab2()
        {
            Console.WriteLine("Mata in en string");
            string str1 = Console.ReadLine();
            Console.WriteLine("Mata in en till string");
            string str2 = Console.ReadLine();

            string resultat = Plussa(str1, str2);

            Console.WriteLine(resultat);
        }
        public string GetMessage()
        {
            return "Hello World";
        }
        public void Lab1()
        {
            string message = GetMessage();
            Console.WriteLine(message);
        }
        // ---------------------------------------------------------------------------------------------------------

        public void Run()
        {
            //Lab1();
            //Lab2();
            //Lab3();
            Lab4();
        }
    }
}
