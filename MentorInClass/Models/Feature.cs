﻿namespace MentorInClass.Models
{
    public class Feature
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<PricingFeature> Pricings { get; set;}
    }
}
