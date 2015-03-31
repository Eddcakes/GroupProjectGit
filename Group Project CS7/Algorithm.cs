using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project_CS7
{
    class Algorithm
    {
        public string Encryptor(string userInput)
        {
            Seed_Generator seedCheck = new Seed_Generator();
            string encryptionOutput = "";
            int enSeed = seedCheck.seed();
            while (enSeed > 95 * 95)
                enSeed = enSeed / 95;

            int temp = 0;

            foreach (char letter in userInput)                      //Here will be the method added to encrypt the user's input.
            {
                for (int i = enSeed + Convert.ToInt32(letter); i > 0; i--)
                {
                    temp++;
                    if (temp > 95)
                        temp = 0;
                }
                encryptionOutput = encryptionOutput + Convert.ToChar(temp + 32);
            }
            return encryptionOutput;
        }
    }
}
