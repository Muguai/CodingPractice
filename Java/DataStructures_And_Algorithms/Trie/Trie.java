
public class Trie {
	
	class TrieNode {
	    TrieNode[] children;
	    boolean isEndOfWord;
	    TrieNode() {
	        children = new TrieNode[26];
	        isEndOfWord = false;
	    }
	}
	
    TrieNode root;
    Trie() {
        root = new TrieNode();
    }

    void insert(String word) {
        TrieNode current = root;
        for (int i = 0; i < word.length(); i++) {
            int index = word.charAt(i) - 'a';
            if (current.children[index] == null) {
                current.children[index] = new TrieNode();
            }
            current = current.children[index];
        }
        current.isEndOfWord = true;
    }

    boolean search(String word) {
        TrieNode current = root;
        for (int i = 0; i < word.length(); i++) {
            int index = word.charAt(i) - 'a';
            if (current.children[index] == null) {
                return false;
            }
            current = current.children[index];
        }
        return current.isEndOfWord;
    }
    public static void main(String[] args) {
    	Trie trie = new Trie();
    	trie.insert("bababoi");
    	trie.insert("biba");
    	System.out.println(trie.search("bababoi")); // true
    	System.out.println(trie.search("lalalalo")); // false
    }
}