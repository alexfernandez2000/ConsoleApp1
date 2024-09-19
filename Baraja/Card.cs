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

        public override string ToString()
        {
            return $"Card suit: {Suit.ToString()} number: {Number}";
        }

        public enum eSuit
        {
            Clubs,//Bastos
            Gold,//Oro
            Swords,//Espadas
            Cups,//Copas
            Jocker,
            Corazones,
            Diamantes,
            Treboles,
            Picas
        }

    }

}
