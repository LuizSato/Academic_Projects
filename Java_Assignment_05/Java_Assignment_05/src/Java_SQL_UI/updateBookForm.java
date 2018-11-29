package Java_SQL_UI;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class updateBookForm extends JDialog implements ActionListener {
    Container container = new Container();

    JLabel lbladdform = new JLabel("Edit Book Record");
    JLabel lblTitle = new JLabel("Book Title: ");
    JLabel lblAuthor = new JLabel("Book Author: ");
    JLabel lblPrice = new JLabel("Book Price: ");
    JLabel lblType = new JLabel("Book Type: ");
    JLabel lblSubject = new JLabel("Book Subject: ");
    JLabel lblbookId = new JLabel();

    JTextField txtTitle = new JTextField();
    JTextField txtAuthor = new JTextField();
    JTextField txtPrice = new JTextField();
    JTextField txtType = new JTextField();
    JTextField txtSubject = new JTextField();

    JButton resetForm = new JButton("Reset");
    JButton editBook = new JButton("Edit Book");
    JButton closeForm = new JButton("Close");

    public updateBookForm()
    {
        container = this.getContentPane();
        container.setLayout(null);
        container.setBackground(Color.white);

        lbladdform.setBounds(220, 10, 150, 20);
        lblTitle.setBounds(50, 70, 120, 20);
        lblAuthor.setBounds(50, 110, 120, 20);
        lblPrice.setBounds(50, 150, 120, 20);
        lblType.setBounds(50, 190, 120, 20);
        lblSubject.setBounds(50, 230, 120, 20);
        lblbookId.setBounds(10,10,120,20);
        lblbookId.setVisible(false);

        txtTitle.setBounds(200, 70, 200, 20);
        txtAuthor.setBounds(200, 110, 200, 20);
        txtPrice.setBounds(200, 150, 200, 20);
        txtType.setBounds(200, 190, 200, 20);
        txtSubject.setBounds(200, 230, 200, 20);

        editBook.setBounds(60, 300, 120, 20);
        resetForm.setBounds(210, 300, 120, 20);
        closeForm.setBounds(360, 300, 120, 20);

        container.add(lbladdform);
        container.add(lblTitle);
        container.add(lblAuthor);
        container.add(lblPrice);
        container.add(lblType);
        container.add(lblSubject);
        container.add(lblbookId);

        container.add(txtTitle);
        container.add(txtAuthor);
        container.add(txtPrice);
        container.add(txtType);
        container.add(txtSubject);

        container.add(resetForm);
        container.add(editBook);
        container.add(closeForm);

        editBook.addActionListener(this);
        resetForm.addActionListener(this);
        closeForm.addActionListener(this);

        this.setModal(true);
    }
    public void actionPerformed(ActionEvent e)
    {
        try {
            if (e.getSource() == editBook)
                try {
                    String booktitle = txtTitle.getText();
                    String bookAuthor = txtAuthor.getText();
                    String bookPrice = txtPrice.getText();
                    String bookType = txtType.getText();
                    String bookSubject = txtSubject.getText();
                    String bookId = lblbookId.getText();

                    double parsedPrice = Double.parseDouble(bookPrice);
                    int bookID = Integer.parseInt(bookId);

                    OperationsBooks.UpdateBook(booktitle, bookAuthor, parsedPrice, bookType, bookSubject, bookID);

                    dispose();
                } catch (Exception eaction) {
                    System.out.println(eaction.getMessage());
                }
            else if (e.getSource() == resetForm) {
                txtTitle.setText(null);
                txtAuthor.setText(null);
                txtPrice.setText(null);
                txtType.setText(null);
                txtSubject.setText(null);
            } else if (e.getSource() == closeForm) {
                dispose();
            }
        } catch (Exception entire) {
            System.out.println(entire.getMessage());
        }
    }
    public void getInfo(int bookID, String bookTitle, String bookAuthor, String price, String bookType, String bookSubject)
    {
        lblbookId.setText(Integer.toString(bookID));
        txtTitle.setText(bookTitle);
        txtAuthor.setText(bookAuthor);
        //txt field cannot be set to int, double, float values
        txtPrice.setText(price);
        txtType.setText(bookType);
        txtSubject.setText(bookSubject);

    }

}
