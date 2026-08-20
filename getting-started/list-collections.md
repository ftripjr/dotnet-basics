# C# Cheatsheet: List Collections (`List<T>`)

`List<T>` stores a sequence of elements. The element type goes between the angle brackets. Unlike a fixed-size array, a list can **grow or shrink**.

---

## Creating a list

```cs
List<string> names = ["Alice", "Ana", "Felipe"];   // collection expression
List<int> numbers = [1, 1];
List<string> empty = [];
```

The `[...]` collection-expression syntax initializes contents inline.

## Iterating

```cs
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}
```

`foreach` walks every element in order. Combined here with string interpolation (`$"..."`) and `String.ToUpper()`.

---

## Modifying contents

| Method | Effect |
|--------|--------|
| `list.Add(item)` | appends to the **end** |
| `list.Remove(item)` | removes first matching item |
| `list.Insert(i, item)` | inserts at index `i` |
| `list.RemoveAt(i)` | removes item at index `i` |

```cs
names.Add("Maria");     // now at the end
names.Add("Bill");
names.Remove("Ana");    // removed by value
```

---

## Indexing

Access items by zero-based index with `[ ]`.

```cs
Console.WriteLine($"First: {names[0]}");
Console.WriteLine($"Third: {names[2]}");
```

- **Indices start at 0**, so the largest valid index is `Count - 1`.
- Accessing past the end throws `ArgumentOutOfRangeException`.

## `Count`

```cs
Console.WriteLine($"The list has {names.Count} people in it");
```

`Count` = number of items. (Arrays and strings use `Length`; `Capacity` is the allocated buffer — a different thing.)

---

## Searching

`IndexOf` returns the item's index, or **`-1`** if not found. Always check the result.

```cs
var index = names.IndexOf("Felipe");
if (index == -1)
    Console.WriteLine("Not found");
else
    Console.WriteLine($"{names[index]} is at index {index}");
```

## Sorting

`Sort()` orders items in place, in their natural order (alphabetical for strings, numeric for numbers).

```cs
names.Sort();
```

---

## Lists of other types

`List<T>` works with any type — swap the type parameter.

```cs
List<int> fibonacciNumbers = [1, 1];

var previous  = fibonacciNumbers[fibonacciNumbers.Count - 1]; // last
var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2]; // second-to-last
fibonacciNumbers.Add(previous + previous2);
```

## Worked example: first 20 Fibonacci numbers

```cs
List<int> fibonacciNumbers = [1, 1];
while (fibonacciNumbers.Count < 20)   // < 20 → exactly 20 items
{
    var previous  = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
    fibonacciNumbers.Add(previous + previous2);
}
foreach (var item in fibonacciNumbers)
    Console.WriteLine(item);           // 20th number is 6765
```

---

## Gotchas

- **Zero-based:** last index is `Count - 1`, not `Count`.
- **`IndexOf` returns `-1`** when absent — never use the raw result as an index without checking.
- **`Count` vs `Length`:** lists use `Count`; arrays/strings use `Length`.
- **Off-by-one in `while`:** `Count < 20` stops at exactly 20 items.
