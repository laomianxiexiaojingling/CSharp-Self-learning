namespace Lesson3_变量的本质
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量本质");
            #region 知识点一
            //通过sizeof方法 可以获取变量类型所占的内存空间（字节）
            int size = sizeof(int);
            Console.WriteLine("int型变量所占用的空间"+size);
            #endregion

            #region 知识点二
            //二进制表示0和1
            //1byte=0000 0000 一个字节为8位
            #endregion

            #region 常用14个变量类型
            //sbyte int long short uint ulong ushort float double
            //string char bool decimal byte
            #endregion
        }
    }
}
