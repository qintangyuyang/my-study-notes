# C# 语法规范与命名（参考手册 · 长期查阅）

> 背景：摸底测试发现关键字大小写习惯需要矫正（Public/Int/If → public/int/if）。
> 这份是**规范参考**，不用背，写代码时对照；目标：两周内养成肌肉记忆。

## 1. 关键字：全部小写

public / private / protected / class / struct / interface / static / void / int / float / double / bool / string / if / else / for / foreach / while / return / new / null / true / false / try / catch / finally / get / set / out / ref / virtual / override / base / this …

```
❌ Public int MaxOf(int[] arr)   ✅ public int MaxOf(int[] arr)
❌ If (x > 0)                    ✅ if (x > 0)
❌ Return MaxNum;                ✅ return maxNum;
```

## 2. 命名规范（C# 官方约定）

| 对象 | 规范 | 示例 |
|---|---|---|
| 类名 / 方法名 / 属性名 | PascalCase（大驼峰） | PlayerController、GetComponent、MaxOf |
| 局部变量 / 方法参数 | camelCase（小驼峰） | moveSpeed、bulletPrefab、maxNum |
| 私有字段 | _camelCase（下划线开头） | _instance、_isGrounded |
| 接口 | I + PascalCase | IInteractable、IDamageable |
| 常量 | 全大写 + 下划线 | MAX_HEALTH |

## 3. 其他习惯

- 每个语句以 `;` 结尾
- 缩进 4 个空格；大括号风格选一种并保持一致（C# 惯例：独占一行）
- `int`、`string`、`bool` 是关键字（小写）；`List<int>` 里的 `List` 是类型（PascalCase）
- 布尔判断直接写 `if (isGrounded)`，不要写 `if (isGrounded == true)`

## 4. IDE 设置（帮助养成习惯）

- 打开自动补全（VS / Rider 默认开启）
- 格式化快捷键：VS `Ctrl+K, Ctrl+D`；Rider `Ctrl+Alt+L`
- 命名不规范时 IDE 会有波浪线提示，按提示改

## 5. 练习自检

- [ ] 我写的每个关键字都是小写
- [ ] 类名/方法名大驼峰，变量名小驼峰
- [ ] 没有漏分号
- [ ] 命名有意义（不用 a、b、x1 这种无意义名字）
