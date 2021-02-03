using System;
using System.Collections.Generic;
using System.Text;

using ASa.ApartmentManagement.Core.Common;

namespace ASa.ApartmentManagement.Core.BaseInfo.DTOs
{
    public class PersonUnitRelationDTO
    {
		public int ApartmentId { get; set; }
		public int PersonId { get; set; }
		public PersonUnitRelationType RelationType { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime? EndDate { get; set; }
	}
}
