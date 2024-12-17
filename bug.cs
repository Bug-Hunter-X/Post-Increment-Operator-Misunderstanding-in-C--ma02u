public class MyClass
{
    public int MyProperty { get; set; }

    public MyClass()
    {
        MyProperty = 5; 
    }

    public void MyMethod()
    {
        int x = MyProperty++; //This line will increment the property after assigning it to x. 
        Console.WriteLine(x); // Output: 5
        Console.WriteLine(MyProperty); // Output: 6
    }
}