This is Assignment 5 in Java
  Implementation of UI in a Java application which is connected to Oracle (You can use your database of preference).
  
In order to run the application:

  1 - Install ojdbc7.jar (will be included in the folder).
  
  2 - Change the Connection() inside UI.java
      e.g.:   String connectionUrl = "jdbc:oracle:thin:@localhost:1521:ORCL"; //in case you're using localhost keep this Url.
              String connectionUser = "";       //your db user here.
              String connectionPassword = "";   //your db password here.
              
  3 - Run the SQL script (if using Oracle, SQL script will be inside the folder).
  
