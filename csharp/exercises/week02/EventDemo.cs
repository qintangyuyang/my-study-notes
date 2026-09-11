using System;

// 练习 2：事件订阅 Publisher / Subscriber（摸底卷子 20 题的正式版）
// 目标：不看资料，完整写出 事件声明 → 订阅(+=) → 触发(?.) → 退订(-=) → 再触发
// 验收：第一次触发打印 A 和 B 两条通知；退订 A 后第二次触发只剩 B。

class EventDemo
{
    class Publisher
    {
        public event Action OnComplete; // 声明事件（Action = 无参委托）

        public void Finish() => OnComplete?.Invoke(); // 触发方法（?. 判空）
    }
    public static void Run()
    {
        Publisher publisher = new Publisher();
        
        publisher.OnComplete += MethodA;
        publisher.OnComplete += MethodB;

        publisher.Finish();

        publisher.OnComplete -= MethodA;
        publisher.Finish();

        // 实验：把下面这行取消注释，看编译器报什么错，把错误抄进笔记（这能说明事件为什么比委托安全）
        //publisher.OnComplete = null;   // 事件外部不允许直接赋值

        Console.WriteLine();
    }

    public static void MethodA()
    {
        Console.WriteLine("A 收到通知");
    }

    public static void MethodB()
    {
        Console.WriteLine("B 收到通知");
    }
}
