# The Using Statement


------

The using statement in C# defines the lifetime of an object in the code. It removes the responsibility for cleaning up and releasing resources used by an object from the developer and by that saving us precious time and effort.

The .NET framework automatically handles memory allocated to an object and releases it when the Common Language Runtime (CLR) decides to perform Garbage Collection (GC). That means whenever all references to an object has run out of scope, the memory used by it will be released at some point. This is to a certain extent quite effective, but in some scenarios it would be better if the resources can be released right after we are done with the object. That's what the using statement is for.

**NOTE:** The *using _statement_* is not the same as the *using _directive_*. The latter is used to reference namespaces that should be included in the code allowing the developer to use types defines in that namespace. The example below incudes the system.data namespace that among other defines types used for database access:

```c-sharp
using system.data; 
```

## IDisposable Interface

Unmanaged resources in .NET are typically objects that wraps system resources such as files, network, or database connections which are not automatically released and cleaned by garbage collection so you have to do that manually. 

The dispose pattern is used when an object access unmanaged resources. It is defined by the implementation of the `IDisposable` interface that has a single method called `Dispose`. All types defined in the .NET Framework that use unmanaged resources implement the `IDisposable` interface, and to release the unmanaged resources you just need to call the Dispose method after you finish using them. 

```c-sharp
StreamReader s = new StreamReader("Files/TextFile1.txt");
try
{
   while (s.Peek() != -1)
   {
      var line = s.ReadLine();
      Console.WriteLine(Encoding.ASCII.GetString(line.GetByteArray()));
   }
}
finally
{
   if (s != null)
      ((IDisposable)s).Dispose();
}
```

In the example above the StreamReader object is used for reading the contents of a file. When the process is done reading the resources used by the streamreader are released by calling the `Dispose` method implemented by the `IDisposable` interface. This is done in a `finally` block to ensure that the unmanaged resources are released even if an exception occurs. It is still possible to handle an exception by adding a `catch` block.

## Using the Using Statement

The using statement simplyfies the code to create and cleanup an object that uses unmanaged resources. The following example uses the `using` statement to create and release a `StreamReader` object by defining a block of code where the object will be automatically disposed when the using statement goes out of scope. The dispose method on the StreamReader object is not explicitly called. 

```c-sharp
using (var s = new StreamReader("Files/TextFile1.txt"))
{
    while (s.Peek() != -1)
    {
        var line = s.ReadLine();
        Console.WriteLine(Encoding.ASCII.GetString(line.GetByteArray()));
    }
}
```

It is also allowed to use multiple resources in a single statement by adding more object initializers or by using nested statements.

## Further Reading
* [Using Statement](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-statement)
* [IDisposable Interface](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable?view=netframework-4.8)
* [Cleaning Up Unmanaged Resources](https://docs.microsoft.com/en-us/dotnet/standard/garbage-collection/unmanaged)
