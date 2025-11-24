namespace Lesson11_字符串拼接
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 字符串拼接的方式
            //之前算数运算符 只是用来数值类型变量进行数学运算的
            //而String不存在算术运算符 不能计算 但是可以用+进行字符串拼接
            string str = "123";
            str=str+ "456";//字符串拼接
            Console.WriteLine(str);//123456
            str = str + 1;
            Console.WriteLine(str);

            //复合运算符 +=
            str = "123";
                str += "456";//str=str+"456"
            str += "1" + 4 + true;
            Console.WriteLine(str);//12345614True 

            //注意：用+进行字符串拼接的时候 如果有非字符串类型变量参与拼接 会先把非字符串类型变量转换为字符串类型 再进行拼接
            #endregion

            #region 知识点二 字符串拼接方式2
            //固定语法
            //string.format("格式字符串",参数1,参数2,...);
            //拼接内容中的固定规则
            //想要被拼接的内容用占位符替代 占位符的格式是{n} n表示参数的索引 从0开始
            string str2;
            str2 = string.Format("我叫{0}，今年{1}岁，身高{2}米", "小明", 23, 1.75f);
            Console.WriteLine(str2);

            #endregion

            #region 控制点打印
            //后面的内容比占位符多 不会报错
            //后面的内容比占位符少 会报错
            Console.WriteLine("a{0},b{1},c{2}", 1, 2, 3);
            #endregion

            string name="小红";
            name = "你好，" + name;
            Console.WriteLine(name);

            string ClientName = "张三";
            int ClientAge = 30;
            Console.WriteLine("客户姓名是{0}，年龄是{1}岁", ClientName, ClientAge);
            
            string Adname="李四";
            int Adage=28;
            string AdClass = "三年二班";
            string str3;
            str3 = string.Format("用户姓名{0}，用户年龄{1},用户班级{2}", Adname, Adage, AdClass);
            Console.WriteLine(str3);

        }
    }
}
