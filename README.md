# InputDialog
A simple .dll library to make Input dialog with C#, VB .NET or some .NET language

## Ca you do it whit this .dll?
Yuo can make useful window(pop up) to ask and catch any messages from users.
this library is similar to java function `OptionPane.showMessageDialog();`

## How to use it
The following codes are examples with C# and VB .NET

<b>C#:</b>
-  reference to .dll 
```c#
using cmsoft.com.inputWindow; 
```
-  call the function.
```c#
String msg;
msg = InputDialog.Show("Here the message");
msg = InputDialog.Show("Here the message", "Here the title window");
//Explore the other options
```

<b>VB .NET:</b>
-   reference to .dll
```vb
Imports cmsoft.com.inputWindow
```
-  call the function.
```vb
Dim msg As String
msg = InputDialog.Show("Here the message")
msg = InputDialog.Show("Here the message", "Here the title window")
```
--------------

Copyright (c) 2015 [Carlos Mario](https://twitter.com/carlos_mario__)

--------------
