/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            string reponse; // saisie de la réponse de l'utilisateur
            string choix; // saisie du choix de l'utilsiateur
            string lettreSolution; // solution en chaîne de caractère 

            // boucle sur le menu
            choix = "1";
            while (choix != "0")
            {
                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                choix = Console.ReadLine();
                // traitement des choix
                if (choix != "0")
                {
                    if (choix == "1")
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");
                        reponse = Console.ReadLine();
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        // conversion de la solution en chaîne de caractère 
                        lettreSolution = solution.ToString();
                        try
                        {
                            if (reponse == lettreSolution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                            }
                        }
                        catch
                        {
                            // erreur de saisie
                            Console.WriteLine("\nErreur de saisie!\nVeuillez saisir un nombre entier\n");
                            reponse = Console.ReadLine();
                        }
                        
                    }
                    else if (choix == "2")
                    {
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        reponse = Console.ReadLine();
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        // conversion de la solution en chaîne de caractère 
                        lettreSolution = solution.ToString();
                        try
                        {
                            if (reponse == lettreSolution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                            }
                        }
                        catch
                        {
                            // erreur de saisie
                            Console.WriteLine("\nErreur de saisie!\nVeuillez saisir un nombre entier\n");
                            reponse = Console.ReadLine();
                        }
                        
                    }
                    else
                    {
                        // erreur de saisie
                        Console.WriteLine("\nErreur de saisie!\nVeuillez saisir un des chiffres proposés\n");
                    }
                }
            }
        }
    }
}
