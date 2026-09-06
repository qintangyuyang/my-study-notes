// =====================================================================
// LC 202 · Happy Number（快乐数）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】对一个正整数反复执行：替换为各位数字的平方和。若最终能变成 1，
//         则是快乐数；若陷入不包含 1 的循环则不是。
// 【示例】19 → 1²+9²=82 → 68 → 100 → 1，快乐数 → true；2 → false
// =====================================================================
using System;

class HappyNumberDemo
{
    public static void Run()
    {
        int[] tests = { 19, 2 };
        foreach (int n in tests)
        {
            Console.WriteLine(n + " → " + IsHappy(n));
        }
        Console.WriteLine("期望：19 → True；2 → False");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 false——打开本文件实现 TODO）");
    }

    // TODO：实现 IsHappy
    static bool IsHappy(int n)
    {
        return false;   // 占位，实现后删除
    }
}
