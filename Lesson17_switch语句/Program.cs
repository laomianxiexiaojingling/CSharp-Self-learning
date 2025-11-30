using System.Linq.Expressions;

namespace Lesson17_switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 作用
            //让顺序执行的代码产生分支
            #endregion

            #region 语法
            switch (1)
            {
                //变量==常量 执行case和break之间的代码
                case 0:
                    //满足条件的代码逻辑
                break;

                case 1:
                    
                break;

                default: 

            }
            //注意：常量！ 只能写一个值 不能去写一个范围 不能写条件运算符 逻辑运算符
            //switch只判断变量是否等于某一个固定值

            int a = 3;
            switch (a)
            {
                //条件一定是常量
                case 1:
                    Console.WriteLine("a=1");
                    break;

                case 2:
                    Console.WriteLine("a=2");
                    break;

                case 3:
                    Console.WriteLine("a=3");
                    break;

                default:
                    Console.WriteLine("什么条件都不满足，执行default中的内容 ");
                    break;
            }

            float f = 1.4f;
            //一般是配合枚举使用
            switch (f)
            {
                case 1.5f:
                    Console.WriteLine("f等于1.5");
                    break;

                case 1:
                    Console.WriteLine  ("f等于1.5");
                    break;

                default:
                    Console.WriteLine("f什么条件都不满足，执行default里的语句");
                    break;
            }
            #endregion

            #region default可省略
            string str = "123";
            switch (str)
            {
                case "123":
                    Console.WriteLine("等于123");
                    break;

                case "234":
                    Console.WriteLine("等于234");
                    break;
            }
            #endregion

            #region 可自定义常量
            const char c = 'A';
            switch (c)
            {
                case c:
                    break;
                default:
                    break;
            }
            #endregion

            #region 贯穿
            //作用：满足某些条件的时候 作地事情是一样的 就可以贯穿
            int aa = 1;
            switch (aa)
            {
                //不写case后面配对的break 就叫做贯穿
                //满足1342其中一个条件 就会执行之后的代码
                case 1:
                case 2:
                    //case和break之间可以写n句语句
                    //并且可以嵌套使用
                Console.WriteLine("是个数字");
                    break;
                default:
                    break;
            }
            #endregion

            Console.WriteLine("唐老师的工资是由基本工资+绩效决定");
            Console.WriteLine("请输入学生对于唐老师的评价");
            int Gongzi = 4000;
            int Jixiao;
            char Grade=Convert.ToChar(Console.ReadLine());
            switch (Grade)
            {
                case 'A':
                    Console.WriteLine("很兴奋");
                    Jixiao = 500;
                    Gongzi += Jixiao;
                    break;

                case 'B':
                    Console.WriteLine("很充实");
                    Jixiao = 0;
                    Gongzi += Jixiao;
                    break;

                case 'C':
                    Console.WriteLine("还好吧");
                    Jixiao = -300;
                    Gongzi += Jixiao;
                    break;
                case 'D':
                    Console.WriteLine("难理解");
                    Jixiao = -500;
                    Gongzi += Jixiao;
                    break;

                case 'E':
                    Console.WriteLine("枯燥乏味");
                    Jixiao = -800;
                    Gongzi += Jixiao;
                    break;

               
            }

            Console.WriteLine("唐老师这个月工资加绩效是" + Gongzi);

            Console.WriteLine("你带了多少钱");
            int Money=int.Parse(Console.ReadLine());
            Console.WriteLine("请选择你要哪种咖啡");
            int Type1 = 5;
            int Type2 = 7;  
            int Type3 = 11;
            string Type = Console.ReadLine();
            switch (Type)
            {
                case "中杯":
                    Console.WriteLine("你选择的是中杯，需要5元");
                    if (Money > 5)
                    {
                        Console.WriteLine("购买成功");
                        Money -= 5;
                        Console.WriteLine("还剩" + Money+"yuan");
                    }
                    else
                    {
                        Console.WriteLine("钱不够");
                    }
                    break;

                case "大杯":
                    Console.WriteLine("你选择的是大杯，需要7元");
                    if (Money > 7)
                    {
                        Console.WriteLine("购买成功");
                        Money -= 7;
                        Console.WriteLine("还剩" + Money + "yuan");
                    }
                    else
                    {
                        Console.WriteLine("钱不够");
                    }
                    break;

                case "超大杯":
                    Console.WriteLine("你选择的是超大杯杯，需要11元");
                    if (Money > 11)
                    {
                        Console.WriteLine("购买成功");
                        Money -= 11;
                        Console.WriteLine("还剩" + Money + "yuan");
                    }
                    else
                    {
                        Console.WriteLine("钱不够");
                    }
                    break;
            }


            Console.WriteLine("输入学生的考试成绩");
            int Score= Convert.ToInt32(Console.ReadLine());
            int Level = Score / 10;

            switch (Level)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("E");
                    break;
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
               
            }

            Console.WriteLine("请在0-9中输入一个数字");
            try
            {
                int num = Convert.ToInt32(Console.ReadKey().KeyChar.ToString());
                switch (num)
                {
                    case 0:
                        Console.WriteLine("零");
                        break;
                    case 1:
                        Console.WriteLine("一");
                        break;
                    case 2:
                        Console.WriteLine("二");
                        break;
                    case 3:
                        Console.WriteLine("三");
                        break;
                    case 4:
                        Console.WriteLine("四");
                        break;
                    case 5:
                        Console.WriteLine("五");
                        break;
                    case 6:
                        Console.WriteLine("六");
                        break;
                    case 7:
                        Console.WriteLine("七");
                        break;
                    case 8:
                        Console.WriteLine("八");
                        break;
                    case 9:
                        Console.WriteLine("九");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("输入错误，请输入一个数字");

            }  
            
        }
    }
} 
