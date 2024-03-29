﻿using SumeraTravelCorporation.Data.Models;

namespace SumeraTravelCorporation.Data.Dtos
{
    public class AirportDto
    {
        public int Id { get; set; }
        public string? Code { get; set; }
        public int? CityRefId { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? Telephone1 { get; set; }
        public string? Telephone2 { get; set; }
        public string? Email1 { get; set; }
        public string? Email2 { get; set; }

    }
}
