print("*****************复杂数据类型 table2*****************")

print("*****************字典*****************")
print("*****************字典的申明*****************")
--字典是由键值对构成
a = {["name"] = "haha",["age"] = 18,["1"] = 5}
--访问单个变量 用中括号填键 来访问
print(a["name"])
print(a["age"])
print(a["1"])
--还可以类似.成员变量的形式得到值
print(a.name)
print(a.age)
--虽然可以通过.成员变量的形式得到值 但是不能是数字
--print(a.1)

--修改
a["name"] = "TTT"
print(a.name)
--增加
a["sex"] = false
print(a.sex)
--删除
a["sex"] = nil

print("*****************字典的遍历*****************")
--如果要模拟字典 遍历一定要用pairs
for k,v in pairs(a) do
	--可以传多个参数 一样可以打印出来
	print(k,v)
end

for k in pairs(a) do
	print(k)
	print(a[k])
end

for _,v in pairs(a) do
	print(v)
end

print("*****************类和结构体*****************")
--lua中是默认没有面向对象的 需要我们自己来实现
--成员变量 成员函数.....
Student = {
			--年龄
			age = 1,
			--性别
			sex = true,
			Up = function()
				--这样写 这个age 和表中的age没有任何关系 它是一个全局变量
				--print(age)

				--想要在表内部函数中 调用表本身的属性或者方法
				--一定要指定是谁的 所以要使用 表名.属性 或 表名.方法
				print(Student.age)
				print("我成长了")
			end,
			Learn = function(t)
				--第二种 能够在函数内部调用自己属性或者方法的 方法
				--把自己作为一个参数传进来 在内部 访问
				print(t.sex)
				print("好好学习")
			end
			}

--lua中 .和冒号的区别
Student.Learn(Student)
--冒号调用方法 会默认把调用者 作为第一个参数传入方法中
Student:Learn()

--在申明表过后 在表外去申明表有的变量和方法
Student.name = "xxx"
Student.Speak = function()
	print("说话")
end
--函数的第三种申明方式
function Student:Speak2()
	--lua中 有一个关键字 self 表示 默认传入的第一个参数
	print(self.sex)
	print("说话2")
end

--C#中使用类 实例化对象new 静态直接点
--lua中类的表现 更像是一个类中有很多 静态变量和函数
print(Student.age)
print(Student.name)
Student.Up()
Student.Speak()
Student:Speak2()

print("*****************表的公共操作*****************")