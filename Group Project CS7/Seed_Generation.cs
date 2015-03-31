using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Group_Project_CS7
{
    class Seed_Generator
    {
        public int seed()
        {
            int key = 0; //returned value of the seed.

            try
            {
                using (StreamReader sr = new StreamReader("seed.txt")) //will try to open the file containing the seed. If it cannot be openned, it'll initiate the catch exception.
                {
                    String line = sr.ReadToEnd(); //reads the seed.
                    key = Convert.ToInt32(line); //converts the string of the seed into an int, which is then return to the Main.
                }
            }
            catch (Exception e) //If the file cannot be openned, this will be run
            {
                string text = randomNumberGenerator(); //creates a string of eight random numbers.
                System.IO.File.WriteAllText(@"C:\Users\computing\Desktop\Group Project CS7\Group Project CS7\bin\Debug\seed.txt", text); //creates a new pernament file containing the seed.
                key = Convert.ToInt32(text); //converts the string of the seed into an int, which is then returned to the Main.
            }
            return key;
        }

        private string randomNumberGenerator() //creates a series of eight random ints and converts it into a string for storage.
        {
            string finalGeneration = "";
            int current = 0;
            Random rnd = new Random();

            for (int i = 0; i < 8; i++) //will repeat the following code eight times.
            {
                current = rnd.Next(10);
                finalGeneration = finalGeneration + Convert.ToString(current); //each time this code is run, it adds a random int between and including 0 to 9 and add it to the final seed.
            }

            return finalGeneration;
        }
    }
}