using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using ASa.ApartmentManagement.Core.BaseInfo.DTOs;

namespace ASa.ApartmentManagement.Core.BaseInfo.DataGateways
{
	public interface IPersonUnitRelationTableGateway
	{
		Task<int> InsertPersonUnitRelation(PersonUnitRelationDTO relation);
	}
}
