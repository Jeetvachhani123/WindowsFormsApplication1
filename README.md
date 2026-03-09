# Inventory Management — Windows Forms (.NET Framework 4.8)

## Project Overview
A college-level Windows Forms application implementing a simple inventory / stock management system for a small food store or cafeteria. Built targeting .NET Framework 4.8 using Visual Studio 2022. Demonstrates WinForms UI, domain models, basic CRUD operations, simple validation, and form-based navigation.

Primary source files in this repository:
- `Form1.cs`, `Form1.Designer.cs`, `Form1.resx` — main UI
- `Stock.Designer.cs` — stock form designer
- `customer.cs` — customer model and logic
- `Category.cs` — category model and logic
- `FoodItems.cs` — product/item model and logic

## Features
- View, add, edit, and delete food items
- Categorize items and manage categories
- Basic customer record support
- Search/filter items by name or category
- Stock-level display and simple validation

Note: Persistence may be in-memory by default. Add a persistence layer (JSON/XML/SQLite/SQL Server) to retain data between runs.

## Requirements
- Windows 10 or Windows 11
- Visual Studio 2022 with the __.NET desktop development__ workload
- .NET Framework 4.8

Optional:
- SQL Server Express or SQLite if adding database persistence

## Setup and Build
1. Clone or copy the project folder to your machine.
2. Open the solution in Visual Studio 2022: `File > Open > Project/Solution` and select the `.sln` file.
3. Confirm the project targets `.NET Framework 4.8` (Project Properties).
4. Restore NuGet packages if present: `Tools > NuGet Package Manager > Manage NuGet Packages for Solution...`.
5. Build: `Build > Build Solution` (Ctrl+Shift+B).
6. Run: `Debug > Start Debugging` (F5) or `Start Without Debugging` (Ctrl+F5).

## Usage
- Use the main form (`Form1`) to view items and navigate to add/edit/delete operations.
- Manage categories from the categories UI and assign categories to items.
- Manage customers via the `customer` UI.
- If persistence is not implemented, data is ephemeral; implement a storage provider to persist data.

## Project Structure
- `Form1.*` — main form and resources
- `Stock.Designer.cs` — designer for stock-related form(s)
- `customer.cs`, `Category.cs`, `FoodItems.cs` — domain models and business logic
- `Properties/` — assembly and project metadata
- `bin/`, `obj/` — build artifacts (do not commit)

## Coding Standards & Contribution
This project includes a `.editorconfig` and `CONTRIBUTING.md` to enforce formatting and contribution rules. Follow these guidelines:
- Respect indentation, naming, and style rules in `.editorconfig`.
- Keep UI/event logic in form classes and business rules in model or service classes.
- Modify designer code only via the Visual Studio Forms Designer when possible.
- Add unit tests for non-UI logic when you extend the project.

## Extending the Project (Suggestions)
- Add persistent storage (SQLite, SQL Server Express, JSON/XML files).
- Implement role-based access or simple authentication.
- Improve search, filtering, sorting, and pagination.
- Add validation messages, confirmation dialogs, and better error handling.
- Separate business logic into services to enable unit testing.

## Testing
- Create unit tests for business logic (e.g., validation, stock update rules).
- UI tests can be manual or automated using a UI testing tool if required.

## Known Issues / Limitations
- By default, data may not persist between runs.
- Designer files (`*.Designer.cs`) are auto-generated; manual edits may be overwritten.

## Academic Notes
This is a college assignment. Include your name, student ID, and collaborator credits in `REPORT.md` or a submission cover page and follow your institution's academic integrity policies.

## License & Acknowledgements
- Add a `LICENSE` file if needed (for example, MIT) or mark as course submission only.
- Acknowledge any third-party libraries or references used.

## Contact / Submission
For submission include:
- Your name and student ID
- Instructor name and course code
- Any special setup or demonstration notes in `REPORT.md`

---
