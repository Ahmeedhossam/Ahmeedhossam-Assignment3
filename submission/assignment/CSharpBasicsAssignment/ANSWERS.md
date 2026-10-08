# Part G — Short Answers

### 1. .csproj Properties
The file contains all the required properties:
- `OutputType`: Exe
- `TargetFramework`: net10.0
- `ImplicitUsings`: enable
- `Nullable`: enable

### 2. #region and #endregion
They do not change the compiled output. They are only used to collapse and hide code in the editor for readability

### 3. XML comments (///) vs Plain comments (//)
Use `///` above classes and methods to generate notes for developers
Use `//` for simple internal notes inside the code.

### 4. Global Variables in C#
C# has no true global variables because it is strictly object-oriented to keep data safe and organized. The closest alternative is using a `public static` field inside a class.