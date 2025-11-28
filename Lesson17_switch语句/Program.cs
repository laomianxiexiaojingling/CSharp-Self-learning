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
        }
    }
} 
