﻿using UtmBuilder;

namespace UtmBuilder.Api.Models
{
    public class UtmModel
    {
        public string Url { get; set; } = String.Empty;
        public string? Id { get; set; }
        public string Source { get; set; } = String.Empty;
        public string Medium { get; set; } = String.Empty;
        public string Name { get; set; } = String.Empty;
        public string? Term { get; set; }
        public string? Content { get; set; }

        public static implicit operator Utm(UtmModel model) =>
            new Utm(
                model.Url,
                model.Source,
                model.Medium,
                model.Name,
                model.Id,
                model.Term,
                model.Content);
    }
}
