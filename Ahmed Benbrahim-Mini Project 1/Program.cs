using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahmed_Benbrahim_Mini_Project_1
{
    class Program
    {
        enum Planets
        {
            Mercury = 1,Venus, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto
        }
        static void Main(string[] args)
        {
            //Variables
            const double Mercury = 0.37;
            const double Venus = 0.88;
            const double Mars = 0.38;
            const double Jupiter = 2.64;
            const double Saturn = 1.15;
            const double Uranus = 1.15;
            const double Neptune = 1.12;
            const double Pluto = 0.04;
            double weight;
            string prompt;
            int chosenPlanet;
            double mercury;
            double venus;
            double mars;
            double jupiter;
            double saturn;
            double uranus;
            double neptune;
            double pluto;

            //Codes
            Console.WriteLine("-----------Mini Project 1----------- ");
            Console.WriteLine("\n");
            Console.WriteLine("In the following program, you will be able to calculate your weight in various planets.");
            Console.WriteLine("\n");
            Console.WriteLine("Menu of the planet");
            Console.WriteLine("==== == === ======");
            Console.WriteLine("1 - Mercury ");
            Console.WriteLine("2 - Venus ");
            Console.WriteLine("3 - Mars ");
            Console.WriteLine("4 - Jupiter ");
            Console.WriteLine("5 - Saturn ");
            Console.WriteLine("6 - Uranus ");
            Console.WriteLine("7 - Neptune ");
            Console.WriteLine("8 - Pluto ");
            Console.WriteLine("\n");
            Console.WriteLine("Please choose a planet of your choice");

            prompt = Console.ReadLine();
            Console.Write("\n");
            chosenPlanet = Convert.ToInt32(prompt);

            Console.WriteLine("Now input your weight in (LBS)");
            prompt = Console.ReadLine();
            Console.Write("\n");
            weight = Convert.ToInt32(prompt);

            mercury = weight * Mercury;
            venus = weight * Venus;
            mars = weight * Mars;
            jupiter = weight * Jupiter;
            saturn = weight * Saturn;
            uranus = weight * Uranus;
            neptune = weight * Neptune;
            pluto = weight * Pluto;

            switch ((Planets)(chosenPlanet))
            {
                case Planets.Mercury:
                    Console.WriteLine("You chose Mercury. Therefore your weight in Mercury would be {0} LBS", mercury);
            
                    break;
                case Planets.Venus:
                    Console.WriteLine("You chose Venus. Therefore your weight in Venus would be {0} LBS", venus);
                    break;
                case Planets.Mars:
                    Console.WriteLine("You chose Mars. Therefore your weight in Mars would be {0} LBS", mars);
                    break;
                case Planets.Jupiter:
                    Console.WriteLine("You chose Jupiter. Therefore your weight in Jupiter would be {0} LBS", jupiter);
                    break;
                case Planets.Saturn:
                    Console.WriteLine("You chose Saturn. Therefore your weight in Saturn would be {0} LBS", saturn);
                    break;
                case Planets.Uranus:
                    Console.WriteLine("You chose Uranus. Therefore your weight in Uranus would be {0} LBS", uranus);
                    break;
                case Planets.Neptune:
                    Console.WriteLine("You chose Neptune. Therefore your weight in Neptune would be {0} LBS", neptune);
                    break;
                case Planets.Pluto:
                    Console.WriteLine("You chose Pluto. Therefore your weight in Pluto would be {0} LBS", pluto);
                    break;
                default:
                    Console.WriteLine("Error! Invalid entry!! Please Try Again!!!");
                    break;

                    Console.WriteLine("Now input your weight in LBS");
                    prompt = Console.ReadLine();
                    Console.Write("\n");
                    weight = Convert.ToInt32(prompt);
            }
            Console.Write("\n");
            Console.WriteLine("****************************");
            Console.WriteLine("Please press any key to exit");
            Console.ReadKey();




        }
    }
}
