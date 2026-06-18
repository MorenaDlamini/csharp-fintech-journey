# C# .NET Fintech Journey 🏦

A hands-on path from zero to building real financial software in **C# and .NET 10**.
Every topic is a small, runnable project with a fintech-flavored challenge, worked
through with a senior-developer review loop.

This repo *is* my progress. Each commit shows another topic learned.

---

## How the learning loop works

For each topic:

1. **Read** the topic's `README.md` — a short primer, the fintech angle, and a challenge with acceptance criteria.
2. **Attempt** it yourself in that topic's `Program.cs`.
3. **Paste** your code into the chat for review.
4. **First review:** hints and leading questions — not the answer.
5. **Revise** and paste again. A few rounds is normal and expected.
6. **After ~2–3 real attempts**, the full worked solution lands in the chat, with an explanation of *how to reason to it* and what to drill next.
7. **Commit** the topic and tick the box below.

Rule of the road: I struggle with it first. The struggle is where the skill forms.

---

## Setup

| Tool | Notes |
|------|-------|
| .NET 10 SDK | Installed (`10.0.301`) — check with `dotnet --version` |
| VS Code | Plus the **C# Dev Kit** extension |
| Git | For committing each topic |

### Running any topic

```bash
cd phase-1-fundamentals/01-hello-world
dotnet run
```

---

## The fintech through-line

These habits get baked in from day one, because in financial software they are the
difference between a clean ledger and an incident report:

- **`decimal` for money — never `double` or `float`.** Floating point can't represent `0.10` exactly; money math must be exact.
- **Rounding is a decision, not a default.** Know `MidpointRounding` and banker's rounding.
- **Money is more than a number** — it has a currency, and is often stored in minor units (cents).
- **Time is in UTC.** Use `DateTimeOffset` for anything that gets recorded or settled.
- **Transactions are immutable.** You append corrections; you don't edit history.
- **Validate at the edges.** Never trust an amount, a currency, or an account id you didn't check.

---

## Progress tracker

### Phase 1 — Fundamentals
- [x] 01 — Hello World
- [ ] 02 — Data Types
- [ ] 03 — Operators
- [ ] 04 — Type Conversions
- [ ] 05 — Control Flow
- [ ] 06 — Loops
- [ ] 07 — Methods
- [ ] 08 — String Operations

### Phase 2 — Data Structures
- [ ] 09 — Arrays
- [ ] 10 — Collections
- [ ] 11 — Nullable Types

### Phase 3 — OOP & the Type System
- [ ] 12 — Classes and Objects
- [ ] 13 — Object-Oriented Programming
- [ ] 14 — Structs, Records and Enums
- [ ] 15 — Advanced Types
- [ ] 16 — Exception Handling

### Phase 4 — Intermediate Language Features
- [ ] 17 — Generics
- [ ] 18 — Delegates and Lambdas
- [ ] 19 — LINQ Basics
- [ ] 20 — Pattern Matching
- [ ] 21 — Date and Time
- [ ] 22 — Modern C# Features
- [ ] 23 — C# 13 and C# 14 Features

### Phase 5 — Real-World .NET
- [ ] 24 — Async Programming
- [ ] 25 — File I/O
- [ ] 26 — HTTP Requests
- [ ] 27 — JSON Serialization
- [ ] 28 — Unit Testing with xUnit
- [ ] 29 — Dependency Injection
- [ ] 30 — Configuration and Logging

### Phase 6 — Data & Persistence
- [ ] 31 — Microsoft SQL Server and T-SQL
- [ ] 32 — Entity Framework Core

### Phase 7 — Building a Fintech Service
- [ ] 33 — ASP.NET Core Web API
- [ ] 34 — Validation
- [ ] 35 — Resilience with Polly
- [ ] 36 — Capstone — Ledger Service

---

## Repo structure

```
csharp-fintech-journey/
├─ README.md          ← you are here (syllabus + progress)
├─ GLOSSARY.md        ← fintech terms, grows as we go
├─ .gitignore
└─ phase-N-.../
   └─ NN-topic/
      ├─ README.md       ← primer + challenge (locked until reached)
      ├─ Program.cs      ← my workspace
      ├─ NOTES.md        ← my takeaways + hints worth keeping
      └─ NN-topic.csproj
```

Locked topics currently hold a placeholder README. Each gets fully written the moment
I reach it.
