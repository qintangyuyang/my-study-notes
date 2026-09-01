using System;

// 练习 1：重写 MaxOf（摸底卷子第 10 题）—— 你已完成，此文件已改造成项目结构
// 你的原代码有两个小问题，已修正：
//   1. Main 里调用了实例方法 MaxOf（静态方法里不能直接调用实例方法）→ MaxOf 改为 static
//   2. 原文件自带 Main 会与项目入口 Program.cs 冲突 → 改为 Run()，由 Program.cs 统一调用
// 优点：你额外做了 null / 空数组检查并抛异常，这是好习惯，保留了。

class MaxOfExercise
{
    public static int MaxOf(int[] arr)
    {
        if (arr == null || arr.Length == 0)
        {
            throw new ArgumentException("数组不能为空");
        }

        int maxNum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > maxNum)
            {
                maxNum = arr[i];
            }
        }
        return maxNum;
    }

    public static void Run()
    {
        // 测试数组 {3, 9, 2, 7, 5}，输出应为 9
        int[] testArray = { 3, 9, 2, 7, 5 };
        var maxValue = MaxOf(testArray);
        Console.WriteLine("最大值：" + maxValue);

        // 思考题：给 MaxOf 传一个空数组会怎样？（try-catch 试试）
    }
}
