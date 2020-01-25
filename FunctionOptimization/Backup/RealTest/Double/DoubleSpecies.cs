using System;
using System.Collections.Generic;

using Jenyay.Genetic;

namespace RealTest
{
	/// <summary>
	/// Одна точка на функции
	/// </summary>
	public class DoubleFuncPoint
	{
		public const int FuncSize = 5;
		/// <summary>
		/// X1, X2, ..., X5
		/// </summary>
		private double[] m_X = new double[FuncSize];
		public double[] X
		{
			get
			{
				return m_X;
			}
		}

		/// <summary>
		/// Значение функции
		/// </summary>
		private double m_Y;
		public double Y
		{
			get
			{
				return m_Y;
			}
		}

		public DoubleFuncPoint(double[] x, double y)
		{
			//Debug.Assert(x.Length == FuncSize);

			m_X = (double[])x.Clone();
			m_Y = y;
		}
	}

	/// <summary>
	/// Summary description for DoubleSpecies.
	/// </summary>
	public class DoubleSpecies: BaseSpecies<DoubleSpecies>, ICloneable
	{
		static private List<DoubleFuncPoint> m_FuncPoints = new List<DoubleFuncPoint> ();


		public static void AddPoint(DoubleFuncPoint point)
		{
			m_FuncPoints.Add(point);
		}


		public static void ClearPoints () 
		{ 
			m_FuncPoints.Clear (); 
		}


		private double m_FuncVal = double.MaxValue;

		private void GetFunc()
		{
			m_FuncVal = 0.0;
			foreach (DoubleFuncPoint point in m_FuncPoints)
			{
				m_FuncVal += Math.Abs (Func (point.X) - point.Y);
			}

			m_FuncVal /= m_FuncPoints.Count;
		}

		/// <summary>
		/// Хромосомы
		/// </summary>
		private double[] m_Chromosomes = new double[DoubleFuncPoint.FuncSize + 1];

		public double[] Cromosomes
		{
			get
			{
				return m_Chromosomes;
			}
		}

		/// <summary>
		/// Min. значение хромосом
		/// </summary>
		static private double m_MinVal = Double.MinValue;

		/// <summary>
		/// Min. значение хромосом
		/// </summary>
		static public double MinVal
		{
			get
			{
				return m_MinVal;
			}

			set
			{
				m_MinVal = value;
			}
		}

		/// <summary>
		/// Max. значение хромосом
		/// </summary>
		static private double m_MaxVal = Double.MaxValue;

		/// <summary>
		/// Max. значение хромосом
		/// </summary>
		static public double MaxVal
		{
			get
			{
				return m_MaxVal;
			}

			set
			{
				m_MaxVal = value;
			}
		}

		public DoubleSpecies()
		{
			//Debug.Assert(m_MinVal < m_MaxVal);

			Int32 Count = m_Chromosomes.Length;
			for (int i = 0; i < Count; ++i)
			{
				m_Chromosomes[i] = m_Rnd.NextDouble() * (m_MaxVal - m_MinVal) + m_MinVal;
			}

			GetFunc();
		}

		public DoubleSpecies(double[] chromosomes)
		{
			// Надеюсь, массивы копируются.
			m_Chromosomes = (double[])chromosomes.Clone();
			GetFunc();
		}

		public override DoubleSpecies Cross (DoubleSpecies Species)
		{
			if (this == Species)
			{
				return new DoubleSpecies ((double[])m_Chromosomes.Clone());
			}

			DoubleSpecies Other = (DoubleSpecies)Species;

			//В данном конкретном случае лучше работает скрещивание сразу всех хромосом
			double[] chromosomes = new double[m_Chromosomes.Length];
			for (int i = 0; i < chromosomes.Length; ++i)
			{
				chromosomes[i] = Cross(m_Chromosomes[i], Other.Cromosomes[i]);
			}
			
			return new DoubleSpecies(chromosomes);
		}

		private double Func(double[] x)
		{
			//Debug.Assert (x.Length == 5);
			// Считаем, что мах. степень многочлена = 5
			return m_Chromosomes[5] * x[0] * x[0] * x[0] * x[0] * x[0] + 
				m_Chromosomes[4] * x[1] * x[1] * x[1] * x[1] + 
				m_Chromosomes[3] * x[2] * x[2] * x[2] + 
				m_Chromosomes[2] * x[3] * x[3] + 
				m_Chromosomes[1] * x[4] + m_Chromosomes[0];
		}

		override public double FinalFunc
		{
			get
			{
				return m_FuncVal;
			}
		}

		public override void Mutation()
		{
			Int32 n = m_Rnd.Next(6);
			//m_Chromosomes[n] = Mutation(m_Chromosomes[n]);
			m_Chromosomes[n] = m_Rnd.NextDouble () * (m_MaxVal - m_MinVal) + m_MinVal;

			GetFunc();
		}

		public override void TestChromosomes()
		{
			Boolean res = false;
			foreach (double chromosome in m_Chromosomes)
			{
				if (Double.IsNaN(chromosome) || chromosome < m_MinVal || chromosome > m_MaxVal)
				{
					res = true;
					break;
				}
			}

			m_Dead = res;
		}

		public override string ToString()
		{
			return base.ToString ();
		}

		/*protected override double Mutation(double val)
		{
			return m_Rnd.NextDouble() * (m_MaxVal - m_MinVal) + m_MinVal;
		}*/


		#region ICloneable Members

		public object Clone ( )
		{
			return new DoubleSpecies (m_Chromosomes);
		}

		#endregion
	}
}
