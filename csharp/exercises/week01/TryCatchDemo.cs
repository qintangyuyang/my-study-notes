using System;

// 笔记《02-异常处理与finally》的实验
// 验证两个现象：
//   1. try 中抛异常后，异常语句后面的代码不会执行，控制权交给 catch，finally 无论如何都执行
//   2. 即使在 catch 里 return，finally 依然会执行
// 做完把运行结果和结论抄进笔记的「② 最小可运行示例」。

class TryCatchDemo
{
    public static void Run()
    {
        // TODO 1：基本流程实验
        // try
        // {
        //     Console.WriteLine("try 开始");
        //     int[] arr = null;
        //     Console.WriteLine(arr.Length);   // 这里会抛 NullReferenceException
        //     Console.WriteLine("这行不会执行");
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine("catch 捕获到：" + e.GetType().Name);
        // }
        // finally
        // {
        //     Console.WriteLine("finally 执行了（无论有没有异常）");
        // }

        // TODO 2：catch 里 return，finally 还会执行吗？
        // Console.WriteLine("--- 实验：catch 里 return ---");
        // ReturnInCatch();

        Console.WriteLine("实验尚未完成：请按 TODO 1-2 补全代码");
    }

    // static void ReturnInCatch()
    // {
    //     try
    //     {
    //         throw new Exception("测试异常");
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine("catch 捕获：" + e.Message + "，准备 return");
    //         return;   // 在 catch 里 return
    //     }
    //     finally
    //     {
    //         Console.WriteLine("finally 还是执行了");
    //     }
    // }
}
