// =====================================================================
// LC 383 · Ransom Note（赎金信）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定两个字符串 ransomNote 和 magazine，判断 ransomNote 能否由
//         magazine 中的字符构成（magazine 每个字符只能用一次，只看小写
//         英文字母）。
// 【示例】ransomNote=a, magazine=b → false；ransomNote=aa, magazine=aab → true
// =====================================================================
using System;

class RansomNoteDemo
{
    public static void Run()
    {
        Console.WriteLine("a / b → " + CanConstruct("a", "b") + "（期望 False）");
        Console.WriteLine("aa / aab → " + CanConstruct("aa", "aab") + "（期望 True）");
        Console.WriteLine("aa / ab → " + CanConstruct("aa", "ab") + "（期望 False）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 false——打开本文件实现 TODO）");
    }

    // TODO：实现 CanConstruct——magazine 能否提供 ransomNote 所需的全部字符
    static bool CanConstruct(string ransomNote, string magazine)
    {
        return false;   // 占位，实现后删除
    }
}
