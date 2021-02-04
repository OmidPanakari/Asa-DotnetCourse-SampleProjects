using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASa.ApartmentManagement.Core.BaseInfo.DTOs;

namespace ASa.ApartmentManagement.Core.BaseInfo.DataGateways
{
    public interface IExpenseTableGateway
    {
        Task<int> InsertExpenseAsync(ExpenseDTO expense);
        Task<int> UpdateExpenseAsync(ExpenseDTO expense);
        Task<int> DeleteExpenseAsync(ExpenseDTO expense);
    }
}
