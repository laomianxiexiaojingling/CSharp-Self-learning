namespace Lesson_13逻辑运算
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            #region 知识点一 逻辑与
            // 逻辑与运算符 &&
            //规则：只有两个操作数都为true时，结果才为true，否则为false

            bool result1=true&&false; //false
            result1 = true && true;  //true

            //bool 相关的类型 bool变量 条件运算符
            //逻辑运算符优先级低于条件运算符 算术运算符
            result1 = 3 > 1 && 5 < 2;//false

            int i = 3;
            //1<i<5;
            //true&&true
            result1= 1 < i && i < 5;//true

            //多个逻辑与 组合运用
            int i2 = 5;
            result1= 1 < i && i < 5 && i2 > 3 && i2 > 10;//false

            #endregion

            #region 知识点二 逻辑或
            //符号|| 或者
            //规则：两个操作数只要有一个为true，结果就为true，只有两个操作数都为false时，结果才为false
            result1= true || false; //true
            result1 = false||false;//false
            result1= 3 > 1 || 5 < 2;//true
            #endregion

            #region 知识点三 逻辑非
            //符号 !
            //规则：对一个操作数进行取反操作，true变false，false变true

            result1=!true; //false
            result1 = !false;//true
            #endregion

            #region 混合使用优先级问题
            //规则 ！（逻辑非）优先级最高 &&(逻辑与）优先级高于||（逻辑或）
            //逻辑运算符优先级低于算术运算符 调剂运算符（逻辑非除外）

            bool gameover = false;
            int hp = 100;
            bool isDead = false;
            bool isMustOver = true;

            //false||false&&true||true;
            result1 = gameover || hp < 0 && !isDead || isMustOver;

            #endregion

            #region 知识点五 逻辑运算符短路的规则
            int i3 = 1;
            //只要逻辑与或者逻辑或 左边满足了条件
            //i3>0 true
            //只要满足条件 右边的内容就不看了
            result1 = i3 > 0 || ++i3 >= 1;//i3=1

            //false && i3++>1
            //逻辑与 有假则假 那左边只要为假了 右边就不重要
            result1 = i3 < 0 && i3++ > 1;
            Console.WriteLine(i3);
            Console.WriteLine(result1);
            #endregion

            //true
            //true
            //true
            //false
            //false

            bool gameOver;
            bool isWin;
            int health = 100;
            gameOver = true;
            isWin = false;
            Console.Write(gameOver||isWin&&health > 0);//true
        }
    }
}
