using System;
class A{
	static int n;     // static field 
    int m;            //non static field
	static A(){       //static constructor
		
		Console.WriteLine("Static Constructor");
	}
	public A(){
		Console.WriteLine("Non-Static Constructor");
	}
	static void Main(string [] args){
		A obj = new A();
	}
}