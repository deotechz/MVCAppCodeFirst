using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace KathmanduUniversity.Models
{
	public class Student
	{
		public int ID { get; set; }
		public string LastName { get; set; }
		public string FirstMidName { get; set; }
		public DateTime EnrollmentDate { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }

		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}