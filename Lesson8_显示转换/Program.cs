namespace Lesson8_显示转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 括号强转
            //作用 一般情况下 将高精度类型转换成低精度类型
            //语法 变量类型 变量名 = (目标类型)变量名;
            
            //相同大类的整形
            //有符号的整形
            sbyte sb = 1;
            short s = 1;
            int i = 1;
            long l = 1;

            s=(short)i; //正确 将int强转成short
            i=(int)l; //正确 将long强转成int
            //括号强转有可能会丢失精度 造成异常

            //无符号的整形
            byte b = 1;
            ushort us = 1;
            uint ui = 1;

            b=(byte)ui;

            //浮点之间
            float f = 1.1f;
            double d = 1.123456789;

            f = (float)d;
            Console.WriteLine(f);

            //无符号和有符号之间的转换
            uint u = 1;
            int j = -1;
            u = (uint)j;
            Console.WriteLine(u);

            //浮点和整型
            i = (int)f;
            Console.WriteLine(i);
            //会丢失精度

            //char和数值类型
            i = 'A';
            char c=(char)i ;
            Console.WriteLine(c);

            //bool和string是不能通过括号强制进行转换的

            #endregion

            #region 知识点二 Parse法
            //作用 将字符串类型转换成对应的数值类型
            //语法 目标类型. Parse(字符串变量);
            //注意事项 字符串必须能够转换成对应类型 否则会报异常

            //有符号  
            //string str2="123";
            int i4 = int.Parse("123");
            Console.WriteLine(i4);
            //填写字符串 必须是要能够转成对应类型的字符
            //i4=int.Parse("123.45"); //报错

            //值得范围 必须是能够被变量存储的值 否则报错
            //short s3 = short.Parse("400000");//报错

            sbyte sb3 = sbyte.Parse("120");
            Console.WriteLine(sb3);
            Console.WriteLine(sbyte.Parse("120"));
            //他们的意思是相同的

            //无符号

            //浮点数
            float f3 = float.Parse("123.45");
            Console.WriteLine(f3);
            double d3 = double.Parse("123.456789");
            Console.WriteLine(d3);

            //特殊类型
            bool bool3 = bool.Parse("true");
            Console.WriteLine(bool3);
            char c3 = char.Parse("A");
            Console.WriteLine(c3);
            #endregion

            #region 知识点三convert类转换
            //作用 各个类型之间相互转换
            //语法 Convert.To目标类型(变量);
            //注意：填写的变量或常量必须正确否则出错

            //转字符串 
            int a = Convert.ToInt32("123");
            Console.WriteLine(a);
            a = Convert.ToInt32(123.34f);


            //把bool类型也可以转成数值类型 true->1 false->0
            a = Convert.ToInt32(true);//1
            Console.WriteLine(a);
            a=Convert.ToInt32(false);//0
            Console.WriteLine(a);
             
            //每一个类型都存在对应的convert方法
            sbyte sb4 = Convert.ToSByte("1");
            short s4 = Convert.ToInt16("2");
            long l4 = Convert.ToInt64("3");

            byte b4 = Convert.ToByte("4");
            ushort us4 = Convert.ToUInt16("5");
            ulong ul4 = Convert.ToUInt64("6");

            float f5=Convert.ToSingle("1.1");
            double d5=Convert.ToDouble("2.2");
            decimal dec5=Convert.ToDecimal("3.3");

            bool bool5=Convert.ToBoolean("true");
            char c5=Convert.ToChar("A");

            string str5=Convert.ToString(123);



            #endregion

            #region 知识点四 其他类型转string
            //作用 将其他类型转换成字符串类型
            //语法 变量名.ToString();

            string str6 = 1.ToString();
            str6 = true.ToString();
            str6 = 1.234f.ToString();
            str6='A'.ToString();

            #endregion

            char a6=(char)24069;
            Console.WriteLine(a6);

            Console.WriteLine("请输入用户名");
            string name=Console.ReadLine();
            Console.WriteLine("您的用户名数字化结果是:"+name);
            Console.WriteLine("请输入你的语文成绩");
            int chinese=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你的语文成绩是:"+chinese);
            int math = int.Parse(Console.ReadLine());
        }
    }
}
