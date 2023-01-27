namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialisation
            double premierNombre = 0;
            double deuxièmeNombre = 0;
            string choixDeCalcul = "";
            string demanderRecommencer = "";
            int recommencer = 1;
            do
            {
                //affichage
                Console.WriteLine("------------");
                Console.WriteLine("-Calculator-");
                Console.WriteLine("------------");


                //demander a l'utilisateur les chiffres 

                Console.Write("Quelle est le premier chiffre : ");
                double.TryParse(Console.ReadLine(), out premierNombre);
                Console.WriteLine();
                Console.Write("Quelle est le deuxième chiffre : ");
                double.TryParse(Console.ReadLine(), out deuxièmeNombre);

                //demander option du calcul ex: - +

                Console.WriteLine("Entrée une option");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("*");
                Console.WriteLine("/");
                choixDeCalcul = Console.ReadLine();


                // les possibilités et les calculs
                if (choixDeCalcul == "+") 
                {
                    Console.WriteLine(addition(premierNombre, deuxièmeNombre));
                    
                }
                else if(choixDeCalcul == "-")
                {
                    Console.WriteLine((premierNombre, deuxièmeNombre));
                    
                }
                else if(choixDeCalcul == "*")
                {
                    Console.WriteLine(multiplication(premierNombre, deuxièmeNombre));
                  
                }
                else if(choixDeCalcul == "/")
                {
                    Console.WriteLine(division(premierNombre, deuxièmeNombre));
                    
                }
                
                // demander a recommencer
                Console.WriteLine("Voulez vous recommencez: y = oui , n = non");
                demanderRecommencer = Console.ReadLine();
                if (demanderRecommencer == "y")
                {
                        recommencer = 1;
                }
                else if (demanderRecommencer == "n")
                {
                         recommencer--;

                }
                // si réponse n'est pas y ou n fermer le programme
                else
                {
                    recommencer--;

                }

                //on nettoie la console
                Console.Clear();
                

            } while (recommencer == 1);
             
            


        }
        // les méthodes de calculs
        static double division(double nombre1, double nombre2)
        {
            double resultat = 0;
            resultat = nombre1 / nombre2;

            return resultat;
        }
        static double soustraction(double nombre1, double nombre2)
        {
            double resultat = 0;
            resultat = nombre1 - nombre2;

            return resultat;
        }
        static double addition(double nombre1, double nombre2)
        {
            double resultat = 0;
            resultat = nombre1 + nombre2;

            return resultat;
        }
        static double multiplication(double nombre1, double nombre2)
        {
            double resultat = 0;
            resultat = nombre1 * nombre2;

            return resultat;
        }
    }
}