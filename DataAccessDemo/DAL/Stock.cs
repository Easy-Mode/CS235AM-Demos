using System;
using SQLite;

namespace DataAccess.DAL
{
	[Table("Stocks")]
	public class Stock
	{
		[PrimaryKey]
		[MaxLength(8)]
		public string Symbol { get; set; }
		public string Name { get; set; }
		public decimal ClosingPrice { get; set;}
	}
}