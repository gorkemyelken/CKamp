using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class GameManager
    {
        public void gameSaleWithoutCampaign(Game game, User user)
        {
            Console.WriteLine(game.gameName + " game successfully sold to " + user.firstName + ".");
            Console.WriteLine("Game price: " + game.unitPrice);
        }

        public void gameSaleWithCampaign(Game game, User user, Campaign campaign)
        {
            Console.WriteLine(game.gameName + " game successfully sold to " + user.firstName + " with " + campaign.campaignName + " campaign." );
            Console.WriteLine("Game price: " + game.unitPrice);
            Console.WriteLine("Game price with campaign: " + (game.unitPrice - ((game.unitPrice/100)*campaign.discount)));
        }


    }
}
