using tapsiriq___9;



Console.WriteLine("Enter string");

var str = Console.ReadLine();
MyClass cls = new MyClass(str);
Func funcDell = new Func(cls.Space);
funcDell += cls.Reverse;
	
Run run = new Run();
run.runFunc(funcDell, str);
