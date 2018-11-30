package Java_SQL_UI;

import javax.swing.*;
import javax.swing.table.DefaultTableModel;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class BookForm extends JFrame implements ActionListener {
    Container container = new Container();

    JLabel lblBook = new JLabel("Book Form ");

    JButton addBtn = new JButton("Add");
    JButton deleteBtn = new JButton("Delete");
    JButton updateBtn = new JButton("Update");
    JButton viewBtn = new JButton("View");

    JButton searchBtn = new JButton("Search");
    JButton refreshBtn = new JButton("Refresh");

    JRadioButton titleRdn = new JRadioButton("Title:");
    JRadioButton authorRdn = new JRadioButton("Author:");
    ButtonGroup allRdn = new ButtonGroup();

    JTextField txtSearch = new JTextField();
    JTable viewTable = new JTable();
    JScrollPane tableScrollPane = new JScrollPane(viewTable);
    DefaultTableModel model;



    public BookForm() {

        container = this.getContentPane();
        container.setLayout(null);
        container.setBackground(Color.white);

        lblBook.setBounds(240, 10, 80, 20);

        titleRdn.setBounds(46, 100, 80, 20);
        titleRdn.setBackground(Color.white);
        titleRdn.setSelected(true);
        authorRdn.setBounds(126, 100, 80, 20);
        authorRdn.setBackground(Color.white);

        addBtn.setBounds(46,60,80,20);
        updateBtn.setBounds(172, 60, 80, 20);
        deleteBtn.setBounds(298, 60, 80, 20);
        viewBtn.setBounds(424,60,80,20);
        searchBtn.setBounds(298, 120, 80, 20);
        refreshBtn.setBounds(424, 120, 80, 20);

        allRdn.add(titleRdn);
        allRdn.add(authorRdn);

        txtSearch.setBounds(46, 120, 250, 20);

        tableScrollPane.setBounds(0, 155, 547, 183);

        container.add(lblBook);

        container.add(titleRdn);
        container.add(authorRdn);

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
            Object rowData[][] = OperationsBooks.DisplayAll();

            Object columnNames[] = {"BookCode", "Title", "Author", "Price", "Type", "Subject"};
            return model = new DefaultTableModel(rowData, columnNames);
        } catch (Exception e) {
            Object rowData[][] = {};

            Object columnNames[] = {"BookCode", "Title", "Author", "Price", "Type", "Subject"};
            return model = new DefaultTableModel(rowData, columnNames);
        }
    }
    public void actionPerformed(ActionEvent e) {
        try {
            if (e.getSource() == addBtn) {
                try {
                    addBookForm addForm = new addBookForm();
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
            else if (e.getSource() == updateBtn) {
                try{
                    updateBookForm updateForm = new updateBookForm();
                    updateForm.setTitle("Edit Book Record");
                    updateForm.setPreferredSize(new Dimension(560, 400));
                    //set location

                    int bookID = (int) viewTable.getValueAt(viewTable.getSelectedRow(), 0);
                    String bookTitle = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(), 1));
                    String bookAuthor = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(), 2));
                    String bookPrice = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(), 3));
                    String bookType = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(), 4));
                    String bookSubject = String.valueOf(viewTable.getValueAt(viewTable.getSelectedRow(), 5));

                    updateForm.getInfo(bookID, bookTitle, bookAuthor, bookPrice, bookType, bookSubject);

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
            else if (e.getSource() == deleteBtn) {
                try {
                    int bookID = (int) viewTable.getValueAt(viewTable.getSelectedRow(), 0);
                    OperationsBooks.DeleteBook(bookID);

                    populatedTable();
                    model.fireTableDataChanged();
                    viewTable.setModel(model);

                } catch (Exception delete) {
                    System.out.println(delete.getMessage());
                    System.out.println("ERROR While trying to Delete");
                }
            }
            else if (e.getSource() == viewBtn) {
                populatedTable();
                model.fireTableDataChanged();
                viewTable.setModel(model);
            }
            else if (e.getSource() == searchBtn) {
                String textField = txtSearch.getText();
                if (titleRdn.isSelected()) {
                    if (textField.isEmpty()) {
                        System.out.println("ERROR Please enter a Title");
                    }else{
                        try {
                            Object searchTable[][] = OperationsBooks.TitleCriteria(textField);

                            Object columnNames[] = {"BookCode", "Title", "Author", "Price", "Type", "Subject"};
                            model = new DefaultTableModel(searchTable, columnNames);
                        } catch (Exception search) {
                            Object searchTable[][] = {};

                            Object columnNames[] = {"BookCode", "Title", "Author", "Price", "Type", "Subject"};
                            model = new DefaultTableModel(searchTable, columnNames);
                        }
                        viewTable.setModel(model);
                        model.fireTableDataChanged();
                    }
                }
                else if(authorRdn.isSelected()){
                    if (txtSearch.getText().isEmpty()) {
                        System.out.println("ERROR Please enter a Author");
                    } else {
                        try {
                            Object searchTable[][] = OperationsBooks.AuthorCriteria(textField);

                            Object columnNames[] = {"BookCode", "Title", "Author", "Price", "Type", "Subject"};
                            model = new DefaultTableModel(searchTable, columnNames);
                        } catch (Exception search) {
                            Object searchTable[][] = {};

                            Object columnNames[] = {"BookCode", "Title", "Author", "Price", "Type", "Subject"};
                            model = new DefaultTableModel(searchTable, columnNames);
                        }
                        viewTable.setModel(model);
                        model.fireTableDataChanged();
                    }
                }
            }
            else if (e.getSource() == refreshBtn) {
                populatedTable();
                model.fireTableDataChanged();
                viewTable.setModel(model);
            }
        } catch (Exception bookAction) {
            System.out.println(bookAction.getMessage());
        }
    }
}