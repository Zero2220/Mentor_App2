﻿namespace MentorInClass.Models
{
    public class PricingFeature
    {
        public int Id { get; set; }
        public int PricingId { get; set; }

        public int FeatureId { get; set; }

        public Feature Feature { get; set; }

        public Pricing Pricing { get; set; }
    }
}
