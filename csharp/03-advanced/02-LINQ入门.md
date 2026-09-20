# LINQ 入门

> 摸底第 12 题（Where 的作用）选了 B 但标注「不确定」，第 19 题（用 LINQ 筛偶数）直接写了「不会」。
> 本周目标：彻底补齐 LINQ。
> 本文件已按 2026-09-12 的答题批改整理，是**详细参考版**（含完整代码示例）。

---

## ① 概念总结

### 1. LINQ 是什么

**LINQ = Language Integrated Query（语言集成查询）**：用同一套语法去查询各种数据源（数组、`List<T>`、Dictionary、XML、数据库…），不用为每种数据源学一套 API。

和「for 循环 + if 判断」相比的三个优势：

| 优势 | 说明 |
|---|---|
| **声明式** | 写「我要什么」（`Where(m => m.Hp > 80)`），而不是「怎么循环」（for + if + 临时 List） |
| **可链式组合** | 查询可以像管道一样叠加：`Where(...).OrderBy(...).Select(...).Take(3)` |
| **类型安全 + 智能提示** | 编译期检查类型，写错立刻报错（SQL 字符串做不到） |

```csharp
// 命令式（传统写法）
var strongOnes = new List<Monster>();
foreach (var m in monsters)
{
    if (m.Hp > 80) strongOnes.Add(m);
}

// 声明式（LINQ）—— 同样的事，一行
var strongOnes = monsters.Where(m => m.Hp > 80).ToList();
```

### 2. 五个核心方法（重点：返回类型 + 是否延迟）

| 方法 | 作用 | 返回类型 | 执行时机 |
|---|---|---|---|
| `Where` | **筛**：保留满足条件的元素（数量变少，元素不变） | `IEnumerable<T>` | 延迟 |
| `Select` | **变**：把每个元素投影成另一种东西（数量不变，元素变了） | `IEnumerable<TResult>` | 延迟 |
| `OrderBy` / `OrderByDescending` | 排序：升序 / 降序 | `IOrderedEnumerable<T>` | 延迟 |
| `Take(n)` | 取前 n 个 | `IEnumerable<T>` | 延迟 |
| `Any` | 是否存在至少一个满足条件的元素 | `bool` | **立即** |
| `First` / `FirstOrDefault` | 取第一个（满足条件的）元素 | `T` | **立即** |
| `ToList` / `ToArray` | 把查询结果物化成集合 | `List<T>` / `T[]` | **立即**（并触发前面所有延迟查询） |

```csharp
var numbers = new List<int> { 5, 2, 8, 1, 9, 3 };

var evens   = numbers.Where(n => n % 2 == 0);              // 筛：2, 8
var doubled = numbers.Select(n => n * 2);                  // 变：10,4,16,2,18,6
var sorted  = numbers.OrderBy(n => n);                     // 升序：1,2,3,5,8,9
var top2    = numbers.OrderByDescending(n => n).Take(2);   // 降序取前 2：9,8
bool hasBig = numbers.Any(n => n > 8);                     // true（9 存在）
int  first  = numbers.FirstOrDefault(n => n > 7);          // 8
```

**Where vs Select 的本质区别**（记住「筛」和「变」两个字）：

```csharp
monsters.Where(m => m.Hp > 80);        // 结果还是 Monster，只是少了几个
monsters.Select(m => m.Name);          // 结果变成了 string（Monster → string）
monsters.Select(m => new { m.Name, m.Hp });   // 也可以投影成匿名对象
```

### 3. 多级排序要用 ThenBy

```csharp
// ❌ 错误理解：第二个 OrderBy 不会「追加」排序，而是重新排序
monsters.OrderBy(m => m.Hp).OrderBy(m => m.Name);

// ✅ 正确：第一级 OrderBy + 后续级 ThenBy
monsters.OrderBy(m => m.Hp).ThenBy(m => m.Name);
```

### 4. Lambda 表达式

- **名字**：Lambda 表达式（匿名函数），C# 里用 `=>` 书写，读作 "goes to"
- **箭头左边**：参数列表；**箭头右边**：表达式或语句块（要执行的操作）
- 它和委托的关系：`m => m.Hp > 80` 会被编译器包装成 `Func<Monster, bool>`，所以能直接传给 `Where`

```csharp
() => Console.WriteLine("无参")                 // 无参数
n => n * 2                                      // 单参数（可省括号）
(int a, int b) => a + b                         // 多参数（带类型）
n => { var x = n * 2; return x + 1; }           // 语句块（需要 return）
m => m.Hp > 80                                  // 最常用于 Where 的条件
```

### 5. 延迟执行（Deferred Execution）

**核心**：`Where` / `Select` / `OrderBy` 这些方法**只是构造了一个查询对象，并没有真正执行**；只有遇到下面的「触发动作」才真正跑起来：

- `foreach` 遍历
- 终端操作：`ToList()`、`ToArray()`、`Count()`、`First()`、`Any()`、`Sum()`、`Max()` …

```csharp
var query = monsters.Where(m => m.Hp > 80);   // 这一行什么都没发生
Console.WriteLine("还没执行");
foreach (var m in query) { /* 到这一行才真正筛选 */ }
```

**两个必须知道的坑**：

```csharp
// 坑 1：延迟执行 + 数据源被修改 → 结果跟着变
var query = monsters.Where(m => m.Hp > 80);
monsters.Add(new Monster { Hp = 999 });       // 查询构造之后加的数据
foreach (var m in query) { ... }              // 这个 999 也会被查出来！

// 坑 2：每次遍历都重新计算一遍（数据量大时浪费性能）
foreach (var m in query) { }                  // 算第一遍
foreach (var m in query) { }                  // 又算一遍

// 解决：需要重复使用时先物化
var cached = monsters.Where(m => m.Hp > 80).ToList();   // 只算一次
```

### 6. First vs FirstOrDefault

| | `First` | `FirstOrDefault` |
|---|---|---|
| 找到 | 返回第一个匹配元素 | 同 |
| **没找到** | **抛 `InvalidOperationException`** | 返回 `default(T)`（引用类型 `null`，int `0`，bool `false`） |
| 该用哪个 | 你**确定**一定有匹配（或希望"没有就报错"来暴露问题） | 你**无法保证**有匹配 |

```csharp
// 陷阱：FirstOrDefault 返回 null 时直接使用 → NullReferenceException
Monster m = monsters.FirstOrDefault(x => x.Hp > 1000);
Console.WriteLine(m.Name);                    // ❌ m 可能是 null
if (m != null) Console.WriteLine(m.Name);     // ✅ 先判空

// .NET 6+ 还能指定默认值
Monster m2 = monsters.FirstOrDefault(x => x.Hp > 1000, new Monster { Name = "无" });
```

---

## ② 最小可运行示例

- [ ] 完成 `csharp/exercises/week02/LinqDemo.cs`：对 100 条怪物数据分别用 Where / Select / OrderBy / Any / FirstOrDefault 查询
- [ ] 用 `Console.WriteLine` 把每步结果打印出来，亲眼看到输出
- [ ] 补摸底第 19 题（一行代码）：

```csharp
// 在这里写你的答案
```

## ③ 踩坑记录

| 坑 | 原因 | 解决 |
|---|---|---|
| 以为 `Where` 返回 `List<T>`，直接调 `list.Add()` 报错 | `Where` 返回的是 `IEnumerable<T>`（惰性序列），不是 List | 需要 List 就用 `.ToList()` 物化 |
| 延迟执行：构造查询后又改了数据源，结果里多出/少了元素 | 查询在**遍历时**才执行，看到的是那一刻的数据 | 需要"快照"就先 `.ToList()` |
| 同一个查询 foreach 两次，结果被算了两遍 | 延迟执行 = 每次枚举都重新计算 | 复用前先 `.ToList()` 缓存 |
| `FirstOrDefault` 返回 null/0 后直接使用 → `NullReferenceException` | 找不到时返回 `default(T)`（引用类型是 null） | 取出来先判空再使用 |
| 多级排序写了两遍 `OrderBy`，前一个排序失效 | 第二个 `OrderBy` 是重新排序，不是追加 | 第一级用 `OrderBy`，后续级用 `ThenBy` |
| 用 `Count() > 0` 判断"有没有" | 要遍历完整个序列才能得到数量 | 用 `Any()`（找到一个就返回，短路求值） |

## ④ 语法速查

```csharp
numbers.Where(n => n > 5)                       // 筛
numbers.Select(n => n * 2)                      // 变
numbers.OrderBy(n => n)                         // 升序
numbers.OrderByDescending(n => n).Take(3)       // 降序取前 3
numbers.Any(n => n > 100)                       // 有没有（bool）
numbers.FirstOrDefault(n => n > 7)              // 第一个（没有则 default）
numbers.Where(n => n > 5).ToList()              // 物化成 List（触发执行）
```
