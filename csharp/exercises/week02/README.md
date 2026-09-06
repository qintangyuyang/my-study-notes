# 第 2 周练习（.NET 8 控制台项目）

第二个练习项目。第 1 周的东西（CSharpExercises.sln、week01）保持不变，这周在 `week02` 里做。

## 运行方式（任选一种）

### Rider
`File → Open` → 选 `csharp/exercises/CSharpExercises.sln`（week01、week02 都在里面）→ 在运行配置里选择 **week02** → 绿色按钮 / `Shift+F10`

### VS Code
`File → Open Folder` → 选 `week02` 文件夹 → `F5` 或终端 `dotnet run`

### 命令行
```bash
cd csharp/exercises/week02
dotnet run
```

## 项目结构

- `Program.cs`：入口，依次运行两个练习
- `LinqDemo.cs`：练习 1（TODO 1–5 等你补全）
- `EventDemo.cs`：练习 2（TODO 1–5 等你补全）

## 练习内容

### 练习 1：LINQ 处理怪物列表（LinqDemo.cs）—— 补摸底 19 题
100 条怪物数据已造好，补全 5 个查询：Where（过滤）、Select（投影）、OrderBy（排序）、Any（判断）、FirstOrDefault（取第一个）。
配套笔记：《02-LINQ入门.md》

### 练习 2：事件订阅（EventDemo.cs）—— 补摸底 20 题
声明 `event Action` → 两个订阅者 `+=` → `?.Invoke()` 触发 → `-=` 退订 → 再触发。
验收：第一次触发 A、B 都收到；退订 A 后只剩 B。
配套笔记：《01-委托与事件.md》

## 检验标准（本周末记复盘用）

□ 不看资料能写出事件声明/订阅/退订/触发
□ 5 个 LINQ 方法都能写出来并解释作用
□ 两个练习都跑通
