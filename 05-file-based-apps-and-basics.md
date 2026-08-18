# C# Cheatsheet: File-Based Apps & Language Basics

Cross-cutting essentials from the Get Started tutorials: running single-file apps, string interpolation, and the boxing/reflection concepts that surfaced along the way.

---

## File-based apps (.NET 10)

Run a single `.cs` file directly — no `.csproj` needed:

```
dotnet run app.cs
```

Great for prototyping and scripts. When it outgrows one file, convert to a real project:

```
dotnet project convert app.cs
```

### `#:` directives

Embed project-level config at the top of the file. Each maps to something you'd otherwise put in a `.csproj`.

| Directive | Example | `.csproj` equivalent |
|-----------|---------|----------------------|
| `#:project` | `#:project ../SharedLibrary/SharedLibrary.csproj` | `<ProjectReference>` |
| `#:property` | `#:property PublishAot=false` | `<PropertyGroup>` property |
| `#:sdk` | `#:sdk Microsoft.NET.Sdk.Web` | `<Project Sdk="...">` |
| `#:package` | `#:package Humanizer@2.14.1` | `<PackageReference>` |

```cs
#:project ../SharedLibrary/SharedLibrary.csproj  // reference another project
#:property PublishAot=false                       // set an MSBuild property
#:sdk Microsoft.NET.Sdk.Web                        // use the web SDK (minimal ASP.NET Core)
```

- Default SDK is `Microsoft.NET.Sdk` (console); `Microsoft.NET.Sdk.Web` unlocks `WebApplication`, endpoint mapping, etc.
- File-based apps enable AOT publishing by default; `PublishAot=false` opts back out (useful with reflection-heavy code).

> .NET 10 was in preview around this material — verify directive syntax against current docs if using a specific SDK build.

---

## String interpolation

Prefix a string with `$` and embed expressions in `{ }`.

```cs
var name = "Ana";
Console.WriteLine($"Hello {name.ToUpper()}!");   // Hello ANA!
```

- The whole `$"..."` is an **interpolated string**; `{name.ToUpper()}` is an **interpolation expression**.
- Format & alignment: `$"{price,10:C2}"` → right-align in 10 chars, currency, 2 decimals.
- Combine with verbatim `$@"..."` (multi-line, no escaping) or raw literals `$"""..."""` (C# 11).
- Roughly sugar over `String.Format`, but compiles to an efficient interpolated-string handler (C# 10+).

---

## Boxing

Converting a **value type** to a **reference type** by wrapping it in a heap `object`.

```cs
int x = 42;
object boxed = x;      // boxing: value copied to the heap
int y = (int)boxed;    // unboxing: copied back (explicit cast)
```

- Costs a heap allocation + copy. Generics (`List<int>` vs old `ArrayList`) exist to avoid it.

## Reflection

Inspecting/manipulating type metadata at **runtime** — discovering properties, methods, attributes, and invoking them dynamically.

```cs
Type t = someObject.GetType();
foreach (var prop in t.GetProperties())
    Console.WriteLine(prop.Name);
```

- Powers serializers (JSON/XML), ORMs, DI containers, test frameworks.
- **Tie-in:** boxing a tuple or reflecting over it shows `Item1`/`Item2` — the friendly names are compile-time only. Records expose real named properties, so they serialize cleanly.

---

## Integer division trap

When **both** operands are `int`, `/` does integer division (truncates), *then* any widening happens.

```cs
double bad  = 10 / 3;             // 3.0   (int division first, then widened)
double good = (double)10 / 3;     // 3.333 (one operand double → float division)
```

- Casting **one** operand is enough.
- The **target** type doesn't change the operator's behavior — only the operand types do.

---

## Quick reference: running code

| Command | Does |
|---------|------|
| `dotnet run app.cs` | run a single file |
| `dotnet run` | run the project in the current folder |
| `dotnet project convert app.cs` | turn a file-based app into a project |
