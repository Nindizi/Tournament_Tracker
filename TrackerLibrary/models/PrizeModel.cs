﻿namespace TrackerLibrary.models
{
    public class PrizeModel
    {
        public int Id { get; set; }

        public int PlaceNumber { get; set; }

        public string PlaceName { get; set; }

        public decimal PrizeAmount { get; set; }

        public double PrizePercentage { get; set; }
    }
}