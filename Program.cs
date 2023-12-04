/*
auteur      : Nurullah Tunç
lieu        : ETML/Vennes
date        : 01.12.2023
description : Il s'agit d'un jeu de devinettes de couleurs.
             Si vous devinez respectivement la longueur que vous choisissez de ces 7 couleurs, vous gagnez la partie. Vous avez 10 suppositions.     
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind_23_Nurullah
{

    internal class Program
    {
          static void Main(string[] args)
          {
                Console.WriteLine("Bienvenue sur le jeu MasterMind \n ");
                Console.WriteLine("\"Le code secret est une combinaison de 4 couleurs.");
                Console.WriteLine("Si vous devinez respectivement la longueur que vous choisissez de ces 7 couleurs, vous gagnez la partie. \n Vous avez 10 tentatives pour deviner le code.\n");
                Console.WriteLine("Veuillez entrer 4 couleur dans les couleurs suivant: Y, G, B, W, O, P, R");
                Console.WriteLine("Comme couleurs, utilisez les lettres « G » pour Gris, « Y » pour Jaune, « W » pour Blanc, « R » pour Rouge, « B » pour Bleu, « O » pour 0range et « P » pour Violette.");
                Console.ReadLine();

                //Définir une combinaison
                string secret = "RRRR";

                //verifier si la combinaison est correcte

                Console.Write("Trouve la combinaison (essai 1):");
                string guess = Console.ReadLine();

                int essai = 1;

                int bonpos = 0;  // bonne position

                int malpos = 0;   //  mal posiition

                do
                {
                    if (guess == secret)

                    {
                        Console.WriteLine("Les couleurs sont bonnes, Félicitation");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Trouvez la combinaison (essai " + essai + ")");
                        Console.WriteLine("entrez les chiffres ");
                        //Console.WriteLine("essai"); 
                        //Si la combinaison est fausse, proposer a l'utilisateur de recommencer maximum 10x

                        for (int i = 0; i < guess.Length; i++)
                        {
                            if (secret[0] == guess[0])
                            {
                                Console.WriteLine($"Le premier chiffre est correct: {secret[0]}");
                                Console.WriteLine("Une valeur identique");
                                Console.WriteLine("NOMBRE CORRECT DE POSITIONS : " + bonpos);

                            }
                            else
                            {
                                Console.WriteLine("Une valeur non identique");
                                Console.WriteLine("NOMBRE CORRECT DE POSITIONS : " + malpos);

                            }
                            if (secret[1] == guess[1])
                            {
                                Console.WriteLine($"Le deuxieme chiffre est correct: {secret[1]}");
                                Console.WriteLine("Une valeur identique");
                                Console.WriteLine("NOMBRE CORRECT DE POSITIONS : " + bonpos);

                            }
                            else
                            {
                                Console.WriteLine("Une valeur non identique");
                                Console.WriteLine("NOMBRE CORRECT DE POSITIONS : " + malpos);

                            }
                            if (secret[2] == guess[2])
                            {
                                Console.WriteLine($"Le 3eme chiffre est correct: {secret[2]}");
                                Console.WriteLine("Une valeur identique");
                                Console.WriteLine("NOMBRE CORRECT DE POSITIONS : " + bonpos);

                            }
                            else
                            {
                                Console.WriteLine("Une valeur non identique");
                                Console.WriteLine("NOMBRE CORRECT DE POSITIONS : " + malpos);

                            }
                            if (secret[3] == guess[3])
                            {
                                Console.WriteLine($"Le 4eme chiffre est correct: {secret[2]}");
                                Console.WriteLine("Une valeur identique");
                                Console.WriteLine("NOMBRE CORRECT DE POSITIONS : " + bonpos);

                            }
                            else
                            {
                                Console.WriteLine("Une valeur non identique");
                                Console.WriteLine("NOMBRE CORRECT DE POSITIONS : " + malpos);

                            }
                            Console.WriteLine("Trouvez la combinaison (essai " + essai + ")");
                             Console.WriteLine("entrez les chiffres ");
                            // Répétition
                            essai++;
                            Console.ReadLine();
                        }
                        
                    }

                } while (essai < 11);

                Console.ReadLine();
          }
    }
}
