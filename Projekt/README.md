
# System zarządzania cyfrową biblioteką (MVC)

Projekt pozwala na pełne zarządzanie biblioteką książek tj. dodawanie,edydowanie, przeglądanie i usuwanie elementów z bazy danych.

---

##Spis treści
1. [funkcjonalności](#funkcjonalności)
2. [instrukcja uruchomienia](#instrukcja-uruchomienia)


---

# Funkcjonalności

Apliakcja służy do zarządzania biblioteką cyfrową:
* **Wyświetlanie listy** - ukazanie listy wszystkich książek i informacji o nich z bazy danych w formie tabeli.
* **Edycja książki** - edycja dowonlej wartości z dowolnej książki. Zmiana Tytułu, Autora, Roku wydania.
* **Dodawanie nowej książki** - dodawanie książki przez formularz z walidacją danych wejściowych (długość znaków, brak pustego pola).
* **Usuwanie książki z listy** - usuwanie danej pozycji książki z bazy danych. 

# Instrukcja uruchomienia

### Wymagania programowe
* .NET SKD w wersji 8.0 lub nowszej

### Jak uruchomić

Aby uruchomić aplikację należy znajdować się w folderze z projektem i uruchomić terminal.

Przywrócenie pakietów:

```bash
dotnet restore
```

Utworzenie bazy danych:

```bash
dotnet ef database update
```

Uruchomienie aplikacji:

```bash
dotnet run
```

Apliakcja znajduje się pod adresem wyświetlanym w konsoli.


