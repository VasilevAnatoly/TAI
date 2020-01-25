using System;
using Jenyay.Genetic;

namespace SpeciesTest
{
	/// <summary>
	/// Пример реализации вида
	/// </summary>
	public class MySpecies: BaseSpecies<MySpecies>
	{
		public MySpecies (Int32 i32, Int64 i64, Double dval)
		{
			m_I32Val = i32;
			m_I64Val = i64;
			m_DVal = dval;
		}

		#region Хромосомы

		/// <summary>
		/// Хромосома типа Int32
		/// </summary>
		private Int32 m_I32Val = m_Rnd.Next(m_Min32, m_Max32);
		public Int32 I32Val
		{
			get	{ return m_I32Val; }
		}

		/// <summary>
		/// Минимальное значение для хромосомы типа Int32
		/// </summary>
		static private Int32 m_Min32;
		static public Int32 Min32
		{
			get	{ return m_Min32; }
			set { m_Min32 = value; }
		}

		/// <summary>
		/// Максимальное значение для хромосомы типа Int32
		/// </summary>
		static private Int32 m_Max32;
		static public Int32 Max32
		{
			get	{ return m_Max32; }
			set { m_Max32 = value; }
		}


		/// <summary>
		/// Хромосома типа Int64
		/// </summary>
		private Int64 m_I64Val = (Int64)m_Rnd.NextDouble() * (m_Max64 - m_Min64) + m_Min64;
		public Int64 I64Val
		{
			get	{ return m_I64Val; }
		}

		/// <summary>
		/// Минимальное значение для хромосомы типа Int64
		/// </summary>
		static private Int64 m_Min64;
		static public Int64 Min64
		{
			get	{ return m_Min64; }
			set { m_Min64 = value; }
		}

		/// <summary>
		/// Максимальное значение для хромосомы типа Int64
		/// </summary>
		static private Int64 m_Max64;
		static public Int64 Max64
		{
			get	{ return m_Max64; }
			set { m_Max64 = value; }
		}


		/// <summary>
		/// Хромосома типа Double
		/// </summary>
		private Double m_DVal = m_Rnd.NextDouble() * (m_MaxDouble - m_MinDouble) + m_MinDouble;
		public Double DoubleVal
		{
			get	{ return m_DVal; }
		}

		/// <summary>
		/// Минимальное значение для хромосомы типа Double
		/// </summary>
		static private Double m_MinDouble;
		static public Double MinDouble
		{
			get	{ return m_MinDouble; }
			set { m_MinDouble = value; }
		}

		/// <summary>
		/// Максимальное значение для хромосомы типа Double
		/// </summary>
		static private Double m_MaxDouble;
		static public Double MaxDouble
		{
			get	{ return m_MaxDouble; }
			set { m_MaxDouble = value; }
		}
		#endregion

		public MySpecies()
		{
		}

		public override MySpecies Cross (MySpecies Species)
		{
			if (this == Species)
			{
				return new MySpecies (m_I32Val, m_I64Val, m_DVal);
			}

			MySpecies s = (MySpecies)Species;

			return new MySpecies(Cross(m_I32Val, s.I32Val), 
				Cross(m_I64Val, s.I64Val),
				Cross(m_DVal, s.DoubleVal));
		}

		public override double FinalFunc
		{
			get
			{
				return 0;
			}
		}

		public override void Mutation()
		{
			m_I32Val = Mutation(m_I32Val);
			m_I64Val = Mutation(m_I64Val);
			m_DVal = Mutation(m_DVal);
		}

		public override void TestChromosomes()
		{
			m_Dead = (m_I32Val < m_Min32) || (m_I32Val > m_Max32) ||
				(m_I64Val < m_Min64) || (m_I64Val > m_Max64) ||
				(m_DVal < m_MinDouble) || (m_DVal > m_MaxDouble) || Double.IsNaN(m_DVal);
		}

		public override string ToString()
		{
			return String.Format("Min32 = {0}, Max32 = {1}, Val32 = {2}   ", m_Min32, m_Max32, m_I32Val) + Environment.NewLine + 
				String.Format("Min64 = {0}, Max64 = {1}, Val64 = {2}   ", m_Min64, m_Max64, m_I64Val) + Environment.NewLine + 
				String.Format("MinDouble = {0}, MaxDouble = {1}, ValDouble = {2}   ", m_MinDouble, m_MaxDouble, m_DVal) + Environment.NewLine + 
				String.Format("Is dead = {0}", m_Dead.ToString());
		}
	}
}
