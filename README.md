In order to be able to run the program in visual studio, you must recover the database from the backup file.
Which is located in the Database folder on the path: puc-quiz-master\Data\Databases.

***
To restore a database from a backup in Microsoft SQL Server, I recommend using SQL Server Management Studio (SSMS). Here are the steps for recovering:

1. Open SQL Server Management Studio (SSMS).

2. Connect to the SQL Server instance where you want to restore the database.

3. In the Object Explorer, right-click on "Databases" and select "Restore Database."

4. In the "Restore Database" window, specify the following:

   a. Under "Source," choose "Device" and then click the (...) button to select the backup file you want to restore.

   b. Under "Destination," specify the name of the database you want to restore to. You can choose a new name or the original name (original name is recommended).

5. Click the "OK" button to initiate the restore process.
***
<b>If you chose a new name in step (4-b) and restored database successfully now open the project in visual studio, go to App.config (puc-quiz-master/App.config) 
and change "Initial Catalog=Puc_Quiz_Questions" to "Initial Catalog=[your name of database]"</b>
***
# puc_quiz

Application screenshots:
![image](https://github.com/user-attachments/assets/0bafe409-71ef-479d-81d0-52171f7e24e3)
![image](https://github.com/user-attachments/assets/533d1192-50c8-408c-8fed-18aae7cf53e7)
![image](https://github.com/user-attachments/assets/23bb7762-79f8-41e0-81c4-7a6f1802e7ca)
![image](https://github.com/user-attachments/assets/7098500f-5f62-4a87-8bce-10530fc4e82d)




