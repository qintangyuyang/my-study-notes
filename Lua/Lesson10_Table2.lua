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

print("*****************表的公共操作*****************")