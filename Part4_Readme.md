# Hello User - C# Console App

A simple C# console application that greets the user by asking for their name and displaying it back.

## 📋 Description

This is a beginner-friendly C# console program that demonstrates basic input/output operations. It prompts the user to enter their name, reads the input, and prints it back to the console.

## 🚀 Features

- Prompts the user for input
- Reads user input from the console
- Displays the entered name
- Waits for a key press before closing

## 🛠️ Technologies Used

- **Language:** C#
- **Platform:** .NET (Console Application)

## 📦 Prerequisites

Before running this project, make sure you have:

- [.NET SDK](https://dotnet.microsoft.com/download) installed (version 6.0 or later recommended)

## ▶️ How to Run

1. Clone this repository:
   ```bash
   git clone <your-repo-url>
   cd <your-repo-folder>
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. When prompted, type your name and press **Enter**.

4. The program will display your name and wait for a key press to exit.

## 💻 Example Output

```
Enter your name : John
John
```

## 📄 Code Overview

```csharp
string name;
Console.Write("Enter your name : ");
name = Console.ReadLine();
Console.Write(name);
Console.ReadKey();
```

- `Console.Write` — displays a prompt without a line break
- `Console.ReadLine()` — reads the user's input as a string
- `Console.ReadKey()` — pauses the console window until a key is pressed

## 📝 License

This project is open source and available for learning purposes.

## 🙋 Author

Feel free to reach out or contribute if you'd like to improve this simple project!
