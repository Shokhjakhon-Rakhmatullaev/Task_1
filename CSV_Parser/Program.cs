// See https://aka.ms/new-console-template for more information
using CSV_Parser;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example for local directory
            string path = "C:\\Users\\Asus\\source\\repos\\CSV_Parser\\CSV_Parser\\Top100ChessPlayers.csv";
            string[] csvLines = File.ReadAllLines(path);
            int counter = 0;
            var chessPlayers = new List<ChessPlayer>();
            for(int i = 1; i < csvLines.Length; i++)
            {
                ChessPlayer chP = new ChessPlayer(csvLines[i]);
                chessPlayers.Add(chP);
            }
            for(int i = 0; i< chessPlayers.Count; i++)
            {
                if (chessPlayers[i].birth_year > 1980 && counter < 10)
                {
                    //Console.WriteLine(chessPlayers[i]);
                    Logger.Log(chessPlayers[i].ToString()); 
                    counter++;
                }
                else if(counter >= 10)
                {
                    break;
                }
                
            }
        }   

    }
}