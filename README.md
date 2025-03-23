# 💸 Monetis - Expense Tracker

**Monetis** is a web-based expense tracker built using **Blazor WebAssembly** and **ASP.NET Core**. It helps users log, categorize, and manage their daily expenses, offering detailed summaries and filtering capabilities — all in a clean and responsive interface.

## 🚀 Features

- ✅ **Expense Logging** – Add new expenses with description, amount, category, and date
- ✅ **Edit/Delete Expenses** – Update or remove entries
- ✅ **Expense Summary** – View total and category-wise breakdown
- ✅ **Search & Filter** – Filter by category or date range
- ✅ **Responsive UI** – Works on desktop and mobile

## 🛠 Technologies Used

| Layer     | Tech Stack                          |
|-----------|-------------------------------------|
| Frontend  | Blazor WebAssembly, Razor Components, Bootstrap |
| Backend   | ASP.NET Core Web API (.NET 8), CORS-enabled |
| Database  | SQLite + Entity Framework Core      |
| Tools     | Swagger/OpenAPI, Visual Studio, Git/GitHub |

## 📁 Project Structure

- `MonetisV2.Client` — Blazor WebAssembly frontend
- `MonetisV2.Server` — ASP.NET Core backend API (runs on `https://localhost:6001`)
- `MonetisV2.Shared` — Shared models between client and server

## 🧪 How to Run Locally

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- Visual Studio 2022 or newer

### Steps

1. Clone the repository:
   ```bash
   git clone https://github.com/VayHek/Monetis.git
   cd Monetis
   ```

2. Run the backend:
   - Open `MonetisV2.Server` in Visual Studio
   - Set it as the **Startup Project**
   - Run it (F5)
   - Should open `https://localhost:6001/swagger`

3. Run the frontend:
   - Open a second instance of Visual Studio
   - Set `MonetisV2.Client` as the Startup Project
   - Run it (F5)
   - App loads at `https://localhost:5000`

## ✅ Integrated Requirements Checklist

- ✔️ Uses Razor Components (Blazor WebAssembly SPA)
- ✔️ Backend API with full CRUD (`GET`, `POST`, `PUT`, `DELETE`)
- ✔️ SQLite database with at least 1 entity (`Expense`)
- ✔️ Entity Framework Core for DB access
- ✔️ At least 3 functions/methods used for data handling
- ✔️ Responsive UI with Bootstrap
- ✔️ Hosted locally with CORS and Swagger support

## 📌 Notes for Reviewers

- The client and server are run **separately** (not hosted by server)
- Ensure CORS is enabled and both are running on their respective ports
- All sample data is stored locally in a SQLite file (`monetis.db`)
- The `README.md` includes complete setup instructions

## 👨‍💻 Author

[VayHek](https://github.com/VayHek)
