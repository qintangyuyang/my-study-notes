# LINQ 入门

> 摸底第 12 题（Where 的作用）你选了 B 但标注「不确定」，第 19 题（用 LINQ 筛偶数）直接写了「不会」。
> 本周目标：彻底补齐 LINQ。

## ① 概念总结（用自己的话回答）

- LINQ 是什么？它和普通的 for + if 遍历写法比，优势是什么？
- 下面每个方法各自做什么？（动手实验后填）
  - Where
  - Select
  - OrderBy / OrderByDescending
  - Any
  - First / FirstOrDefault
- `n => n % 2 == 0` 这种写法的名字叫什么？代表什么？
- LINQ 的「延迟执行」是什么意思？（提示：Where 返回的是查询而不是结果，只有遍历/ToList 才真正执行）

## ② 最小可运行示例

- [ ] 完成 `csharp/exercises/week02/LinqDemo.cs`：对 100 条怪物数据分别用 Where / Select / OrderBy / Any / First 查询
- [ ] 用 Console 把每步结果打印出来，亲眼看到输出
- [ ] 补摸底第 19 题：`var evens = numbers.Where(n => n % 2 == 0);`

## ③ 踩坑记录

| 坑 | 原因 | 解决 |
|---|---|---|
|   |   |   |
