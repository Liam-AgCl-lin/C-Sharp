namespace lesson_枚举
{
    enum E_meiju
    {
        a,//第一个整形常量默认为1，依次累加1
        b,
        c,
        g
    }
    
    //在namespace语句块一般
    //class struct
    //枚举不能在函数语句块中申明 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举");
            //////////基本概念
            //被命名的整型变量集合
            //申明枚举      创建自定义的枚举类型
            //申明枚举变量  使用申明的自定义枚举类型，创建一个枚举变量

            E_meiju play = E_meiju.a;
            //枚举的类型转换 int string
            int i = (int)play;
            Console.WriteLine (play);
            Console.WriteLine(i);
            string str=play.ToString();
            Console.WriteLine(str);
            //string转为枚举
            //                               枚举类型    对应的枚举项
            play = (E_meiju)Enum.Parse(typeof(E_meiju), "b");
            Console.WriteLine(play);
            E_meiju meiju = E_meiju.a; 
        }
    }
}
