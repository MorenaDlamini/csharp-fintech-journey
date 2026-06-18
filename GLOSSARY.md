# Glossary

Fintech and C# terms collected as we go. Add to it whenever a new term shows up.

| Term | Meaning |
|------|---------|
| **Ledger** | The authoritative record of all transactions. Append-only — you never edit a past entry, you add a correcting one. |
| **Minor units** | The smallest unit of a currency (cents for USD/EUR, so $1.00 = 100 minor units). Amounts are often stored as integers of minor units to avoid fractional errors. |
| **Banker's rounding** | Rounding to nearest, but ties go to the nearest *even* digit (2.5 → 2, 3.5 → 4). Reduces cumulative bias over many roundings. In C#: `MidpointRounding.ToEven`. |
| **Settlement** | When a transaction actually moves money and becomes final, often later than when it was authorized. |
| **Idempotency** | An operation that produces the same result whether run once or many times — vital so a retried payment doesn't charge twice. |
| **decimal (C#)** | A 128-bit base-10 number type. Exact for decimal fractions, which is why it's the type for money. |
| **double / float** | Base-2 floating point. Fast but *cannot* represent values like 0.1 exactly. Never use for money. |
