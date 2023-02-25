using System.Collections.Generic;
using System;

namespace DevcadeGame{

    public struct Player{
        public Player(int value){
            money = value;
        }
        public int money{get;set;}
         public List<Card> hand{get;set;} = new List<Card>();
        public Boolean bust{get;set;} = false; 
        }
    public struct Card{
        public Card(int Size, int Face){
            value = Size;
            suit = Face;
        }
        public int value { get; }
        public int suit { get; }
        }

    public class AiPlayer{
        List<Card> hand {get;} = new List<Card>();
        public string name{get;} 
        private int stopPoint;
        public AiPlayer(string name, int stopPoint){
            this.name = name;
            this.stopPoint = stopPoint;
        }

        public void Play(){

        }

        public int handValue(){
            int total = 0;
            foreach(Card card in hand){
                total += card.value;
            }
            return total;
        }
    }
    public class BlackJack{
        private List<Card> deck = new List<Card>();
        private const int DECKNUMBER = 6;
        private static Random rng = new Random(); 

        public BlackJack(int money){
            shuffle();
            Player p = new Player(money);
        }

        public Card DrawCard(){
            Card top = deck[0];
            deck.RemoveAt(0);
            return top;
        }
        private void shuffle(){
            deck.Clear();
            for(int y = 0; y < DECKNUMBER; y++ ){
                for(int x = 1; x <= 13; x++)
                {
                    deck.Add(new Card(x,0));
                    deck.Add(new Card(x,1));
                    deck.Add(new Card(x,2));
                    deck.Add(new Card(x,3));
                }
            }
            int n = deck.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                Card value = deck[k];  
                deck[k] = deck[n];  
                deck[n] = value;  
            }  
        }
    }
}
