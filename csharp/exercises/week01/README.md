# 第 1 周练习

两个练习都是**纯 C# 控制台程序**（不需要 Unity）。

运行方式（任选一种）：
- **VS / Rider**：新建「控制台应用」项目，把对应 .cs 文件的内容复制到 Program.cs（或替换）后运行
- **命令行**（装有 .NET SDK 时）：`dotnet new console` 新建项目，替换 Program.cs 后 `dotnet run`

## 练习 1：重写 MaxOf（文件：MaxOf.cs）

来源：摸底卷子第 10 题。逻辑你已经写对了，这次练的是**规范**。

要求：
1. 所有关键字小写（public / class / static / int / if / for / return …）
2. 命名规范：方法 PascalCase、局部变量 camelCase
3. 在 Main 里用 `{3, 9, 2, 7, 5}` 测试，运行输出应为 `9`

验收：0 编译错误、0 警告、运行输出 9。

## 练习 2：动物多态（文件：AnimalDemo.cs）

来源：摸底第 14 题纠错 + 本周多态知识点。

要求：
1. Animal 基类，定义 `virtual` 方法 Speak()
2. Dog、Cat 继承 Animal，`override` Speak()（分别打印「汪汪」「喵喵」）
3. 关键步骤：用 **Animal 类型**的引用去调用（`Animal a = new Dog(); a.Speak();`）
4. 额外实验：把 virtual/override 去掉再运行，观察输出有什么变化，把结论写进《01-多态与继承.md》的踩坑记录

验收：两个引用各自调用到**子类**的实现（多态生效）。
