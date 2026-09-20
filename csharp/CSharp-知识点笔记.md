# C# 知识点笔记

> 按主题整理的知识手册：只记录**知识点**（概念、代码示例、对比表、常见坑）。
> 学习过程、每日记录与复盘见 `log/` 周记；代码练习见 `csharp/exercises/`。

## 目录

- [一、语法规范与命名](#一语法规范与命名)
- [二、值类型与引用类型（栈与堆）](#二值类型与引用类型栈与堆)
- [三、继承与多态](#三继承与多态)
- [四、异常处理与 finally](#四异常处理与-finally)
- [五、委托与事件](#五委托与事件)
- [六、LINQ](#六linq)

---

## 一、语法规范与命名

### 1.1 关键字：全部小写

public / private / protected / class / struct / interface / static / void / int / float / double / bool / string / if / else / for / foreach / while / return / new / null / true / false / try / catch / finally / get / set / out / ref / virtual / override / base / this …

```
❌ Public int MaxOf(int[] arr)   ✅ public int MaxOf(int[] arr)
❌ If (x > 0)                    ✅ if (x > 0)
❌ Return MaxNum;                ✅ return maxNum;
```

### 1.2 命名规范（C# 官方约定）

| 对象 | 规范 | 示例 |
|---|---|---|
| 类名 / 方法名 / 属性名 | PascalCase（大驼峰） | PlayerController、GetComponent、MaxOf |
| 局部变量 / 方法参数 | camelCase（小驼峰） | moveSpeed、bulletPrefab、maxNum |
| 私有字段 | _camelCase（下划线开头） | _instance、_isGrounded |
| 接口 | I + PascalCase | IInteractable、IDamageable |
| 常量 | 全大写 + 下划线 | MAX_HEALTH |

### 1.3 代码书写习惯

- 每个语句以 `;` 结尾
- 缩进 4 个空格；大括号风格选一种并保持一致（C# 惯例：独占一行）
- `int`、`string`、`bool` 是关键字（小写）；`List<int>` 里的 `List` 是类型（PascalCase）
- 布尔判断直接写 `if (isGrounded)`，不要写 `if (isGrounded == true)`
- 命名要有意义（不用 a、b、x1 这类名字）
- 完成的代码不留 `TODO` 标记——代码完成的标志是代码本身

### 1.4 IDE 辅助设置

- 打开自动补全（VS / Rider 默认开启）
- 格式化快捷键：VS `Ctrl+K, Ctrl+D`；Rider `Ctrl+Alt+L`
- 命名不规范时 IDE 会有波浪线提示，按提示改

---

## 二、值类型与引用类型（栈与堆）

### 2.1 分类

- **值类型**：int、float、double、bool、char、enum、struct
- **引用类型**：class、数组、List、string、委托、接口、object

### 2.2 存储位置

| 内容 | 存储位置 |
|---|---|
| 值类型变量 | **栈**（值直接存在变量里） |
| 引用类型变量**本身** | **栈**（存的是堆上实例的地址） |
| `new` 出来的实例 | **堆** |

### 2.3 string 的特殊性

string 是**引用类型**，但内容**不可变（immutable）**：任何「修改」操作（拼接、替换、ToUpper…）都不会改动原字符串，而是**创建一个新字符串对象**返回。正因为它不可变、用起来像值类型，是值类型/引用类型最容易混淆的地方。

### 2.4 赋值的两种语义（复制值 vs 复制地址）

```csharp
struct PointStruct { public int X; }
class  PointClass  { public int X; }

// 值类型：赋值 = 复制值本身，改副本不影响原变量
int a = 10;
int b = a;
b = 20;                          // a 仍然是 10

PointStruct s1 = new PointStruct { X = 1 };
PointStruct s2 = s1;
s2.X = 99;                       // s1.X 仍然是 1

// 引用类型：赋值 = 复制地址，两个变量指向堆上同一个实例
PointClass c1 = new PointClass { X = 1 };
PointClass c2 = c1;
c2.X = 99;                       // c1.X 也变成 99
```

**结论**：值类型赋值复制**值本身**；引用类型赋值复制**地址**（栈上的引用），两个变量共享同一个堆上实例。

### 2.5 常见坑

| 坑 | 原因 | 解决 |
|---|---|---|
| 以为 class 实例赋给新变量后是两个独立对象，结果改一个另一个也变 | 引用类型赋值只复制栈上的地址，不复制堆上的实例 | 需要独立副本时显式 new 一份，或写 Clone 逻辑 |

---

## 三、继承与多态

### 3.1 继承解决什么问题

**代码复用 + is-a 关系**。共同属性/方法放基类，子类直接继承使用，避免重复逻辑（例：怪物基类实现扣血、攻击逻辑，各种怪物继承即可）。

### 3.2 多态解决什么问题

**同一套代码能处理不同子类**——调用方只依赖基类、不知道也不需要知道具体类型，新增子类**不用修改调用方代码**（开闭原则）。

```csharp
List<Enemy> enemies = ...;        // 里面可以装 Goblin、Zombie、Boss
foreach (var e in enemies)
{
    e.TakeDamage(10);             // 各自调用自己的实现，调用方不需要判断类型
}

void Feed(Animal a) { ... }       // 将来新增任何动物子类，这个方法一行都不用改
```

### 3.3 virtual / override / base

| 关键字 | 含义 |
|---|---|
| `virtual` | 父类声明：这个方法**允许**被子类覆盖 |
| `override` | 子类声明：我真的**覆盖**了父类的这个方法 |
| `base` | 在子类里调用**父类被覆盖的版本**（`base.Method()`；Unity 常见 `base.Awake()` / `base.Start()`） |

### 3.4 运行时绑定 vs 编译期绑定

```csharp
class Animal { public virtual void Speak() => Console.WriteLine("动物在叫"); }
class Dog : Animal { public override void Speak() => Console.WriteLine("汪汪"); }

Animal a = new Dog();
a.Speak();          // 输出「汪汪」：运行时按对象真实类型分派 → 多态生效

// 把 virtual / override 去掉后，同样一行输出「动物在叫」：
// 没有 virtual/override 时是编译期绑定，调用只看引用变量的声明类型（Animal）
```

**要点**：多态 = 父类引用 + 子类 override + **运行时**绑定，三者缺一不可。
调用绑定的时机决定了行为：有 virtual/override → 看对象真实类型（运行时）；没有 → 看变量声明类型（编译期）。

### 3.5 常见坑

| 坑 | 原因 | 解决 |
|---|---|---|
| 去掉 virtual/override 后，`Animal a = new Dog()` 调 Speak 输出「动物在叫」 | 没有 virtual/override 是编译期绑定，按声明类型（Animal）绑定 | 需要多态时父类加 virtual、子类加 override，才能运行时按真实类型分派 |

---

## 四、异常处理与 finally

### 4.1 三者各自的作用

| 关键字 | 作用 |
|---|---|
| `try` | 把**可能抛异常**的代码包起来，异常发生时程序不崩溃 |
| `catch` | 捕获 try 抛出的异常并处理：打印日志、给默认值、回退状态、提示用户 |
| `finally` | 无论 try 是否抛异常、是否被 return，都**最后执行**；放释放资源的收尾代码 |

### 4.2 抛出异常后的执行流程

```
try 中异常点「之后」的代码直接跳过 → 控制权交给 catch → 最后一定走 finally
```

```csharp
try
{
    Console.WriteLine("try 开始");
    int[] arr = null;
    Console.WriteLine(arr.Length);      // 抛 NullReferenceException
    Console.WriteLine("这行不会执行");   // 异常点之后被跳过
}
catch (Exception e)
{
    Console.WriteLine("catch 捕获：" + e.GetType().Name);
    return;                             // 即使这里 return，finally 依然执行
}
finally
{
    Console.WriteLine("finally 总会执行");
}
```

### 4.3 finally 的执行保证

- 正常结束、抛异常被捕获、`catch` 里 `return` —— **三种路径都会执行**
- `return` 挡不住 finally：真实顺序是「先准备好返回值 → 执行 finally → 才真正返回」
- 不保证执行的极端情况：进程被杀、`Environment.FailFast`、StackOverflow 等

### 4.4 什么时候该捕获、什么时候该向上抛

| 场景 | 做法 |
|---|---|
| 你能就地恢复（读存档失败 → 新建存档） | **捕获** |
| 你能给用户兜底（网络失败 → 提示重试） | **捕获** |
| 你不知道怎么处理，上层才知道 | **向上抛** |
| 最差做法 | `catch { }` 空捕获——把错误藏起来，以后出 bug 根本查不到 |

> 口诀：**能处理就捕获，处理不了就抛，绝不空捕获吞掉异常。**

### 4.5 常见坑

| 坑 | 原因 | 解决 |
|---|---|---|
| 以为 catch 里 return 后 finally 就不执行了 | finally 在方法返回路径上被强制执行 | 资源释放必须放 finally；别在 catch 里写空逻辑藏错误 |

---

## 五、委托与事件

### 5.1 委托（delegate）是什么

**类型安全的「方法引用」**——把方法当作值来传递、存储和调用。通俗说法是「装方法的盒子」，专业说法是「类型安全的函数指针」。

- **类型安全**：委托规定方法的签名（参数个数/类型、返回值），签名不匹配编译器直接报错
- **多播**：一个委托变量可以挂**多个方法**（调用列表），调用时按加入顺序**依次执行**；`+=` 追加、`-=` 移除
- 用途：把「要执行什么」当作参数传递——回调、事件通知、策略切换

```csharp
// 方式一：自定义委托类型（语义清晰，但多数场景不必自己定义）
public delegate void NotifyHandler(string message);

// 方式二：使用内置泛型委托（推荐）
Action<string> notify = Console.WriteLine;          // 无返回值
Func<int, int, int> add = (a, b) => a + b;          // 最后一个类型参数是返回值
Predicate<int> isEven = n => n % 2 == 0;            // 返回 bool

// 方式三：具体方法赋值 + 多播
notify = PrintMessage;                              // 直接挂方法
notify += m => Console.WriteLine("[lambda] " + m);  // 追加 lambda
notify("hello");                                    // 两个方法依次执行
```

### 5.2 事件（event）是什么

**事件 = 被封装起来的委托字段 + 访问权限限制**：声明它的类**内部**可以触发和赋值，**外部**只能 `+=` / `-=`。

```csharp
// 发布方（Publisher）
public class OrderService
{
    public event Action<int> OrderCompleted;      // 事件：外部只能 += / -=

    public void CompleteOrder(int orderId)
    {
        Console.WriteLine($"订单 {orderId} 已完成");
        OrderCompleted?.Invoke(orderId);          // 只有类内部能触发
    }
}

// 订阅方（Subscriber）
var service = new OrderService();

Action<int> logger = id => Console.WriteLine($"[日志] 记录订单 {id}");
service.OrderCompleted += logger;                                   // 订阅
service.OrderCompleted += id => Console.WriteLine($"[UI] 弹出订单 {id} 提示");

service.CompleteOrder(1001);        // 两个订阅者依次被通知
service.OrderCompleted -= logger;   // 退订：日志不再收到通知
service.CompleteOrder(1002);
```

### 5.3 事件为什么更安全（编译期限制）

在**声明事件的类之外**写 `service.OrderCompleted = null;`，编译器直接拒绝：

```
The event 'OrderService.OrderCompleted' can only appear on the left hand side of += or -=
(except when used from within the type 'OrderService')
```

- 事件**只能出现在 `+=` / `-=` 的左侧**（外部）
- 括号里那句意思是：**只有声明它的类内部**才能赋值 `=` 或直接调用
- 如果它是 public 委托字段，这行会编译通过并**一句话清空所有人的订阅**（别人还在等通知却永远收不到，极难排查）；`event` 让编译器把这条路堵死了

### 5.4 委托 vs 事件 对比表

| 对比项 | 公开的委托字段 | 事件 `event` |
|---|---|---|
| 外部触发（调用） | ✅ 可以 | ❌ 编译错误 |
| 外部赋值 `=` | ✅ 可以（危险：清空所有订阅） | ❌ 编译错误 |
| 外部 `+=` / `-=` | ✅ 可以 | ✅ 可以 |
| 谁能触发 | 任何拿到引用的人 | 只有声明事件的类内部 |
| 类型安全 | ✅ 编译期检查签名 | ✅ 编译期检查签名 |
| 典型用途 | 回调参数、策略、工厂 | 一对多通知、模块解耦 |

### 5.5 `?.Invoke()` 与 NullReferenceException

- 没有任何订阅者时，事件内部的委托是 `null`，直接写 `OrderCompleted(orderId)` 会抛 **`NullReferenceException`**（调用 null 委托）
- `OrderCompleted?.Invoke(orderId)` 是判空后调用，等价于：

```csharp
if (OrderCompleted != null)
{
    OrderCompleted.Invoke(orderId);
}
```

- 进阶（多线程）：`?.Invoke()` 相当于对委托引用取了「快照」；否则在判空和调用之间若有别的线程退订，仍可能抛 NRE

### 5.6 Lambda 表达式与委托

- lambda 是**匿名方法的简写**：编译器为它生成一个方法，再包装成委托实例
- **闭包**：lambda 可以捕获外部的局部变量和字段
- **重要坑**：用 lambda 直接订阅后，**无法用 `-=` 退订**（每次 lambda 都是新的委托对象，匹配不上）

```csharp
// ❌ 退订无效
service.OrderCompleted += id => Console.WriteLine(id);
service.OrderCompleted -= id => Console.WriteLine(id);

// ✅ 正确：把 lambda 存进变量
Action<int> handler = id => Console.WriteLine(id);
service.OrderCompleted += handler;
service.OrderCompleted -= handler;
```

### 5.7 内置委托 Action / Func / Predicate

| 类型 | 参数 | 返回值 | 示例 |
|---|---|---|---|
| `Action` | 0–16 个 | 无 | `Action`、`Action<int>` |
| `Func<T1,…,TResult>` | 0–16 个 | **最后一个类型参数是返回值** | `Func<int, bool>`：收 int 返回 bool |
| `Predicate<T>` | 1 个 | `bool` | `Predicate<int>` |

**建议**：优先用内置委托，不自己定义 `delegate`。

### 5.8 内存泄漏：订阅与退订必须成对

**机制**：事件内部保存着对订阅者对象的引用；只要事件还活着，这条**引用链**就存在 → GC 认为该对象「仍被引用」→ **无法回收**。

**后果**：
- 内存持续增长（反复开关的面板、反复生成的敌人都被旧事件引用着）
- Unity 里更糟：订阅者已被 `Destroy`，事件再触发会抛 `MissingReferenceException`

```csharp
public class HudPanel : MonoBehaviour
{
    void OnEnable()  { GameEvents.OnScoreChanged += UpdateScore; }   // 启用时订阅
    void OnDisable() { GameEvents.OnScoreChanged -= UpdateScore; }   // 禁用时退订

    void UpdateScore(int score) { /* 刷新 UI */ }
}
```

### 5.9 Unity 中的委托与事件

```csharp
// 1) C# 事件：纯代码解耦，最常用
public static class GameEvents
{
    public static event Action<int> OnScoreChanged;
    public static void RaiseScoreChanged(int score) => OnScoreChanged?.Invoke(score);
}

// 2) UnityEvent / UnityAction：可在 Inspector 拖拽绑定，适合策划配置
using UnityEngine.Events;
public class TriggerZone : MonoBehaviour
{
    public UnityEvent OnPlayerEnter;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) OnPlayerEnter?.Invoke();
    }
}

// 3) UI 按钮：AddListener 本质就是委托订阅，遗忘 RemoveListener 同样会泄漏
button.onClick.AddListener(OnClick);
button.onClick.RemoveListener(OnClick);
```

### 5.10 自研事件中心 vs C# 原生 event

| 对比项 | 自研（枚举 + 事件中心） | C# 原生 `event` |
|---|---|---|
| 相同点 | 观察者模式：注册回调 → 触发时依次通知 | 同 |
| 触发权限 | 外部也能调用（安全性等同裸委托） | 只有声明类内部能触发 |
| 类型安全 | 靠运行时判断 / 类型转换，写错要跑起来才发现 | 编译期检查订阅方法签名 |
| 组织方式 | 一个管理器集中管所有事件类型（靠枚举 key 分发） | 每个事件是独立成员 |
| 适用 | 跨模块、事件种类多的项目 | 局部、一对多通知 |

> 自研轻量事件中心在项目里很常见，但要清楚它的**代价**：牺牲了编译期类型安全和触发权限控制。
> 改进方向：用泛型事件中心（`Action<T>` 按类型分发）而不是枚举 + object 参数。

### 5.11 语法速查

```csharp
public event Action<int> OnValueChanged;      // 声明事件
OnValueChanged += Handler;                    // 订阅
OnValueChanged -= Handler;                    // 退订
OnValueChanged?.Invoke(42);                   // 触发（判空）
OnValueChanged = null;                        // 仅类内部可用：清空所有订阅
```

### 5.12 常见坑

| 坑 | 原因 | 解决 |
|---|---|---|
| 用 lambda 订阅后 `-=` 退订无效 | 每次 lambda 都是新的委托对象，无法与订阅时的实例匹配 | 把 lambda 存进 `Action` 变量，再用同一个变量订阅 / 退订 |
| 忘记退订 → 内存泄漏 | 事件持有订阅者引用，GC 无法回收；Unity 中还会 `MissingReferenceException` | 订阅 / 退订成对写；Unity 放 `OnEnable` / `OnDisable` |
| 没有订阅者时直接 `OnComplete()` 触发报错 | 委托为 null，调用 null 委托 → `NullReferenceException` | 用 `?.Invoke()` 判空后触发 |
| 外部对事件用 `=` 赋值编译不过 | `=` 是替换整个订阅列表，会让所有人订阅被清空 | 外部只用 `+=` / `-=`；类内部需要清空时才用 `=` |
| 订阅方法签名不匹配 | 委托要求签名一致（参数、返回值） | 按签名写方法；用 `Action` / `Func` 明确参数类型 |
| `static event` 的订阅会跨调用累积 | 静态成员生命周期是整个程序：方法结束后订阅仍在列表里，下次再订阅就变成两份 | 优先用实例事件；必须用静态事件中心时，成对订阅 / 退订或提供 `Clear()` |
| 订阅后没退订干净，逻辑执行两次会重复收到通知 | 第一次执行结束时订阅还挂着，第二次又订阅一遍（列表变成 `[B, A, B]`） | 结束时把订阅的**全部**退掉；重复执行两次就能发现 |

---

## 六、LINQ

### 6.1 LINQ 是什么

**LINQ = Language Integrated Query（语言集成查询）**：用同一套语法查询各种数据源（数组、`List<T>`、Dictionary、XML、数据库…），不用为每种数据源学一套 API。

| 优势 | 说明 |
|---|---|
| **声明式** | 写「我要什么」（`Where(m => m.Hp > 80)`），而不是「怎么循环」（for + if + 临时 List） |
| **可链式组合** | 查询像管道一样叠加：`Where(...).OrderBy(...).Select(...).Take(3)` |
| **类型安全 + 智能提示** | 编译期检查类型，写错立刻报错 |

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

### 6.2 核心方法一览（重点：返回类型 + 执行时机）

| 方法 | 作用 | 返回类型 | 执行时机 |
|---|---|---|---|
| `Where` | **筛**：保留满足条件的元素（数量变少，元素不变） | `IEnumerable<T>` | 延迟 |
| `Select` | **变**：把每个元素投影成另一种东西（数量不变，元素变） | `IEnumerable<TResult>` | 延迟 |
| `OrderBy` / `OrderByDescending` | 排序：升序 / 降序 | `IOrderedEnumerable<T>` | 延迟 |
| `Take(n)` | 取前 n 个 | `IEnumerable<T>` | 延迟 |
| `Any` | 是否存在至少一个满足条件的元素 | `bool` | **立即** |
| `First` / `FirstOrDefault` | 取第一个（满足条件的）元素 | `T` | **立即** |
| `ToList` / `ToArray` | 把查询物化成集合 | `List<T>` / `T[]` | **立即**（触发前面所有延迟查询） |

```csharp
var numbers = new List<int> { 5, 2, 8, 1, 9, 3 };

var evens   = numbers.Where(n => n % 2 == 0);              // 筛：2, 8
var doubled = numbers.Select(n => n * 2);                  // 变：10,4,16,2,18,6
var sorted  = numbers.OrderBy(n => n);                     // 升序：1,2,3,5,8,9
var top2    = numbers.OrderByDescending(n => n).Take(2);   // 降序取前 2：9,8
bool hasBig = numbers.Any(n => n > 8);                     // true
int  first  = numbers.FirstOrDefault(n => n > 7);          // 8
```

### 6.3 Where vs Select：记住「筛」和「变」

```csharp
monsters.Where(m => m.Hp > 80);                // 结果还是 Monster，只是少了几个
monsters.Select(m => m.Name);                  // 结果变成 string（Monster → string）
monsters.Select(m => new { m.Name, m.Hp });    // 也可以投影成匿名对象
```

### 6.4 多级排序要用 ThenBy

```csharp
// ❌ 第二个 OrderBy 是「重新排序」，不是追加
monsters.OrderBy(m => m.Hp).OrderBy(m => m.Name);

// ✅ 第一级 OrderBy + 后续级 ThenBy
monsters.OrderBy(m => m.Hp).ThenBy(m => m.Name);
```

### 6.5 Lambda 表达式

- **名字**：Lambda 表达式（匿名函数），用 `=>` 书写，读作 "goes to"
- **箭头左边**：参数列表；**箭头右边**：表达式或语句块
- 与委托的关系：`m => m.Hp > 80` 会被编译器包装成 `Func<Monster, bool>`，所以能直接传给 `Where`

```csharp
() => Console.WriteLine("无参")                 // 无参数
n => n * 2                                      // 单参数（可省括号）
(int a, int b) => a + b                         // 多参数（带类型）
n => { var x = n * 2; return x + 1; }           // 语句块（需要 return）
m => m.Hp > 80                                  // 最常用于 Where 的条件
```

### 6.6 延迟执行（Deferred Execution）

`Where` / `Select` / `OrderBy` 这些方法**只是构造查询对象，并没有真正执行**；遇到下面的「触发动作」才真正跑：

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
foreach (var m in query) { ... }              // 这个 999 也会被查出来

// 坑 2：每次遍历都重新计算一遍（数据量大时浪费性能）
foreach (var m in query) { }                  // 算第一遍
foreach (var m in query) { }                  // 又算一遍

// 解决：需要重复使用时先物化
var cached = monsters.Where(m => m.Hp > 80).ToList();   // 只算一次
```

### 6.7 First vs FirstOrDefault

| | `First` | `FirstOrDefault` |
|---|---|---|
| 找到 | 返回第一个匹配元素 | 同 |
| **没找到** | **抛 `InvalidOperationException`** | 返回 `default(T)`（引用类型 `null`，int `0`，bool `false`） |
| 该用哪个 | 你**确定**一定有匹配（或希望「没有就报错」暴露问题） | 你**无法保证**有匹配 |

```csharp
// 陷阱：FirstOrDefault 返回 null 时直接使用 → NullReferenceException
Monster m = monsters.FirstOrDefault(x => x.Hp > 1000);
Console.WriteLine(m.Name);                    // ❌ m 可能是 null
if (m != null) Console.WriteLine(m.Name);     // ✅ 先判空

// .NET 6+ 可指定默认值
Monster m2 = monsters.FirstOrDefault(x => x.Hp > 1000, new Monster { Name = "无" });
```

### 6.8 语法速查

```csharp
numbers.Where(n => n > 5)                       // 筛
numbers.Select(n => n * 2)                      // 变
numbers.OrderBy(n => n)                         // 升序
numbers.OrderByDescending(n => n).Take(3)       // 降序取前 3
numbers.Any(n => n > 100)                       // 有没有（bool，短路求值）
numbers.FirstOrDefault(n => n > 7)              // 第一个（没有则 default）
numbers.Where(n => n > 5).ToList()              // 物化成 List（触发执行）
```

### 6.9 常见坑

| 坑 | 原因 | 解决 |
|---|---|---|
| 以为 `Where` 返回 `List<T>`，直接调 `list.Add()` 报错 | `Where` 返回的是 `IEnumerable<T>`（惰性序列） | 需要 List 就用 `.ToList()` 物化 |
| 构造查询后又改了数据源，结果里多出/少了元素 | 查询在**遍历时**才执行，看到的是那一刻的数据 | 需要「快照」就先 `.ToList()` |
| 同一个查询 foreach 两次，结果被算了两遍 | 延迟执行 = 每次枚举都重新计算 | 复用前先 `.ToList()` 缓存 |
| `FirstOrDefault` 返回 null/0 后直接使用 → `NullReferenceException` | 找不到时返回 `default(T)`（引用类型是 null） | 取出来先判空再使用 |
| 多级排序写了两遍 `OrderBy`，前一个排序失效 | 第二个 `OrderBy` 是重新排序，不是追加 | 第一级用 `OrderBy`，后续级用 `ThenBy` |
| 用 `Count() > 0` 判断「有没有」 | 要遍历完整个序列才能得到数量 | 用 `Any()`（找到一个就返回，短路求值） |
