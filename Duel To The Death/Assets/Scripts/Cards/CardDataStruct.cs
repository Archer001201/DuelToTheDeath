using System;
using Data;
using UnityEngine;
using UnityEngine.UI;

namespace Cards
{
    [Serializable]
    public class CardDataStruct
    {
        public string cardName;
        public CardType cardType;
        public Image cardIcon;
        public string cardCost;
        public CardRarity cardRarity;
        [TextArea]
        public string cardEffect;
        public BaseCard cardScript;
    }
}
