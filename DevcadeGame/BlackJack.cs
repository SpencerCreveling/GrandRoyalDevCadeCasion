namespace DevcadeGame{
    public class BlackJack()
    {

        private struct Card{
            public Card(int Size, int Face)
            {
                value = Size;
                suit = Face;
            }

            public int value { get; }
            public int suit { get; }
        }

        private List<int> deck = new List<int>();

        public void BlackJack()
        {
            shuffle();
        }

        private void shuffle()
        {
            deck.clear();
            for(int x = 1; x <= 13; x++)
            {
                deck.Add(new Card(x,0));
                deck.Add(new Card(x,1));
                deck.Add(new Card(x,2));
                deck.Add(new Card(x,3));
            }
        }    
    }
}
