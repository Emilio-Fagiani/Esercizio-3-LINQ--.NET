using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_3_LINQ__.NET
{
    public class RandomNumber
    {
        public List<int> GenerateRandomNum(int num)
        {
            Random random = new Random();
            List<int> listInt = new List<int>();
            for (int i = 0; i < num; i++)
            {
                int randomNum = random.Next();
                listInt.Add(randomNum);
               // Console.WriteLine(listInt[i]);
            }
            return listInt;
        }
    }
}
