// =====================================================================
// LC 9 · Palindrome Number（回文数）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给一个整数 x，如果 x 是回文整数（正着读反着读相同）返回 true，
//         否则返回 false。
// 【示例】121 → true；-121 → false；10 → false
// =====================================================================
using System;

class PalindromeDemo
{
    public static void Run()
    {
        int[] tests = { 121, -121, 10 };
        foreach (int x in tests)
        {
            Console.WriteLine(x + " → " + IsPalindrome(x));
        }
        Console.WriteLine("期望：121 → True；-121 → False；10 → False");
        Console.WriteLine();
    }

    static bool IsPalindrome(int x)
    {
        if (x < 0)
        {
            return false;
        }
        var str = x.ToString();
        int left = 0;
        int right = str.Length - 1;
        while (left < right)
        {
            if(str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true; 
    }
}
