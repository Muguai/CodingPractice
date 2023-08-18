import java.util.Scanner;

public class RedblackTreeExample {
    public static void main(String[] args) {
        RedBlackTree rbt = new RedBlackTree();
        Scanner sc = new Scanner(System.in);

        while (true) {
            System.out.println("1. Insert");
            System.out.println("2. Delete");
            System.out.println("3. Search");
            System.out.println("4. Exit");
            int choice = sc.nextInt();

            if (choice == 1) {
                System.out.println("Enter the value to insert:");
                int value = sc.nextInt();
                rbt.insert(value);
            } else if (choice == 2) {
                System.out.println("Enter the value to delete:");
                int value = sc.nextInt();
                rbt.delete(value);
            } else if (choice == 3) {
                System.out.println("Enter the value to search:");
                int value = sc.nextInt();
                if (rbt.search(value)) {
                    System.out.println("Value: " + value + " found in the tree.");
                } else {
                    System.out.println("Value not found in the tree.");
                }
            } else {
                break;
            }
        }
    }
}