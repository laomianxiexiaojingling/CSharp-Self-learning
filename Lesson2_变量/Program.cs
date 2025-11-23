//引用命名空间
using System;


//命名空间
namespace Lesson2_变量
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //知识点一 折叠代码
            //主要作用 代码逻辑清晰
            //与#region #endregion配对出现
            //本质是编辑器提供的预处理指令，发布代码的时候自己会删除后再运行
            #region 知识点二 如何申明变量
            //变量就是存储各种不同类型值的容器
            //不同类型的变量可以储存不同类型的值
            int i=1;
            //变量类型 有14种
            //变量名 自定义 按照一定规则

            //变量类型
            //拼接打印
            Console.WriteLine("我有" + i );
            //1.有符号整型变量
            //sbyte -128~127
            //int -21亿~21亿
            //short 
            //long

            //2.无符号整型变量
            //byte 0~255
            //uint 0~
            //ushort 0~
            //ulong 0~

            //3.浮点数
            //float 存储7~8位有效数字 超出部分自动四舍五入
            //后面加f是因为c#中是默认浮点数是double类型加f是为了告诉系统是float型
            float f = 0.123456789f;
            //double 存储15~17位有效数字
            double d = 0.1234567890123456789;
            //decimal 存储27~28位有效数字 后面加m

            //4.特殊类型
            //bool true false
            //char 字符类型 只能存一个
            char c = '敌';
            //string 字符串类型，用来存储多个字符没有上限
            #endregion

            #region 知识点三 为什么有那么多不同的变量类型
            //不同变量存储范围和类型不一样，本质是占用的内存空间不同
            //选择不同的数据类型装在不同的数据

            #endregion

            #region 知识点四 多个相同类型变量 同时申明
            //多个同类型变量申明
            //固定写法
            //变量类型 变量名=值，变量名=值，变量名=值
            int a1 = 1, b1 = 2, c1 = 3, d1 = 4;
            #endregion

            #region 知识点五 变量的初始化
            //变量声明的时候可以不声明变量的值
            #endregion
        }
    }
}
