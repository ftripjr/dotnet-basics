# C# Cheatsheet: C# for Python Developers

A roadmap for Python devs learning C# — what's familiar, what's new, and what Python features have no direct C# equivalent. Learning C# from Python is a smooth journey; the concepts largely overlap, the syntax differs.

---

## What's familiar (shared concepts)

Both languages share these, so you already know the ideas:

| Concept | Note |
|---------|------|
| **Object-oriented** | Class concepts from Python apply in C#, different syntax. |
| **Cross-platform** | Both run on many platforms. |
| **Garbage collection** | Automatic memory management; unreferenced objects reclaimed. |
| **Strongly typed** | No implicit type coercion in either. |
| **Async / await** | Python's `async`/`await` was **directly inspired by C#'s**. |
| **Pattern matching** | Python's `match` ≈ C#'s `switch` expression + patterns. |
| **Statement keywords** | `if`, `else`, `while`, `for`, etc. shared — you can read C# already. |

---

## Syntax at a glance

**Type annotations** — C# puts the type first, no colon:

```python
# Python
name: str = "Hello"
count: int = 5
```
```csharp
// C#
string name = "Hello";
int count = 5;
```

**List filtering** — comprehension becomes LINQ:

```python
# Python
result = [x for x in items if x > 5]
```
```csharp
// C#
var result = items.Where(x => x > 5).ToList();
```

**Block scope** — indentation becomes braces:

```python
# Python
if count > 0:
    print("positive")
```
```csharp
// C#
if (count > 0)
{
    Console.WriteLine("positive");
}
```

**Class/data definition** — a whole class collapses to a record:

```python
# Python
class Point:
    def __init__(self, x: int, y: int):
        self.x = x
        self.y = y
```
```csharp
// C#
record Point(int X, int Y);
```

---

## Key differences (Python → C#)

1. **Indentation vs. tokens** — Python: whitespace is syntax. C#: whitespace is insignificant; `;` ends statements and `{ }` control block scope. (Indent anyway for readability.)
2. **Static typing** — C# variable declarations include a type; reassigning to a different type is a **compiler error**. Python types can change on reassignment.
3. **Nullable types** — C# distinguishes **nullable** vs **non-nullable** types; a non-nullable type always refers to a valid object.
4. **LINQ** — query keywords aren't in Python (though `itertools`, `more-itertools`, `py-linq` offer similar functionality).
5. **Generics** — C# generics use static typing to assert things about type arguments, and can specify **constraints** an argument type must satisfy.

---

## Python features NOT in C#

1. **Structural (duck) typing** — C# types have names and declarations; two types with the same shape aren't interchangeable. (**Exception:** tuples.)
2. **REPL** — no built-in Read-Eval-Print Loop for quick prototyping.
3. **Significant whitespace** — you must use `{ }` for block scope; indentation alone means nothing.

---

## Mental-model shifts

- **"The type comes first and it's permanent."** Declaration binds a variable to one type for life.
- **"Comprehensions become method chains."** `[expr for x in xs if cond]` → `xs.Where(...).Select(...)`.
- **"A data class is one line."** Reach for `record` where you'd write an `__init__`-heavy class.
- **"Braces, not colons + indent."** The compiler reads tokens, not layout.

---

## Next steps

- C# Fundamentals — deeper type system, OOP, generics, interfaces.
- LINQ overview — the comprehension replacement, and much more.
- Records & the type system — where `class` vs `struct` is unpacked.
