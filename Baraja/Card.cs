namespace Baraja
{
    public class Card
    {
        public int Number { get; set; }
        public eSuit Suit { get; set; }

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
