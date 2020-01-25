using System;
using System.Collections.Generic;
using System.Text;

using Jenyay.Genetic;

namespace SchwefelTest
{
	class SchwefelSpecies: BaseDoubleSpecies<SchwefelSpecies>
	{
		public SchwefelSpecies ():
			base ()
		{
		}

		public SchwefelSpecies (double[] chromosomes):
			base (chromosomes)
		{
		}

		protected override double CalcFinalFunc ()
		{
			double result = 0;

			for (int i = 0; i < m_Chromosomes.Length; i++)
			{
				result -= 
					m_Chromosomes[i] * Math.Sin (Math.Sqrt (Math.Abs (m_Chromosomes[i]) ) );
			}

			return result;
		}

		public override string ToString ()
		{
			StringBuilder builder = new StringBuilder();

			for (int i = 0; i < m_Chromosomes.Length; i++)
			{
				builder.AppendFormat ("x[{0:D4}] = {1}\r\n", i, m_Chromosomes[i]);
			}

			builder.AppendLine ();
			builder.AppendFormat ("FinalFunc = {0}", m_FuncVal);

			return builder.ToString ();
		}
	}
}
