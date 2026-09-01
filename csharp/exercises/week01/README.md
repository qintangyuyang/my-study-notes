# 第 1 周练习（.NET 8 控制台项目）

这是一个完整的 C# 控制台项目，**打开项目后可直接运行**（不要单独打开 .cs 文件——.cs 只是源码，必须放在项目里才能编译运行）。

## 项目结构

- `week01.csproj`：项目文件（Rider / VS Code / dotnet 都靠它识别项目）
- `Program.cs`：程序入口，依次运行两个练习
- `MaxOf.cs`：练习 1（已完成 ✅）
- `AnimalDemo.cs`：练习 2（TODO 等你补全）
- `.vscode/`：VS Code 的运行/调试配置（已配好，F5 即可）

## 运行方式（任选一种）

### Rider
1. `File → Open` → 选择 `csharp/exercises/CSharpExercises.sln`（以后每周的练习都会加进这个解决方案）
2. 点击绿色运行按钮或按 `Shift+F10`

### VS Code
1. 安装扩展「C# Dev Kit」（扩展市场搜索 C# Dev Kit）
2. `File → Open Folder` → 选择 `week01` 这个文件夹
3. 按 `F5`（已配好调试配置），或在终端输入 `dotnet run`

### 命令行
```bash
cd csharp/exercises/week01
dotnet run
```

## 练习内容

### 练习 1：重写 MaxOf（MaxOf.cs）✅ 已完成
你已实现并额外做了空数组检查（好习惯）。运行时留意输出是否为 9，然后试试思考题：给 MaxOf 传空数组会发生什么。

### 练习 2：动物多态（AnimalDemo.cs）
来源：摸底第 14 题纠错 + 本周多态知识点。
1. Animal 基类 + `virtual` Speak()
2. Dog、Cat 继承并 `override` Speak()（打印「汪汪」「喵喵」）
3. 用 **Animal 类型**引用调用（`Animal a1 = new Dog(); a1.Speak();`）
4. 实验：去掉 virtual/override 再运行，把结论写进《01-多态与继承.md》的踩坑记录

## 小知识

- `.cs` 是源码文件，不能单独运行；放进项目（`.csproj`）由编译器编译成程序后才能运行
- 编译产物在 `bin/` 和 `obj/` 目录，已加入 `.gitignore`，不会提交到 GitHub
- 提交代码前不用删除 bin/obj，git 会自动忽略它们
