using System.ComponentModel.DataAnnotations.Schema;

namespace DbPerfTest.Models
{
    public class City
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [ForeignKey(nameof(Country))]
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }
    }
}