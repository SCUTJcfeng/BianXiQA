using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
百鸡问题：100元钱买100只鸡，如何买？已知条件：鸡母每只3元，鸡公每只1元，鸡仔每3只1元。
鸡兔同笼问题：鸡兔在同一笼子中，共有头30只，共有脚100只，问鸡兔又有几只？
百分币问题：要给人100分币有多少种方案。已知分币的种类有1分、2分、5分、10分、50分共5种。
佩尔方程： 某将领的军队有29个方阵（人数为平方），如果他也参与其中，则可以排成一个大方阵，请问他有多少军队？
*/


namespace BianXiQA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Baiji(100, 100);
            //Jitu(30, 100);
            //Ahundred(100);
            PellEquation(29);
            Console.ReadLine();
        }

        static void Baiji(int sum, int money)
        {
            int count = 0;
            for (int i = 0; i <= sum / 3; i++)
                for (int j = 0; j <= sum; j++)
                    for (int k = 0; k / 3 <= sum; k += 3)
                        if (money == i * 3 + j + k / 3 && sum == i + j + k)
                        {
                            count++;
                            Console.WriteLine("母鸡有{0}只，公鸡有{1}只，鸡仔有{2}只", i, j, k);
                        }
            Console.WriteLine("共有{0}种方案", count);
        }

        static void Jitu(int head, int foot)
        {
            int count = 0;
            for (int i = 0; i <= head; i++)
                for (int j = head - i; j <= head; j++)
                    if (foot == i * 2 + j * 4 && head == i + j)
                    {
                        count++;
                        Console.WriteLine("鸡有{0}只，兔有{1}只", i, j);
                    }
            Console.WriteLine("共有{0}种方案", count);
        }

        static void Ahundred(int sum)
        {
            int count = 0;
            for (int i = 0; i <= sum; i++)
                for (int j = 0; j <= sum / 2; j++)
                    for (int k = 0; k <= sum / 5; k++)
                        for (int l = 0; l <= sum / 10; l++)
                            for (int m = 0; m <= sum / 50; m++)
                                if (sum == i + j * 2 + k * 5 + l * 10 + m * 50)
                                {
                                    count++;
                                    Console.WriteLine("1分有{0}个，2分有{1}个，5分有{2}个，10分有{3}个，50分有{4}个", i, j, k, l, m);
                                }
            Console.WriteLine("共有{0}种方案", count);
        }

        static void PellEquation(int num)
        {
            int count = 0;
            for (ulong i = 1; i < 100000; i++)
                if (Math.Sqrt(i * i * (ulong)num + 1) == Math.Round(Math.Sqrt(i * i * (ulong)num + 1)))
                {
                    count++;
                    Console.WriteLine("每个方阵的行列各{0}人，方阵总人数为{1}", i, i * i * 29);
                }
            Console.WriteLine("总计{0}种方案", count);
        }
    }
}
