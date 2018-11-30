package Java_SQL_UI;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class SaleForm extends JFrame implements ActionListener{
    Container container = new Container();

    JLabel lblBook = new JLabel("Sale Form ");

    JButton addBtn = new JButton("Add");
    JButton deleteBtn = new JButton("Delete");
    JButton updateBtn = new JButton("Update");
    JButton viewBtn = new JButton("View");

    JButton searchBtn = new JButton("Search");
    JButton refreshBtn = new JButton("Refresh");

    JRadioButton saleDateRdn = new JRadioButton("Sale Date: (YYYY-MM-DD)");

    JTextField txtSearch = new JTextField();
    JTable viewTable = new JTable();
    JScrollPane tableScrollPane = new JScrollPane(viewTable);
    DefaultTableModel model;

    public SaleForm() {

        container = this.getContentPane();
        container.setLayout(null);
        container.setBackground(Color.white);

        lblBook.setBounds(240, 10, 80, 20);

        saleDateRdn.setBounds(46, 100, 200, 20);
        saleDateRdn.setBackground(Color.white);
        saleDateRdn.setSelected(true);

        addBtn.setBounds(46, 60, 80, 20);
        updateBtn.setBounds(172, 60, 80, 20);
        deleteBtn.setBounds(298, 60, 80, 20);
        viewBtn.setBounds(424, 60, 80, 20);
        searchBtn.setBounds(298, 120, 80, 20);
        refreshBtn.setBounds(424, 120, 80, 20);

        txtSearch.setBounds(46, 120, 250, 20);

        tableScrollPane.setBounds(0, 155, 547, 183);

        container.add(lblBook);

        container.add(saleDateRdn);

        container.add(addBtn);
        container.add(updateBtn);
        container.add(deleteBtn);
        container.add(viewBtn);
        container.add(searchBtn);
        container.add(refreshBtn);

        container.add(tableScrollPane);

        container.add(txtSearch);

        viewTable.setFillsViewportHeight(true);
        viewTable.getTableHeader().setReorderingAllowed(false);


        addBtn.addActionListener(this);
        updateBtn.addActionListener(this);
        deleteBtn.addActionListener(this);
        viewBtn.addActionListener(this);
        searchBtn.addActionListener(this);
        refreshBtn.addActionListener(this);

        populatedTable();
        viewTable.setModel(model);
    }
    public DefaultTableModel populatedTable()
    {
        try {
            Object rowData[][] = OperationsSales.DisplayAll();

            Object columnNames[] = {"SaleID", "BookCode", "Sales Date", "Quantity", "Price"};
            return model = new DefaultTableModel(rowData, columnNames);
        } catch (Exception e) {
            Object rowData[][] = {};

            Object columnNames[] = {"SaleID", "BookCode", "Sales Date", "Quantity", "Price"};
            return model = new DefaultTableModel(rowData, columnNames);
        }
    }
    public void actionPerformed(ActionEvent e) {
        try{
            if (e.getSource() == addBtn){
                try {
                    addSaleForm addForm = new addSaleForm();
                    addForm.setTitle("Add Book Record");
                    addForm.setPreferredSize(new Dimension(560, 400));

                    addForm.pack();
                    addForm.setVisible(true);

                    populatedTable();
                    model.fireTableDataChanged();
                    viewTable.setModel(model);

                } catch (Exception add) {
                    System.out.println(add.getMessage());
                    System.out.println("ERROR While trying to Add");
                }

            }
            else if (e.getSource() == updateBtn){
                try{
                    updateSaleForm updateForm = new updateSaleForm();
                    updateForm.setTitle("Edit Sale Record");
                    updateForm.setPreferredSize(new Dimension(560, 400));

                    int saleID = (int) viewTable.getValueAt(viewTable.getSelectedRow(),0);
                    String bookCode = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(), 1));
                    String saleDate = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(),2));
                    String saleQuantity = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(), 3));
                    String salePrice = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(),4));

                    updateForm.getInfo(saleID, bookCode, saleDate, saleQuantity, salePrice);

                    updateForm.pack();
                    updateForm.setVisible(true);

                    populatedTable();
                    model.fireTableDataChanged();
                    viewTable.setModel(model);

                }catch (Exception update){
                    System.out.println(update.getMessage());
                    System.out.println("ERROR While trying to Edit");
                }

            }
            else if (e.getSource() == deleteBtn){
                try{
                    int saleID = (int) viewTable.getValueAt(viewTable.getSelectedRow(),0);
                    OperationsSales.DeleteSale(saleID);

                    populatedTable();
                    model.fireTableDataChanged();
                    viewTable.setModel(model);

                }catch (Exception delete){
                    System.out.println(delete.getMessage());
                    System.out.println("ERROR While trying to Delete");
                }

            }
            else if (e.getSource() == viewBtn){
                populatedTable();
                model.fireTableDataChanged();
                viewTable.setModel(model);
            }
            else if (e.getSource() == searchBtn){
                java.sql.Date saleDate = java.sql.Date.valueOf(txtSearch.getText());
//                String searchField = txtSearch.getText();
                if(saleDateRdn.isSelected()){
                    if(txtSearch.getText().isEmpty()) {
                        System.out.println("ERROR Please enter a Sale Date");
                    }else{
                        try {
                            Object searchTable[][] = OperationsSales.SaleDateCriteria(saleDate);

                            Object columnNames[] = {"SaleID", "BookCode", "Sales Date", "Quantity", "Price"};
                            model = new DefaultTableModel(searchTable, columnNames);
                        } catch (Exception search) {
                            Object searchTable[][] = {};

                            Object columnNames[] = {"SaleID", "BookCode", "Sales Date", "Quantity", "Price"};
                            model = new DefaultTableModel(searchTable, columnNames);
                        }
                        viewTable.setModel(model);
                        model.fireTableDataChanged();
                    }
                }
            }
            else if (e.getSource() == refreshBtn){
                populatedTable();
                model.fireTableDataChanged();
                viewTable.setModel(model);
            }
        }catch (Exception saleAction){
            System.out.println(saleAction.getMessage());
        }
    }
}
