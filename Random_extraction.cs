using System;



    class Program
    {
        static void Main(string[] args)
        {
            Random k = new Random();
            double DD;
            DD = k.NextDouble(); // >= 0 && < 1 的 double
            Console.WriteLine("DD == " + DD);
            string[] P;

            P = new string[] { "皮卡丘", "水箭龜", "妙蛙種子", "小火龍" };

            Console.WriteLine("????????????????????????????");
            for(int i = 0; i < P.Length; i++)
            {
                Console.Write(" " + P[i]);
            }
            Console.WriteLine();
            Console.WriteLine("###############################");

            // fix #1 隨機抽出每一個
            int Left = P.Length;
            {
                Left = P.Length;
                for(int i = 0; i<P.Length; i++)
                {
                    DD = k.NextDouble();
                    int index = (int)(Left * DD); //轉型成 int
                    Console.WriteLine(index);
                    Console.Write(" " + P[index]);
                    //對調
                    {
                        string 記下 = P[index];
                        P[index] = P[Left - 1];
                        P[Left - 1] = 記下;
                    }

                    Left -= 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$");
            {
                Left = P.Length;
                for(int i = 0; i<P.Length; i++)
                {
                    DD = k.NextDouble();
                    int index = (int)(Left * DD);
                    Console.WriteLine(index);
                    Console.Write(" " + P[index]);
                    // 對調
                    {
                        string 記下 = P[index];
                        P[index] = P[Left - 1];
                        P[Left - 1] = 記下;
                    }
                    Left -= 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }

