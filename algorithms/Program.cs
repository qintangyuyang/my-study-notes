using System;

// 算法练习入口：输入 LeetCode 题号运行对应题目
// 加新题步骤：
//   1. 在 solutions/ 目录新建文件（LC 题号-题目名.cs）
//   2. 文件里写一个 class（如 xxxDemo），提供 public static void Run()
//   3. 在下面菜单加一行 case
//   4. 在 README.md 的进度表里登记
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("===== 算法题练习（输入 LC 题号）=====");
            Console.WriteLine("    1  Two Sum 两数之和               简单  ✅");
            Console.WriteLine("    9  Palindrome Number 回文数       简单  ⬜");
            Console.WriteLine("   13  Roman to Integer 罗马数字      简单  ⬜");
            Console.WriteLine("   14  Longest Common Prefix 公共前缀 简单  ⬜");
            Console.WriteLine("   26  Remove Duplicates 去重         简单  ⬜");
            Console.WriteLine("   27  Remove Element 移除元素        简单  ⬜");
            Console.WriteLine("   58  Length of Last Word 末词长度   简单  ⬜");
            Console.WriteLine("   88  Merge Sorted Array 合并数组    简单  ⬜");
            Console.WriteLine("  121  Best Time to Buy/Sell 股票     简单  ⬜");
            Console.WriteLine("  125  Valid Palindrome 验证回文串    简单  ⬜");
            Console.WriteLine("  167  Two Sum II 两数之和 II        中等  ⬜");
            Console.WriteLine("  169  Majority Element 多数元素      简单  ⬜");
            Console.WriteLine("  202  Happy Number 快乐数            简单  ⬜");
            Console.WriteLine("  219  Contains Duplicate II 重复元素 简单  ⬜");
            Console.WriteLine("  242  Valid Anagram 字母异位词       简单  ⬜");
            Console.WriteLine("  383  Ransom Note 赎金信             简单  ⬜");
            Console.WriteLine("  392  Is Subsequence 子序列          简单  ⬜");
            Console.WriteLine("    0  退出");
            Console.Write("输入题号：");
            string input = Console.ReadLine();
            Console.WriteLine();
            if (input == null) { break; }        // 没有输入（例如管道关闭）时退出，防止卡住
            switch (input.Trim())
            {
                case "1": TwoSumDemo.Run(); break;
                case "9": PalindromeDemo.Run(); break;
                case "13": RomanToIntegerDemo.Run(); break;
                case "14": LongestCommonPrefixDemo.Run(); break;
                case "26": RemoveDuplicatesDemo.Run(); break;
                case "27": RemoveElementDemo.Run(); break;
                case "58": LengthOfLastWordDemo.Run(); break;
                case "88": MergeSortedArrayDemo.Run(); break;
                case "121": MaxProfitDemo.Run(); break;
                case "125": ValidPalindromeDemo.Run(); break;
                case "167": TwoSumIIDemo.Run(); break;
                case "169": MajorityElementDemo.Run(); break;
                case "202": HappyNumberDemo.Run(); break;
                case "219": ContainsDuplicateDemo.Run(); break;
                case "242": ValidAnagramDemo.Run(); break;
                case "383": RansomNoteDemo.Run(); break;
                case "392": IsSubsequenceDemo.Run(); break;
                case "0": return;
                default: Console.WriteLine("无效题号，请输入列表中的编号"); break;
            }
        }
    }
}
