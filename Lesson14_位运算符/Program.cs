namespace Lesson14_位运算符
{
     class Program
    {
        static void Main(string[] args)
        {
            //位运算符 只要用数值类型进行计算的
            //将数值转换为二进制 再进行位运算

            #region 知识点一 位与 &
            //规则 连接两个数值进行位运算 将数值转换为二进制
            //对位运算 有0则0
            int a = 1;//0001
            int b = 5;//0101
            int c=a & b;//实际上就是数值转换为二进制之后每一位上下对位相乘
            Console.WriteLine(c);//0001 1

            a = 3;//011
            b = 19;//10011
            c=a & b;//00011 3
            Console.WriteLine(c);
            #endregion

            #region 知识点二 位或|
            //规则 连接两个数值进行位运算 将数值转换为二进制
            //对位运算 有1则1

            a = 1;//0001
            b = 5;//0101
            c=a | b;//0101
            Console.WriteLine(c);//5
            #endregion

            #region 知识点三 异或^
            //规则 连接两个数值进行位运算 将数值转换为二进制
            //对位运算 相同为0 不同为1
            a = 1;//0001
            b = 5;//0101
            c=a ^ b;//0100
            Console.WriteLine(c);//4
            #endregion

            #region 知识点四 取反~
            //规则 将数值转换为二进制
            //对位运算 0变1 1变0
            a = 5;//0101
            //0000 0000 0000 0000 0000 0000 0000 0101
            //1111 1111 1111 1111 1111 1111 1111 1010
            //有符号位 所以最高位是1 代表负数
            //取反之后变为1010 但是计算机中是以补码形式存储的 所以结果是-6
            c=~a;
            Console.WriteLine(c);//-6
            #endregion

            #region 知识点五 位移运算符 << >>
            //规则 让一个数值的二进制整体向左或向右移动 指定位数
            //左移 低位补0
            a = 5;//101
            c = a<<5;
            //10100000
            Console.WriteLine(c);//160
            a = 5;
            c = a>>5;
            //1位 10
            //2位 1
            //3位 0
            Console.WriteLine(c);//0

            #endregion

            int d = 35;//00100011
            c = d << 4;
            Console.WriteLine(c);//1000110000 512+32+16

            int e = 66;//01000010
            c = e >> 1;
            Console.WriteLine(c);//00100001 32+1=33

            int f = 99;//01100011
            int g = 33;//00100001
            c = f ^ g;
            //01100011
            //00100001
            //01000010
            Console.WriteLine(c);//66

            int h = 76;//01001100

            int j = 85;//01010101
            c = h | j;
            //01001100
            //01010101
            //01011101
            Console.WriteLine(c);//93

        }
    }
}
