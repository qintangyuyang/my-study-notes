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
    }

    static int RomanToInt(string s)
    {
        int result = 0;
        int first = 0;
        int second = 1;
        if (s.Length == 1)
        {
            return GetValue(s[0]);
        }
        while (second < s.Length)
        {
            if (GetValue(s[first]) >= GetValue(s[second]))
            {
                result += GetValue(s[first]);
                first++;
                second++;
            }
            else
            {
                result += GetValue(s[second]) - GetValue(s[first]);
                first += 2;
                second += 2;
            }
            //判断一下指针移动后second是否越界，如果越界了就把最后一个字符的值加上
            if (second >= s.Length && first < s.Length)
            {
                result += GetValue(s[first]);
            }
        }
        return result;
    }

    static int GetValue(char c)
    {
        switch (c)
        {
            case 'I': return 1;
            case 'V': return 5;
            case 'X': return 10;
            case 'L': return 50;
            case 'C': return 100;
            case 'D': return 500;
            case 'M': return 1000;
            default: return 0;
        }
    }
}
