// =====================================================================
// LC 125 · Valid Palindrome（验证回文串）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定字符串 s，忽略其中非字母数字字符，且忽略大小写，判断它是否
//         是回文串（正读反读相同）。
// 【示例】"A man, a plan, a canal: Panama" → true；"race a car" → false
// =====================================================================
using System;

class ValidPalindromeDemo
{
    public static void Run()
    {
        string s1 = "A man, a plan, a canal: Panama";
        string s2 = "race a car";
        Console.WriteLine("用例1 → " + IsPalindrome(s1) + "（期望 True）");
        Console.WriteLine("用例2 → " + IsPalindrome(s2) + "（期望 False）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 false——打开本文件实现 TODO）");
    }

    // TODO：实现 IsPalindrome——只比较字母数字字符且忽略大小写
    static bool IsPalindrome(string s)
    {
        return false;   // 占位，实现后删除
    }
}
