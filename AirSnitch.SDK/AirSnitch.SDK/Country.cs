namespace AirSnitch.SDK
{
    public class Country
    {
        public string Code { get; set; }

        public string Name { get; set; }

        public static Country UA = new Country()
        {
            Code = "UA",
            Name = "Ukraine"
        };
    }
}