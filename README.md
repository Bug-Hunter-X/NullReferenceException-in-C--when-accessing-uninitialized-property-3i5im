# NullReferenceException in C# when accessing uninitialized property

This repository demonstrates a common error in C#: the `NullReferenceException` that occurs when accessing a property of a class that has not been initialized.

## The Problem

The `bug.cs` file contains a class `MyClass` with a property `MyProperty`. The `MyMethod` attempts to use the value of `MyProperty` without checking if it has been assigned a value.

If `MyProperty` is null, accessing it will throw a `NullReferenceException`.

## The Solution

The `bugSolution.cs` file shows how to solve this problem by initializing `MyProperty` before using it, or by using null-conditional operators to safely handle the case where `MyProperty` is null.