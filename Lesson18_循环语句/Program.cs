namespace Lesson18_循环语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 作用
            //让顺序执行的代码可以不停的循环执行某一代码块的内容
            //条件分支语句 是 让代码产生分支
            //循环语句 是 让代码可以被重复执行
            #endregion

            #region 知识点二 语法相关
            //bool 类型变量 条件运算符 逻辑运算符
            //while (bool类型的值)
            //{
            //    当满足条件的时候 就会执行while语句当中的内容
            //        当代码执行完毕 会回到while循环的开头
            //        再次进行条件判断
            //}

            //死循环
            //不停的执行循环中的逻辑
            //while (true)
            //{
            //    Console.WriteLine("11");
            //}

            //计算一个为0的整形变量 让他只能累加1 不停的加到10为止
            //int i = 0;
            ////bool类型的值 还可以用逻辑运算符&& || ！ 条件运算符 算术运算结合
            //while (i < 10)
            //{
            //    ++i;
            //}
            //Console.WriteLine(i);
            #endregion

            #region 知识点三 嵌套使用
            //不仅可以嵌套if switch 还可以嵌套while
            int a = 0;
            int b = 0;
            while (a < 10)
            {
                ++a;
                while (b < 10)
                {
                    ++b;
                }
            }

            int a2 = 0;
            while (a2 < 10)
            {
                ++a2;

                //每次从外层循环进来是
                //b2和上一次的b2没有关系
                int b2 = 0;
                while (b2 < 10)
                {
                    ++b2;
                }
                 
        }

            #endregion

            #region 知识点四 流程控制关键字
            //作用：控制循环逻辑的关键词
            //break：跳出循环
            //while (true)
            //{
            //    Console.WriteLine("break之前的代码");
            //    break;
            //    Console.WriteLine("break之后的代码");
            //}
            //Console.WriteLine("循环外的代码");


            ////int i = 0;
            ////while(true)
            ////{
            ////    ++i;
            ////    Console.WriteLine(i);
            ////    if (i == 10)
            ////    {
            ////        break;
            ////    }

            ////}
            ////Console.WriteLine(i);

            ////continue:回到循环开始 继续执行
            ////while (true)
            ////{
            ////    Console.WriteLine("continue前的代码");
            ////    continue;
            ////    Console.WriteLine("continue后的代码");
            ////}
            ////Console.WriteLine();

            ////打印1到20之间的奇数
            //int index = 0;
            //while (index <= 20)
            //{
            //    index++;
            //    if (index % 2 == 0)
            //    {
            //        continue;
            //    }
            //    else if(index<=20)
            //    {
            //        Console.WriteLine(index);
            //    }

            //}
            #endregion

            int num = 0;
            //while(num <= 100){
            //    Console.WriteLine(num);
            //    num++;
            //}

            //Console.WriteLine("在控制台输出1-100之间所有整数的和");
            //num = 0;
            //int sum = 0;
            //while (num <= 100)
            //{
            //    sum = sum + num;
            //    num++;
            //}
            //Console.WriteLine("1到100之间所有整数的和"+sum);

            //Console.WriteLine("1到100之间的除了能被7整除之外所有整数的和");
            //num = 0;
            //sum = 0;
            //while (num <= 100)
            //{
            //    if (num % 7 != 0)
            //    {
            //        sum = sum + num;
            //        num++;
            //    }
            //    else
            //    {
            //        num++;
            //        continue;
            //    }
            //}
            //Console.WriteLine("1到100之间的除了能被7整除之外所有整数的和" + sum);

            //Console.WriteLine("请输入一个数，判断是不是素数");
            //try
            //{
            //    int Sushu = int.Parse(Console.ReadLine());
            //    int Chushu=2;
            //    while (true)
            //    {
            //        if (Chushu != Sushu)
            //        {
            //            if (Sushu % Chushu == 0)
            //            {
            //                Console.WriteLine("不是素数");
            //                break;
            //            }
            //            else
            //            {
            //                Chushu++;
            //                continue;
            //            }

            //        }
            //        else
            //        {
            //            if (Sushu == 1)
            //            {
            //                Console.WriteLine("不是素数");
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("是素数");
            //                break;
            //            }
                            
            //        }
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("输入的不是数字");
            //}


            //Console.WriteLine("请输入用户名和密码");
            //string Name= Console.ReadLine(); ;
            //string Password= Console.ReadLine();
            //while (Name != "admin" || Password != "8888")
            //{
            //    if (Name != "admin")
            //    {
            //        Console.WriteLine("用户名所悟，请重新输入用户名");
            //        Console.WriteLine("请重新输入密码");
            //        Name =Console.ReadLine();
            //        Password = Console.ReadLine();
            //        continue;
            //    }
            //    else
            //    {   
            //        Console.WriteLine("密码错误，请重新输入密码");
            //        Password=Console.ReadLine();
            //        continue;
            //    }  
            //}

            //Console.WriteLine("请输入班级总人数");
            //try
            //{
            //    int Memeber = Convert.ToInt32(Console.ReadLine());
            //    int No = 1;
            //    int sum1 = 0;
            //    int Score;
            //    while (No <= Memeber)
            //    {
            //        Console.WriteLine("现在是{0}号学员", No);
            //        Score = Convert.ToInt32(Console.ReadLine());
            //        No++;
            //        sum1 += Score;

            //    }
            //    int avg = sum1 / Memeber;
            //    Console.WriteLine("平均成绩是{0}，总成绩是{1}", avg, sum1);
            //}
            //catch
            //{

            //}


            int sum2 = 0;
            while (num <= 100)
            {
                if (sum2 <= 500)
                {
                    sum2 = sum2 + num;
                    num++;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine("累加到数字{0}可以使sum大于500", num);

            int People = 100;
            float IncreaseRate = 0.2f;
            int Month = 0;
            while (People < 1000)
            {
                People = Convert.ToInt32(People * (1 + IncreaseRate));
                Month++;
            }
            Console.WriteLine("经历了{0}个月看唐老师视频的同学能达到1000人", Month);
        }
    }
}
