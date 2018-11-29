package Java_SQL_UI;

import java.sql.*;
import java.text.SimpleDateFormat;

public class OperationsSales {
    static PreparedStatement preparedStatement = null;
    static Statement statement = null;
    static Connection connection = UI.Connection();
    static ResultSet resultSet = null;

    public static Object[][] DisplayAll()
    {
        Object[][] rowData = new Object[1000][5];
        int i = 0;
        try {
            statement = connection.createStatement();
            resultSet = statement.executeQuery("SELECT * FROM sales");
            while(resultSet.next()) {
                int saleCode = resultSet.getInt(1);
                int bookCOde = resultSet.getInt(2);
                String saleDate = resultSet.getString(3);
                int quantity = resultSet.getInt(4);
                double price = resultSet.getDouble(5);

                String[] newDate = saleDate.split(" ");

                rowData[i][0] = saleCode;
                rowData[i][1] = bookCOde;
                rowData[i][2] = newDate[0];
                rowData[i][3] = quantity;
                rowData[i][4] = price;

                i += 1;
            }
        }
        catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return rowData;
    }
    public static void AddSales(int bookCode, String date, int quantity, double price)
    {
        try {
            preparedStatement = connection.prepareStatement("INSERT INTO sales (BOOKCODE, SALESDATE, QUANTITY, PRICE) VALUES (?,?,?,?)");
            preparedStatement.setInt(1, bookCode);
            preparedStatement.setString(2, date);
            preparedStatement.setInt(3, quantity);
            preparedStatement.setDouble(4, price);

            int row = preparedStatement.executeUpdate();
            System.out.println(row + " record have been added");
        }
        catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
    public static void UpdateSale(int saleID, int bookCode, Date saleDate, int quantity, double price)
    {
        try{
            preparedStatement = connection.prepareStatement("UPDATE sales SET  BOOKCODE = ?, SALESDATE = ?, QUANTITY = ?, PRICE = ? WHERE SALEID = ?");

            preparedStatement.setInt(1, bookCode);
            preparedStatement.setDate(2, saleDate);
            preparedStatement.setInt(3, quantity);
            preparedStatement.setDouble(4, price);
            preparedStatement.setInt(5, saleID);
            preparedStatement.executeUpdate();
        }
        catch (Exception e){
            System.out.println(e.getMessage());
        }
    }
    public static void DeleteSale(int saleID)
    {
        try{
            preparedStatement = connection.prepareStatement("DELETE FROM sales WHERE SALEID = ?");
            preparedStatement.setInt(1, saleID);

            int row = preparedStatement.executeUpdate();
            System.out.println(row + " row have been deleted");
        }catch (Exception e){
            System.out.println(e.getMessage());
        }
    }
    public static Object[][] SaleDateCriteria(Date date)
    {
        Object[][] searchTable = new Object[1000][5];
        int i = 0;
        try{
            preparedStatement = connection.prepareStatement("SELECT * FROM sales WHERE salesdate = ?");
            preparedStatement.setDate(1, date);
            resultSet = preparedStatement.executeQuery();
            while(resultSet.next()) {
                int saleCode = resultSet.getInt(1);
                int bookCOde = resultSet.getInt(2);
                String saleDate = resultSet.getString(3);
                int quantity = resultSet.getInt(4);
                double price = resultSet.getDouble(5);

                String[] newDate = saleDate.split(" ");

                searchTable[i][0] = saleCode;
                searchTable[i][1] = bookCOde;
                searchTable[i][2] = newDate;
                searchTable[i][3] = quantity;
                searchTable[i][4] = price;

                i += 1;
            }
        }
        catch (Exception e){
            System.out.println(e.getMessage());
        }
        return searchTable;
    }
}
