//
// AS3AP -	An ANSI SQL Standard Scalable and Portable Benchmark
//			for Relational Database Systems.
//
// Author: Carlos Guzmn lvarez <carlosga@telefonica.net>
//
// Distributable under LGPL license.
// You may obtain a copy of the License at http://www.gnu.org/copyleft/lgpl.html
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// LGPL License for more details.
//
// This file was created by members of the Firebird development team.
// All individual contributions remain the Copyright (C) of those
// individuals.  Contributors to this file are either listed here or
// can be obtained from a CVS history command.
//
// (c) 2003. All rights reserved.
//
// For more information please see http://www.firebirdsql.org
//

using System;
using System.Data;

namespace AS3AP.BenchMark
{
	public class Sql87TestSuite : BaseTestSuite
	{
		#region CONSTRUCTORS

		public Sql87TestSuite(BenchMarkConfiguration configuration) : base(configuration)
		{
			this.testSuiteName = "SQL87";
		}

		#endregion

		#region METHODS

		[IsolationLevel(IsolationLevel.ReadCommitted)]
		public override void join_2() 
		{
			int	count = 0;

			try
			{			
				beginTransaction();
				cursorOpen( 
					"select uniques.col_signed, uniques.col_name, "		+
					"hundred.col_signed, hundred.col_name "				+
					"from uniques, hundred "							+
					"where uniques.col_address = hundred.col_address "	+
					"and uniques.col_address = 'SILICON VALLEY'"	);
				
				while (cursorFetch()) 
				{
					count++;
				}
			}
			catch (Exception)
			{
				base.testFailed = true;
			}
			finally
			{
				cursorClose();
				if (base.testFailed)
				{
					rollbackTransaction();
				}
				else
				{
					commitTransaction();
				}
			}

			base.testResult = count;
		}

		[IsolationLevel(IsolationLevel.ReadCommitted)]
		public override void join_2_cl() 
		{
			int	count = 0;
			
			try
			{
				beginTransaction();
				cursorOpen(
					"select uniques.col_signed, uniques.col_name, "	+
					"hundred.col_signed, hundred.col_name "			+
					"from uniques, hundred "						+
					"where uniques.col_key = hundred.col_key "		+
					"and uniques.col_key = 1000");
				
				while (cursorFetch()) 
				{
					count++;
				}
			}
			catch (Exception)
			{
				base.testFailed = true;
			}
			finally
			{
				cursorClose();
				if (base.testFailed)
				{
					rollbackTransaction();
				}
				else
				{
					commitTransaction();
				}
			}

			base.testResult = count;
		}

		[IsolationLevel(IsolationLevel.ReadCommitted)]
		public override void join_2_ncl() 
		{
			int count = 0;

			try
			{
				beginTransaction();
				cursorOpen( 
					"select uniques.col_signed, uniques.col_name, "	+
					"hundred.col_signed, hundred.col_name "			+
					"from uniques, hundred "						+
					"where uniques.col_code = hundred.col_code "	+
					"and uniques.col_code = 'BENCHMARKS'"			);
				
				while (cursorFetch()) 
				{
					count++;
				}
			}
			catch (Exception)
			{
				base.testFailed = true;
			}
			finally
			{
				cursorClose();
				if (base.testFailed)
				{
					rollbackTransaction();
				}
				else
				{
					commitTransaction();
				}
			}

			base.testResult = count;
		}

		[IsolationLevel(IsolationLevel.ReadCommitted)]
		public override void join_3_cl() 
		{
			int	count = 0;

			try
			{
				beginTransaction();
				cursorOpen(
					"select uniques.col_signed, uniques.col_date, "	+
					"hundred.col_signed, hundred.col_date, "		+
					"tenpct.col_signed, tenpct.col_date "			+
					"from uniques, hundred, tenpct "				+
					"where uniques.col_key = hundred.col_key "		+
					"and uniques.col_key = tenpct.col_key "			+
					"and uniques.col_key = 1000");
				
				while (cursorFetch()) 
				{
					count++;
				}
			}
			catch (Exception)
			{
				base.testFailed = true;
			}
			finally
			{
				cursorClose();
				if (base.testFailed)
				{
					rollbackTransaction();
				}
				else
				{
					commitTransaction();
				}
			}

			base.testResult = count;
		}

		[IsolationLevel(IsolationLevel.ReadCommitted)]
		public override void join_3_ncl() 
		{
			int count = 0;

			try
			{
				beginTransaction();
				cursorOpen( 
					"select uniques.col_signed, uniques.col_date, "		+
					"hundred.col_signed, hundred.col_date, "			+
					"tenpct.col_signed, tenpct.col_date "				+
					"from uniques, hundred, tenpct "					+
					"where uniques.col_code = hundred.col_code "		+
					"and uniques.col_code = tenpct.col_code "			+
					"and uniques.col_code = 'BENCHMARKS'");
				
				while (cursorFetch()) 
				{
					count++;
				}
			}
			catch (Exception)
			{
				base.testFailed = true;
			}
			finally
			{
				cursorClose();
				if (base.testFailed)
				{
					rollbackTransaction();
				}
				else
				{
					commitTransaction();
				}
			}

			base.testResult = count;
		}

		[IsolationLevel(IsolationLevel.ReadCommitted)]
		public override void join_4_cl() 
		{
			int count = 0;
	
			try
			{
				beginTransaction();
				cursorOpen(
					"select uniques.col_date, hundred.col_date, "	+
					"tenpct.col_date, updates.col_date "			+
					"from uniques, hundred, tenpct, updates "		+
					"where uniques.col_key = hundred.col_key "		+
					"and uniques.col_key = tenpct.col_key "			+
					"and uniques.col_key = updates.col_key "		+
					"and uniques.col_key = 1000");
				
				while (cursorFetch()) 
				{
					count++;
				}
			}
			catch (Exception)
			{
				base.testFailed = true;
			}
			finally
			{
				cursorClose();
				if (base.testFailed)
				{
					rollbackTransaction();
				}
				else
				{
					commitTransaction();
				}
			}

			base.testResult = count;
		}

		[IsolationLevel(IsolationLevel.ReadCommitted)]
		public override void join_4_ncl() 
		{
			int count=0;

			try
			{
				beginTransaction();
				cursorOpen( 
					"select uniques.col_date, hundred.col_date, "	+
					"tenpct.col_date, updates.col_date "			+
					"from uniques, hundred, tenpct, updates "		+
					"where uniques.col_code = hundred.col_code "	+
					"and uniques.col_code = tenpct.col_code "		+
					"and uniques.col_code = updates.col_code "		+
					"and uniques.col_code = 'BENCHMARKS'");
				
				while (cursorFetch()) 
				{
					count++;
				}				
			}
			catch (Exception)
			{
				base.testFailed = true;
			}
			finally
			{
				cursorClose();
				if (base.testFailed)
				{
					rollbackTransaction();
				}
				else
				{
					commitTransaction();
				}
			}

			base.testResult = count;
		}

		#endregion
	}
}
