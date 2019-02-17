namespace graphql_dotnet_boxed_template.Models
{
    using System;

    public class Droid : Character
    {
        public DateTimeOffset Created { get; set; }

        public TimeSpan ChargePeriod { get; set; }

        public string PrimaryFunction { get; set; }
    }
}
