using System;

namespace Paul_Nissane_avec_fonction
{
    class Program
    {
        static void Main(string[] args)
        {
            

            // calcul du montant d'une assurance
            // déclaration des variables à saisir
            string nom, prenom, typecontrat, conduite;
            char sexe;
            DateTime ddn;
            bool condAcc;
            byte groupe;
            double cotisation;
            // declaration des variables de calculs
            double montBase = 0, montMajoration;

            // saisie des données
            Console.Write("\n\n\n\t\t\t CALCUL DU MONTANT ANNUEL D'UNE COTISATION D'ASSURANCE AUTOMOBILE");
            Console.Write(" \n\n\n\t Donnez votre nom : \t");
            nom = Console.ReadLine();
            Console.Write(" \n\t Donnez votre prenom : \t");
            prenom = Console.ReadLine();
            Console.Write(" \n\t Donnez votre sexe (F/M) : \t");
            sexe = Convert.ToChar(Console.ReadLine());
            Console.Write(" \n\t Donnez votre date de naissance : \t");
            ddn = Convert.ToDateTime(Console.ReadLine());
            Console.Write(" \n\t Donnez le groupe  de type de véhicule (1, 2, 3 .......,14) : \t");
            groupe = Convert.ToByte(Console.ReadLine());
            Console.Write(" \n\t Donnez le type de contrat (TIE pour Tiers ou TTR pour Tout risque) : \t");
            typecontrat = (Console.ReadLine());
            Console.Write(" \n\t Êtes vous en conduite Accompagnée ? ( Oui ou Non ) : \t");
            conduite = (Console.ReadLine());
            // traitements
            // calcul de l'âge

            DateTime d1 = DateTime.Now;
            int age = d1.Year - ddn.Year;




            //  motant de la cotisation
            montBase = CalculMontantBase(groupe, typecontrat);
            montMajoration = CalculMajoration(montBase, age, sexe);


            // ================================  declaration des fonctions ======================
            // fonction calcul du montant de base
            static double CalculMontantBase(int g, string c)
            {
                double cotisation = 0;
                switch (g)
                {
                    case 1:
                        cotisation = 150;
                        break;

                    case 2:
                        cotisation = 172;
                        break;

                    case 3:
                        cotisation = 196;
                        break;

                    case 4:
                        cotisation = 218;
                        break;

                    case 5:
                        cotisation = 255;
                        break;

                    case 6:
                        cotisation = 291;
                        break;

                    case 7:
                        cotisation = 333;
                        break;

                    case 8:
                        cotisation = 349;
                        break;

                    case 9:
                        cotisation = 368;
                        break;

                    case 10:
                        cotisation = 380;
                        break;

                    case 11:
                        cotisation = 399;
                        break;

                    case 12:
                        cotisation = 425;
                        break;

                    case 13:
                        cotisation = 458;
                        break;

                    case 14:
                        cotisation = 482;
                        break;

                    default:
                        cotisation = 1;
                        break;

                }

                // Regarde si c'est tie ou ttr

                if (c.ToUpper() == "TTR")
                {

                    cotisation = cotisation * 1.2; // 20% en plus
                }
                return cotisation;
            } // fin fonction



            // fonction calcul du mmajoration



            static double CalculMajoration(double montBase, int age, char sexe, string typecontrat)
            {
                if (conduite.ToUpper() == "NON")
                {
                    if (sexe == 'F')
                    {
                        if (age == 18 | age == 19 | age == 20 | age == 21)
                        {
                            montBase = montBase * 1.5;
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Femme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + montBase);
                        }
                        else
                        {
                            montBase = montBase * 1.25;
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Femme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat);
                        }
                    }

                    // calcul avec le masculin et l'age AVEC CONDUITE ACCOMPAGNEE

                    else
                    {

                        if (age == 18 | age == 19 | age == 20)
                        {
                            montBase = montBase * 1.5;
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Homme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat + " avec Majoration de la cotisation de 50% incluse ");
                        }

                        if (age == 21 | age == 22 | age == 23)
                        {
                            montBase = montBase * 1.25;
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Homme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat + " avec Majoration de la cotisation de 25% incluse ");
                        }

                        else
                        {
                            montBase = montBase * 1.15;
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Homme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat + " avec Majoration de la cotisation de 15% incluse ");

                        }
                    }

                }

                else
                {
                    // calcul avec le féminin et l'age SANS CONDUITE ACCOMPAGNEE

                    if (sexe == 'F')
                    {
                        if (age == 18 | age == 19 | age == 20 | age == 21)
                        {
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Femme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat + " avec aucune majoration de la cotisation");
                        }
                        else
                        {
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Femme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat + " avec aucune majoration de la cotisation");
                        }
                    }

                    // calcul avec le masculin et l'age et SANS CONDUITE ACCOMPAGNEE

                    else
                    {

                        if (age == 18 | age == 19 | age == 20)
                        {
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Homme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat + " avec aucune majoration de la cotisation");
                        }

                        if (age == 21 | age == 22 | age == 23)
                        {
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Homme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat + " avec aucune majoration de la cotisation");
                        }

                        else
                        {
                            Console.Write("\n\t" + prenom + " " + nom + " en tant que Homme avec l'âge de " + age + " ans, payera : " + montBase + " euros par an avec son contrat " + typecontrat + " avec aucune majoration de la cotisation");

                        }
                    }

                }
                return montBase;
            }
        } 
    }
}
