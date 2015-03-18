# SafeConvert
The SafeConvert is a .NET library used to convert data between data types safely.
![SafeConvert class diagram](http://i.imgur.com/DVSuiwO.png "SafeConvert class diagram")

### Install and Requirements
In order to use this library, your application needs the .NET Framework 3.5 or higher. If okay, you can install via two following ways:
* Via Nuget: ```Install-Package SafeConvert```
* Via Github: ```https://github.com/congdongdotnet/SafeConvert.git```

### Usages
After refering to the SafeConvert library, remember that you need to include the library by __using__ keyword:
```c#
using SafeConvert;
```

### Samples
Convert from string "1" to byte
```c#
var b = "1".ToByte(); // Print 1
```
Convert from string "10" to short
```c#
var s = "10".ToShort(); // Print 10
```
Convert from string "100" to int
```c#
var n = "100".ToInt(); // Print 100
```
Convert from string "1000" to long
```c#
var l = "1000".ToLong(); // Print 1000
```
Convert from string "6.5" to float
```c#
var f = "6.5".ToFloat(); // Print 6.5
```
Convert from string "6.5" to decimal
```c#
var d = "6.5".ToDecimal(); // Print 6.5
```
Convert from string "6.5" to double
```c#
var d = "6.5".ToDouble(); // Print 6.5
```
Convert from string "2014-12-02 11:00:00" to DateTime
```c#
var dateTime = "2014-12-02 11:00:00".ToDateTime();
```
Convert from string "20" to int using generic
```c#
var n = "20".To<int>();
```
Each extension methods has the default value in case of failing to parse. E.g: convert from string "abc" to int using default value
```c#
var n = "abc".ToInt(10); // Print default value 10 because of failing to parse
```

### Tests
This library has been tested ![Passed](http://i.imgur.com/rq5lf6x.png "Passed") using NUnit Test Framework. If any issue or bug, please push a new issue [here](https://github.com/congdongdotnet/SafeConvert/issues).

### Copyright and License
Copyright 2015 by CongDongDotNet - MIT License
