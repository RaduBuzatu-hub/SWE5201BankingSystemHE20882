===============================
Banking System Submission
Student ID: HE20882
===============================

Thank you for reviewing my project. This README explains how to set up and run the Banking System application on your Windows machine.

---

1. System Requirements
---------------------
- Windows 10 or 11 (64-bit recommended)
- Microsoft SQL Server Express 2022 (free edition)
- (Optional but recommended) SQL Server Management Studio (SSMS) to manage and restore the database
- No installation of Visual Studio or .NET SDK is required to run the app

---

2. Files Included
-----------------
- BankingApp          : Folder containing the compiled application files (.exe and dependencies)
- Backup : Child backup file for SQL Server database
- BankingDB.bak           : Backup of the SQL Server database
- README.txt              : This instruction file

---

3. Installing SQL Server Express
-------------------------------
If you do not have SQL Server Express installed:

1. Go to https://www.microsoft.com/en-us/sql-server/sql-server-downloads
2. Download and install **SQL Server 2022 Express Edition**
3. During installation, choose the default instance or named instance `SQLEXPRESS`
4. Finish installation and ensure SQL Server service is running

---

4. Installing SQL Server Management Studio (Optional)
-----------------------------------------------------
To restore the database backup easily, it is recommended to install SSMS:

1. Go to https://learn.microsoft.com/en-gb/ssms/install/install
2. Download and install SQL Server Management Studio
3. Launch SSMS and connect to your SQL Server instance (`localhost\SQLEXPRESS`)

---

5. Restoring the Database Backup
--------------------------------

The database backup consists of two backup files:
- BankingDB.bak
- Backup 

Steps:

a. Open SSMS and connect to the SQL Server instance
b. Right-click on **Databases** in Object Explorer and select **Restore Database...**
c. Choose **Device** and browse to select the included `BankingDB.bak` file
d. Set the destination database name to `BankingDB`
e. Click **OK** to restore the database

---

6. Running the Application
--------------------------
1. Open the `BankingApp` folder
2. Double-click `SWE5201BankingSystemHE20882.exe` to start the banking system application
3. Use the login screen to test admin or customer features
4. Username: admin
5. Password: admin123

---

7. Notes
--------
- The application connects to the database instance `localhost\SQLEXPRESS` by default.
- Make sure the SQL Server service is running before starting the app.
- If you encounter any errors related to the database connection, verify the instance name and that the database is restored correctly.
- No additional setup or Visual Studio is required to run the published application.

---

Thank you for your time and consideration.

If you have any questions, please feel free to contact me.

Student ID: HE20882

===============================
