using System;


//no parameter and return type void empty function
Action a=()=>Console.WriteLine("hi");
a();
//one int parameter and return void
Action<int> a1=n=>Console.WriteLine(n*n);
a1(10);
//two parameter 
Action<string,string> a2=(s1 ,s2)=>Console.WriteLine(s1+s2);
a2("Hello","World");
//func delegate  no parameter but return int
Func<int> f=()=>12;
Console.WriteLine(f());
//func with int parameter and return int 
//here it always return last type of parameter here int
Func<int ,int> f1=n=>n*n;
Console.WriteLine(f1(10));
//here return bool the last parameter
Func<int,int,bool> f2=(n1,n2)=>n1==n2;
Console.WriteLine(f2(10,20));