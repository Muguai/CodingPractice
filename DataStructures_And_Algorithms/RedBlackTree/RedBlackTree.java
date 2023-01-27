import java.util.LinkedList;

enum Color { RED, BLACK }

class RedBlackTree {
    private Node root;

    class Node {
        int data;
        Color color;
        Node left, right, parent;

        public Node(int data) {
            this.data = data;
            color = Color.RED;
            left = right = parent = null;
        }
    }

    public RedBlackTree() {
        root = null;
    }

    public void insert(int data) {
        root = insert(root, data);
        root.color = Color.BLACK;
    }

    //InsertMethodd
    private Node insert(Node node, int data) {
        if (node == null) {
            return new Node(data);
        }

        if (node.data > data) {
            node.left = insert(node.left, data);
            node.left.parent = node;
        } else {
            node.right = insert(node.right, data);
            node.right.parent = node;
        }

        if (isRed(node.right) && !isRed(node.left)) {
            node = rotateLeft(node);
        }

        if (isRed(node.left) && isRed(node.left.left)) {
            node = rotateRight(node);
        }

        if (isRed(node.left) && isRed(node.right)) {
            flipColors(node);
        }

        return node;
    }

    private Node rotateLeft(Node node) {
        Node right = node.right;
        node.right = right.left;
        right.left = node;
        right.color = node.color;
        node.color = Color.RED;
        return right;
    }

    private Node rotateRight(Node node) {
        Node left = node.left;
        node.left = left.right;
        left.right = node;
        left.color = node.color;
        node.color = Color.RED;
        return left;
    }

    private void flipColors(Node node) {
        node.color = Color.RED;
        node.left.color = Color.BLACK;
        node.right.color = Color.BLACK;
    }

    private boolean isRed(Node node) {
        if (node == null) {
            return false;
        }
        return node.color == Color.RED;
    }

    public void inOrderTraversal() {
        inOrderTraversal(root);
    }

    private void inOrderTraversal(Node node) {
        if (node == null) {
            return;
        }

        inOrderTraversal(node.left);
        System.out.print(node.data + " ");
        inOrderTraversal(node.right);
    }
    
    //DELETE Method
    public void delete(int value) {
        root = deleteRecursive(root, value);
    }

    private Node deleteRecursive(Node current, int value) {
        if (current == null) {
            return null;
        }

        if (value == current.data) {
            if (current.left == null && current.right == null) {
                return null;
            }

            if (current.right == null) {
                return current.left;
            }

            if (current.left == null) {
                return current.right;
            }

            int smallestValue = findSmallestValue(current.right);
            current.data = smallestValue;
            current.right = deleteRecursive(current.right, smallestValue);
            return current;
        }

        if (value < current.data) {
            current.left = deleteRecursive(current.left, value);
            return current;
        }

        current.right = deleteRecursive(current.right, value);
        return current;
    }

    private int findSmallestValue(Node root) {
        return root.left == null ? root.data : findSmallestValue(root.left);
    }
    
    // Search Method
    public boolean search(int value) {
        return searchRecursive(root, value);
    }

    private boolean searchRecursive(Node current, int value) {
        if (current == null) {
            return false;
        }

        if (current.data == value) {
            return true;
        }

        return value < current.data
                ? searchRecursive(current.left, value)
                : searchRecursive(current.right, value);
    }
}