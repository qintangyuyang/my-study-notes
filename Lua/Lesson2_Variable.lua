print("*****************变量*****************")
--lua当中的简单变量类型
-- nil number string boolean
--lua中所有的变量申明 都不需要申明变量类型 它会自动的判断类型
--lua中的一个变量可以随便赋值 自动识别类型

--通过type函数 返回值是string 可以得到变量的类型

--lua中使用没有申明过的变量
--不会报错 默认值 是nil
print(b)

print("*****************nil*****************")
--这个nil 类似于C#中的null
a = nil
print(a)
print(type(a))
print(type(type(a))) --string

print("*****************number*****************")
--number 所有的数值都是number
a = 10
print(a)
a = 1.2
print(a)
print(type(a))

print("*****************string*****************")
a = "123"
print(a)
--字符串的申明 使用单引号或者双引号包裹
--lua里 没有char
a = '1234'
print(a)
print(type(a))

print("*****************Boolean*****************")
a = true
print(a)
a = false
print(a)
print(type(a))


--复杂数据类型
--函数
--表 table
--数据结构 userdata
--协同程序 thread（线程）