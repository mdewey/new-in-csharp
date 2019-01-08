namespace TheOcho
{

    public enum CatColor{
        CALICO,
        ORANGE_TABBY,
        GREY_TABBY, 
        BLACK,
        TUXEDO 
    }
    public class Cat
    {
        public string Name { get; set; } = string.Empty;
        public int IQ { get; set; }
        public CatColor Color { get; set; }

        public string Greeting()
        {
            return $"{char.ToUpper(this.Name[0]) + this.Name.Substring(1)} says meow!";
        }
    }
}