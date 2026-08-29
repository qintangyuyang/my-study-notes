using System;

// 练习 2：动物多态（摸底第 14 题纠错）
// 要求：
//   1. Animal 基类：virtual 方法 Speak()
//   2. Dog、Cat 继承 Animal：override Speak()，分别打印「汪汪」「喵喵」
//   3. 关键：用 Animal 类型的引用去调用 Speak()，观察调用的是谁的实现（这就是多态）
//   4. 实验：把 virtual / override 去掉再运行，观察输出变化，结论写进笔记的踩坑记录
// 验收：两个引用各自调用到子类的实现。

class AnimalDemo
{
    // TODO: 定义 Animal 基类（virtual Speak 方法，可打印「动物在叫」）

    // TODO: 定义 Dog 类继承 Animal（override Speak，打印「汪汪」）

    // TODO: 定义 Cat 类继承 Animal（override Speak，打印「喵喵」）

    static void Main()
    {
        // TODO: Animal a1 = new Dog(); a1.Speak();  观察输出
        // TODO: Animal a2 = new Cat(); a2.Speak();  观察输出
    }
}
