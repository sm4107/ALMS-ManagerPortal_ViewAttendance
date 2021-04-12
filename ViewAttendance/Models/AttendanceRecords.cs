using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ViewAttendance.Models
{
    public class AttendanceRecords
    {
		
	    [Key]
	    public int AttendanceID { get; set; }
		public int ProjectID { get; set; }
		public System.Int64 EmployeeID { get; set; }
		public DateTime AttedanceDate { get; set; }
		public System.TimeSpan InTime { get; set; }
		public System.TimeSpan OutTime { get; set; }

		public string AttendanceStatus { get; set; }
		public DateTime StatusUpdateDate { get; set; }
		public System.Int64 StatusUpdatedBy { get; set; }


	}
}
