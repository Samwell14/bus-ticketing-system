# bus-ticketing-system

Here is a step-by-step procedure to import a .sql file into a MySQL server:

## Open Command Prompt or Terminal:

On Windows, open Command Prompt.
On macOS or Linux, open Terminal.
Navigate to the Directory Containing the .sql File:

## Use the cd command to change to the directory where your .sql file is located.
cd path/to/your/file
## Log in to MySQL:

Use the mysql command to log in to your MySQL server.
mysql -u [username] -p
Replace [username] with your MySQL username. You will be prompted to enter your password.
Select the Database:

## If you haven't created the database yet, you can create it using:
SQL
CREATE DATABASE [database_name];
Replace [database_name] with the name of the database you want to create.
Select the database to use:
SQL
USE [database_name];
## Import the .sql File:

Exit the MySQL prompt by typing exit or pressing Ctrl+D.
Use the mysql command to import the .sql file into the selected database.
mysql -u [username] -p [database_name] < [dump_file.sql]
Replace [username] with your MySQL username, [database_name] with the name of your database, and [dump_file.sql] with the name of your .sql file.
