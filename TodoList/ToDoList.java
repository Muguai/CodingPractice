import java.awt.*;
import java.awt.event.*;
import java.util.*;
import javax.swing.*;

public class ToDoList extends JFrame {
    private JTextField itemField;
    private JList<String> list;
    private DefaultListModel<String> model;

    public ToDoList() {
        super("To-Do List");
        setLayout(new BorderLayout());

        itemField = new JTextField();
        itemField.addActionListener(new ItemListener());
        itemField.setColumns(10);

        model = new DefaultListModel<>();
        list = new JList<>(model);
        list.setSelectionMode(ListSelectionModel.SINGLE_SELECTION);
        list.setVisibleRowCount(5);

        JButton addButton = new JButton("Add Item");
        addButton.addActionListener(new ItemListener());
        JButton removeButton = new JButton("Remove Item");
        removeButton.addActionListener(new RemoveListener());
        JButton clearButton = new JButton("Cleaar All");
        clearButton.addActionListener(new ClearListener());

        JPanel panel = new JPanel();
        panel.add(itemField);
        panel.add(addButton);
        panel.add(removeButton);
        panel.add(clearButton);

        JScrollPane scroll = new JScrollPane(list);

        add(panel, BorderLayout.NORTH);
        add(scroll, BorderLayout.CENTER);

        setSize(600, 500);
        setVisible(true);
    }

    private class ItemListener implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            String item = itemField.getText();
            if (!item.isEmpty()) {
                model.addElement(item + " |.. Added on " + new Date().toString());
                itemField.setText("");
            }
        }
    }

    private class RemoveListener implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            int selected = list.getSelectedIndex();
            if (selected != -1) {
                model.remove(selected);
            }
        }
    }

    private class ClearListener implements ActionListener {
        public void actionPerformed(ActionEvent e) {
            model.clear();
        }
    }

    public static void main(String[] args) {
        ToDoList toDoList = new ToDoList();
        toDoList.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    }
}