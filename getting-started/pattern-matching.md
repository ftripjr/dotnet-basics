# C# Cheatsheet: Pattern Matching

Pattern matching compares an expression against characteristics — its value, type, or structure — often clearer than chains of `if`. Use with `is` expressions or `switch` expressions.

---

## Nullable annotation `?`

A `?` after a type name allows `null` (e.g., `bool?` can be `true`, `false`, or `null`; `string?` can be null).

```cs
string? line;   // may hold null
```

---

## Matching a value with `is`

Comparing a variable to a constant is the basic building block.

```cs
if (transactionType?.ToUpper() is "DEPOSIT")
    currentBalance += amount;
else if (transactionType?.ToUpper() is "WITHDRAWAL")
    currentBalance -= amount;
```

### `is not null`

A null-test pattern — common in read loops:

```cs
string? line;
while ((line = reader.ReadLine()) is not null)
{
    // process line; loop ends when ReadLine() returns null
}
```

---

## Safe parsing: `TryParse`

Returns a **`bool`** for success and hands back the value via `out`, avoiding an exception on bad input.

```cs
if (double.TryParse(parts[1].Trim(), out double amount))
{
    // amount is valid here
}
```

Prefer this over `double.Parse`, which throws on invalid input.

---

## Enum matching

```cs
public enum TransactionType { Deposit, Withdrawal, Invalid }

if (transaction.type == TransactionType.Deposit)
    currentBalance += transaction.amount;
```

---

## `switch` expressions

Assigns a result by matching arms. `=>` maps a pattern to a value; `_` is the discard (default) arm.

```cs
currentBalance += transaction switch
{
    (TransactionType.Deposit, var amount)    => amount,
    (TransactionType.Withdrawal, var amount) => -amount,
    _                                        => 0.0,
};
```

- `var amount` captures the matched value for use on the right side.
- Arms are tested **top to bottom**.

---

## Two properties the compiler checks

**Exhaustive** — every possible input satisfies at least one arm. If not, the compiler warns (unmatched inputs would fail at runtime).

**Subsumption** — a later arm is unreachable because earlier arms already match all its inputs.

```cs
// SUBSUMPTION ERROR: _ matches everything, so the Withdrawal arm is unreachable
currentBalance += transaction switch
{
    (TransactionType.Deposit, var amount)    => amount,
    _                                        => 0.0,        // matches all remaining
    (TransactionType.Withdrawal, var amount) => -amount,    // unreachable → error
};
```

Analogous `if` pitfall:

```cs
if (n < 20)
    Console.WriteLine("< 20");
else if (n < 10)                 // unreachable: everything < 10 is also < 20
    Console.WriteLine("< 10");
```

The `switch` expression enforces exhaustiveness/subsumption checks that `if` chains don't — fewer bugs.

---

## Type patterns

Test an expression's **runtime type**, and bind it to a variable on a match.

```cs
public record Deposit(double Amount, string description);
public record Withdrawal(double Amount, string description);

currentBalance += transaction switch
{
    Deposit d    => d.Amount,     // is it a Deposit? bind to d
    Withdrawal w => -w.Amount,    // is it a Withdrawal? bind to w
    _            => 0.0,
};
```

`Deposit d` succeeds when `transaction` is a `Deposit`, binding it to `d` so you can read `d.Amount`.

---

## Pattern types summary

| Pattern | Example | Tests |
|---------|---------|-------|
| Constant | `is "DEPOSIT"` | equals a constant |
| Null | `is not null` | null / non-null |
| Type | `Deposit d` | runtime type (+ binds) |
| Tuple/positional | `(Deposit, var amt)` | deconstructed shape |
| Discard | `_` | anything (default) |

---

## Gotchas

- **Order matters:** put `_` (and broad patterns) **last** — a catch-all before specific arms causes an unreachable-arm error.
- **Non-exhaustive switch** → compiler warning; unmatched input fails at runtime.
- **`TryParse` over `Parse`** for untrusted input — returns `bool`, no exception.
- **`var` in an arm** binds the matched value; it doesn't re-filter.
