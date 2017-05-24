using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyAPIs.Data.Contexts
{
    public class FullDbContext : DbContext
	{
		public FullDbContext(DbContextOptions<FullDbContext> options) : base(options)
		{

		}
	}
}
