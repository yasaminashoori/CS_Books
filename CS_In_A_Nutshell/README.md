# C# in a nutsehll

## English words:

Flagship = گل سر سبد

compromising = مصالحه کردن

companion = همراه

notation = نشانه گذاری

slanted = شیب داشتن

hollow = توخالی

incarnation = تجسم

expressiveness = روشنی

## The definations:

What is C#? C# is a general-purpose, type-safe, object-oriented programming language.

Runtime: The C# language is platform neutral and works with a range of platform-specific
runtimes.

Encapsulation: Encapsulation means creating a boundary around an object to separate its external (public) behavior from its internal (private) implementation details.

Unified type system: The fundamental building block in C# is an encapsulated unit of data and functions called a type.
C# has a unified type system in which all types ultimately share a common base type. This means that all types, whether they represent business objects or are primitive types such as numbers, share the same basic functionality. For example, an instance of any type can be converted to a string by calling its ToString method.

Classes and interfaces
In a traditional object-oriented paradigm, the only kind of type is a class. In C#, there are several other kinds of types, one of which is an interface. An interface is like a class that cannot hold data. This means that it can define only behavior (and not state), which allows for multiple inheritance as well as a separation
between specification and implementation.

high-level abstractions such as: query expressions and asynchronous
continuations

allows low-level efficiency through constructs such as custom value types and optional pointers.

# 2. C# Language Basics

accelerates = تسریع کردن

conjunction = پیوستگی

reside = اقامت داشتن

Qualifying = تعیین کردن

denotes = نشان می‌دهد

clashes = conflict, meeting

lexically = از نظر لغوی

Literals = تحت اللفظی

demarcate : مرزبندی کردن

blueprint = نقشه، راهنما

pertains = مربوط می شود

collision =

### A First C# Program

- Comment: The double forward slash indicates that the remainder of a line is a comment //

- What is a statement?
  Statements in C# execute sequentially and are terminated by a semicolon.

- What is a method?
  A method performs a function.

- What is a class? a class groups function members and data members to form an object-oriented building block.
  The Console class groups members that handle command-line input/output (I/O) functionality, such as the WriteLine
  method. A class is a kind of type!

- Namespace: At the outermost level, types are organized into namespaces.
  The .NET libraries are organized into nested namespaces.The System.Text namespace contains types for handling text.

- Using: Qualifying the Console class with the System namespace on every use adds clutter. The using directive lets you avoid this clutter by importing a namespace.

- Refactoring method: A basic form of code reuse is to write higher-level functions that call lower-level
  functions. We can refactor our program with a reusable method called FeetToInches that multiplies an integer by 12.

```
using System;
Console.WriteLine (FeetToInches (30)); // 360
Console.WriteLine (FeetToInches (100)); // 1200
int FeetToInches (int feet)
{
int inches = feet \* 12;
return inches;
}

```

- Statement block: ethod contains a series of statements surrounded by a pair of braces. This is
  called a statement block.

- Return in method: A method can receive input data from the caller by specifying parameters and output
  data back to the caller by specifying a return type.

- void methods: If a method doesn’t receive input, use empty parentheses. If it doesn’t return anything, use the void keyword.

- arguments: The literals 30 and 100 are the arguments passed to the FeetToInches method.
  Other functions: Methods and operator like \* which performs multiplication. there are also constructors, properties, events, indexers, and finalizers.

- Compilation: The C# compiler turns .cs source files into assemblies, which are the main units for packaging and deployment in .NET.
  Assemblies can be applications with an entry point or libraries without one. Libraries are used by applications or other libraries.
  .NET is composed of libraries and a runtime environment.
  Top-level statements in a program create an implicit entry point for console or Windows applications. Without them, the Main method serves as the entry point.
  In .NET 8, assemblies do not have a .exe extension. The .exe seen after building is a native loader that initiates the .dll assembly.
  .NET 8 supports self-contained deployments, bundling the loader, assemblies, and necessary .NET runtime components into a single .exe file.
  It also supports Ahead-Of-Time (AOT) compilation for improved startup speed and less memory use, by including precompiled native code in the executable.
  This summary encapsulates the key points about .NET assembly creation, deployment, and the advancements in .NET 8.

- C# syntax: C# syntax is inspired by C and C++ syntax.
  The dotnet tool is used for handling .NET source code and binaries via the command line, serving as an alternative to IDEs like Visual Studio.
  It is part of the .NET 8 SDK and is located in %ProgramFiles%\dotnet on Windows or /usr/bin/dotnet on Ubuntu Linux.
  To compile a .NET application, dotnet requires a project file and C# source files.
  The command dotnet new Console -n MyFirstProgram scaffolds a new console project, creating a folder with a .csproj project file and a Program.cs file with a “Hello world” program.
  To build and execute the program, use dotnet run MyFirstProgram from within the project’s folder.
  For building without execution, the command is dotnet build MyFirstProgram.csproj.
  The resulting assembly is placed in the bin\debug subdirectory.

- Identifiers and Keywords: Identifiers are names that programmers choose for their classes, methods and variables.

```
  System x Console WriteLine
```

must be a whole word, essentially made up of Unicode characters starting with a letter or underscore. C# identifiers are case sensitive. By convention, parameters, local variables, and private fields should be in camel case (e.g., myVaria
ble), and all other identifiers should be in Pascal case (e.g., MyMethod).

- Keywords: Keywords are names that mean something special to the compiler.

- Keywords: Most keywords are reserved, which means that you can’t use them as identifiers.

```
abstract
as
base
bool
break
byte
case
catch
char
checked
class
const
continue
decimal
default
delegate
do
double
else
enum
event
explicit
extern
false
finally
fixed
float
for
foreach
goto
if
implicit
in
int
interface
internal
is
lock
long
namespace
new
null
object
operator
out
override
params
private
protected
public
readonly
record
ref
return
sbyte
sealed
short
sizeof
stackalloc
static
string
struct
switch
this
throw
true
try
typeof
uint
ulong
unchecked
unsafe
ushort
using
virtual
void
volatile
while
```

- Use Keywords: you can do so by qualifying it with the @ prefix. The @ symbol doesn’t form part of the identifier itself. So, @myVariable is the same as myVariable.

- Contextual keywords: Some keywords are contextual, meaning that you also can use them as identifiers without an @ symbol. With contextual keywords, ambiguity cannot arise within the context in which they are used.

```
add
alias
and
ascending
async
await
by
descending
dynamic
equals
file
from
get
global
group
init
into
join
let
managed
nameof
nint
not
notnull
nuint
on
or
orderby
partial
remove
required
select
set
unmanaged
value
var
with
when
where
yield

```

- Literals, Punctuators, and Operators: Literals are primitive pieces of data lexically embedded into the program. The
  literals we used in our example program are 12 and 30.

- Punctuators help demarcate the structure of the program. An example is the semicolon, which terminates a statement. Statements can wrap multiple lines:

```
Console.WriteLine
(1 + 2 + 3 + 4 + 5 + 6 + 7 + 8 + 9 + 10);

```

Operators: An operator transforms and combines expressions. Most operators in C# are deno‐
ted with a symbol, such as the multiplication operator, \*. We discuss operators in
more detail later in this chapter. These are the operators we used in our example program:

= \* . ()

A period denotes a member of something (or a decimal point with numeric literals).
Parentheses are used when declaring or calling a method; empty parentheses are
used when the method accepts no arguments. (Parentheses also have other purposes
that you’ll see later in this chapter.) An equals sign performs assignment. (The
double equals sign, ==, performs equality comparison, as you’ll see later.)

- Comments: C# offers two different styles of source-code documentation: single-line comments and multiline comments.
  A single-line comment begins with a double forward slash and continues until the end of the line; for example:

int x = 3; // Comment about assigning 3 to x

A multiline comment begins with /_ and ends with _/; for example:

int x = 3; /_ This is a comment that
spans two lines _/

Comments also can embed XML documentation tags.

Type Basics: A type defines the blueprint for a value. In this example, we use two literals of type int with values 12 and 30. We also declare a variable of type int whose name is x.

```
int x = 12 * 30;
Console.WriteLine (x);

```

- Variable and constant: A variable denotes a storage location that can contain different values over time. In contrast, a constant always represents the same value (more on this later):

```
const int y = 360;

```

All values in C# are instances of a type. The meaning of a value and the set of possible values a variable can have are determined by its type.

- Members of a type: A type contains data members and function members

# Chapter 3: Creating Types in C#

Words:

comprises = شامل بودن

tersely = به طور مختصر

- Field: A field is a variable that is a member of a class or struct.
