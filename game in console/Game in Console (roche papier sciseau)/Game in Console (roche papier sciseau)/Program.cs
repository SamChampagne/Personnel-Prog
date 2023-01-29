namespace Game_in_Console__roche_papier_sciseau_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int recommencer = 0;
            bool boucle = true;
            int lancerJeu = 0;
            
            lancerJeu = AffichageDébut();
            
            if(lancerJeu == 1)
            {
                while(boucle)
                {
                    

                    tablePossibilité();

                    

                    Console.WriteLine();

                    Console.WriteLine("voulez vous continuer: 1 = oui, 2 = non");
                    int.TryParse(Console.ReadLine(), out recommencer);
                    if(recommencer == 1)
                    {
                        boucle = true;
                    }
                    else if(recommencer == 2)
                    {
                        boucle = false;
                    }
                    else
                    {
                        boucle = false;
                    }
                    Console.Clear();
                }

            }
        }
        // Méthode qui affiche le jeu et qui demande si on veut le lance
        static int AffichageDébut()
        {
            int choice = 0;
            bool reponse = true;

            Console.WriteLine("Voulez vous lancer le jeu: 1 = lancer, 2 = fermer");
            int.TryParse(Console.ReadLine(), out choice);

            

            return choice;

        }
        // méthode qui demande a l'utilisateur quelle choix il veut choisir
        static int choixUtilisateur()
        {
            int choix = 0;

            Console.WriteLine("Quelle action voulez vous choisir: 1 = papier, 2 = roche, 3 = sciseau");
            int.TryParse(Console.ReadLine(), out choix);


            return choix;
            

        }
        // méthode qui génère un choix fait par hazard par l'ordie
        static int choixOrdinateur()
        {
            int choix = 0;
            Random random = new Random();

            choix = random.Next(1, 4);

            return choix;
        }
        static void tablePossibilité()
        {
            int choixU = choixUtilisateur();
            int choixO = choixOrdinateur();

            if(choixU == 1 && choixO == 1)
            {
                Console.WriteLine("Égalité vous avez choisi les deux sciseau");
                return;
            }
            if(choixU == 1 && choixO == 2)
            {
                Console.WriteLine("Vous avez perdu car l'ordie a choisis roche");
                return;

            }
            if(choixU == 1 && choixO == 3)
            {
                Console.WriteLine("Vous avez gagnée car l'ordie a choisi papier");
                return;
            }
            if (choixU == 2 && choixO == 1)
            {
                Console.WriteLine("Vous avez gagnée car l'ordie a choisi sciseau");
                return;
            }
            if (choixU == 2 && choixO == 2)
            {
                Console.WriteLine("Égalité vous avez choisi les deux sciseau");
                return;

            }
            if (choixU == 2 && choixO == 3)
            {
                Console.WriteLine("Vous avez perdu car l'ordi a choisi papier");
                return;
            }
            if (choixU == 3 && choixO == 1)
            {
                Console.WriteLine("Vous avez perdu l'ordie a choisi sciseau");
                return;
            }
            if (choixU == 3 && choixO == 2)
            {
                Console.WriteLine("Vous avez gagnée l'ordie a choisi roche");
                return;

            }
            if (choixU == 3 && choixO == 3)
            {
                Console.WriteLine("Égalité vous avez choisi les deux papier");
                return;
            }
        }
    }
}