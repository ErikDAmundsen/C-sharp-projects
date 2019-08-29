
using System;

public class Boggle
{


    //    static readonly int SIZE = 26;

    //    static readonly int M = 3;
    //    static readonly int N = 3;


    //    public class TrieNode
    //    {
    //        public TrieNode[] Child = new TrieNode[SIZE];


    //        public bool leaf;


    //        public TrieNode()
    //        {
    //            leaf = false;
    //            for (int i = 0; i < SIZE; i++)
    //                Child[i] = null;
    //        }
    //    }

    //    static void insert(TrieNode root, String Key)
    //    {
    //        int n = Key.Length;
    //        TrieNode pChild = root;

    //        for (int i = 0; i < n; i++)
    //        {
    //            int index = Key[i] - 'A';

    //            if (pChild.Child[index] == null)
    //                pChild.Child[index] = new TrieNode();

    //            pChild = pChild.Child[index];
    //        }


    //        pChild.leaf = true;
    //    }


    //    static bool isSafe(int i, int j, bool[,] visited)
    //    {
    //        return (i >= 0 && i < M && j >= 0 &&
    //                j < N && !visited[i, j]);
    //    }


    //    static void searchWord(TrieNode root, char[,] boggle, int i,
    //                    int j, bool[,] visited, String str)
    //    {

    //        if (root.leaf == true)
    //            Console.WriteLine(str);

    //        if (isSafe(i, j, visited))
    //        {

    //            visited[i, j] = true;


    //            for (int K = 0; K < SIZE; K++)
    //            {
    //                if (root.Child[K] != null)
    //                {

    //                    char ch = (char)(K + 'A');


    //                    if (isSafe(i + 1, j + 1, visited) &&
    //                                boggle[i + 1, j + 1] == ch)
    //                        searchWord(root.Child[K], boggle, i + 1, j + 1,
    //                                                visited, str + ch);
    //                    if (isSafe(i, j + 1, visited) &&
    //                        boggle[i, j + 1] == ch)
    //                        searchWord(root.Child[K], boggle, i, j + 1,
    //                                                visited, str + ch);
    //                    if (isSafe(i - 1, j + 1, visited) &&
    //                       boggle[i - 1, j + 1] == ch)
    //                        searchWord(root.Child[K], boggle, i - 1, j + 1,
    //                                                visited, str + ch);
    //                    if (isSafe(i + 1, j, visited) &&
    //                        boggle[i + 1, j] == ch)
    //                        searchWord(root.Child[K], boggle, i + 1, j,
    //                                                visited, str + ch);
    //                    if (isSafe(i + 1, j - 1, visited) &&
    //                        boggle[i + 1, j - 1] == ch)
    //                        searchWord(root.Child[K], boggle, i + 1, j - 1,
    //                                                visited, str + ch);
    //                    if (isSafe(i, j - 1, visited) &&
    //                        boggle[i, j - 1] == ch)
    //                        searchWord(root.Child[K], boggle, i, j - 1,
    //                                                visited, str + ch);
    //                    if (isSafe(i - 1, j - 1, visited) &&
    //                        boggle[i - 1, j - 1] == ch)
    //                        searchWord(root.Child[K], boggle, i - 1, j - 1,
    //                                                visited, str + ch);
    //                    if (isSafe(i - 1, j, visited) &&
    //                        boggle[i - 1, j] == ch)
    //                        searchWord(root.Child[K], boggle, i - 1, j,
    //                                            visited, str + ch);
    //                }
    //            }


    //            visited[i, j] = false;
    //        }
    //    }


    //    static void findWords(char[,] boggle, TrieNode root)
    //    {

    //        bool[,] visited = new bool[M, N];
    //        TrieNode pChild = root;

    //        String str = "";


    //        for (int i = 0; i < M; i++)
    //        {
    //            for (int j = 0; j < N; j++)
    //            {

    //                if (pChild.Child[(boggle[i, j]) - 'A'] != null)
    //                {
    //                    str = str + boggle[i, j];
    //                    searchWord(pChild.Child[(boggle[i, j]) - 'A'],
    //                            boggle, i, j, visited, str);
    //                    str = "";
    //                }
    //            }
    //        }
    //    }


    //    public static void Main(String[] args)
    //    {

    //        String[] dictionary = {  "FOR", "FORM", "FAR", "ARM"};


    //        TrieNode root = new TrieNode();


    //        int n = dictionary.Length;
    //        for (int i = 0; i < n; i++)
    //            insert(root, dictionary[i]);

    //        char[,] boggle = {
    //                {'F','O','P','W'},
    //                { 'A','R','M','E' },
    //                {'U','L','S','B' },
    //                {'X','T','D','I' }

    //            };
    //        findWords(boggle, root);
    //        Console.ReadLine();
    //    }
    private void wordSearch(String currentWord, int row, int col, char[size][size] boggleTable)
{
    //Check out of bounds
    if (row < 0 || col < 0 || row >= boggleTable.size || col >= boggleTable[row].size)
        return;

    //Check if current letter used, we using a space to denote the letter has been used
    if (char[row][col] = ' ')
        return;

    //Update Word, Update Table
    currentWord = currentWord + boggleTable[row][col];
    char[row][col] = ' ';

    //Check current word
    if (dictionary.contains(currentWord) && currentWord.length() > 2)
        machineWords.add(prefix);

    //Recursion
    wordSearch(currentWord, row - 1, col - 1, boggleTable); //Top Left
    wordSearch(currentWord, row - 1, col, boggleTable); //Top Mid
    wordSearch(currentWord, row - 1, col + 1, boggleTable); //Top Right
    wordSearch(currentWord, row, col - 1, boggleTable); //Left
    wordSearch(currentWord, row, col + 1, boggleTable); //Right
    wordSearch(currentWord, row + 1, col - 1, boggleTable); //Bottom Left
    wordSearch(currentWord, row+1, col, boggleTable); //Bottom Mid
    wordSearch(currentWord, row + 1, col + 1, boggleTable); //Bottom Right
}
}

