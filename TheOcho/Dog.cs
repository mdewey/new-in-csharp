namespace TheOcho
{
    public class Dog:Pet
    {

        public string Name { get; set; } = string.Empty;
        public int CollarNumber { get; set; }
        public string Greeting()
        {
            return $"Baaaaaaaaark!";
        }
    }
}