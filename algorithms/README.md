# 算法练习（algorithms/）

独立于每周学习练习的算法题集，**直接打开本文件夹就能运行**（Rider / VS Code / 命令行）。

## 目录结构

```
algorithms/
├── Algorithms.sln         # 解决方案（Rider 打开它）
├── Algorithms.csproj      # 项目文件
├── Program.cs             # 菜单入口：输入编号运行对应题目
├── solutions/             # 每题一个 .cs 文件（题号-题目名）
└── README.md              # 本文件（进度记录表在这里）
```

## 运行方式（任选一种）

- **Rider**：`File → Open` → 选 `algorithms/Algorithms.sln` → 运行按钮 / `Shift+F10`
- **VS Code**：装「C# Dev Kit」→ `Open Folder` 选 `algorithms` 文件夹 → `F5`（已配好）或终端 `dotnet run`
- **命令行**：`cd algorithms && dotnet run`，然后输入题目编号回车

## 怎么加新题（每次 4 步）

1. 复制 `solutions/001-TwoSum.cs` 改名为 `00X-题目名.cs`
2. 修改文件头注释（题号 / 题目 / 示例 / 思路 / 复杂度 / 日期）
3. 补 `Program.cs` 菜单里加一行 case
4. 在下面进度表登记一行

## 每题文件头注释模板（照抄）

```
// 题号：00X　题目：xxx　难度：简单/中等/困难
// 来源：LeetCode 序号
// 【题目】一句话说明 + 输入输出
// 【示例】一个例子
// 【思路】你怎么想的（这是最重要的复盘材料，别偷懒）
// 【复杂度】时间 O(?) 空间 O(?)
// 【完成日期】xxxx-xx-xx
```

## 推荐刷题清单（LeetCode「面试经典 150 题」子集 · 2026-09 批次）

按当前水平挑选，建议节奏每周 2–3 道。来源：[Top Interview 150 官方题单](https://leetcode.com/studyplan/top-interview-150/)。

### 第 1 批 · 数组/字符串热身（现在就能刷）
| LC 题号 | 题名 | 难度 | 考点 |
|---|---|---|---|
| 27 | Remove Element | 简单 | 数组原地操作 |
| 26 | Remove Duplicates from Sorted Array | 简单 | 数组遍历 |
| 169 | Majority Element | 简单 | 遍历计数 / 摩尔投票 |
| 121 | Best Time to Buy and Sell Stock | 简单 | 一次遍历记录最小值 |
| 58 | Length of Last Word | 简单 | 字符串 |
| 14 | Longest Common Prefix | 简单 | 字符串比较 |
| 9 | Palindrome Number | 简单 | solutions/009-PalindromeNumber.cs 已建好，先补它 |

### 第 2 批 · 哈希表实战（Dictionary 练手）
| LC 题号 | 题名 | 难度 | 考点 |
|---|---|---|---|
| 1 | Two Sum | 简单 | 已完成（001），可重刷 |
| 242 | Valid Anagram | 简单 | 字符计数 |
| 383 | Ransom Note | 简单 | 字符计数 |
| 13 | Roman to Integer | 简单 | char→value 映射 |
| 202 | Happy Number | 简单 | 循环检测 |
| 219 | Contains Duplicate II | 简单 | 值→索引哈希 |

### 第 3 批 · 双指针入门（先理解「双指针思想」再刷）
| LC 题号 | 题名 | 难度 | 考点 |
|---|---|---|---|
| 125 | Valid Palindrome | 简单 | 首尾双指针 |
| 392 | Is Subsequence | 简单 | 双指针 |
| 88 | Merge Sorted Array | 简单 | 从后往前合并 |
| 167 | Two Sum II | 中等 | 有序数组双指针 |

> 所有文件已生成在 `solutions/`（LC 题号命名，含题目与测试用例，**无解题思路**，自行实现 TODO）。

## 进度记录表（做题后更新）

| 题号 | 题目 | 难度 | 思路/要点 | 复杂度 | 日期 | 状态 |
|---|---|---|---|---|---|---|
| LC 1 | 两数之和 TwoSum | 简单 | 哈希表：值→下标，边遍历边查 | O(n)/O(n) | 2026-09-06 | ✅ |
| LC 9 | 回文数 Palindrome | 简单 | - | - | - | ⬜ |
| LC 13 | 罗马数字转整数 Roman to Integer | 简单 | - | - | - | ⬜ |
| LC 14 | 最长公共前缀 Longest Common Prefix | 简单 | - | - | - | ⬜ |
| LC 26 | 删除有序数组重复项 Remove Duplicates | 简单 | - | - | - | ⬜ |
| LC 27 | 移除元素 Remove Element | 简单 | - | - | - | ⬜ |
| LC 58 | 最后一个单词长度 Length of Last Word | 简单 | - | - | - | ⬜ |
| LC 88 | 合并两个有序数组 Merge Sorted Array | 简单 | - | - | - | ⬜ |
| LC 121 | 买卖股票最佳时机 Best Time to Buy/Sell | 简单 | - | - | - | ⬜ |
| LC 125 | 验证回文串 Valid Palindrome | 简单 | - | - | - | ⬜ |
| LC 167 | 两数之和 II Two Sum II | 中等 | - | - | - | ⬜ |
| LC 169 | 多数元素 Majority Element | 简单 | - | - | - | ⬜ |
| LC 202 | 快乐数 Happy Number | 简单 | - | - | - | ⬜ |
| LC 219 | 存在重复元素 II Contains Duplicate II | 简单 | - | - | - | ⬜ |
| LC 242 | 有效的字母异位词 Valid Anagram | 简单 | - | - | - | ⬜ |
| LC 383 | 赎金信 Ransom Note | 简单 | - | - | - | ⬜ |
| LC 392 | 判断子序列 Is Subsequence | 简单 | - | - | - | ⬜ |

## 约定

- 每题先**自己写**，跑通后再看别人的题解；把「你的思路」写进文件头注释
- 一道题卡 30 分钟以上可以先跳过或看提示，但要标记「没想出来」，下次重做
- 编译产物 bin/ obj/ 已被 `.gitignore` 忽略，不用担心提交
