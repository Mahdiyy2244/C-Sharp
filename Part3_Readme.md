# 🎨 Console Color Demo (C#)

A minimal C# console application that demonstrates how to change the background color of the console window using the `System.Console` API.

## 📌 What it does

```csharp
Console.BackgroundColor = ConsoleColor.Blue;
Console.Clear();
Console.ReadLine();
```

This small snippet:
1. Sets the console's **background color** to blue using `Console.BackgroundColor`.
2. Calls `Console.Clear()` to apply the new background color to the entire visible screen.
3. Calls `Console.ReadLine()` to pause execution and keep the window open until the user presses **Enter**.

## 🚀 Why this matters

Working directly with the `Console` class is a great way to understand how terminal applications control rendering, colors, and I/O at a low level — a foundational skill before moving into more advanced UI or CLI tooling in .NET.

## 🛠️ Tech Stack

- **Language:** C#
- **Runtime:** .NET (Console Application)

## ▶️ How to run

```bash
# Clone the repository
git clone https://github.com/<your-username>/<repo-name>.git
cd <repo-name>

# Run the project
dotnet run
```

## 📷 Preview

When you run the app, the console background instantly turns blue and waits for you to press **Enter** to exit.

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

⭐ If you found this useful, consider giving the repo a star!
