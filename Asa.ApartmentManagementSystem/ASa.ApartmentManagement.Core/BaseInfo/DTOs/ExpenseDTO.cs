using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.BaseInfo.DTOs
{
    public class ExpenseDTO
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public decimal Value { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Description { get; set; }
    }
}
