using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boggle
{
    class Program
    {

       
        static readonly int alphabetCount = 26;

       
       
        public class TrieNode
        {
            public TrieNode[] Child = new TrieNode[alphabetCount];

            
            public bool leaf;

           
            public TrieNode()
            {
                leaf = false;
                for (int i = 0; i < alphabetCount; i++)
                    Child[i] = null;
            }
        }

         
        static void insert(TrieNode root, String Key)
        {
            int n = Key.Length;
            TrieNode pChild = root;

            for (int i = 0; i < n; i++)
            {
                int index = Key[i] - 'A';

                if (pChild.Child[index] == null)
                    pChild.Child[index] = new TrieNode();

                pChild = pChild.Child[index];
            }

           
            pChild.leaf = true;
        }

        static void Main(string[] args)
        {


            /*
F O P W
A R M E
U L S B
X T D I

- Assume list of dictionary words (list of sorted strings) as input
- Write code that finds all valid words in the 4x4 matrix 
- Words must be a minimum of 3 letters long
- Can only follow adjacent cells to form words (up-left, up, up-right,right,down-right,down,down-left,left)
- Cannot revisit same letter within the same word
- Can reuse dice within different words
- Can extend words to make more words (FORM, FORMS)

// Implement me
List<String> findWords(List<String> dictionary, char[][] board) {
*/

            char[,] board = {
                    {'F','O','P','W'},
                    { 'A','R','M','E' },
                    {'U','L','S','B' },
                    {'X','T','D','I' }

                };

            String[] dict =
            {
                "FAUX",
                "FOR",
                "FORM",
                "OAR",
                "WEB",
                "WEST",
                "FROM",
                "XTD"
              



            };


            TrieNode root = new TrieNode();
            int n = dict.Length;
            for (int i = 0; i < n; i++)
                insert(root, dict[i]);


            List<string> result = new List<string>();
            string str = "";

            for (int Col = 0; Col <= 3; Col++)
            {


                for (int Row = 0; Row <= 3; Row++)
                {
                    bool[,] visited = new bool[4, 4];

                    TrieNode pChild = root;
                    if (pChild.Child[(board[Col, Row]) - 'A'] != null)
                    {
                        str = str + board[Col, Row];
                        traverseAdjacent( dict, "", Row, Col, visited, root);
                       
                        str = "";
                    }

              


                }


            }



            void traverseAdjacent(String[] dictionary, string checker, int Row, int Col, bool[,] visited, TrieNode Root)
            {
                // finding adjacent cells and recurse

                
                if (Row < 0 || Row > 3 || Col < 0 || Col > 3)
                {
                    return;

                }
                if (visited[Row, Col] == true)
                {
                    return;
                }
               

                checker += board[Row, Col];
                visited[Row, Col] = true;
                if (checker.Length >= 3 && dictionary.Contains(checker))

                {
                    result.Add(checker);
                    Console.WriteLine("Congratulations you found a word! {0}", checker);


                }

              


                        for (int vert = -1; vert <= 1; vert++)
                        {
                            for (int horiz = -1; horiz <= 1; horiz++)
                            {

                                traverseAdjacent(dictionary, checker, Row + vert, Col + horiz, visited, Root);

                            }
                   

                }
                visited[Row, Col] = false;


            }


            Console.ReadLine();
        }
    }
}

