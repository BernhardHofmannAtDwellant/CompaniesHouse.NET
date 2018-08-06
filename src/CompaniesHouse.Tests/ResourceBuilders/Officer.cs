using System;

namespace CompaniesHouse.Tests.ResourceBuilders
{
    public class Officer
    {
        public DateTime AppointedOn { get; set; }

        public DateTime ResignedOn { get; set; }

        public DateOfBirth DateOfBirth { get; set; }

        public string Name { get; set; }

        public string OfficerRole { get; set; }

        public string Nationality { get; set; }
    }
}