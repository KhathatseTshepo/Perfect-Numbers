using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int iUpperLimit = 10000;

            List<int> lstFactor = new List<int>();

            for (int i = 1; i <= iUpperLimit; i++)
            {
                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        lstFactor.Add(k);
                    }
                    if (k == i - 1)
                    {
                        if (lstFactor.Sum() == i)
                        {

                            Console.WriteLine("{0,8} is a perfect number ", i);
                            lstFactor.Clear();
                            break;
                        }
                        else
                        {
                            lstFactor.Clear();
                        }
                    }
                }
            }
            Console.ReadKey();


        }
    }
}
