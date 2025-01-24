public class MyClass {
    public int MyProperty { get; set; } = 0; // Initialize the property

    public void MyMethod() {
        // Now this will not throw a NullReferenceException
        int value = MyProperty * 2; 
    }

    public void MyMethodSafe() {
        //This handles the case where MyProperty might be null using null-conditional operator
        int value = MyProperty != 0 ? MyProperty * 2 : 0;
    }
}