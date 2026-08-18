# C# Cheatsheet: Tuples and Types

How C# groups data — from lightweight ad-hoc tuples up to named records — and the value-vs-reference distinction underneath it all.

---

## Tuples

A lightweight, ad-hoc bundle of values with **no named type of its own**. A tuple *type* is defined by its **arity** (number of members) and the **types** of those members — names are just convenience.

```cs
var pt = (X: 3, Y: 4);
Console.WriteLine(pt.X);        // 3

var subscript = (A: 0, B: 0);
subscript = pt;                 // legal! same arity + member types
                                // (A/B vs X/Y names don't matter)
```

- Element names (`X`, `Y`) are **compile-time only** — erased at runtime to `Item1`, `Item2`.
- Deconstruction: `var (x, y) = pt;`

**Limitations that motivate records:** tuple types have no name to convey meaning, and you **can't add behavior** (methods, validation).

---

## Records

A **named** type with value-based equality and concise syntax. `record` is shorthand for `record class`.

```cs
public record Point(int X, int Y);   // positional record
```

That one line generates: init-only properties `X`/`Y`, a constructor, value equality (`==`, `Equals`, `GetHashCode`), a deconstructor, and a readable `ToString()`.

```cs
Point pt3 = new Point(1, 1);
var pt4 = pt3 with { Y = 10 };       // nondestructive mutation
Console.WriteLine($"{pt3} and {pt4}");
// Point { X = 1, Y = 1 } and Point { X = 1, Y = 10 }
```

- **`with` expression:** creates a **copy** with some members changed — `pt4` has the same values as `pt3` except `Y = 10`. `pt3` is untouched.
- Records are **immutable by default** (init-only properties), so you derive new values rather than mutating.

### Adding behavior

Open a body to add methods — something tuples can't do:

```cs
public record Point(int X, int Y)
{
    public double Slope() => (double)Y / (double)X;
}
```

---

## Tuples vs Records at a glance

| | Tuple | Record |
|--|-------|--------|
| Named type | No (structural) | Yes |
| Storage | value type (`ValueTuple`) | reference type (`record class`) |
| Equality | by value | by value |
| Add behavior/methods | No | Yes |
| Member names at runtime | erased (`Item1`...) | real properties |
| `with` expression | No | Yes |
| Best for | local, throwaway grouping | meaningful domain concepts, public APIs |

---

## The type system: value vs reference

Every concrete named type is ultimately a **`class`** or a **`struct`**.

| | `struct` (value type) | `class` (reference type) |
|--|----------------------|--------------------------|
| Stores | contents **inline** | a **reference** to heap storage |
| Assignment (`b = a`) | copies the **data** (independent) | copies the **reference** (shared instance) |
| Examples | `int`, `bool`, `ValueTuple`, `record struct` | `class`, `record` / `record class` |

```cs
// Value type — independent copy
var a = (X: 1, Y: 2);
var b = a;
b.X = 99;            // a.X still 1

// Reference type — shared instance
Point p = new Point(1, 2);
Point q = p;         // both reference the same object
```

**Records are a hybrid:** stored/assigned like a class (reference semantics) but *compared* like a struct (value equality). A normal class compares by reference identity instead.

Want a value-type record (inline storage, copy on assignment)? Use `record struct`.

---

## Choosing a type

- **Tuple** — a couple of related values, locally/privately, no ceremony.
- **`record`** — data-first type that's a meaningful concept, crosses API boundaries, or needs value equality.
- **`class`** — you want OO idioms: encapsulation, inheritance, polymorphism.
- **`struct`** — small value type, copy semantics.

---

## Gotchas

- **Tuple names are cosmetic** — reflection/boxing/serialization see `Item1`, `Item2`. Records expose real named properties (serialize cleanly).
- **Records are immutable by default** — use `with`, don't try to reassign init-only properties.
- **Reference sharing:** `q = p` on a class/record means both point at one object; heap addresses aren't stable (the GC moves objects).
- **`record` = `record class`** (reference); `record struct` is the value-type variant.
