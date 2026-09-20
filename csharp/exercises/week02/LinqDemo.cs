using System;
using System.Collections.Generic;
using System.Linq;

// 练习 1：LINQ 处理怪物列表（摸底卷子 19 题的正式版）
// 数据已经帮你造好了（100 只怪物），你的任务是补全 5 个 TODO 查询。
// 做完用 Console.WriteLine 打印结果，亲眼看到输出。

// 怪物数据结构（已提供，不用改）
class Monster
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Hp { get; set; }

    public override string ToString() => $"#{Id} {Name}(HP:{Hp})";
}

class LinqDemo
{
    public static void Run()
    {
        // 造 100 条怪物数据：Slime1 ~ Slime100，血量 10~100
        var monsters = new List<Monster>();
        var random = new Random();
        for (int i = 1; i <= 100; i++)
        {
            monsters.Add(new Monster { Id = i, Name = "Slime" + i, Hp = random.Next(10, 101) });
        }
        Console.WriteLine("共 " + monsters.Count + " 只怪物，样例：" + monsters[0]);

        //（Where 过滤）：找出血量大于 80 的强怪，打印数量
        // 提示：var strongOnes = monsters.Where(m => m.Hp > 80);
        // 提示：ToArray()/ToList() 或 foreach 才能取到结果（延迟执行）
        var strongOnes = monsters.Where(m => m.Hp > 80).ToList();
        Console.WriteLine("血量大于 80 的强怪数量：" + strongOnes.Count);

        //（Select 投影）：把所有怪物名字投影成 List<string>，打印前 3 个名字
        var monsterNames = monsters.Select(m => m.Name).ToList();
        Console.WriteLine("前 3 个怪物名字：" + string.Join(", ", monsterNames.Take(3)));

        //（OrderBy 排序）：按血量从低到高排序，打印血量最低的 3 只
        // 提示：OrderBy(m => m.Hp)，再 Take(3)
        var lowestHpMonsters = monsters.OrderBy(m => m.Hp).Take(3).ToList();
        Console.WriteLine("血量最低的 3 只怪物：" + string.Join(", ", lowestHpMonsters));

        // Any 判断）：有没有血量小于等于 10 的「菜鸡」？打印 有/没有
        // 提示：monsters.Any(m => m.Hp <= 10)
        var hasWeakMonster = monsters.Any(m => m.Hp <= 10);
        Console.WriteLine("有没有血量小于等于 10 的「菜鸡」？" + (hasWeakMonster ? "有" : "没有"));

        // First 取第一个）：找出第一个血量小于等于 10 的菜鸡，打印它的名字
        // 提示：FirstOrDefault(...)；找不到时返回 null，打印前先判空
        var firstWeakMonster = monsters.FirstOrDefault(m => m.Hp <= 10);
        Console.WriteLine("第一个血量小于等于 10 的菜鸡：" + (firstWeakMonster != null ? firstWeakMonster.Name : "没有找到"));
    }
}
