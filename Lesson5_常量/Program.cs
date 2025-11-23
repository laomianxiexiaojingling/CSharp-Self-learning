namespace Lesson5_常量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 常量的申明
            //关键字 const
            //固定写法
            //const 变量类型 变量名 = 初始值
            //变量的申明
            int i = 10;
            //常量的申明
            const int i2 = 20;

            #endregion

            #region 知识点二 常量的特点
            //1.必须初始化
            //2.不能被修改
            string name;
            name = "123";
            const string myName = "111";

            //常量的作用是申明一些常用不变的变量
            #endregion
        }
    }
}
