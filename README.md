# Monetis – Expense Tracker

Monetis is a simple web-based expense tracker that lets users log, categorize, and view their daily spending. It’s built with Blazor WebAssembly and ASP.NET Core Web API, using SQLite as the database.

---

## Features

- Add, edit, and delete expenses
- Filter expenses by category
- See a chart of spending by category (Chart.js)
- Total spent amount calculated automatically
- Dark/light mode toggle
- Seeded database with example data
- Responsive UI built with Bootstrap

---

## Technologies Used

- Blazor WebAssembly (Frontend)
- ASP.NET Core 8 (Backend API)
- Entity Framework Core + SQLite
- Chart.js (via CDN for category visualization)
- Bootstrap for styling and layout

---

## How to Run

1. Clone the repo  
2. Make sure both projects (`MonetisV2.Client` and `MonetisV2.Server`) are set as startup projects  
3. Run the solution  
4. Open the client in your browser (usually `https://localhost:6004`)

> Make sure the backend is also running (usually `https://localhost:6002`)  
> You can test the API directly using Swagger at `https://localhost:6002/swagger`

---

## Implemented From Feature Checklist

- ✅ Built as a full CRUD API
- ✅ Uses async methods throughout
- ✅ Shared class model with Blazor and Web API
- ✅ Added category filtering and a summary function (total spent)
- ✅ Chart shows spending breakdown by category
- ✅ Dark/light theme toggle
- ✅ Clean commits and final polish

---

## Notes

- Sample data is included via EF Core seeding
- Chart.js is loaded via CDN — no extra setup required
- Project is structured using top-level C# 9 syntax for clarity

---

## Author

Built by me for a course submission. Feel free to explore and use the code for learning.
