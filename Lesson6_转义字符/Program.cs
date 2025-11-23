namespace Lesson6_转义字符
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 知识点一 转义字符的使用
            //是字符串的一部分 用来表示一些特殊含义的字符
            #endregion

            #region 各种转义字符
            //固定写法  \字符

            //常用转义字符
            // 单引号  \'
            string str="\'";

            //双引号  \"
            str="\"哈哈哈\"";

            //换行 \n
            str="第一行\n第二行";

            //斜杠 \\ 计算机路径是要用到斜杠的
            str="c:\\abc\\def\\ghi";

            //不常用的转义字符
            //tab 制表符 \t
            //光标退格 \b
            //警报音 \a
            #endregion

            #region 知识点二取消转义字符
            //在字符串前面加上@符号 可以取消转义字符的作用
            string str2=@"c:\abc\def\ghi";

            #endregion
        }
    }
}
