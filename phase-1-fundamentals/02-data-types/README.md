# 02 — Data Types ✅ (active)

In 01 you printed a balance. Today you'll think harder about *what type* a balance,
an account id, and a currency actually are — and why getting that wrong in fintech
software is how incidents happen.

## What you'll learn
- C#'s built-in value types: `int`, `long`, `decimal`, `double`, `bool`, `char`
- Why `decimal` exists as a distinct type from `double`/`float`
- `string` basics and the difference between value types and reference types
- Default values and var inference

## Primer (read this once)

C# is statically typed — every variable has a type, known at compile time. The common
ones you'll reach for constantly:

| Type | Use for | Example |
|------|---------|---------|
| `int` | whole numbers, counts | `int retries = 3;` |
| `long` | bigger whole numbers (IDs, minor units across a ledger) | `long accountId = 8841234L;` |
| `decimal` | **money, always** | `decimal balance = 150000.00m;` |
| `double` | scientific/approximate math — not money | `double distanceKm = 42.2;` |
| `bool` | true/false flags | `bool isActive = true;` |
| `char` | a single character | `char currencySymbol = 'R';` |
| `string` | text | `string accountHolder = "M. Dlamini";` |

The `m` suffix on a decimal literal (`150000.00m`) tells the compiler "this is a
`decimal`, not a `double`" — without it, `150000.00` defaults to `double`.

`var` lets the compiler infer the type from the right-hand side — `var balance = 150000.00m;`
is identical to writing `decimal balance = ...` explicitly. Use whichever reads clearer;
many teams prefer explicit types for money so the type is obvious at a glance.

## The fintech angle

`double` and `float` store numbers in base-2 floating point, which **cannot exactly
represent most base-10 decimals** — `0.1 + 0.2` in double-land doesn't equal `0.3`,
it's off by a tiny fraction. That tiny fraction, multiplied across millions of
transactions, is how ledgers stop balancing. `decimal` in .NET is base-10 under the
hood, built specifically so money math is exact.

This is the first of the repo's non-negotiables from [MENTOR.md](../../MENTOR.md):
**`decimal` for money — never `double` or `float`.**

## Your challenge

In `Program.cs`, model a single bank account's opening state using well-chosen types,
then print a short summary. Specifically declare and print:

1. An **account holder name** (`string`).
2. An **account number** (`long` — account numbers can get long and aren't used for
   arithmetic, so they're an ID, not a quantity).
3. An **opening balance** (`decimal`, using the `m` suffix).
4. A **currency code**, e.g. `"ZAR"` (`string`).
5. A **boolean** flag for whether the account is active.
6. Print a line that proves `double` is the wrong choice for money: show what
   `0.1 + 0.2` equals as a `double` vs. as a `decimal`.

### Acceptance criteria
- [ ] `dotnet run` prints all the account details with no errors.
- [ ] The balance is declared as `decimal`, never `double`/`float`.
- [ ] The account number is a `long` (or `int` if you can justify why it's safe here).
- [ ] The output visibly demonstrates the `double` vs `decimal` precision difference.
- [ ] At least one variable uses explicit typing and at least one uses `var` — so you
  can see both styles.

### Stretch (optional)
- Try declaring the balance as `double` instead and printing it with many decimal
  places (`balance.ToString("G17")`) to see the imprecision directly.
- Look up `decimal.MaxValue` vs `double.MaxValue` — which has more *precision*, and
  which has more *range*? They're not the same thing.

## When you're ready
Paste your `Program.cs` into the chat. First review will be hints, not answers.
Then commit:

```bash
git add .
git commit -m "02 data-types"
```
