using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 1;
            int wybor;
            int wybor2;
            int exit2 = 1;
            int exit3 = 1;
            var rzecz_po_ang = new List<string> { "car", "woman", "boy", "shoe" };
            var poj_niezdef = new List<string> { "en bil", "en kvinde", "en dreng", "en sko" };
            var poj_zdef = new List<string> { "bilen", "kvinden", "drengen", "skoen" };
            var mn_niezdef = new List<string> { "biler", "kvinder", "drenge", "sko" };
            var mn_zdef = new List<string> { "bilerne", "kvinderne", "drengene", "skoene" };
            int dl_list = rzecz_po_ang.Count;
            string los_slowo = "dupa";
            var los = new Random();
            int index_los_slowo = -1;
            int while1 = 0;
            int while2 = 0;
            int while3 = 0;
            int while4 = 0;
            string odp = "dupsko";
            while (exit == 1)
            {
                while (exit2 == 1)
                {
                    Console.WriteLine("\n[1] odpytywanie \n[2] wyjscie ");
                    wybor = Convert.ToInt32(Console.ReadLine());
                    if (wybor == 1)
                    {
                        
                        while (exit3 == 1)
                        {
                            Console.WriteLine("\nchcesz: \n[1] wylosowac slowko \n[2] wybrac slowko \n[3] sprawdzic liste slow \n[4] sprawdzic indeks danego slowa \n[5] konczyc ");
                            wybor2 = Convert.ToInt32(Console.ReadLine());
                            while1 = 0;
                            while2 = 0;
                            while3 = 0;
                            while4 = 0;
                            if (wybor2 == 1)
                            {
                                index_los_slowo = los.Next(0, dl_list);
                                los_slowo = rzecz_po_ang[index_los_slowo];
                                Console.WriteLine("\nwylosowano slowo: " + los_slowo + "\nw kazdeh chwili mozesz napisac 'koniec' aby przerwac odpytywanie");
                                while (while1 == 0)
                                {
                                    Console.WriteLine("\nliczba pojedyncza, niezdefiniowana od '" + los_slowo + "' to: ");
                                    odp = Console.ReadLine();
                                    if (odp == poj_niezdef[index_los_slowo])
                                    {
                                        while1 = 1;
                                        while (while2 == 0)
                                        {
                                            Console.WriteLine("\nliczba pojedyncza, zdefiniowana od '" + los_slowo + "' to: ");
                                            odp = Console.ReadLine();
                                            if (odp == poj_zdef[index_los_slowo])
                                            {
                                                while2 = 1;
                                                while (while3 == 0)
                                                {
                                                    Console.WriteLine("\nliczba mnoga, niezdefiniowana od '" + los_slowo + "' to: ");
                                                    odp = Console.ReadLine();
                                                    if (odp == mn_niezdef[index_los_slowo])
                                                    {
                                                        while3 = 1;
                                                        while (while4 == 0)
                                                        {
                                                            Console.WriteLine("\nliczba mnoga, zdefiniowana od '" + los_slowo + "' to: ");
                                                            odp = Console.ReadLine();
                                                            if (odp == mn_zdef[index_los_slowo])
                                                            {
                                                                while4 = 1;
                                                                Console.WriteLine("\nudalo sie! ");

                                                            }
                                                            else if (odp == "koniec")
                                                            {
                                                                while4 = 1;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("\nzla odpowiedz ;c ");
                                                            }
                                                        }
                                                    }
                                                    else if (odp == "koniec")
                                                    {
                                                        while3 = 1;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\nzla odpowiedz ;c ");
                                                    }
                                                }
                                            }
                                            else if (odp == "koniec")
                                            {
                                                while2 = 1;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nzla odpowiedz ;c ");
                                            }
                                        }
                                    }
                                    else if (odp == "koniec")
                                    {
                                        while1 = 1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nzla odpowiedz ;c ");
                                    }
                                }
                            }
                            else if (wybor2 == 2)
                            {
                                int whilewybb = 0;
                                string wybrane_slowo = "asdf";
                                int indekswybb = -1;
                                while (whilewybb == 0)
                                {
                                    Console.WriteLine("\nwpisz slowo z ktorego chcesz zostac przepytanym, albo napisz 'koniec' aby wyjsc: ");
                                    wybrane_slowo = Console.ReadLine();
                                    indekswybb = rzecz_po_ang.IndexOf(wybrane_slowo);
                                    if (indekswybb == -1 & wybrane_slowo != "koniec")
                                    {
                                        Console.WriteLine("nie ma takiego slowa w bazie danych ");
                                    }
                                    else if (wybrane_slowo == "koniec")
                                    {
                                        whilewybb = 1;
                                    }
                                    else
                                    {
                                        los_slowo = rzecz_po_ang[indekswybb];
                                        Console.WriteLine("\nwybrano slowo: " + los_slowo + "\nw kazdeh chwili mozesz napisac 'koniec' aby przerwac odpytywanie");
                                        while (while1 == 0)
                                        {
                                            Console.WriteLine("\nliczba pojedyncza, niezdefiniowana od '" + los_slowo + "' to: ");
                                            odp = Console.ReadLine();
                                            if (odp == poj_niezdef[indekswybb])
                                            {
                                                while1 = 1;
                                                while (while2 == 0)
                                                {
                                                    Console.WriteLine("\nliczba pojedyncza, zdefiniowana od '" + los_slowo + "' to: ");
                                                    odp = Console.ReadLine();
                                                    if (odp == poj_zdef[indekswybb])
                                                    {
                                                        while2 = 1;
                                                        while (while3 == 0)
                                                        {
                                                            Console.WriteLine("\nliczba mnoga, niezdefiniowana od '" + los_slowo + "' to: ");
                                                            odp = Console.ReadLine();
                                                            if (odp == mn_niezdef[indekswybb])
                                                            {
                                                                while3 = 1;
                                                                while (while4 == 0)
                                                                {
                                                                    Console.WriteLine("\nliczba mnoga, zdefiniowana od '" + los_slowo + "' to: ");
                                                                    odp = Console.ReadLine();
                                                                    if (odp == mn_zdef[indekswybb])
                                                                    {
                                                                        while4 = 1;
                                                                        Console.WriteLine("\nudalo sie! ");
                                                                        whilewybb = 1;

                                                                    }
                                                                    else if (odp == "koniec")
                                                                    {
                                                                        while4 = 1;
                                                                    }
                                                                    else
                                                                    {
                                                                        Console.WriteLine("\nzla odpowiedz ;c ");
                                                                    }
                                                                }
                                                            }
                                                            else if (odp == "koniec")
                                                            {
                                                                while3 = 1;
                                                            }
                                                            else
                                                            {
                                                                Console.WriteLine("\nzla odpowiedz ;c ");
                                                            }
                                                        }
                                                    }
                                                    else if (odp == "koniec")
                                                    {
                                                        while2 = 1;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("\nzla odpowiedz ;c ");
                                                    }
                                                }
                                            }
                                            else if (odp == "koniec")
                                            {
                                                while1 = 1;
                                            }
                                            else
                                            {
                                                Console.WriteLine("\nzla odpowiedz ;c ");
                                            }
                                        }
                                    }
                                }
                            }
                            else if (wybor2 == 5)
                            {
                                exit3 = 0;
                            }
                            else if (wybor2 == 3)
                            {
                                foreach (var slowa in rzecz_po_ang)
                                {
                                    Console.WriteLine(slowa);
                                }
                            }
                            else if (wybor2 == 4)
                            {
                                int indeksslowawhile = 0;
                                string slowoxx = "asdf";
                                int indeksslowaxx = -1;
                                while (indeksslowawhile == 0)
                                {
                                    Console.WriteLine("\nwprowadz slowo ktorego szukasz, albo napisz 'koniec' ");
                                    slowoxx = Console.ReadLine();
                                    indeksslowaxx = rzecz_po_ang.IndexOf(slowoxx);
                                    if (slowoxx == "koniec")
                                    {
                                        indeksslowawhile = 1;
                                    }
                                    else if (indeksslowaxx == -1)
                                    {
                                        Console.WriteLine("\nnie ma takiego slowa");
                                    }
                                    else
                                    {
                                        Console.WriteLine(indeksslowaxx);
                                    }
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine("\nzly numerek");
                            }
                        }
                    }
                    else if (wybor == 2)
                    {
                        exit = 0;
                        exit2 = 0;
                    }
                    else
                    {
                        Console.WriteLine("\nzly numerek");
                    }
                }
            }

        }
    }
}
