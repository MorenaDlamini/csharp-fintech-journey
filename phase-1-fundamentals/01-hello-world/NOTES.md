# 01 — Hello World · Notes

Use this file as your own scratchpad: things that clicked, mistakes you made,
hints worth remembering.

## What I learned

- I learnt about `System.Globalization`. The Globalization namespace contains
  tools for working with:
  - Languages
  - Countries/regions
  - Currency formatting
  - Date formatting
  - Number formatting

- I learnt about `CultureInfo`. A `CultureInfo` object contains formatting
  rules for a specific country and language.

## Gotchas

Step-by-step breakdown of the currency formatting example:

```csharp
using System.Globalization;
```
Gives access to `CultureInfo`.

```csharp
decimal balance = 150000m;
```
Stores the money amount.

```csharp
CultureInfo culture = new CultureInfo("en-ZA");
```
Creates South African formatting rules.

```csharp
balance.ToString("C", culture)
```
Converts the number to a currency string using those rules.

```csharp
Console.WriteLine(...)
```
Displays it.

## Senior-dev hints worth keeping

-
