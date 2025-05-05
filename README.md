Belgium Campus Cafeteria Discount Eligibility System
C# .NET Console App

A C# console application that helps Belgium Campus determine which students qualify for a high-performing student discount based on residency status, academic performance, and financial criteria.

📌 Features
✅ Student Data Capture

Collects student details (name, residency status, years on campus, allowance, average marks).

Supports both residential and commuter students.

✅ Discount Eligibility Check

Validates if a student qualifies for the discount based on:

Residency: Must be a residence student with >1 year on campus.

Academic Performance: Average mark > 85%.

Financial Constraint: Monthly allowance ≤ R1000.

✅ Interactive Menu System

Enum-based menu for easy navigation:

Capture Student Details

Check Discount Qualification

Display Qualification Status

Exit Program

✅ Input Validation & Error Handling

Ensures correct data types (e.g., numbers for marks, non-empty names).

Handles exceptions gracefully (e.g., invalid user input).

✅ OOP Design

Uses abstract class Student with derived classes:

Residential (dorm name, room number)

CommuterStudent (address, transport mode)

🚀 How It Works
Capture Student Data

Enter student details (name, residency, years on campus, allowance, marks).

Supports adding multiple students in one session.

Check Discount Eligibility

Evaluates each student against discount criteria.

Stores qualified students in a separate list.

Display Qualification Stats

Shows the count of students who qualified vs. did not qualify.

Lists names of eligible students.

Exit

Closes the application.

📂 Code Structure
plaintext
BelgiumCampusDiscountApp/
├── Program.cs            # Main program & menu logic
├── Student.cs            # Abstract Student class
├── Residential.cs        # Residential student subclass
├── CommuterStudent.cs    # Commuter student subclass
└── README.md             # Project documentation
🔧 Setup & Execution
Prerequisites

.NET SDK (6.0 or later)

IDE (VS Code, Visual Studio, or JetBrains Rider)

Run the Application

bash
dotnet run
Follow On-Screen Prompts

Use the menu options (1-4) to navigate.

📊 Sample Output
plaintext
Main Menu
1. Capture Details
2. Check Discount Qualification
3. Show Qualification Status
4. Exit
Enter your choice: 1

Enter full student's name: John Doe
Is the student a residence student? (Y/N): Y
Years on campus: 2
Years at current residence: 1
Monthly allowance: 800
Average mark: 90
Dormitory name: ABC Hall
Room number: 101

Add another student? (Y/N): N

2 students qualify for a discount:
- John Doe
- Jane Smith
📜 License
This project is open-source under the MIT License.

🎯 Key Improvements
✔ Input Validation – Ensures correct data entry (e.g., marks between 0-100).
✔ Exception Handling – Catches errors like invalid user input.
✔ Clean OOP Design – Separates residential/commuter student logic.
✔ User-Friendly Menu – Simple navigation with enum-driven options.
