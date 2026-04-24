# 🔐 Password Generator (C# Console App)

Prosta aplikacja konsolowa w C# do generowania bezpiecznych haseł zgodnych z wymaganiami polityki haseł Microsoft (np. Microsoft 365 / Entra ID).

## 📌 Funkcje

* Generowanie losowych haseł o długości od **8 do 256 znaków**
* Spełnia wymagania bezpieczeństwa:

  * co najmniej **3 z 4 kategorii znaków**:

    * małe litery
    * wielkie litery
    * cyfry
    * symbole
* Domyślnie używa **wszystkich 4 kategorii** (maksymalna zgodność)
* Usuwa mylące znaki:

  * `O`, `0`
  * `l`, `1`
  * `I`
* Wykorzystuje **kryptograficznie bezpieczny generator losowy**
* Walidacja hasła
* Konsola nie zamyka się automatycznie po wykonaniu

---

## ▶️ Jak uruchomić

### Wymagania

* .NET 6.0 lub nowszy

### Uruchomienie

```bash
dotnet run
```

lub po zbudowaniu:

```bash
dotnet build -c Release
./bin/Release/net6.0/YourAppName.exe
```

---

## 🧪 Przykładowe hasło

```
A7$dKp2!
xT9#LmQ2
P@4zW8!k
```

---

## 🔐 Bezpieczeństwo

Aplikacja korzysta z:

* `System.Security.Cryptography.RandomNumberGenerator`

Zamiast standardowego `Random`, co zapewnia:

* brak przewidywalności
* zgodność z dobrymi praktykami bezpieczeństwa

---

## ⚙️ Jak to działa

1. Program pobiera długość hasła od użytkownika
2. Zapewnia obecność znaków z wymaganych kategorii
3. Uzupełnia resztę znaków losowo
4. Tasuje wynik, aby uniknąć przewidywalnych wzorców

---

## 📁 Struktura projektu

```
/PasswordGenerator
 ├── Program.cs
 ├── PasswordGenerator.csproj
 └── README.md
```

---

## 🚀 Możliwe rozszerzenia

* kopiowanie hasła do schowka
* generowanie wielu haseł naraz
* eksport do pliku
* GUI (WinForms / WPF)
* integracja z Microsoft Graph API (automatyczne tworzenie użytkowników)

---

## ⚠️ Uwagi

* Nie przechowuj wygenerowanych haseł w repozytorium
* Nie używaj generatora do produkcji bez audytu bezpieczeństwa (jeśli projekt rośnie)

---

## 📄 Licencja

MIT (lub dowolna, którą wybierzesz)
