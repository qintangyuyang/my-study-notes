using System;

// 第 1 周练习入口：依次运行练习 1 和练习 2
// 练习代码分别在 MaxOf.cs 和 AnimalDemo.cs 里，去那里补全 TODO。
class Program
{
    static void Main()
    {
        Console.WriteLine("===== 练习 1：重写 MaxOf =====");
        MaxOfExercise.Run();
        Console.WriteLine();
        Console.WriteLine("===== 练习 2：动物多态 =====");
        AnimalDemo.Run();
        Console.WriteLine();
        Console.WriteLine("===== 实验：值类型与引用类型 =====");
        ValueRefDemo.Run();
        Console.WriteLine();
        Console.WriteLine("===== 实验：异常处理与 finally =====");
        TryCatchDemo.Run();
        Console.WriteLine();
        Console.WriteLine("全部练习运行完毕。");
    }
}
