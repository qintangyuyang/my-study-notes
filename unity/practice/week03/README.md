# 第 3 周练习：2D 角色移动 + 跳跃 + 落地判定

> 这是重做**摸底卷子第 39 题**（当时输入 API 忘了怎么写、用了 `transform.Translate` 移动刚体）。
> 这次要求：在 Unity 里真跑起来——A/D 移动、Space 跳跃、不能二段跳、不穿地。

---

## 一、建工程（约 5 分钟）

1. 打开 **Unity Hub → New project**，模板选 **2D**（Built-in 或 URP 都行）
2. 工程位置填 `D:\AA-Learning\unity-lab`，工程名 `unity-lab`
3. 版本：2022.3 LTS 或 Unity 6 都行——**记下版本号，填进周记**
4. 建好后，在 `D:\AA-Learning\unity-lab` 目录里开终端执行：

```bash
git init
copy ..\my-study-notes\.gitignore .gitignore   # 笔记仓库里那份就是 Unity 官方模板
git add .
git commit -m "chore: 初始化 Unity 2D 练习工程"
```

> `.gitignore` 会忽略 `Library/`、`Temp/`、`Logs/` 等；**`.meta` 文件必须提交**（Unity 用它记录资源引用关系）。

5. **Unity 设置检查**（很重要，决定场景/prefab 能不能 diff 和合并）：
   `Edit → Project Settings → Editor`
   - Version Control Mode = **Visible Meta Files**
   - Asset Serialization = **Force Text**

## 二、放脚本

把本目录的 `PlayerController2D.cs` 拷到工程的 `Assets/Scripts/` 下。

## 三、搭场景

1. 新建场景：`File → New Scene`，保存为 `Assets/Scenes/Week03.unity`
2. **地面**：Hierarchy 右键 → `2D Object → Sprites → Square`，改名 `Ground`
   - Transform Scale 设为 `(20, 1, 1)`，位置 `(0, -3, 0)`
   - Inspector → `Add Component` → **Box Collider 2D**
3. **玩家**：Hierarchy 右键 → `2D Object → Sprites → Capsule`，改名 `Player`，位置 `(0, 0, 0)`
   - `Add Component` → **Rigidbody 2D**（Body Type 保持 Dynamic）
   - `Add Component` → **Capsule Collider 2D**
   - `Add Component` → 选 **Player Controller 2D**（刚拷进去的脚本）
4. **Tag**：Project 面板 → `Tags and Layers` → Tags 里新增 `Ground`；选中 Ground 物体，把 Tag 设为 `Ground`
5. 摄像机保持默认即可（2D 正交视角）

## 四、填参数

选中 `Player`，在 Inspector 的 Player Controller 2D 组件里：
- `Move Speed` = 5
- `Jump Force` = 8

（如果你自己加了 `groundLayer` 之类的字段，也在这里设置）

## 五、运行与验收

按 **Play**，逐条测试：

| 操作 | 期望结果 |
|---|---|
| 按 A / D | 角色水平移动 |
| 站在地面上按 Space | 角色跳起 |
| 空中再按 Space | **不能**二段跳 |
| 从高处落下 | 稳稳落在 Ground 上，**不穿地** |
| Console 面板 | 没有红色报错 |

全部通过 = 本周练习达标。有任何一条不通过，先看下面的调试提示。

## 六、调试提示（卡住时再看）

- **角色穿地/往下掉不停**：Collider 是否加上？Rigidbody2D 是否是 Dynamic？两个物体是否在同一物理层？
- **跳跃没反应**：`_isGrounded` 是不是一直是 false？在 Update 和碰撞回调里加 `Debug.Log(_isGrounded)` 打印出来看
- **移动很滑 / 停不下来**：检查 Rigidbody2D 的 `Linear Drag`、`Gravity Scale`，以及是否每帧都在覆盖速度
- **完全不动**：检查输入的轴名（`Horizontal`、`Jump` 是旧输入系统的默认轴名，拼写必须一致）
- **方向键/A/D 都不响应**：Unity 6 如果用的是 **Input System Package**，旧 API（`Input.GetAxis`）会被禁用——`Project Settings → Player → Active Input Handling` 改成 `Both` 即可

## 七、卡住时怎么办

按老规矩：**先自己想 20–30 分钟**，把这周学的四个知识点翻一遍（输入 / 移动 / 碰撞 / UI），还是不行就把现象发我（Console 报错、你的代码、Inspector 截图），我们一起来查。
