using System;

// 笔记《02-值类型与引用类型》的实验
// 验证两个现象：
//   现象 A：int、自定义 struct 赋值给新变量后，改其中一个，另一个不变（值类型复制值）
//   现象 B：new 出来的 class 实例被两个变量引用，通过一个改字段，另一个能看到（引用类型共享实例）
// 做完把运行结果和结论抄进笔记的「② 最小可运行示例」。

struct PointStruct
{
    public int X;
}

class PointClass
{
    public int X;
}

class ValueRefDemo
{
    public static void Run()
    {
        // TODO 3：现象 A —— int 与 struct 的复制实验
        int a = 10;
        int b = a;      // 把 a 复制给 b
        b = 20;         // 改 b
        Console.WriteLine("int：a = " + a + "，b = " + b);   // a 还是 10 吗？

        PointStruct s1 = new PointStruct { X = 1 };
        PointStruct s2 = s1;    // 把 s1 复制给 s2
        s2.X = 99;              // 改 s2
        Console.WriteLine("struct：s1.X = " + s1.X + "，s2.X = " + s2.X);   // s1.X 变了吗？

        // TODO 4：现象 B —— class 的共享引用实验
        PointClass c1 = new PointClass { X = 1 };
        PointClass c2 = c1;     // c1、c2 指向同一个实例
        c2.X = 99;              // 通过 c2 修改
        Console.WriteLine("class：c1.X = " + c1.X + "，c2.X = " + c2.X);   // c1.X 变了吗？

    }
}
