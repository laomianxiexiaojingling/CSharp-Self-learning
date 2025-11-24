namespace Lesson9_异常捕获
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 作用
            //作用 捕获程序运行过程中出现的异常 并进行处理 避免程序崩溃
            string str = Console.ReadLine();
            //Parse转字符串为数值类型 必须要合法合规
            int i = int.Parse(str);



            #endregion

            #region 基本语法
            try
            {
                //可能出现异常的代码
                //报错的时候就不会卡死
            }
            catch (Exception e)
            {
                //如果出错了 会执行这里的代码捕获异常
                //catch(expection e)具体报错跟踪 通过e得到 具体的错误信息
            }
            //可选部分
            finally
            {
                //最后执行的代码，不管有没有出错都会执行
            }
            //注意：异常捕获代码基本结构种 不需要加；再里面去写代码逻辑的时候，每一句代码才加；

            #endregion

            Console.WriteLine("请输入一个数字");
            try
            {
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine($"你输入的数字是n" + num);
            }
            catch
            {
                Console.WriteLine("输入有误，请输入一个合法的数字");

            }
            finally
            {
                Console.WriteLine("无论是否出错，都会执行这里的代码");
            }

            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your Chinese score,Math Score,English Score");
            try
            {
                int Chinese = int.Parse(Console.ReadLine());
                int Math = int.Parse(Console.ReadLine());
                int English = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的成绩有误，请输入合法的数字");
            }
            finally
            {
                Console.WriteLine("感谢使用本系统");

            }
        }
    }
}
