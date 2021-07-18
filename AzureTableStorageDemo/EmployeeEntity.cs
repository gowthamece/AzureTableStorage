using Microsoft.Azure.Cosmos.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureTableStorageDemo
{
    public class EmployeeEntity : TableEntity
    {
        public EmployeeEntity(string firstname, string lastName)
        {
            this.PartitionKey = lastName; this.RowKey = firstname;
        }
        public EmployeeEntity() { }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
