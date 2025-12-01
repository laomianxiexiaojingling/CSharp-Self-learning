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
            while (true)
            {
                Console.WriteLine("break之前的代码");
                break;
                Console.WriteLine("break之后的代码");
            }
            Console.WriteLine("循环外的代码");


            //int i = 0;
            //while(true)
            //{
            //    ++i;
            //    Console.WriteLine(i);
            //    if (i == 10)
            //    {
            //        break;
            //    }

            //}
            //Console.WriteLine(i);

            //continue:回到循环开始 继续执行
            //while (true)
            //{
            //    Console.WriteLine("continue前的代码");
            //    continue;
            //    Console.WriteLine("continue后的代码");
            //}
            //Console.WriteLine();

            //打印1到20之间的奇数
            int index = 0;
            while (index <= 20)
            {
                index++;
                if (index % 2 == 0)
                {
                    continue;
                }
                else if(index<=20)
                {
                    Console.WriteLine(index);
                }
                
            }
            #endregion
        }
    }
}
