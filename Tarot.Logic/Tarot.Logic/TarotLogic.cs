using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarot.Logic.Model;

namespace Tarot.Logic
{
    public class TarotLogic
    {
        public TarotCard GenerateTarotCard(List<int> alreadyGeneratedNumbers)
        {
            // generate the random number of the tarot card
            var cardNumber = this.GenerateCarotCardNumber(alreadyGeneratedNumbers);

            // get the card description
            var cardDescription = CardDescriptions.CarotCartDescriptions[cardNumber];

            // generate image file name, ex : carot_1.jpg
            var imageFileName = String.Format("carot_{0}.jpg", cardNumber);

            TarotCard tarotCard = new TarotCard()
            {
                CartId = cardNumber,
                Description = cardDescription,
                ImageName = imageFileName
            };

            return tarotCard;
        }

        private int GenerateCarotCardNumber(List<int> excludedNumbers)
        {
            var rnd = new Random();
            int randomGeneratedNumber;
            do
            {
                randomGeneratedNumber = rnd.Next(1, 10);
            } while (excludedNumbers.Contains(randomGeneratedNumber));
            return randomGeneratedNumber;
        }
    }
}
