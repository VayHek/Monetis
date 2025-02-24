# Monetis

Project Plan: Monetis - Expense Tracker Application


1. Project Overview

Monetis is a web-based expense tracker designed to help users manage their daily finances effortlessly. It allows users to log expenses, categorize them, and view detailed summaries of their spending. The application aims to simplify personal finance management by providing an intuitive and user-friendly platform.

Key Features:

Expense Logging: Users can add new expenses with a description, amount, category, and date.

Expense Management: Users can update or delete existing expenses.

Expense Summary: Users can view a summary of their expenses, including total spending and breakdowns by category.

Search and Filter: Users can search for expenses by description or filter them by category or date range.

Responsive Design: The application will be accessible on both desktop and mobile devices.

2. Technical Insight

The project will leverage the following tools, technologies, and frameworks:

Frontend:

Blazor (WebAssembly): For building an interactive and responsive user interface.

Razor Components: To create reusable UI components (e.g., expense cards, forms).

CSS/Bootstrap: For styling the application.

Backend:

ASP.NET Core 5: To build a RESTful API for handling CRUD operations.

Entity Framework Core (EF Core): For database operations and migrations.

SQLite Database: A lightweight, file-based database for storing expenses.

APIs:

ASP.NET Core Web API: The backend will expose endpoints for:

GET /api/expenses – Retrieve all expenses.

GET /api/expenses/{id} – Retrieve a specific expense by ID.

POST /api/expenses – Create a new expense.

PUT /api/expenses/{id} – Update an existing expense.

DELETE /api/expenses/{id} – Delete an expense.

Asynchronous Programming:

Async/Await: All database operations and API calls will be asynchronous to ensure the application remains responsive.

Development Tools:

Visual Studio 2022: For development and debugging.

Swagger/OpenAPI: For API documentation and testing.

Git/GitHub: For version control.


TODOs

Set up the project structure in Visual Studio.

Create the database schema using EF Core and SQLite.

Implement the backend API with ASP.NET Core 5.

Develop the frontend using Blazor WebAssembly.

Test the application and refine.


Branding Ideas for Monetis

Logo: A sleek, modern design incorporating a coin or currency symbol with a flow or graph element to represent tracking.


Tagline: "Track. Manage. Thrive."


Color Scheme: Professional and calming colors like navy blue, teal, and white.
