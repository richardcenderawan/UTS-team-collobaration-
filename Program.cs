using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSTeamCollab
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("jika x = 4 dan n = 100 maka jawabannya adalah : " + SumX(4, 100));
            Console.WriteLine("jika x = 3 dan n = 10 maka jawabannya adalah  : " + SumX(3, 10));
            Console.WriteLine("jika x = 1 dan n = 10 maka jawabannya adalah  : " + SumX(1, 10));
            Console.WriteLine("jika x = -1 dan n = 10 maka jawabannya adalah  : " + SumX(-1, 10));
            Console.WriteLine("jika x = -20 dan n = 1000 maka jawabannya adalah  : " + SumX(-20, -1000));
        }

        public static int SumX(int x, int N)
        {
            int jawaban = 0;
            if (x < -1000 || x > 1000 || N < -1000 || N > 1000)
            {
                Console.WriteLine("Tidak bisa !!");
            }
            else
            {
                if (x < 0 && N >= 0)
                {
                    jawaban = 0;
                }

                else if (x >= 0 && N >= 0)
                {
                    int temp = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        if (i % x == 0)
                        {
                            temp += i;
                        }
                    }
                    jawaban = temp;
                }
                else if (x > 0 && N <= 0)
                {
                    jawaban = 0;
                }
                else if (x == 0)
                {
                    jawaban = 0;
                }
                
                else if (x < 0 && N < 0)
                {
                    int temp = 0;
                    for (int i = 1; i <= N * -1; i++)
                    {
                        if (i % x * -1 == 0)
                        {
                            temp += i;
                        }
                    }
                    jawaban = temp * -1;
                }
            }
            return jawaban;
        }
    }
}