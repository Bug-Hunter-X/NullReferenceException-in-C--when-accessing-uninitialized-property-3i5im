public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // This will throw a NullReferenceException if MyProperty is not initialized.
        int value = MyProperty * 2; 
    }
}