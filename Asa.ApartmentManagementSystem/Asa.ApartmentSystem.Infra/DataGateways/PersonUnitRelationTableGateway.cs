using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using ASa.ApartmentManagement.Core.BaseInfo.DataGateways;
using ASa.ApartmentManagement.Core.BaseInfo.DTOs;

namespace Asa.ApartmentSystem.Infra.DataGateways
{
	public class PersonUnitRelationTableGateway : IPersonUnitRelationTableGateway
	{
		string _connectionString;
		public PersonUnitRelationTableGateway(string connectionString)
		{
			_connectionString = connectionString;
		}

		public Task<int> InsertPersonUnitRelation(PersonUnitRelationDTO relation)
		{
			int id = 0;
			using (var connection = new SqlConnection(_connectionString))
			{
				using(var cmd = new SqlCommand())
				{

				}
			}
		}
	}
}
