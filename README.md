# C# Delegates Demo (`Delegates`)

Console application demonstrating the core concepts of **delegates**, **multicast delegates**, and built-in generic delegate types (`Action` and `Func`) in C#.

---

## 🚀 Features Demonstrated

1. **Custom Delegates**:
   * `MessageDelegate`: Takes a string message and returns `void`.
   * `CalculateDelegate`: Takes two integers and returns an integer (superseded by `Func` in modern C# practices).

2. **Built-in Generic Delegates**:
   * `Action`: Represents methods that return `void`.
   * `Func<T1, T2, TResult>`: Represents methods that take parameters and return a specified value.

3. **Multicast Delegates**:
   * Combining multiple methods into a single delegate invocation list using the `+=` operator.
   * Removing methods from the invocation list using the `-=` operator.

4. **Local Functions & Local Methods**:
   * Utilization of local functions declared right inside `RunLauncher` for clean and encapsulated logic.

---

## 🛠️ Code Structure

* **`Program.cs`**: Entry point of the application that calls `DelegatesCodeRealise.RunLauncher()`.
* **`DelegatesCodeRealise.cs`**: Contains the `RunLauncher` method with all delegate examples, arithmetic operations (`Add`, `Sub`, `Mult`, `Div`), and message handlers.

---

## 📋 Example Output Breakdown

When you run `DelegatesCodeRealise.RunLauncher()`, the console sequentially executes:
* Simple `Action` invocation (`SayHello`).
* Custom/Func delegate calculations (`Sum`).
* Multicast delegate chaining (`FirstMessage`, `SecondMessage`, `ThirdMessage`) and unchaining (`SecondMessage`).
* Sequential arithmetic assignments (`Add`, `Mult`, `Sub`, `Div`) and multicast arithmetic evaluation where multiple return values are chained (returning the result of the *last* executed method in the invocation list).

---

## ⚙️ How to Run

1. Make sure you have the [.NET SDK](https://dotnet.microsoft.com/) installed (version .NET Core / .NET 6+ recommended).
2. Clone or open the solution folder in your terminal or IDE (e.g., Visual Studio, Visual Studio Code, or JetBrains Rider).
3. Run the project using the .NET CLI:
   ```bash
   dotnet run
