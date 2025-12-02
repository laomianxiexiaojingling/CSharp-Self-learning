namespace Lesson20_循环语句_for语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本语法
            //for(/*初始表达式*/;/*条件表达式*/;/*增量表达式*/ )
            //{
            //    //循环代码逻辑；
            //}

            // 第一个空（初始表达式）：一般声明一个临时变量，用来计数
            //第二个空（条件表达式）：表明进入循环的条件 一个bool类型的结果（bool变量 条件运算符 逻辑运算符）
            //第三个空（增量表达式）：用第一个空中的变量 进行 自增减运算

            //第一次进入循环时 才会调用第一个空中的代码
            //每次进入循环之前 都会判断第二个空中的条件 满足才会进入循环逻辑
            //for( int i=0;i<10 ;i++ )
            //{
            //    Console.WriteLine( i );
            //    //执行完循环语句中的逻辑后
            //    //最后执行第三个空中的代码
            //}

            //for(int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //每个空位 可以按照规则进行书写
            //第一个空位就是申明变量 所以可以连续申明
            //第二个空位 就是进入条件 只要是bool结果的表达式 都可以
            //第三个空位 就是执行一次循环逻辑过后要做的事情 做啥都可以
            //for(int i = 0, j = 0; i < 10 && j < 0; ++i, j = j + 1)
            {

            }
            #endregion

            #region 知识点二 支持嵌套
            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine(i + "_" + j);
            //    }
            //}
            #endregion

            #region 知识点三 特殊写法
            //for选后按 这三个空位可以都空着 跟着需求去填写
            // for循环可以写死循环
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("for循环的死循环");
            //}

            //int k = 0;
            //for (; k < 10;)
            //{
            //    ++k;
            //}

            //for (k = 0; ; ++k)
            //{
            //    if (k >= 10)
            //    {
            //        break;
            //    }
            //}
            #endregion

            #region 知识点四 对比while循环
            //for循环 一般用来可以准确地到一个范围内中的所有数
            for(int i = 0; i < 10; ++i)
            {
                 
            }
            #endregion 

            for (int k=0; k <=100; ++k)
            {
                Console.WriteLine(k);
            }

            int sum = 0;
            for(int i = 0; i <= 100; i = i + 2)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            int Ge = 0;
            int Shi = 0;
            int Bai =0;
           
            for(int i = 100; i <= 999; i++)
            {
                Bai = i / 100;
                Shi = (i % 100)/10;
                Ge = i % 10;
                if (i == Bai * Bai * Bai + Shi * Shi * Shi + Ge * Ge * Ge)
                {
                    Console.WriteLine("{0}是个水仙花数", i);
                }
            }

            for (int i = 1; i < 10; i++)
            {
                for(int k = 1; k <=i; k++)
                {
                 Console.Write("{0}×{1}={2} ", k, i, i * k);
                }
                Console.WriteLine();
            }

            for (int j = 1; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (j == 1 || j == 10)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        if (i == 1 || i == 10)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
                Console.WriteLine();
            }

           

            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                        Console.Write("*");
                }
                Console.WriteLine(" ");
            }

            for (int i = 1; i < 10; i++)
            {
                 for(int k = 1; k <= 10 - i; k++)
                {
                    Console.Write(" ");
                }

                 for(int j = 1; j <= 2*i-1; j++)
                {
                    Console.Write('*');
                }
                 Console.WriteLine();
            }

        }
    }
}
