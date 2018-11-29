package Java_SQL_UI;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class addSaleForm extends JDialog implements ActionListener {
    Container container = new Container();

    JLabel lbladdform = new JLabel("Add New Sale Record");
    JLabel lblCode = new JLabel("Enter Book Code: ");
    JLabel lblSaleDate = new JLabel("Enter Sales Date: ");
    JLabel lblQuantity = new JLabel("Enter Sale Quantity: ");
    JLabel lblPrice = new JLabel("Enter Sale Price: ");

    JTextField txtCode = new JTextField();
    JTextField txtSaleDate = new JTextField();
    JTextField txtQuantity = new JTextField();
    JTextField txtPrice = new JTextField();

    JButton resetForm = new JButton("Reset");
    JButton addBook = new JButton("Add New Book");
    JButton closeForm = new JButton("Close");

    public addSaleForm()
    {
        container = this.getContentPane();
        container.setLayout(null);
        container.setBackground(Color.white);

        lbladdform.setBounds(220, 10, 150, 20);
        lblCode.setBounds(50, 70, 120, 20);
        lblSaleDate.setBounds(50, 110, 120, 20);
        lblQuantity.setBounds(50, 150, 120, 20);
        lblPrice.setBounds(50, 190, 120, 20);

        txtCode.setBounds(200, 70, 200, 20);
        txtSaleDate.setBounds(200, 110, 200, 20);
        txtQuantity.setBounds(200, 150, 200, 20);
        txtPrice.setBounds(200, 190, 200, 20);

        addBook.setBounds(60, 300, 120, 20);
        resetForm.setBounds(210, 300, 120, 20);
        closeForm.setBounds(360, 300, 120, 20);

        container.add(lbladdform);
        container.add(lblCode);
        container.add(lblSaleDate);
        container.add(lblQuantity);
        container.add(lblPrice);

        container.add(txtCode);
        container.add(txtSaleDate);
        container.add(txtQuantity);
        container.add(txtPrice);

        container.add(resetForm);
        container.add(addBook);
        container.add(closeForm);

        addBook.addActionListener(this);
        resetForm.addActionListener(this);
        closeForm.addActionListener(this);

        this.setModal(true);
    }
    public void actionPerformed(ActionEvent e)
    {
        try {
            if (e.getSource() == addBook)
                try {
                    String bookCode = txtCode.getText();
                    String saleDate = txtSaleDate.getText();
                    String saleQuantity = txtQuantity.getText();
                    String salePrice = txtPrice.getText();

                    int parsedCode = Integer.parseInt(bookCode);
                    int parsedQuantity = Integer.parseInt(saleQuantity);
                    double parsedPrice = Double.parseDouble(salePrice);
                    if (bookCode.isEmpty() || saleDate.isEmpty() || saleQuantity.isEmpty() || salePrice.isEmpty()) {
                        System.out.println("ERROR: Please fill all the fields");
                    } else {

                        OperationsSales.AddSales(parsedCode, saleDate, parsedQuantity, parsedPrice);
                    }
                    dispose();
                } catch (Exception eaction) {
                    System.out.println(eaction.getMessage());
                }
            else if (e.getSource() == resetForm) {
                txtCode.setText(null);
                txtSaleDate.setText(null);
                txtQuantity.setText(null);
                txtPrice.setText(null);
            } else if (e.getSource() == closeForm) {
                dispose();
            }
        } catch (Exception entire) {
            System.out.println(entire.getMessage());
        }
    }
}
