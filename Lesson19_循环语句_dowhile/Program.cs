namespace Lesson19_循环语句_dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do...while循环");

            #region 知识点一 基本语法
            //while循环 是先判断条件再执行
            // do while 意思是先执行一次循环语句块中的逻辑 在判断是否继续
            //do
            //{
            //    //do while循环语句块
            //} while (bool类型的值);
            ////注意 do while 语句存在一个重要的分号
            #endregion

            #region 知识点二 实际使用
            //do
            //{
            //    Console.WriteLine("");
            //} while (false);

            int a = 1;
            do
            {
                Console.WriteLine();
                ++a;
            } while (a < 2);
            //如果有continue，会回到while判断的地方
            #endregion

            //    do
            //    {
            //        Console.WriteLine("请输入用户名和密码");
            //        string Username= Console.ReadLine();
            //        string Password= Console.ReadLine();
            //        if (Username != "admin")
            //        {
            //            Console.WriteLine("用户名错误");
            //            continue;
            //        }
            //        else if (Password != "8888")
            //        {
            //            Console.WriteLine("密码错误");
            //            continue;
            //        }
            //        break;
            //    } while (true);
            //    Console.WriteLine("登陆成功");

            string Username = "";
            string Password = "";
            bool isShow = false;
            do
            {
                if (isShow)
                {
                    Console.WriteLine("用户名或密码错误，请重新输入");
                }

                Console.WriteLine("请输入用户名");
                Username = Console.ReadLine();
                Console.WriteLine("请输入密码");
                Password = Console.ReadLine();
                isShow = true;
            }while (Username!="admin"||Password!="admin");
        }

    }
}
