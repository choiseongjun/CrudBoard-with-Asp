using JunBoard.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JunBoard.Context
{
	public class BoardDb : DbContext
	{
		public BoardDb() : base("name=DBCS") { }

		public DbSet<Board> Boards { get; set; }
	}
}