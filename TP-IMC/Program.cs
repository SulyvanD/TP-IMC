using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double imc, taille;
            int poids;

            Console.WriteLine("Combien vous pesez ?");
            poids = int.Parse(Console.ReadLine());
            Console.WriteLine("Combien vous mesurez ?");
            taille = double.Parse(Console.ReadLine()) / 100;
            imc = Math.Round(poids / Math.Pow(taille, 2), 2);

            Console.WriteLine("Votre poids: "+poids);
            Console.WriteLine("Votre taille: "+taille);
            Console.WriteLine("Votre IMC: "+imc);

            if (imc < 16.5) {
                Console.WriteLine("Votre statut: Dénutrition");
            } else {
                if (imc < 18.5) {
                    Console.WriteLine("Votre statut: Maigreur");
                } else {
                    if (imc < 25) {
                        Console.WriteLine("Votre statut: Corpulence normale");
                    } else {
                        if (imc < 30) {
                            Console.WriteLine("Votre statut: Surpoids");
                        } else {
                            if (imc < 35) {
                                Console.WriteLine("Votre statut: Obésité modérée");
                            } else {
                                if (imc < 40) {
                                    Console.WriteLine("Votre statut: Obésité sévère");
                                } else {
                                    if (imc > 40) {
                                        Console.WriteLine("Votre statut: Obésité morbide ou massive");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
