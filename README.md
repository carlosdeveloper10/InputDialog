# InputDialog
A simple .dll library to make Input dialog with C#, VB .NET or some .NET languages

## What can you do it with this .dll?
You can make useful windows(pop ups) to request and catch any messages from users.
This library is similar to java's class `JOptionPane`

## How to use it
The following codes are examples with C# and VB .NET

<b>C#:</b>
-  reference to the .dll 
```c#
using cmsoft.com.inputWindow; 
```
-  call the function.
```c#
String msg;
msg = InputDialog.Show("Here the message");
msg = InputDialog.Show("Here the message", "Here the window title");
//Explore the other options
```

<b>VB .NET:</b>
-   reference to the .dll
```vb
Imports cmsoft.com.inputWindow
```
-  call the function.
```vb
Dim msg As String
msg = InputDialog.Show("Here the message")
msg = InputDialog.Show("Here the message", "Here the window title")
```
--------------

Copyright (c) 2015 [Carlos Mario](https://twitter.com/carlos_mario__)

--------------
