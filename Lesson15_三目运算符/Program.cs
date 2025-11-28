namespace Lesson15_三目运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 基本语法
            //套路：3个空位 2个符号！！！
            //变量 = 条件运算符 ? 值1 : 值2;
            //关键信息：bool类型？bool类型为真返回的内容：bool类型为假返回的内容
            //三目运算符 会有返回值，这个返回值类型必须一致，并且必须使用
            #endregion

            #region 知识点二 三目运算符的应用
            string str=true? "你是对的":"你是错的";
            Console.WriteLine(str);//你是对的

            int a = 5;
            str =a>1? "a满足条件":"a不满足条件";
            Console.WriteLine(str);//a大于1

            //第一个空位 始终是结果为bool类型的表达式 bool变量 条件表达式 逻辑运算符表达式
            //第二个空位 和第三个空位 必须是相同类型

            bool b = a > 3 ? a > 6 : !false; 
            Console.WriteLine(b);//False
            #endregion

            int e = 1;
            int f = 2;
            b= e > f ? true : false;

            Console .WriteLine("请用户输入姓名");
            string username=Console.ReadLine();
            Console.WriteLine(username);
            string sex = username=="帅哥"?"帅哥":"美女";
            Console.WriteLine(sex);

            Console.WriteLine("请输入学生姓名");
            Console.ReadLine();
            Console.WriteLine("请输入学生的语文成绩");
            int Chinese = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入你的C#成绩");
            int CSharp = Convert.ToInt32(Console.ReadLine());
            string level = (Chinese >= 90 && CSharp >= 90) ? "毕业" : "不毕业";
            Console.WriteLine("学生的毕业情况是：" + level);

            Console.WriteLine("请输入年份");
            int year=Convert.ToInt32(Console.ReadLine());
            string isLeapYear=(year%400==0||(year%4==0&&year%100!=0))?"是闰年":"不是闰年";
            Console.WriteLine(isLeapYear);
        }
    }
}
