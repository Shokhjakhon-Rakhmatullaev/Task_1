using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Parser
{
    public class ChessPlayer
    {
        public string title, country, name , sureName;
        public int rank, birth_year, rating, games;

        public ChessPlayer(string rowData)
        {
            string[] data = rowData.Split(';');

            this.rank = Convert.ToInt32(data[0]);
            this.name = data[1].Split(',')[1];
            this.sureName = data[1].Split(',')[0];
            this.title = data[2];
            this.country = data[3];
            this.rating = Convert.ToInt32(data[4]);
            this.games = Convert.ToInt32(data[5]);
            this.birth_year = Convert.ToInt32(data[6]);
        }
        public override string ToString()
        {
            string str = $" Full Name:{name} {sureName}\n" + $" Country:{country}\n" + $" Birth year:{birth_year}\n" +
                $" Rank:{rank}\n" + $" Rating:{rating}\n" + $" Games Played:{games}.\n\n";
            return str;
        }
    }
}
