# StudyRoomBooking

Setting up connection between the application and SQL database server

Install Microsoft SQL Server

1- Run the SQL files saved under SQL folder to create tables and add some data to those tables
	
2- Create a new login on Microsoft sql server management Studio: 
	Security -> logins (right click on login)
	New Login ( login name: project3300)
	Click SQL Server authentication
	Password: csiis3300
	On the left side click User Mapping and make sure the SudentRoomBooking is selected
	Click ok.

 3-Right click on the StudentRoomBooking database and go to properties.
	On the left side, click Permissions.
	Under User Roles, click project3300
	Under Permissions for 3300, grant the necessary permissions that we will need to
	 access and modify the database
	Click ok

4 - Connect to the login and check if you can access the info on the database StudyRoomBooking
	If you can't connect, check if the SQL Server and Windows Authentication mode is enabled.
		On Microsoft SQL Server Management Studio:
		Right click on the current server -> Properties -> Security 

4 - Run the aplication and login with the username and id saved on database.

	For Student:
	Username: 1234
	Password: 1234
	
	For Administrator
	Username: 3300
	Password: databases
