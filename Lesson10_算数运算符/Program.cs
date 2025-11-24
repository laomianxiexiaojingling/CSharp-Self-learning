namespace Lesson10_算数运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //赋值运算符 =

            //算数运算符 + - * / %

            int age = 23;
            age = age + 10;
            Console.WriteLine("十年后的年龄是" + age);

            float Π= 3.14f;
            int r = 5;
            float area=Π*r*r; 
            float circumference=2*Π*r;
            Console.WriteLine("半径为5的圆的面积是"+area);
            Console.WriteLine("半径为5的圆的周长是"+circumference);

            int CsharpScore = 90; ;
            int UnityScore = 85;
            int MathScore = 95;
            int totalScore = CsharpScore + UnityScore + MathScore;
            float averageScore = totalScore / 3.0f;
            Console.WriteLine("三门课的总分是" + totalScore);
            Console.WriteLine("三门课的平均分是" + averageScore);

            int TshirtPrice = 285;
            int TrousersPrice = 720;
            int TotalMoney = 2 * TshirtPrice + 3 * TrousersPrice;
            Console.WriteLine("购买2件T恤和3条裤子一共需要" + TotalMoney + "元");
            float DiscountedPrice = TotalMoney * 0.38f;
            Console.WriteLine("打3.8折后需要支付" + DiscountedPrice + "元");

            //i++的意思是先使用i的当前值，然后将i的值增加1。
            //++i的意思是先将i的值增加1，然后使用增加后的值。
            //31
            //30
            //a++=10 ++b=21 a++=11
            //42

            int a = 99;
            int b = 87;
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("交换后a的值是" + a);
            Console.WriteLine("交换后b的值是" + b);

            int TotalSecond = 987652;
            int Days = TotalSecond / 86400;
            int hours = (TotalSecond % 86400) / 3600;
            int minutes = (TotalSecond % 86400%3600) / 60;
            int seconds = TotalSecond % 86400 % 3600 % 60;
            Console.WriteLine("987652秒是" + Days + "天" + hours + "小时" + minutes + "分钟" + seconds + "秒");

        }
    }
}
