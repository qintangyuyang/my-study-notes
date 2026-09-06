using System;

// 练习 2：事件订阅 Publisher / Subscriber（摸底卷子 20 题的正式版）
// 目标：不看资料，完整写出 事件声明 → 订阅(+=) → 触发(?.) → 退订(-=) → 再触发
// 验收：第一次触发打印 A 和 B 两条通知；退订 A 后第二次触发只剩 B。

// TODO 1：定义 Publisher 类
//  - public event Action OnComplete;           // 声明事件（Action = 无参委托）
//  - public void Finish() => OnComplete?.Invoke();  // 触发方法（?. 判空）

// TODO 2：定义两个订阅方法（可以写在某个 Subscriber 类里，也可以直接写两个普通静态方法）
//  - 方法 A：打印「A 收到通知」
//  - 方法 B：打印「B 收到通知」

class EventDemo
{
    public static void Run()
    {
        // TODO 3：创建 Publisher，把方法 A、B 订阅到 OnComplete（用 +=）

        // TODO 4：触发一次（调用 Finish()），观察输出——应该 A、B 都打印

        // TODO 5：退订方法 A（用 -=），再触发一次，观察输出——应该只剩 B

        // 实验：把下面这行取消注释，看编译器报什么错，把错误抄进笔记（这能说明事件为什么比委托安全）
        // publisher.OnComplete = null;   // 事件外部不允许直接赋值

        Console.WriteLine();
        Console.WriteLine("练习 2 完成！去《01-委托与事件.md》把 事件vs委托 的区别写进笔记。");
    }
}
