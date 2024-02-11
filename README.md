# c-sharp

## What is C#
- It is a programming language developed by Microsoft Corporation to run the .net framework.
- It is used to develop web applications, mobile apps and games

## Compiler

- C# is complied language.

![C# Compiler](assets/c#%20compiler.png)

1. `code` - ends with .cs extension

2. `compiler` - check error or not, generate the CLI code

3. `IL code` - Half complied code (Intermediate language).

4. `JIT compiler` - It converts the IL to machine code (Just in time).

## Syntax 

- c# files are created with the extension of .cs 

## Comments

```csharp
// single line comment 
/* Multi line comment */
```

## Variables

1. `int`
2. `double`
3. `char`
4. `string`
5. `bool`

Example:

```csharp
string name = "John";
Console.WriteLine(name);
```

### constants 

constants which is unchangable, it uses `const` keyword before the datatype

```csharp
const num = 7;
Console.WriteLine(num);
```

## Datatype

1. int myNum = 5;               // Integer (whole number) [2 bytes]
2. double myDoubleNum = 5.99D;  // Floating point number  [8 bytes]
3. char myLetter = 'D';         // Character              [2 bytes]
4. bool myBool = true;          // Boolean                [1 bit]
5. string myText = "Hello";     // String                 [2 bytes per char]


### Integer type

```csharp
int num = 5; // Integer
```
The int data type can store whole numbers from -2147483648 to 2147483647

```csharp
long num = 150000000000L;
```
The long data type can store whole numbers from -9223372036854775808 to 9223372036854775807

### float type
```csharp
float num = 5.0f; // Float
double dblNum = 5.0d; // Double
```
### scientific notation
```csharp
float f1 = 35e3f;
double d1 = 54e5d;

### boleans

```csharp
bool b1 = true;
bool b2 = false;
```

### char
```csharp
char c1 = 'A';
```

### string
```csharp
string s1 = "Hi there";
```

## type conversion

1. Implicit conversion - It is automatic conversion, it converts small values to large values.

`char` -> `int` -> `long` -> `float` -> `double`

```csharp
int num = 5;
double dd = num;
Console.WriteLine(num);
Console.WriteLine(dd);
```

2. Explicit conversion - It is a manual conversion, it converts large values to small values.

`double` -> `float` -> `long` -> `int` -> `char`

```csharp
double dd = 5.112;
int num = (int) dd;
Console.WriteLine(num);
Console.WriteLine(dd);
```

### Type conversion methods

```csharp
int myInt = 10;
double myDouble = 5.25;
bool myBool = true;

Console.WriteLine(myInt.toString());
Console.WriteLine(myDouble.toString());
Console.WriteLine(myBool.ToString()); 
```