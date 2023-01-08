﻿namespace WATERWebsite.Core.Models
{
    public class Service
    {
        public Service()
        {
            ServiceDivisons = new HashSet<ServiceDivisons>();
            ProjectServices = new HashSet<ProjectServices>();
        }
        public int ServiceCode { get; set; }
        public string ServiceNameE { get; set; } = string.Empty;
        public string? ServiceOverviewE { get; set; }
        public string? ServiceBriefE { get; set; }
        public string ServiceNameA { get; set; } = string.Empty;
        public string? ServiceOverviewA { get; set; }
        public string? ServiceBriefA { get; set; }
        public string ServicePhotoPath { get; set; } = string.Empty;
        public string ServiceLogo { get; set; } = string.Empty;
        public ICollection<ServiceDivisons>? ServiceDivisons { get; set; }
        public ICollection<ProjectServices>? ProjectServices { get; set; }
    }
}
