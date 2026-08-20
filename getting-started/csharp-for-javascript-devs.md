# C# Cheatsheet: C# for JavaScript / TypeScript Developers

C#, TypeScript, and JavaScript are all in the **C family** of languages, so much of the syntax already reads naturally. This sheet maps what's familiar, what's new, and what JS/TS features don't carry over.

---

## What's familiar (shared concepts)

| Concept | Note |
|---------|------|
| **Similar syntax** | Curly braces, semicolons, `if`/`else`/`switch`, `for`/`while`/`do...while`, `class`/`interface`, access modifiers (`public`…`private`) — all shared. |
| **The `=>` token** | C# **lambda expressions** ≈ JS **arrow functions**. |
| **Function hierarchies** | All three support **local functions** (functions inside functions). |
| **Async / await** | Same `async`/`await` keywords. |
| **Garbage collection** | Automatic memory management in all three. |
| **Event model** | C#'s `event` syntax resembles JS DOM events. |
| **Package manager** | **NuGet** ≈ npm; C# libraries ship as **assemblies**. |

---

## Syntax at a glance

**Type annotations** — type goes first, no colon:

```typescript
// TypeScript
let name: string = "Hello";
let count: number = 5;
```
```csharp
// C#
string name = "Hello";
int count = 5;
```

**Async / await** — `Promise<T>` becomes `Task<T>`:

```typescript
// TypeScript
async function fetchData(): Promise<string> {
    const response = await fetch(url);
    return await response.text();
}
```
```csharp
// C#
async Task<string> FetchDataAsync() {
    var response = await client.GetAsync(url);
    return await response.Content.ReadAsStringAsync();
}
```

**Classes** — TS constructor shorthand becomes a record:

```typescript
// TypeScript
class Point {
    constructor(public x: number, public y: number) {}
}
```
```csharp
// C#
record Point(int X, int Y);
```

**Pattern matching** — `typeof` checks become `is` patterns:

```typescript
// TypeScript
if (typeof value === "string") { /* ... */ }
```
```csharp
// C#
if (value is string s) { /* use s */ }
```

---

## Runtime model differences

Similar syntax, very different execution:

- **JavaScript** runs on a runtime like **V8**, using an **event loop** for async work.
- **C#** runs on the **.NET runtime (CLR)**: code compiles to **Intermediate Language (IL)**, then executes via **JIT or AOT** compilation.

---

## What's new for you in C# (some familiar from TypeScript)

1. **C# type system** — strongly typed; every variable has a fixed type. Define `class`/`struct`, and `interface` definitions for behavior. Stricter than TypeScript's (which is bolted onto JS).
2. **Pattern matching** — `is` expression tests a pattern; `switch` expression inspects shape and decides.
3. **String interpolation & raw string literals** — `$"..."` embeds expressions; `"""..."""` minimizes escaping.
4. **Nullable / non-nullable types** — append `?`; the compiler warns before you dereference a possibly-null value or assign null to a non-nullable. Cuts down `NullReferenceException`. (Like TS optional `?`.)
5. **LINQ** — one query syntax to transform data regardless of source.

---

## JS/TS features NOT in C#

**From JavaScript:**
1. **`dynamic` types** — C# is statically typed; type can't change. (There *is* a `dynamic` type for runtime binding, but it's the exception.)
2. **Prototypal inheritance** — C# inheritance is declared in the type (base class in the `class` declaration); no `__proto__`.
3. **Interpreted execution** — C# must be **compiled** before running; JS runs directly in the browser.

**From TypeScript:**
1. **Union types** — supported only from **C# 15** onward (a closed set of named cases with exhaustive pattern matching); older versions lack them.
2. **Decorators** — C# has none. Some (like `@sealed`) map to reserved keywords; others map to **Attributes**, or you write your own attribute.
3. **More forgiving syntax** — the C# compiler parses more **strictly** than JavaScript.

---

## Mental-model shifts

- **"`Promise<T>` is `Task<T>`."** Same `async`/`await`, different return type.
- **"`typeof` guards become `is` patterns."** And they bind a variable (`is string s`).
- **"Types are fixed and checked hard."** No implicit reshaping; the compiler is stricter than TS.
- **"Compile, then run."** No running source directly in a browser — IL + JIT/AOT.
- **"npm → NuGet, arrow fn → lambda."** Familiar tools with new names.

---

## Building web apps

Consider **Blazor**, a full-stack C# web framework. Components run on the server (as .NET assemblies) or in the browser via **WebAssembly**, and it interops with your existing JS/TS libraries.

---

## Next steps

- C# Fundamentals — type system, OOP, generics, interfaces.
- Asynchronous programming — the `Task`-based model in depth.
- Pattern matching & records — the shape-matching and data-type features above.
