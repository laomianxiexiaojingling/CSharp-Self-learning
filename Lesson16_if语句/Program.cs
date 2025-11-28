namespace Lesson16_if语句
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 作用
            //让顺序执行的代码产生分支
            //if语句是第一个可以让我们的代码产生分支的语句

            #endregion

            #region 知识点二 基本语法
            //单分支if语句
            //if(条件表达式)
            //{
            //	语句体;
            //}
            //if语句可以嵌套使用

            //if else语句
            //if(条件表达式)
            //{
            //	语句体1;
            //}
            //else
            //{
            //	语句体2;
            //}
            //产生两条分支 满足条件执行语句体1 不满足条件执行语句体2

            //if else if 语句
            //作用：产生n条分支 多条道路选择 最先满足其中的一个条件 就做什么

            //语法：
            //if（bool类型值）
            //{
            //	语句体1;
            //}
            //else if（bool类型值）
            //{
            //	语句体2;
            //}
            //...
            //多个判断条件，依次判断，满足哪个条件就执行哪个语句体
            #endregion

            Console.WriteLine("今天看了多久电视");
            int time = Convert.ToInt32(Console.ReadLine());
            if (time >= 60)
            {
                Console.WriteLine("今天看视频看了" + time + "分钟，看来你离成功又进了一步");
            }

            Console.WriteLine("请输入你的语文，数学，英语成绩");
            int Chinese = Convert.ToInt32(Console.ReadLine());
            int Math = Convert.ToInt32(Console.ReadLine());
            int English = Convert.ToInt32(Console.ReadLine());
            if ((Chinese > 70 && Math > 80 && English > 90) || (Chinese >= 100 || Math >= 100 || English >= 100) || (Chinese > 90 && (Math >= 70 || English >= 70)))
            {
                Console.WriteLine("非常棒，继续加油");
            }

            Console.WriteLine("请输入赵四的成绩");
            int ZhaoScore = Convert.ToInt32(Console.ReadLine());
            if (ZhaoScore >= 90)
            {
                Console.WriteLine("爸爸奖励100元");
            }
            else
            {
                Console.WriteLine("一个月不能玩游戏");
            }

            Console.WriteLine("请输入两个数");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if ((a % b == 0) || (a + b >= 100))
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("请输入一个整数");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Your input is even");
            }
            else
            {
                Console.WriteLine("Your input is odd");
            }

            Console.WriteLine("请输入三个数");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= num2 && num1 >= num3)
            {
                Console.WriteLine("最大值是：" + num1);
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                Console.WriteLine("最大值是：" + num2);
            }
            else
            {
                Console.WriteLine("最大值是：" + num3);
            }

            Console.WriteLine("请输入");
            int num4 = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (num4 == 1 || num4 == 2 || num4 == 3 || num4 == 4 || num4 == 5 || num4 == 6 || num4 == 7 || num4 == 8 || num4 == 9)
                {
                    Console.WriteLine("是1-9的数字");
                }
               
            }
            catch
            {
                    Console.WriteLine("不是数字");
            }
            

            Console.WriteLine("请输入用户名");
            string admin = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();
            if (admin == "admin" && password == "8888")
            {
                Console.WriteLine("登录成功");
            }
            else if (admin == "admin" && password != "8888")
            {
                Console.WriteLine("用户名不正确");
            }
            else
            {
                Console.WriteLine("密码不正确");
            }

            Console.WriteLine("请用户输入年龄");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine("可以查看");
            }
            else if (age < 13)
            {
                Console.WriteLine("成年人");
            }
            else if (age >= 18 && age < 13)
            {
                Console.WriteLine("请选择是否观看");
                if (Console.ReadLine() == "yes")
                {
                    Console.WriteLine("请查看");
                }
                else if (Console.ReadLine() == "no")
                {
                    Console.WriteLine("退出");
                }

                Console.WriteLine(7);
            }
        }
    }
}
