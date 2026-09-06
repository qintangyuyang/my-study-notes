// =====================================================================
// LC 121 · Best Time to Buy and Sell Stock（买卖股票的最佳时机）· 简单
// 来源：LeetCode 面试经典 150 题
// ---------------------------------------------------------------------
// 【题目】给定数组 prices，prices[i] 是第 i 天的股票价格。只能选择某一天
//         买入并在之后的某一天卖出，求能获得的最大利润；无法获利则返回 0。
// 【示例】[7,1,5,3,6,4] → 5（第 2 天买 1，第 5 天卖 6）
// =====================================================================
using System;

class MaxProfitDemo
{
    public static void Run()
    {
        int[] prices = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine("prices=[7,1,5,3,6,4] → " + MaxProfit(prices) + "（期望 5）");
        Console.WriteLine("prices=[7,6,4,3,1] → " + MaxProfit(new[] { 7, 6, 4, 3, 1 }) + "（期望 0）");
        Console.WriteLine();
        Console.WriteLine("（尚未实现，目前恒返回 0——打开本文件实现 TODO）");
    }

    // TODO：实现 MaxProfit——只能买卖一次（先买后卖），返回最大利润
    static int MaxProfit(int[] prices)
    {
        return 0;   // 占位，实现后删除
    }
}
