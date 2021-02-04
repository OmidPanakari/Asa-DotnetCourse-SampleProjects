using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ASa.ApartmentManagement.Core.BaseInfo.DTOs;


namespace ASa.ApartmentManagement.Core.BaseInfo.DataGateways
{
    public interface IExpenseCategoryTableGateway
    {
        Task<int> InsertExpenseCategoryAsync(ExpenseCategoryDTO expense);
        Task<int> UpdateExpenseCategoryAsync(ExpenseCategoryDTO expense);
        Task<int> DeleteExpenseCategoryAsync(ExpenseCategoryDTO expense);
    }
}
