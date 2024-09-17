namespace Baraja
{
    public class Card
    {
        private int number;
        private eSuit suit;
        public int Number { get { return number;} set { number = value; } }
        public eSuit Suit { get { return suit; } set { suit = value; } }

        public Card()
        {
            
        }

        public Card(int number,eSuit suit)
        {
            Number=number;
            Suit=suit;
        }
        public enum eSuit
        {
            Clubs,//Bastos
            Gold,//Oro
            Swords,//Espadas
            Cups,//Copas
            Jocker
        }

    }

}
