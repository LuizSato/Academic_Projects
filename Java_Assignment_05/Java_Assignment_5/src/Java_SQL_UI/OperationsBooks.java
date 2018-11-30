package Java_SQL_UI;

import java.sql.*;

public class OperationsBooks {
    static PreparedStatement preparedStatement = null;
    static Statement statement = null;
    static Connection connection = UI.Connection();
    static ResultSet resultSet = null;

    public static Object[][] DisplayAll()
    {
        Object[][] rowData = new Object[1000][6];
        int i = 0;
        try{
            statement = connection.createStatement();
            resultSet = statement.executeQuery("SELECT * FROM books");

            while(resultSet.next()) {
                int bookCode = resultSet.getInt(1);
                String title = resultSet.getString(2);
                String author = resultSet.getString(3);
                double price = resultSet.getDouble(4);
                String type = resultSet.getString(5);
                String subject = resultSet.getString(6);

                rowData[i][0] = bookCode;
                rowData[i][1] = title;
                rowData[i][2] = author;
                rowData[i][3] = price;
                rowData[i][4] = type;
                rowData[i][5] = subject;

                i += 1;
            }
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
        return rowData;
    }
    public static void AddBook(String bookTitle, String bookAuthor, double price, String bookType, String bookSubject)
    {
        try {
            preparedStatement = connection.prepareStatement("INSERT INTO books (TITLE, AUTHOR, PRICE, TYPE, SUBJECT) VALUES (?,?,?,?,?)");

            preparedStatement.setString(1, bookTitle);
            preparedStatement.setString(2, bookAuthor);
            preparedStatement.setDouble(3, price);
            preparedStatement.setString(4, bookType);
            preparedStatement.setString(5, bookSubject);

            int row = preparedStatement.executeUpdate();
            System.out.println(row + " record have been added \n" + bookTitle + " added");
        }
        catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    public static void UpdateBook(String bookTitle, String bookAuthor, double price, String bookType, String bookSubject, int bookID)
    {
        try{
            preparedStatement = connection.prepareStatement("UPDATE books SET TITLE = ?, AUTHOR = ?, PRICE = ?, TYPE = ?, SUBJECT = ? WHERE BOOKCODE = ?");

            preparedStatement.setString(1, bookTitle);
            preparedStatement.setString(2, bookAuthor);
            preparedStatement.setDouble(3, price);
            preparedStatement.setString(4, bookType);
            preparedStatement.setString(5, bookSubject);
            preparedStatement.setInt(6, bookID);


            int row = preparedStatement.executeUpdate();
            System.out.println(row + " record have been updated");
        }
        catch (Exception e){
            System.out.println(e.getMessage());
        }
    }
    public static void DeleteBook(int bookID)
    {
        try{
            preparedStatement = connection.prepareStatement("DELETE FROM sales WHERE BOOKCODE = ?");
            preparedStatement.setInt(1, bookID);
            preparedStatement.executeUpdate();
            preparedStatement = connection.prepareStatement("DELETE FROM books WHERE BOOKCODE = ?");
            preparedStatement.setInt(1, bookID);
            int row = preparedStatement.executeUpdate();
            System.out.println(row + " record have been deleted");
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
    }
    public static Object[][] TitleCriteria(String bookTitle)
    {
        Object[][] searchTable = new Object[1000][6];
        int i = 0;
        try{
            preparedStatement = connection.prepareStatement("SELECT * FROM books WHERE title = ?");
            preparedStatement.setString(1, bookTitle);
            resultSet = preparedStatement.executeQuery();
            while(resultSet.next()){
                int bookCode = resultSet.getInt(1);
                String title = resultSet.getString(2);
                String author = resultSet.getString(3);
                double price = resultSet.getDouble(4);
                String type = resultSet.getString(5);
                String subject = resultSet.getString(6);

                searchTable[i][0] = bookCode;
                searchTable[i][1] = title;
                searchTable[i][2] = author;
                searchTable[i][3] = price;
                searchTable[i][4] = type;
                searchTable[i][5] = subject;

                i += 1;
            }
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
        return searchTable;
    }
    public static Object[][] AuthorCriteria(String bookAuthor)
    {
        Object[][] searchTable = new Object[1000][6];
        int i = 0;
        try{
            preparedStatement = connection.prepareStatement("SELECT * FROM books WHERE author = ?");
            preparedStatement.setString(1, bookAuthor);
            resultSet = preparedStatement.executeQuery();
            while(resultSet.next()){
                int bookCode = resultSet.getInt(1);
                String title = resultSet.getString(2);
                String author = resultSet.getString(3);
                double price = resultSet.getDouble(4);
                String type = resultSet.getString(5);
                String subject = resultSet.getString(6);

                searchTable[i][0] = bookCode;
                searchTable[i][1] = title;
                searchTable[i][2] = author;
                searchTable[i][3] = price;
                searchTable[i][4] = type;
                searchTable[i][5] = subject;

                i += 1;
            }
        }
        catch (Exception e){
            System.out.println(e.getMessage());
        }
        return searchTable;
    }
}