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
                "FAUX",//not a real word, checking to see if logic works
                "FOR",
                "FORM",
                "WEST"



            };

      

            string check = "";


            for (int col = 0; col < 3; col++)
            {


                for (int row = 0; row < 3; row++)
                {
                    check = "";
                    bool[,] visited = new bool[4, 4];


                    traverseAdjacent(dict, check, row, col, visited);

//reset visited to false
                    for (int column = 0;column<3;column++)
                    {
                        for (int rows = 0; rows < 3; rows++)
                        {
                            visited[column, rows] = false;
                        }
                    }
                 
                 


                }


            }



            void traverseAdjacent(List<string> dictionary, string checker, int row, int col, bool[,] visited)
            {
                // finding adjacent cells and recurse




                if (row < 0 || row > 3 || col < 0 || col > 3)
                {
                    return;

                }
                if (visited[row, col] == true)
                {
                    return;
                }
                checker += board[row, col];
                visited[row, col] = true;

                if (checker.Length >= 3 && dictionary.Contains(checker))
                {
                    Console.WriteLine("Congratulations you found a word! {0}", checker);
                    
                }

                //for (int vert = -1; vert <= 1; vert++)
                //    for (int horiz = -1; horiz <= 1; horiz++)
                //    {
                //        if (row + vert >= 0 && row + vert < 3 &&
                //           !(vert == 0 && horiz == 0) &&
                //           board[row + vert, col + horiz] != "~")
                //        {
                //            board[row, col] = "~";
                //            traverseAdjacent(dictionary, checker, row + vert, col + horiz, visited);
                //            //board[row, col] = originalValue;
                //        }
                //        else { continue; }
                //    }


                traverseAdjacent(dictionary, checker, row - 1, col - 1, visited);
                traverseAdjacent(dictionary, checker, row, col - 1, visited);
                traverseAdjacent(dictionary, checker, row + 1, col - 1, visited);
                traverseAdjacent(dictionary, checker, row - 1, col, visited);
                traverseAdjacent(dictionary, checker, row + 1, col, visited);
                traverseAdjacent(dictionary, checker, row - 1, col + 1, visited);
                traverseAdjacent(dictionary, checker, row, col + 1, visited);
                traverseAdjacent(dictionary, checker, row + 1, col + 1, visited);

                //else if(col<3 && (visited[row, col] == true))
                // { traverseAdjacent(dictionary, checker, row, col + 1, visited); }
                // else if()


                //for(int loop1 = 0; loop1 < 3; loop1++)
                //{
                //    for (int loop2 = 0; loop1 < 3; loop1++)
                //    {


                //    }

                //        traverseAdjacent(dictionary, checker, row, col + 1, visited);
                //}




                //int loop1 = 1;

                //switch (loop1)
                //{
                //    case 1:
                //        loop++;
                //        traverseAdjacent(dictionary, checker, row, col + 1, visited);
                //        break;
                //    case 2:
                //        loop++;
                //        traverseAdjacent(dictionary, checker, row, col, visited);
                //        break;
                //    case 3:
                //        traverseAdjacent(dictionary, checker, row, col - 1, visited);
                //        break;
                //    case 4:
                //        traverseAdjacent(dictionary, checker, row - 1, col, visited);
                //        break;
                //    case 5:
                //        traverseAdjacent(dictionary, checker, row, col + 1, visited);
                //        break;
                //    case 6:
                //        traverseAdjacent(dictionary, checker, row + 1, col, visited);
                //        break;
                //    case 7:
                //        traverseAdjacent(dictionary, checker, row, col + 1, visited);
                //        break;
                //    case 8:
                //        traverseAdjacent(dictionary, checker, row, col, visited);
                //        break;
            }
            





            Console.ReadLine();
        }
    }
}