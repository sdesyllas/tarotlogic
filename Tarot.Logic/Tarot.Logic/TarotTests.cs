using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Tarot.Logic.Model;

namespace Tarot.Logic
{
    [TestFixture]
    public class TarotTests
    {
        [Test]
        public void TestCartCardGenerator()
        {
            TarotLogic tarotLogic = new TarotLogic();

            List<TarotCard> tarotCards = new List<TarotCard>();
            for (int i = 1; i <= 3; i++)
            {
                var tarotCard = tarotLogic.GenerateTarotCard(tarotCards.Select(x => x.CartId).ToList());
                tarotCards.Add(tarotCard);
                Assert.Greater(tarotCard.CartId, 0);
            }

            tarotCards.ForEach(x=>Console.WriteLine($"{x.ImageName} , text : {x.Description}"));
        }
    }
}
