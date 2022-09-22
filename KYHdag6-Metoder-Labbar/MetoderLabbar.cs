using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KYHdag6_Metoder_Labbar
{
    internal class MetoderLabbar
    {
        public string Translate(string input)
        {
            input = input.Trim();
            
            string toBeTranslated = "";

            foreach (char c in input)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'å' || c == 'ä' || c == 'ö')
                {
                    toBeTranslated += c;
                }
                else if (c ==' ')
                {
                    toBeTranslated += c;
                }
                else
                    toBeTranslated = toBeTranslated + c + 'o' + c;
            }
            string translatedString = toBeTranslated.ToLower();

            return translatedString;
        }
        public void Lab8()
        {
            Console.WriteLine("Skriv en text som ska översättas till rövarspråket");
            string input = Console.ReadLine();

            string translatedString = Translate(input);
            Console.WriteLine(translatedString);

        }


        public bool VocalOrConsonant(char checkThisChar)
        {
            bool result;
            char lowerchar = checkThisChar; // Kan inte göra char till lowercase med .ToLower();     Varför inte???

            if (lowerchar == 'a' || lowerchar == 'e' || lowerchar == 'i' || lowerchar == 'o' || lowerchar == 'u' || lowerchar == 'å' || lowerchar == 'ä' || lowerchar == 'ö')
            {
                result = true;
            }
            else
                result = false;

            return result;
        }
        public void Lab7()
        {
            Console.WriteLine("Mata in en bokstav");
            char checkThisChar = char.Parse(Console.ReadLine());

            bool result = VocalOrConsonant(checkThisChar);

            Console.WriteLine(result);
        }

        int CalculateTaxesOnSalary(int salary)
        {
            if (salary >= 30000)
            {
                salary = Convert.ToInt32(salary * 0.33f);
            }
            else if (salary < 15000)
            {
                salary = Convert.ToInt32(salary * 0.12f);
            }
            else if (salary < 30000 && salary > 15000)
            {
                salary = Convert.ToInt32(salary * 0.28f);
            }
            return salary;
        }

        public void Lab6()
        {
            Console.WriteLine("Ange din lön");
            int salary = int.Parse(Console.ReadLine());

            int calculatedSalary = CalculateTaxesOnSalary(salary);
            Console.WriteLine($"Skatten på din lön är: {calculatedSalary}");
        }

        public string FindLongestWord(string[] listOfStrings)
        {
            string longest = listOfStrings.OrderByDescending(s => s.Length).First();
            return longest.ToString();
        }
        public void Lab5()
        {
            Console.WriteLine("Ange hur många ord du vill lägga in");
            int antalStrings = int.Parse(Console.ReadLine());

            string[] listOfStrings = new string[antalStrings];

            Console.WriteLine("Skriv strängarna du vill lägga in i fältet");
            for (int i = 0; i < listOfStrings.Length; i++)
            {
                listOfStrings[i] = Console.ReadLine();
            }

            string longestString = FindLongestWord(listOfStrings);
            Console.WriteLine(longestString);

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
            int summa = int.Parse(Console.ReadLine());

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
            //Lab4();
            //Lab5();
            //Lab6();
            //Lab7();
            Lab8();

        }
    }
}
