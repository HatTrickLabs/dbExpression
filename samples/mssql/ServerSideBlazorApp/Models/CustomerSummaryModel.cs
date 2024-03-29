﻿using System.Collections;

namespace ServerSideBlazorApp.Models
{
    public class CustomerSummaryModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public double LifetimeValue { get; set; }
        public short? CurrentAge { get; set; }
        public bool IsVIP { get; set; }
    }
}
