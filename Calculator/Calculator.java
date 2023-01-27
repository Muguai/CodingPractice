import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Calculator extends JFrame implements ActionListener {
    private JTextField textField;
    private JPanel panel;
    private double num1;
    private double num2;
    private double result;
    private String operator;

    public Calculator() {
        setTitle("Thisisacalculator");
        setSize(400, 500);
        setResizable(false);
        setDefaultCloseOperation(EXIT_ON_CLOSE);

        textField = new JTextField();
        textField.setEditable(false);
        
        
        textField.setBackground(Color.WHITE);
        textField.setPreferredSize(new Dimension(200, 50));
        textField.setFont(new Font("Arial", Font.PLAIN, 18));

        panel = new JPanel();
        panel.setLayout(new GridLayout(4, 4));

        String[] buttonLabels = {"7", "8", "9", "+", "4", "5", "6", "-", "1", "2", "3", "*", "C", "0", "=", "/"};
        for (String label : buttonLabels) {
            JButton button = new JButton(label);
            button.addActionListener(this);
            panel.add(button);
        }
        add(textField, BorderLayout.NORTH);
        add(panel, BorderLayout.CENTER);

        operator = "";
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        JButton button = (JButton) e.getSource();
        String buttonLabel = button.getText();
        if (Character.isDigit(buttonLabel.charAt(0))) {
            textField.setText(textField.getText() + buttonLabel);
        } else if (buttonLabel.equals("C")) {
            textField.setText("");
            num1 = 0;
            num2 = 0;
            operator = "";
        } else {
            if (operator.isEmpty()) {
                num1 = Double.parseDouble(textField.getText());
                operator = buttonLabel;
                textField.setText("");
            } else {
                num2 = Double.parseDouble(textField.getText());
                doOperator();
                operator = buttonLabel;
                num1 = result;
                num2 = 0;
            }
        }
    }

    private void doOperator() {
        switch (operator) {
            case "+":
                result = num1 + num2;
                break;
            case "-":
                result = num1 - num2;
                break;
            case "*":
                result = num1 * num2;
                break;
            case "/":
                result = num1 / num2;
                break;
        }
        textField.setText(String.valueOf(result));
    }

    public static void main(String[] args) {
        Calculator myCalculator = new Calculator();
        myCalculator.setVisible(true);
    }
}