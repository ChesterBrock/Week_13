using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Week_13
{
    class Project
    {
        static void Main(string[] args)
        {
            int choice, choice2;
            string name;
            Dictionary<string, int> boyRanks = new Dictionary<string, int>();
            Dictionary<string, int> girlRanks = new Dictionary<string, int>();
            char[] delimiterChars = { ' ' };

            using (StreamReader s = new StreamReader("C:\\Users\\w7259378\\source\\repos\\Week_13\\Homework_Week_13\\boynames.txt"))
            {
                string line = null;
                int i = 1;
                while ((line = s.ReadLine()) != null)
                {
                    string[] word = line.Split(delimiterChars);
                    boyRanks.Add(line, i);
                    i++;
                }
            }

            // for girls
            using (StreamReader g = new StreamReader("C:\\Users\\w7259378\\source\\repos\\Week_13\\Homework_Week_13\\girlnames.txt"))
            {
                string gline = null;
                int i = 1;
                while ((gline = g.ReadLine()) != null)
                {
                    string[] word = gline.Split(delimiterChars);
                    boyRanks.Add(gline, i);
                    i++;
                }
            }

            //menu
            Console.WriteLine("1) Boy Name\n2) Girl name");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // second menu
                    Console.WriteLine("3) display all names and ranks\n4) Search boys name");
                    choice2 = Int32.Parse(Console.ReadLine());
                    // new switch 
                    switch (choice2)
                    {
                        case 3:
                            foreach (KeyValuePair<string, int> ele in boyRanks)
                            {
                                Console.WriteLine("name: {0} rank: {1}", ele.Key, ele.Value);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Name of child : ");
                            name = Console.ReadLine();
                            foreach (KeyValuePair<string, int> ele in boyRanks)
                            {
                                if (ele.Key == name)
                                {
                                    Console.WriteLine("Found! rank is : Rank {0} and has {1} baby's named after it", ele.Value, ele.Key);
                                }
                                else
                                {
                                    Console.WriteLine("{0} is not ranked among the top 1000 boy names.", name);
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("Bad input");
                            break;
                    }
                    break;
                case 2:
                    // second menu
                    Console.WriteLine("1) display all names and ranks\n2) Search girls name");
                    choice2 = Int32.Parse(Console.ReadLine());
                    // new switch 
                    switch (choice2)
                    {
                        case 1:
                            foreach (KeyValuePair<string, int> ele in girlRanks)
                            {
                                Console.WriteLine("name: {0} rank: {1}", ele.Key, ele.Value);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Name of child : ");
                            name = Console.ReadLine();
                            foreach (KeyValuePair<string, int> ele in girlRanks)
                            {
                                if (ele.Key == name)
                                {
                                    Console.WriteLine("Found! rank is : Rank {0} and has {1} baby's named after it", ele.Value, ele.Key);
                                }
                                else
                                {
                                    Console.WriteLine("{0} is not ranked among the top 1000 girl names.", name);
                                }
                            }
                            break;

                        default:
                            Console.WriteLine("Bad input");
                            break;
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
