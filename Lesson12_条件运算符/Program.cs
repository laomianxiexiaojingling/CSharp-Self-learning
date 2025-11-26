namespace Lesson12_条件运算符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 条件运算符
            //用于比较两个变量或常量
            //> < >= <= == != 判断两个值的关系

            //条件运算符 左右两边一定存在可比较的内容
            //左边内容 条件运算符 右边内容
            //不能直接使用条件运算符
            int a = 10;
            int b = 10;
            //a>b false
            //比较的结果是一个布尔值 true false
            //true和false 如果比较的条件满足 那就返回true 否则返回false
                        Console.WriteLine(a > b);//false

            #endregion

            #region 知识点二 各种应用写法
            //变量和变量的比较
            a = 5;
            b = 10;
            bool result;
            result = a < b;
            //变量和数值（常量）比较
            result = a < 10;
            result = b > 5;
            

            //计算结果之间的比较
            //条件运算符的优先级 低于 算数运算符
            //8>6
            //先计算后比较
            result = a + 3 > a - 2 + 3;

            #endregion

            #region 知识点三 不能进行范围的比较
            //在C#中 不支持范围的比较
            //result = 1 < a < 6;
            //要判断 一个变量是否在两个数之间要结合逻辑运算符的知识点
            #endregion

            #region 知识点四 不同类型之间的比较

            //不同数值类型之间 可以随意进行条件运算符比较
            int i = 5;
            float f = 1.2f;
            double d = 3.4;
            short s = 2;
            byte by = 4;
            uint ui = 6;
            //只要是数值就能够进行条件运算符比较 比较大于小于等于等等
             result = i > f;
            result = f > d;
            result = f > s;
            result = f > by;
            result = f > ui;

            //特殊类型 char string bool 只能同类型==和！=比较
            string str = "123";
            char c = 'A';
            bool bo = true;

            result = str == "123";
            result =str=="abc";
            result = str != "123";

            result = c == 'A';

            result = bo==false;
            #endregion

            //false
            //false
            //false
            //false
            //false
            //true
            //false
            //true
            //true
            //true

        }
    }
}
