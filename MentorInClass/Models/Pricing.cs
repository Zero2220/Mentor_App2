namespace MentorInClass.Models
{
    public class Pricing
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
        public bool IsAdvanced { get; set; }

        public bool IsFeature { get; set; }

        public List<PricingFeature> Features { get; set; }
        

    }
}
