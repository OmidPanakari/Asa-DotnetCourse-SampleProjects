using ASa.ApartmentManagement.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASa.ApartmentManagement.Core.BaseInfo.DTOs
{
    public class ExpenseCategoryDTO
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public FormulaType CalculationFormula { get; set; }
    }
}
