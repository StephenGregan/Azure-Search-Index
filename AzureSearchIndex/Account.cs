using Microsoft.Azure.Search;
using Microsoft.Azure.Search.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSearchIndex
{
    [SerializePropertyNamesAsCamelCase]
    public class Account
    {
        [System.ComponentModel.DataAnnotations.Key]
        [IsFilterable]
        public string Account_Number { get; set; }

        [IsFilterable, IsSortable, IsFacetable]
        public double? Balance { get; set; }

        [IsFilterable, IsSortable, IsSearchable]
        public string FirstName { get; set; }

        [IsFilterable, IsSortable, IsSearchable]
        public string LastName { get; set; }

        [IsFilterable, IsSortable, IsFacetable]
        public int? Age { get; set; }

        [IsFilterable, IsSortable, IsSearchable]
        public string Gender{ get; set; }

        [IsFilterable, IsSearchable]
        public string Address{ get; set; }

        [IsFilterable, IsSortable, IsFacetable]
        public string Employer{ get; set; }

        [IsFilterable]
        public string Email{ get; set; }

        [IsFilterable, IsSortable, IsSearchable]
        public string City{ get; set; }

        [IsFilterable, IsSortable, IsSearchable]
        public string State{ get; set; }
    }
}
