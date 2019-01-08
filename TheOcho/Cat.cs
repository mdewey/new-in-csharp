namespace TheOcho
{

    public enum CatColor
    {
        CALICO,
        ORANGE_TABBY,
        GREY_TABBY,
        BLACK,
        TUXEDO
    };
    public class Cat : Pet //:IClimb
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public CatColor Color { get; set; }

        // public void Climb(string direction)
        // {
        //     // climb over all the things here
        // }

        public string Greeting()
        {
            return $"{char.ToUpper(this.Name[0]) + this.Name.Substring(1)} says meow!";
        }
    }
}