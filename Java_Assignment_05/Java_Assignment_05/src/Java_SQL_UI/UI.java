package Java_SQL_UI;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.sql.*;
import javax.swing.*;

public class UI {
    static Connection connection = null;
    static BookForm bkForm = new BookForm();
    static SaleForm slForm = new SaleForm();

    public static void main(String[] args) {
        bkForm.setVisible(true);
        bkForm.setTitle("Java Assignment 5 - BookForm");
        bkForm.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        bkForm.setJMenuBar(UI.MenuBar());
        bkForm.setSize(560, 400);

        slForm.setTitle("Java Assignment 5 - Sale Form");
        slForm.setDefaultCloseOperation(JFrame.DISPOSE_ON_CLOSE);
        slForm.setSize(560, 400);
        slForm.setJMenuBar(UI.MenuBar());
    }
    public static Connection Connection() {
        try {
            Class.forName("oracle.jdbc.OracleDriver");
            String connectionUrl = "jdbc:oracle:thin:@localhost:1521:ORCL";
            String connectionUser = "JavaProject";
            String connectionPassword = "password";

            connection = DriverManager.getConnection(connectionUrl, connectionUser, connectionPassword);

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
        return connection;
    }
    public static JMenuBar MenuBar() {
        JMenuBar menuBar = new JMenuBar();
        JMenu menu = new JMenu("Table");
        menuBar.add(menu);

        JMenuItem bookMenu = new JMenuItem("Books Table");
        bookMenu.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                bkForm.setVisible(true);
                slForm.dispose();
            }
        });
        menu.add(bookMenu);

        JMenuItem saleMenu = new JMenuItem("Sale Table");
        saleMenu.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                slForm.setVisible(true);
                bkForm.dispose();
            }
        });
        menu.add(saleMenu);
        return menuBar;
    }
}