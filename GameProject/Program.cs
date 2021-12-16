using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.gameName = "CS:GO";
            game1.unitPrice = 100;
            Game game2 = new Game();
            game2.gameName = "PUBG";
            game2.unitPrice = 87;

            User user1 = new User();
            user1.identityNumber = "12345678910";
            user1.firstName = "Görkem";
            user1.lastName = "Yelken";
            user1.birthOfDate = 1998;

            Campaign campaign1 = new Campaign();
            campaign1.campaignName = "New Year";
            campaign1.discount = 20;

            GameManager gameManager = new GameManager();
            gameManager.gameSaleWithCampaign(game1, user1, campaign1);
            Console.WriteLine("---------------");
            gameManager.gameSaleWithoutCampaign(game2, user1);

        }
    }
}
