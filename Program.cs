using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            string encriptKey = "qqwwasezxrwetsdyxcueridfocvprtafgsvbdtyfghgbnhyujhjknmluizjkxikcklvlpbqenadmzc1wr2sf3xv4et5dg6cb7ry8fh9vn0tu";
            string password = "sraka";
            string encrPass = "";
            for (int i = 0; i <= password.Length; i++)
            {
                string letter = password[i].ToString();

                for(int j = 0; j < encriptKey.Length; j += 3)
                {
                    string tempEncript = encriptKey[j].ToString();

                    if (letter == tempEncript)
                    {
                        string temp = encriptKey[j + 1].ToString() + encriptKey[j + 2].ToString();
                        encrPass = encrPass + temp;
                    }
                }
                if (i == password.Length - 1) break;
            }
            encrPass = encrPass + "oo";


            for (int k = 0; k > -1; k++)
            {
                if (k % 3 == 0) continue;
                encrPass = encrPass + encriptKey[k];
                if (encrPass.Length == 180) break;
                if (k == encriptKey.Length-1) k = 0;
            }
            Console.WriteLine(password);
            Console.WriteLine(encrPass);
            Console.WriteLine(encrPass.Length);
            Console.ReadKey();
        }
    }
}
