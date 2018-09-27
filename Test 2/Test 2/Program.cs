using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Bird
    {
        // defining variables
        string name;
        string species;
        string sex;
        string weight;
        string bandno;
        //getters and setters
        public string Name { get { return name; } set { name = value; } }
        public string Species { get { return species; } set { species = value; } }
        public string Sex { get { return sex; } set { sex = value; } }
        public string Weight { get { return weight; } set { weight = value; } }
        public string Bandno { get { return bandno; } set { weight = value; } }



        public Bird (string _name, string _species, string _sex, string _weight, string _bandno )
        {
            //assigning new information to bird 1
            if (_name == "unknown")// for setting defaults
            {
                name = "unknown";
                species = "unknown";
                sex = "unknown";
                weight = "unknown";
                bandno = "unknown";
                Console.WriteLine("Bird object created and default data loaded...");
            }
            //for assigned information
            name = _name;
            species = _species;
            sex = _sex;
            weight = _weight;
            bandno = _bandno;
            
        }
        
       public string DisplayBird ()
        {
            //Program to display Birds data
            

                Console.WriteLine("BIRD OF PREY DATA OUTPUT");
                Console.WriteLine("Birdname: " + name);
                Console.WriteLine("Species: " + species);
                Console.WriteLine("Sex: " + sex);
                Console.WriteLine("Weight: " + weight);
                Console.WriteLine("BandNumber+ " + bandno);
            return "";

            
            
            
        }


        


              

    }

    class Program
    {
        static void Main(string[] args)
            //Program to aid in managing birds for Wingspan National Bird of Pray Centre by Aaron Hansen 
        {   string newname = "";
            string newspecies = "";
            string newsex = "";
            string newweight  = "";
            string newbandno  = "";
            Bird bird1 = new Bird(newname, newspecies, newsex, newweight, newbandno);
            
            Console.WriteLine("PLEASE UPDATE BIRD DATA");
            Console.ReadLine();
            // Providing new details for bird1
            Console.Write("Enter Bird name:");
            newname = Console.ReadLine();
            Console.Write("Enter Bird species:");
            newspecies = Console.ReadLine();
            Console.Write("Enter Bird sex:");
            newsex = Console.ReadLine();
            Console.Write("Enter Bird weight (###grams):");
            newweight = Console.ReadLine();
            Console.Write("Enter Bird band number:");
            newbandno = Console.ReadLine();
            bird1 = new Bird(newname, newspecies, newsex, newweight, newbandno);
            Console.ReadLine();
            bird1.DisplayBird();
            
            Console.ReadLine();
        }
    }
}
