using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorBite.Models
{
	public class Review
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; } = string.Empty;

		[Required]
		[StringLength(100)]
		public string LastName { get; set; } = string.Empty;

		[Required]
		[EmailAddress]
		public string Email { get; set; } = string.Empty;

		[Required]
		[Phone]
		public string Phone { get; set; } = string.Empty;

		[Required]
		[DataType(DataType.DateTime)]
		public DateTime VisitDate { get; set; }

		[Required]
		public int Rating { get; set; }

		[StringLength(500)]
		public string Comment { get; set; } = string.Empty;
	}
}
