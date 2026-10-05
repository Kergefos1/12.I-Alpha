using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatstatisztics
{
    public class ConsoleView
    {

        public void ShowPlayer(Player player)
        {
            Console.WriteLine(player.Describtion());
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
        public void ShowPlayers(List<Player> players)
        {
            players.ForEach(x=> Console.WriteLine(x));
        }

    }
}
