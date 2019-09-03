
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boggle
{
    class Program
    {
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


            string[,] board = new string[,]
            {
                {"F","O","P","W"},
                {"A","R","M","E" },
                {"U","L","S","B" },
                {"X", "T", "D","I" }

            };
            List<string> dict = new List<string>
            {

                "FAUX",
                "FOR",
                "FORM",
                "OAR",
                "WEB",
                "WEST",
                "FROM",
                "ARM",
                "RAUL",
                "BEST",
                "ARMS",
                "FAULT",
                "RUT",


            };
            string[] first = new string[dict.Count];

    //for (int W = 0; W<=dict.Count;W++)
    //        {
    //            first[W] = dict[W].First<char>
    //        }

            int count = 0;
            foreach (string word in dict)
            {
               
                first[count] = word[0].ToString();
                count += 1;
            }

            //string check = "";
            List<String> result = new List<string>();

            for (int Col = 0; Col <= 3; Col++)
            {


                for (int Row = 0; Row <= 3; Row++)
                {

                    bool[,] visited = new bool[4, 4];

                    if (first.Contains(board[Row, Col]))
                    {
                        traverseAdjacent(dict, "", Row, Col, visited);
                    }


                }


            }



            void traverseAdjacent(List<string> dictionary, string checker, int Row, int Col, bool[,] visited)
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

                        traverseAdjacent(dictionary, checker, Row + vert, Col + horiz, visited);

                    }
                }
                visited[Row, Col] = false;


            }


            Console.ReadLine();
        }
    }
}