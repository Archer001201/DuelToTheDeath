using System;
using System.Collections.Generic;
using Data;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;

namespace Cards
{
    public class CardManager : MonoBehaviour
    {
        public List<CardDataStruct> deck;
        public List<CardDataStruct> hand;
        public List<CardDataStruct> discard;
        public CardDataSO deckSO;
        public int defaultNumOfDraw = 3;

        private void OnEnable()
        {
            Begin();
            Draw(defaultNumOfDraw);
        }

        public void Begin()
        {
            Shuffle();
            hand.Clear();
        }

        public void Draw(int num)
        {
            for (var i = 0; i < num; i++)
            {
                if (deck.Count <= 0)
                {
                    Shuffle();
                }
                
                var drawnCard = deck[Random.Range(0, deck.Count)];
                hand.Add(drawnCard);
                deck.Remove(drawnCard); 
            }
        }

        public void Shuffle()
        {
            deck.Clear();
            discard.Clear();
            
            deck = deckSO.cardList;
        }
    }
}
