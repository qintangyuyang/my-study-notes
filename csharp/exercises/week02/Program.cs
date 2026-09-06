using System;

// 第 2 周练习入口：依次运行练习 1 和练习 2
// 练习代码分别在 LinqDemo.cs 和 EventDemo.cs 里，去那里补全 TODO。
class Program
{
    static void Main()
    {
        Console.WriteLine("===== 练习 1：LINQ 处理怪物列表 =====");
        LinqDemo.Run();
        Console.WriteLine();
        Console.WriteLine("===== 练习 2：事件订阅 Publisher / Subscriber =====");
        EventDemo.Run();
        Console.WriteLine();
        Console.WriteLine("第 2 周练习运行完毕。");
    }
}
