// =====================================================================
// LC 13 · Roman to Integer（罗马数字转整数）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】罗马数字含 I、V、X、L、C、D、M 七种字符，将其转换为整数。
//         通常小的数在大的数右边表示加；小的数在大的数左边表示减
//         （如 IV = 4、IX = 9）。
// 【示例】"III" → 3；"LVIII" → 58；"MCMXCIV" → 1994
// =====================================================================
using System;

class RomanToIntegerDemo
{
    public static void Run()
    {
        string[] tests = { "III", "LVIII", "MCMXCIV" };
        foreach (string s in tests)
        {
            Console.WriteLine(s + " → " + RomanToInt(s));
        }
        Console.WriteLine("期望：III → 3；LVIII → 58；MCMXCIV → 1994");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 0——打开本文件实现 TODO）");
    }

    // TODO：实现 RomanToInt
    static int RomanToInt(string s)
    {
        return 0;   // 占位，实现后删除
    }
}
