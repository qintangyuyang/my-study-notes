using System;

// 练习 2：动物多态（摸底第 14 题纠错）
// 要求：
//   1. Animal 基类：virtual 方法 Speak()（打印「动物在叫」）
//   2. Dog、Cat 继承 Animal：override Speak()，分别打印「汪汪」「喵喵」
//   3. 关键：用 Animal 类型的引用去调用 Speak()，观察调用的是谁的实现（这就是多态）
//   4. 实验：把 virtual / override 去掉再运行，观察输出变化，结论写进笔记的踩坑记录
// 验收：运行后分别输出「汪汪」「喵喵」。

class Animal
{
    public virtual void Speak() { Console.WriteLine("动物在叫"); }
}
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("汪汪");
    }
}
class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("喵喵");
    }
}

class AnimalDemo
{
    public static void Run()
    {
        Animal a1 = new Dog();
        a1.Speak();   // 应该输出：汪汪
        
        Animal a2 = new Cat();
        a2.Speak();   // 应该输出：喵喵
    }
}
