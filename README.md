# 🔐 Password Generator (C# Console App)

A simple C# console application for generating secure passwords compliant with Microsoft password policies (e.g., Microsoft 365 / Entra ID).

## 📌 Features

* Generate random passwords with length **8–256 characters**
* Meets security requirements:

  * at least **3 out of 4 character categories**:

    * lowercase letters
    * uppercase letters
    * digits
    * symbols
* Uses **all 4 categories by default** (maximum compatibility)
* Excludes ambiguous characters:

  * `O`, `0`
  * `l`, `1`
  * `I`
* Uses a **cryptographically secure random number generator**
* Built-in password validation
* Console stays open until user exits

---

## ▶️ Getting Started

### Requirements

* .NET 6.0 or newer

### Run the app

```bash
dotnet run
```

### Build and run (Release)

```bash
dotnet build -c Release
./bin/Release/net6.0/YourAppName.exe
```

---

## 🧪 Example Output

```
A7$dKp2!
xT9#LmQ2
P@4zW8!k
```

---

## 🔐 Security

The application uses:

* `System.Security.Cryptography.RandomNumberGenerator`

Instead of `Random`, which ensures:

* better entropy
* resistance to prediction
* alignment with security best practices

---

## ⚙️ How It Works

1. The user provides the desired password length
2. The app guarantees required character categories
3. Remaining characters are filled randomly
4. Final password is shuffled to avoid predictable patterns

---

## 📁 Project Structure

```
/PasswordGenerator
 ├── Program.cs
 ├── PasswordGenerator.csproj
 └── README.md
```

---

## 🚀 Possible Improvements

* copy password to clipboard
* generate multiple passwords at once
* export to file
* GUI version (WinForms / WPF)
* integration with Microsoft Graph API (user provisioning)

---

## ⚠️ Notes

* Do not store generated passwords in the repository
* Do not use in production environments without proper security review

---

## 📄 License

MIT (or any license you choose)
