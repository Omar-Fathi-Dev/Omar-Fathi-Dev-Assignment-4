# BenchmarkDotNet Analysis

## Benchmark Setup

I used BenchmarkDotNet to compare two methods:

* `StringConcatenation`
* `StringBuilderConcatenation`

I tested them with:

* 100 iterations
* 1,000 iterations
* 10,000 iterations
* 100,000 iterations

I also used `MemoryDiagnoser` to check memory usage.

## Benchmark Results

| Method                     | Iterations |                Mean |       Allocated |
| -------------------------- | ---------: | ------------------: | --------------: |
| StringConcatenation        |        100 |          6,915.1 ns |        51.73 KB |
| StringBuilderConcatenation |        100 |            719.3 ns |         2.42 KB |
| StringConcatenation        |      1,000 |        588,834.8 ns |     4,912.08 KB |
| StringBuilderConcatenation |      1,000 |          7,506.0 ns |        26.49 KB |
| StringConcatenation        |     10,000 |     96,886,783.1 ns |   488,586.72 KB |
| StringBuilderConcatenation |     10,000 |        114,762.9 ns |       208.56 KB |
| StringConcatenation        |    100,000 | 13,622,466,228.6 ns | 48,834,679.1 KB |
| StringBuilderConcatenation |    100,000 |      1,074,000.8 ns |     1,966.48 KB |

## Analysis

### 1. Which approach was faster with 100 iterations?

`StringBuilderConcatenation` was faster.


### 2. Which approach was faster with 100,000 iterations?

`StringBuilderConcatenation` was faster.

### 3. Which approach allocated more memory?

`StringConcatenation` allocated much more memory.

### 4. What happened when the loop size increased?

As the number of iterations increased, `StringConcatenation` became much slower.

It also used much more memory.

`StringBuilderConcatenation` was still fast when the number of iterations increased.

### 5. Why does repeated string concatenation create more allocations?

Strings in C# are immutable.
A `string` cannot be changed after it is created.

When we write:

```csharp
result += "Hello";
```

a new string is created with the old text and the new text.

Doing this many times creates many new strings.

### 6. Why does StringBuilder usually perform better?

StringBuilders in C# are mutable.
`StringBuilder` is made for adding text many times.

It can keep and change the text while we are building it.

### 7. Is StringBuilder always better than normal string operations?

No.

For small or simple string operations, normal strings are easier and are usually enough.

`StringBuilder` is more useful when we need to add or change text many times.
