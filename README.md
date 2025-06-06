# 🏋️ WorkoutSpecialist

**WorkoutSpecialist** to aplikacja desktopowa Windows Forms (.NET), która pozwala użytkownikom tworzyć, przeglądać i zarządzać swoimi planami treningowymi.

---

## 📦 Funkcje

- ✅ Rejestracja i logowanie użytkowników
- ✅ Dodawanie treningów (data, ćwiczenia, serie, powtórzenia, ciężar, notatki)
- ✅ Filtrowanie i przeglądanie historii treningów
- ✅ Szczegóły wykonanych ćwiczeń
- ✅ Edycja profilu (login, email, hasło)
- ✅ Walidacja danych (login, email, hasło)

---

## 🛠️ Wymagania

- [.NET 6.0 SDK lub wyższy](https://dotnet.microsoft.com/download)
- Visual Studio 2022 lub nowszy
- SQL Server LocalDB (lub pełna wersja SQL Server)
- Entity Framework Core

---

## 🧱 Struktura bazy danych

Projekt korzysta z dwóch głównych tabel:

### `Workouts`

| Kolumna     | Typ           | Opis                |
|-------------|----------------|---------------------|
| WorkoutId   | int            | Klucz główny        |
| UserId      | int            | Klucz obcy (Users)  |
| Date        | DateTime       | Data treningu       |
| Note        | string?        | Opcjonalna notatka  |

### `Workoutexercises`

| Kolumna         | Typ      | Opis                         |
|------------------|-----------|------------------------------|
| WorkoutExerciseId| int       | Klucz główny                 |
| WorkoutId        | int       | Klucz obcy (Workouts)        |
| ExerciseId       | int       | Klucz obcy (Exercises)       |
| Sets             | int       | Ilość serii                  |
| Reps             | int       | Ilość powtórzeń              |
| Weight           | float     | Obciążenie w kilogramach     |

---

## ▶️ Jak uruchomić?

1. Sklonuj repozytorium:

   ```bash
   git clone https://github.com/twoje-repozytorium/workoutspecialist.git