using System.Collections.Generic;
using Cards;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "ScriptableObject", menuName = "CardData", order = 0)]
    public class CardDataSO : ScriptableObject
    {
        public List<CardDataStruct> cardList;
    }
}