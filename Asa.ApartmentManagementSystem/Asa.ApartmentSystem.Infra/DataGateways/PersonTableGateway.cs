using ASa.ApartmentManagement.Core.BaseInfo.DataGateways;
using ASa.ApartmentManagement.Core.BaseInfo.DTOs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Asa.ApartmentSystem.Infra.DataGateways
{
	public class PersonTableGateway : IPersonTableGateway
	{
		string _connectionString;
		public PersonTableGateway(string connectionString)
		{
			_connectionString = connectionString;
		}

		public async Task<int> InsertPersonAsync(PersonDTO person)
		{
			int id;
			using(var connection = new SqlConnection(_connectionString))
			{
				using(var cmd = new SqlCommand())
				{
					cmd.CommandType = System.Data.CommandType.StoredProcedure;
					cmd.Parameters.AddWithValue("@first_name", person.FirstName);
					cmd.Parameters.AddWithValue("@last_name", person.LastName);
					cmd.Parameters.AddWithValue("@phone_number", person.PhoneNumber);
					cmd.Connection = connection;
					connection.Open();
					var result = cmd.ExecuteScalarAsync();
					id = Convert.ToInt32(result);
				}
			}
			return id;
		}
	}
}
