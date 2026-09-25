print("*****************条件分支语句*****************")
a = 9
-- if 条件 then ... end
--单分支
if a > 5 then
	print("123")
end

--双分支
if a < 5 then
	print("222")
else
	print("333")
end

--多分支
if a < 5 then
	print("123")
--lua中elseif一定是连着写
elseif a ==6 then
	print("6")
elseif a ==7 then
	print("7")
elseif a ==9 then
	print("9")	
end

--lua中没有switch语法 需要自己实现