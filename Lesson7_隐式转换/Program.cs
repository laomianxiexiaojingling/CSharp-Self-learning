namespace Lesson7_隐式转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 相同大类型之类的转换
            //有符号 long ->int-> short-> sbyte
            long l = 1;
            int i = 1;
            short s = 1;
            sbyte sb = 1;
            //隐式转换 int隐式转换成了long
            l = i;//正确 可以用大类型隐式装小类型

            //i =l; //错误 不能将小类型隐式转换成大类型
            l=s;//正确
            l=sb;//正确
            s=sb;//正确
            //sb = i;//错误
            //sb = s;//错误


            //无符号 ulong -> uint -> ushort -> byte
            ulong ul = 1;
            ulong v = 1;
            ushort us = 1;
            byte b = 1;
            //隐式转换 uint隐式转换成了ulong
            ul = v;//正确 可以用大类型隐式装小类型
            //v=ul; //错误 不能将小类型隐式转换成大类型
            ul=us;//正确
            ul=b;//正确
            us=b;//正确

            //b = v;//错误

            //浮点数  decimal没有办法通过隐式转换存储double和float double-> float

            //特殊类型之间不存在隐式转换

            #endregion

            #region 知识点二 不同大类型之间的转换

            #region 有符号和无符号之间的转换
            //无符号 不能装负数
            byte b2 = 1;
            ushort us2 = 1;
            uint ui2 = 1;
            ulong ul2 = 1;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;


            //无符号装有符号
            //有符号的变量是不能够隐式转换成无符号的
            //b2=sb2;
            //us2=sb2;

            //有符号装无符号
            //有符号变量是可以装无符号便令的 前提是范围一定是要覆盖的 存在隐式转换
            //i2 = ui2;//因为 有符号的变量可能会超过无符号的变量范围
            i2 = b2;//因为 有符号的变量 不管是多少 都在无符号变量的范围内

            #endregion

            #region 整数和浮点数之间的转换
            //整数可以隐式转换成浮点数

            //浮点数不能隐式转换成整数
            #endregion
            #endregion

            #region 知识点三 char类型的隐式转换
            char c = 'A';
            int ic = c;//正确 char可以隐式转换成int
            long lc = c;//正确 char可以隐式转换成long
            float fc = c;//正确 char可以隐式转换成float
            double dc = c;//正确 char可以隐式转换成double

            //char能够隐式转换成这些类型 是因为char本质上是一个整数类型
            //char是一个无符号的整数类型 范围是0~65535 所以可以隐式转换成比它宽度更大的类型的数值类型
            //char是用于表示Unicode字符的类型 对应的数字其实是一个ASCII码
            #endregion

            //总结 隐式转换规则
            //1.相同大类型之间可以隐式转换 大类型可以隐式装小类型
            //double->float->long->int->short->sbyte
            //ulong->uint->ushort->byte
            //2.不同大类型之间 有符号类型不能隐式转换成无符号类型 有符号类型可以隐式转换成无符号类型 前提是范围要覆盖
            //decimal->整数类型->char
            //string和bool不参与隐式转换

        }
    }
}
