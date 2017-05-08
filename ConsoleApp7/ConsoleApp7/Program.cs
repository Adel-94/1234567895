using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)

        {
      
            int n,m;
            Console.Write("birinci intervali daxil edin :  ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("ikinci intervali daxil edin :  ");
            m = Convert.ToInt32(Console.ReadLine());
            for ( int j= n; j <=m; j++)
               
            {
                string b = j.ToString();
                int z = 0;
                for (int i = 1; i < b.Length; i++)
                {
                    if ((int)(b[i] - b[i - 1]) == 1)

                    {
                        z++;
                    }
                }

                if (z == b.Length - 1)
                {
                    Console.WriteLine(j);
                }
                
            }
            Console.ReadKey();
        }
    }
}
