# C# Cheatsheet: Branches and Loops

Control flow — making decisions and repeating work. C# ignores indentation/whitespace; use braces `{ }` to group multiple statements.

---

## `if` / `else if` / `else`

An `if` statement evaluates a **`bool`** condition. If true, the following statement runs; otherwise it's skipped.

```cs
int a = 5, b = 3;
if (a + b > 10)
    Console.WriteLine("Big");
else if (a + b > 5)
    Console.WriteLine("Medium");   // runs: 8 > 5
else
    Console.WriteLine("Small");
```

- Without an `else`, a false condition simply runs nothing.
- Use braces for multi-statement blocks — whitespace alone does **not** group.

## Boolean logic

| Operator | Meaning | True when |
|----------|---------|-----------|
| `&&` | AND | **both** sides true |
| `\|\|` | OR | **either** side true |
| `!`  | NOT | negates |

```cs
if (age >= 18 && hasID)      // both required
if (isWeekend || isHoliday)  // either suffices
```

`&&` and `||` short-circuit: the right side isn't evaluated if the left already decides the result.

## Equality vs assignment

- `==` **tests** equality (returns `bool`)
- `=` **assigns** a value

```cs
if (x == 5)   // comparison
x = 5;        // assignment
```

Mixing these up is a classic bug — `if (x = 5)` won't even compile in C# for non-bool types, which is a helpful guardrail.

---

## `while` loop (pre-check)

Tests the condition **first**, then runs the body. May execute **zero** times.

```cs
int counter = 0;
while (counter < 10)
{
    Console.WriteLine($"Hello World! {counter}");
    counter++;
}
```

## `do`...`while` loop (post-check)

Runs the body **first**, then tests. Always executes **at least once**.

```cs
int counter = 0;
do
{
    Console.WriteLine($"Hello World! {counter}");
    counter++;
} while (counter < 10);
```

**Key difference:** `while` checks before (0+ runs); `do...while` checks after (1+ runs).

---

## `for` loop

Three parts separated by `;` — initializer, condition, iterator.

```cs
//   initializer   condition   iterator
for (int i = 0;    i < 10;     i++)
{
    Console.WriteLine($"Hello World! {i}");
}
```

| Part | Example | Runs |
|------|---------|------|
| Initializer | `int i = 0` | once, at start |
| Condition | `i < 10` | before each iteration |
| Iterator | `i++` | after each iteration |

## Nested loops

The inner loop runs to completion on **every** iteration of the outer loop.

```cs
for (int row = 1; row < 4; row++)
{
    for (int col = 1; col < 4; col++)
    {
        Console.Write($"({row},{col}) ");
    }
    Console.WriteLine();
}
// 3 outer × 3 inner = 9 total lines of work
```

---

## Operators worth remembering

- `++` increment (adds 1, stores back); `--` decrement.
- `%` **remainder** (modulo) — the workhorse for divisibility.

```cs
if (number % 3 == 0)   // true when evenly divisible by 3
```

## Worked example: sum multiples of 3 in 1–20

```cs
int sum = 0;
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
        sum += i;
}
Console.WriteLine(sum);   // 63  (3+6+9+12+15+18)
```

---

## Gotchas

- **Off-by-one:** `count < 20` yields exactly 20 iterations; `count <= 20` yields 21. When looping until you've collected *n* items, use `< n`.
- **`==` vs `=`:** comparison vs assignment.
- **Integer division:** `10 / 3 == 3` (truncated) when both operands are `int`. Cast one to `double` for `3.333...`.
