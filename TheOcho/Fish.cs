namespace TheOcho
{
    public class Fish:Pet
    {

        public string Name { get; set; } = string.Empty;
        public int TankId { get; set; }
        public string Greeting()
        {
            return $"Blooop!";
        }
    }
}