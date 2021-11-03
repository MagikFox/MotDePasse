using System;

namespace MotDePasse
{
    class Program
    {
        static int Change()
        {
            try
            {
                int Long = int.Parse(Console.ReadLine());
                return (Long);
            }
            catch
            {
                Console.WriteLine("Tu ne peut mettre que des nombres ici ! ALORS ARRÊTE DE FAIRE N'IMP!!!!");
                return Long();
            }
        }
        static int Change2()
        {
            try
            {
                int Nu = int.Parse(Console.ReadLine());
                return (Nu);
            }
            catch
            {
                Console.WriteLine("Tu ne peut mettre que des nombres ici ! ALORS ARRÊTE DE FAIRE N'IMP!!!!");
                return Change();
            }
        }
        static void Choose_Random_Num1(int Longueur, int NbMDP)
        {
            Random Rand = new Random();
            int i = 0;
            int l = 1;
            Console.WriteLine("voici ton mot de passe :");
            while (NbMDP != l-1)
            {
                Console.Write("Mot de passe N°" + l + " : ");
                while (Longueur > i)
                {
                    char Nume1 = (char)Rand.Next('A', 'Z');
                    Console.Write(Nume1);
                    i = i + 1;
                }
                Console.WriteLine(" ");
                i = 0;
                l = l+1;
            }
            Restart();
        }
        static void Choose_Random_Num2(int Longueur, int NbMDP)
        {
            Random Rand = new Random();
            int i = 0;
            int l = 1;
            Console.WriteLine("voici ton mot de passe :");
            while (NbMDP != l - 1)
            {
                Console.Write("Mot de passe N°" + l + " : ");
                while (Longueur > i)
                {
                    string DataBase = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN";
                    int Nume1 = Rand.Next(0, DataBase.Length);
                    Console.Write(DataBase[Nume1]);
                    i = i + 1;
                }
                
                Console.WriteLine(" ");
                i = 0;
                l = l + 1;
            }
            Restart();
        }
        static void Choose_Random_Num3(int Longueur, int NbMDP)
        {
            Random Rand = new Random();
            int i = 0;
            int l = 1;
            Console.WriteLine("voici ton mot de passe :");
            while (NbMDP != l - 1)
            {
                Console.Write("Mot de passe N°" + l + ": ");
                while (Longueur > i)
                {
                    string DataBase = "azertyuiopqsdfghjklmwxcvbnAZERTYUIOPQSDFGHJKLMWXCVBN0123456789";
                    int Nume1 = Rand.Next(0, DataBase.Length);
                    Console.Write(DataBase[Nume1]);
                    i = i + 1;
                }
                Console.WriteLine(" ");
                i = 0;
                l = l + 1;
            }
            Restart();
        }
        static void Choose_Random_Num4(int Longueur, int NbMDP)
        {
            Random Rand = new Random();
            int i = 0;
            int l = 1;
            Console.WriteLine("voici ton mot de passe :");
            while (NbMDP != l - 1)
            {
                Console.Write("Mot de passe N°" + l + " : ");
                while (Longueur > i)
                {
                    char Nume1 = (char)Rand.Next('!', 'z');
                    Console.Write(Nume1);
                    i = i + 1;
                }
                Console.WriteLine(" ");
                i = 0;
                l = l + 1;
            }
            Restart();
        }
        static void GetNum()
        {

        }
        static void StartText()
        {
            Console.WriteLine("Maintenant que tu a fait ton choix");
            Console.WriteLine("fait le choix de ton type de mot de passe");
            Console.WriteLine("1 - Uniquement des caractères en majuscules");
            Console.WriteLine("2 - Des caractères minuscules et des majuscules");
            Console.WriteLine("3 - Des caractères et des chiffres");
            Console.WriteLine("4 - Tous ce qui est possible de mettre c:");
            Console.Write("Ton choix : ");
        }
        static int Long()
        {
            Console.Write("Longueur du mot de passe : ");
            int Longueur = Change();
            return Longueur;
        }
        static int NbMotDePasse()
        {
            Console.WriteLine("Combien de mot de passe veux tu ? ");
            Console.Write(": ");
            try
            {
                int NbMDP = int.Parse(Console.ReadLine());
                if (NbMDP < 1)
                {
                    Console.WriteLine("Tu ne peut pas avoir 0 mot de passe, refait ton choix");
                    return NbMotDePasse();
                }
                else
                {
                    return NbMDP;
                }
            }
            catch
            {
                Console.WriteLine("tu ne peut pas mettre de texte ici, seulement des chiffres !!");
                return NbMotDePasse();
            }

        }
        static void Restart()
        {
            Console.Write("Tu veut encore un/des mot de passe ?");
            string Rep = Console.ReadLine();
            if (Rep == "oui") 
            {
                Mainn();
            }
            else
            {
                
            }
        }
        static void Main(string[] args)
        {
            Mainn();

        }
        static void Mainn()
        { 
            int Longueur = Long();
            int NbMDP = NbMotDePasse();
            StartText();
            int Num = Change2();
            if (Num == 1)
            {
                Choose_Random_Num1(Longueur, NbMDP);
            }
            else if (Num == 2)
            {
                Choose_Random_Num2(Longueur, NbMDP);
            }
            else if (Num == 3)
            {
                Choose_Random_Num3(Longueur, NbMDP);
            }
            else if (Num == 4)
            {
                Choose_Random_Num4(Longueur, NbMDP);
            }
            else if (Num > 4)
            {
                Choose_Random_Num4(Longueur, NbMDP);
            }
            
            

        }
    }
}
