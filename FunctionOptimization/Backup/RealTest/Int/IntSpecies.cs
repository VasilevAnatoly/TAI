using System;
using System.Collections.Generic;

using Jenyay.Genetic;

namespace RealTest
{
	/// <summary>
	/// Класс для описания многомерной точки на функции
	/// </summary>
	public class IntFuncPoint
	{
		/// <summary>
		/// Переменные
		/// </summary>
		public readonly Int32[] X = new int[5];

		/// <summary>
		/// Значение функции в данной точке
		/// </summary>
		public readonly Int64 Y;

		public IntFuncPoint(Int32[] x, Int64 y)
		{
			X = (Int32[])x.Clone();

			Y = y;
		}
	}

	/// <summary>
	/// Класс вида для тестирования целых хромосом
	/// </summary>
	public class IntSpecies: BaseSpecies<IntSpecies>, ICloneable
	{
		/// <summary>
		/// Значение целевой функции
		/// </summary>
		Int64 m_FuncVal = Int64.MaxValue;

		static private List<IntFuncPoint> m_Points = new List<IntFuncPoint> ();

		public static void AddPoint(IntFuncPoint point)
		{
			m_Points.Add(point);
		}

		public static void ClearPoints ()
		{
			m_Points.Clear ();
		}


		Int64 Func(Int32[] X)
		{
			return m_a5 * X[0] * X[0] * X[0] * X[0] * X[0] + 
				m_a4 * X[1] * X[1] * X[1] * X[1] + 
				m_a3 * X[2] * X[2] * X[2] +
				m_a2 * X[3] * X[3] + 
				m_a1 * X[4] +
				m_a0;
		}

		private void GetFunc()
		{
			m_FuncVal = 0;
			foreach (IntFuncPoint point in m_Points)
			{
				m_FuncVal += Math.Abs (Func (point.X) - point.Y);
			}

			m_FuncVal /= m_Points.Count;
		}

		/// <summary>
		/// Мин. значение 32-битных хромосом
		/// </summary>
		static private Int32 m_Min32Val;
		static public Int32 Min32Val
		{
			get
			{
				return m_Min32Val;
			}

			set
			{
				m_Min32Val = value;
			}
		}

		/// <summary>
		/// Max. значение 32-битных хромосом
		/// </summary>
		static private Int32 m_Max32Val;
		static public Int32 Max32Val
		{
			get
			{
				return m_Max32Val;
			}

			set
			{
				m_Max32Val = value;
			}
		}

		/// <summary>
		/// Мин. значение 64-битных хромосом
		/// </summary>
		static private Int64 m_Min64Val;
		static public Int64 Min64Val
		{
			get
			{
				return m_Min64Val;
			}

			set
			{
				m_Min64Val = value;
			}
		}

		/// <summary>
		/// Max. значение 64-битных хромосом
		/// </summary>
		static private Int64 m_Max64Val;
		static public Int64 Max64Val
		{
			get
			{
				return m_Max64Val;
			}

			set
			{
				m_Max64Val = value;
			}
		}

		#region Хромосомы
		Int32 m_a0 = m_Rnd.Next(m_Max32Val - m_Min32Val) + m_Min32Val;
		public Int32 A0
		{
			get {return m_a0;}
		}

		Int64 m_a1 = (Int64)(m_Rnd.NextDouble() * (m_Max64Val - m_Min64Val) + m_Min64Val);
		public Int64 A1
		{
			get {return m_a1;}
		}

		Int32 m_a2 = m_Rnd.Next(m_Max32Val - m_Min32Val) + m_Min32Val;
		public Int32 A2
		{
			get {return m_a2;}
		}
		Int64 m_a3 = (Int64)(m_Rnd.NextDouble() * (m_Max64Val - m_Min64Val) + m_Min64Val);
		public Int64 A3
		{
			get {return m_a3;}
		}

		Int32 m_a4 = m_Rnd.Next(m_Max32Val - m_Min32Val) + m_Min32Val;
		public Int32 A4
		{
			get {return m_a4;}
		}
		Int64 m_a5 = (Int64)(m_Rnd.NextDouble() * (m_Max64Val - m_Min64Val) + m_Min64Val);
		public Int64 A5
		{
			get {return m_a5;}
		}
		#endregion

		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public IntSpecies(): base()
		{
			GetFunc();
		}

		/// <summary>
		/// Конструктор с передачей хромосом
		/// </summary>
		/// <param name="a0">Хромосома</param>
		/// <param name="a1">Хромосома</param>
		/// <param name="a2">Хромосома</param>
		/// <param name="a3">Хромосома</param>
		/// <param name="a4">Хромосома</param>
		/// <param name="a5">Хромосома</param>
        public IntSpecies (Int32 a0, Int64 a1, Int32 a2, Int64 a3, Int32 a4, Int64 a5)
		{
			m_a0 = a0;
			m_a1 = a1;
			m_a2 = a2;
			m_a3 = a3;
			m_a4 = a4;
			m_a5 = a5;

			GetFunc();
		}

		public override IntSpecies Cross (IntSpecies Species)
		{
			if (this == Species)
			{
				return new IntSpecies(m_a0, m_a1, m_a2, m_a3, m_a4, m_a5);
			}

			IntSpecies Other = (IntSpecies)Species;
			/*return new IntSpecies(Cross(m_a0, Other.A0),
				Cross(m_a1, Other.A1),
				Cross(m_a2, Other.A2),
				Cross(m_a3, Other.A3),
				Cross(m_a4, Other.A4),
				Cross(m_a5, Other.A5));*/

			IntSpecies NewSpecies;

			Int32 n = m_Rnd.Next(6);
			switch (n)
			{
				case 0:
					NewSpecies = new IntSpecies(Cross(m_a0, Other.A0),
							m_a1, m_a2, m_a3, m_a4, m_a5);
					break;
				case 1:
					NewSpecies = new IntSpecies(m_a0,
							Cross(m_a1, Other.A1), m_a2, m_a3, m_a4, m_a5);
					break;
				case 2:
					NewSpecies = new IntSpecies(m_a0,
							m_a1, Cross(m_a2, Other.A2), m_a3, m_a4, m_a5);
					break;
				case 3:
					NewSpecies = new IntSpecies(m_a0,
							m_a1, m_a2, Cross(m_a3, Other.A3), m_a4, m_a5);
					break;
				case 4:
					NewSpecies = new IntSpecies(m_a0,
							m_a1, m_a2, m_a3, Cross(m_a4, Other.A4), m_a5);
					break;
				case 5:
					NewSpecies = new IntSpecies(m_a0,
							m_a1, m_a2, m_a3, m_a4, Cross(m_a5, Other.A5));
					break;
				default:
					throw new ArgumentException();
			}

			return NewSpecies;
		}

		public override double FinalFunc
		{
			get
			{
				return m_FuncVal;
			}
		}

		public override void Mutation()
		{
			Int32 n = m_Rnd.Next(6);
			/*switch (n)
			{
				case 0:
					m_a0 = Mutation(m_a0);
					break;
				case 1:
					m_a1 = Mutation(m_a1);
					break;
				case 2:
					m_a2 = Mutation(m_a2);
					break;
				case 3:
					m_a3 = Mutation(m_a3);
					break;
				case 4:
					m_a4 = Mutation(m_a4);
					break;
				case 5:
					m_a5 = Mutation(m_a5);
					break;
				default:
					throw new ArgumentException();
			}*/

			// Здесь лучше работает скрещивание по одной хромосоме
            switch (n)
			{
				case 0:
					m_a0 = m_Rnd.Next(m_Max32Val - m_Min32Val) + m_Min32Val;
					break;
				case 1:
					m_a1 = (Int64)(m_Rnd.NextDouble() * (m_Max64Val - m_Min64Val) + m_Min64Val);
					break;
				case 2:
					m_a2 = m_Rnd.Next(m_Max32Val - m_Min32Val) + m_Min32Val;
					break;
				case 3:
					m_a3 = (Int64)(m_Rnd.NextDouble() * (m_Max64Val - m_Min64Val) + m_Min64Val);
					break;
				case 4:
					m_a4 = m_Rnd.Next(m_Max32Val - m_Min32Val) + m_Min32Val;
					break;
				case 5:
					m_a5 = (Int64)(m_Rnd.NextDouble() * (m_Max64Val - m_Min64Val) + m_Min64Val);
					break;
				default:
					throw new ArgumentException();
			}

			GetFunc();
		}

		public override void TestChromosomes()
		{
			m_Dead = (m_a0 < m_Min32Val || m_a0 > m_Max32Val) ||
				(m_a1 < m_Min64Val || m_a1 > m_Max64Val) ||
				(m_a2 < m_Min32Val || m_a2 > m_Max32Val) ||
				(m_a3 < m_Min64Val || m_a3 > m_Max64Val) ||
				(m_a4 < m_Min32Val || m_a4 > m_Max32Val) ||
				(m_a5 < m_Min64Val || m_a5 > m_Max64Val);
		}


		#region ICloneable Members

		public object Clone ( )
		{
			return new IntSpecies (m_a0, m_a1, m_a2, m_a3, m_a4, m_a5);
		}

		#endregion
	}
}
