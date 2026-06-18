# 01 — Hello World ✅ (active)

Your very first C# program. The goal isn't the output — it's getting comfortable with
the shape of a C# program and the run-edit-run rhythm.

## What you'll learn
- The anatomy of a minimal C# program (top-level statements)
- How to print to the console
- How to run a project with `dotnet run`

## Primer (read this once)

In .NET 10, a brand-new console program can be just one line. There's no ceremony
required — you can write statements straight in the file. This is called
**top-level statements**.

The tool for printing a line of text to the console is:

```csharp
Console.WriteLine("any text you want");
```

`Console` is a built-in helper for talking to the terminal, and `WriteLine` writes
your text followed by a new line. Each statement ends with a semicolon `;`.

You can also drop a value into a string using **string interpolation** — a `$` before
the opening quote lets you put `{...}` holes in the text:

```csharp
var name = "Ada";
Console.WriteLine($"Hello, {name}!");
```

That's genuinely all you need for this one. (We'll meet the classic `static void Main`
form later — top-level statements quietly compile down to it.)

## The fintech angle

Over this journey we're building toward a small banking/ledger app. Today you're just
writing its **welcome screen** — the first thing a user sees when the app starts.

## Your challenge

In `Program.cs`, write a program that prints, on separate lines:

1. A welcome banner naming your fintech app (pick any name — e.g. `LedgerLite`).
2. A short greeting to the user.
3. A line showing an opening account balance, e.g. `Opening balance: 1000.00`.

### Acceptance criteria
- [ ] Running `dotnet run` from this folder prints all three lines with no errors.
- [ ] The app's name appears in the output.
- [ ] An opening balance value appears in the output.
- [ ] At least one line uses string interpolation (`$"..."`).

### Stretch (optional)
- Store the app name and the balance in variables first, then print them — rather than
  typing the literal text inside `WriteLine`. (We'll dig into *which type* a balance
  should be in the next topic. For now, anything that prints is fine — but keep the
  question in mind: is a money amount really just a plain number?)

## When you're ready
Paste your `Program.cs` into the chat. First review will be hints, not answers.
Then commit:

```bash
git add .
git commit -m "01 hello-world"
```
