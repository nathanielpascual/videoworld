﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoWorld.Models
{
	public class MembershipType
	{
		public int Id { get; set; }

		[Required]
		[StringLength(20)]
		public string Name { get; set; }
		public short Discount { get; set; }
		public byte DurationInMonths { get; set; }
		public byte DiscountRate { get; set; }
	}
}