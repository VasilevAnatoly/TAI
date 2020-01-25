using System;
//using System.Diagnostics;

namespace GeneticGUI
{
	/// <summary>
	/// ������� ����� ��� ����
	/// </summary>
	abstract public class BaseSpecies<TSpecies>: IComparable 
		where TSpecies: BaseSpecies<TSpecies>
	{
		/// <summary>
		/// ������������ ��� ��������� ������� ����������� �������� � �������
		/// </summary>
		static protected Random m_Rnd = new Random();

		#region ����������� ������� ��� ����������� �������� ������� �����
		/// <summary>
		/// ��������� ��� ��������� ���� double
		/// </summary>
		/// <param name="x">1-� ���������</param>
		/// <param name="y">2-� ���������</param>
		/// <returns>����� ���������</returns>
		static protected double Cross (double x, double y)
		{
			Int64 ix = BitConverter.DoubleToInt64Bits(x);
			Int64 iy = BitConverter.DoubleToInt64Bits(y);

			double res = BitConverter.Int64BitsToDouble(BitCross(ix, iy));

			if (m_Rnd.Next() % 2 == 0)
			{
				if (x * res < 0)
				{
					res = -res;
				}
			}
			else
			{
				if (y * res < 0)
				{
					res = -res;
				}
			}

			return res;

			//return (x + y) / 2.0;
		}
		
		/// <summary>
		/// ��������� ��� ��������� ���� int
		/// </summary>
		/// <param name="x">1-� ���������</param>
		/// <param name="y">2-� ���������</param>
		/// <returns>����� ���������</returns>
		static protected int Cross (Int32 x, Int32 y)
		{
			// ����� ���, ���������� ����� �� ����� ����������� ��������
			Int32 Count = m_Rnd.Next(1, 31);
			Int32 mask = ~0;

			mask = mask << (32 - Count);

			//Debug.Assert(mask != 0 && mask != ~0 ,String.Format("mask = {0}", mask));

			Int32 res = (x & mask) | (y & ~mask);

			if (m_Rnd.Next() % 2 == 0)
			{
				if (x * res < 0)
				{
					res = -res;
				}
			}
			else
			{
				if (y * res < 0)
				{
					res = -res;
				}
			}

			return res;
		}
		
		/// <summary>
		/// ��������� �������� ��� ����� ����� ��� ��������� ���� Int64
		/// </summary>
		/// <param name="x">1-� ���������</param>
		/// <param name="y">2-� ���������</param>
		/// <returns>����� ���������</returns>
		static protected Int64 BitCross (Int64 x, Int64 y)
		{
			// ����� ���, ���������� ����� �� ����� ����������� ��������
			int Count = m_Rnd.Next(62) + 1;
			Int64 mask = ~0;

			mask = mask << (64 - Count);

			return (x & mask) | (y & ~mask);
		}

		/// <summary>
		/// ��������� �������� � ������ ����� ��� ��������� ���� Int64
		/// </summary>
		/// <param name="x">1-� ���������</param>
		/// <param name="y">2-� ���������</param>
		/// <returns>����� ���������</returns>
		static protected Int64 Cross (Int64 x, Int64 y)
		{

			Int64 res = BitCross(x, y);

			if (m_Rnd.Next() % 2 == 0)
			{
				if (x * res < 0)
				{
					res = -res;
				}
			}
			else
			{
				if (y * res < 0)
				{
					res = -res;
				}
			}

			return res;
		}

		#endregion
		/// <summary>
		/// ����� �� ���.
		/// </summary>
		/// <remarks>��������, ����� ��������� �� �������� � �������� ��������</remarks>
		protected bool m_Dead = false;

		/// <summary>
		/// ������� �� ���?
		/// </summary>
		public bool Dead
		{
			get	{ return m_Dead; }
		}

		/// <summary>
		/// ���������, ����� ��� ��������� ������ �� � �������� ���������. 
		/// � ��������� ������ �������� ��� ��� "�������".
		/// </summary>
		abstract public void TestChromosomes();

		/// <summary>
		/// ����� ��� ��������� ����������� ���� � ������ �����
		/// </summary>
		/// <param name="Species">������ ���</param>
		/// <returns>���������� ���</returns>
		abstract public TSpecies Cross (TSpecies Species);

        /// <summary>
		/// ����� ��� ������������� ����������� ���� � ������ �����
		/// </summary>
		/// <param name="Species">������ ���</param>
		/// <returns>���������� ���</returns>
		abstract public TSpecies CrossReal(TSpecies Species);

        /// <summary>
        /// ���������� �������
        /// </summary>
        abstract public void Mutation();

		/// <summary>
		/// ������� �������. ������ � ������ �������� ������ �������� ���������� � ������ ��������
		/// </summary>
		/// <returns>�������� ������� �������</returns>
		abstract public double FinalFunc
		{
			get;
		}

		#region IComparable Members

		/// <summary>
		/// ��� ��������� ������, ���� �� ����� ��� � ���� ������ ������� �������
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public Int32 CompareTo(object obj)
		{
			TSpecies Other = (TSpecies)obj;

			Int32 res = 0;

			// ���� ��� �����, � ������ - ���
			if (this.Dead && !Other.Dead)
			{
				res = 1;
			}
			else if (!this.Dead && Other.Dead)
			{
				// ���� ��� ���, � ������ ��� �����
				res = -1;
			}
			else
			{
				double ThisFunc = this.FinalFunc;
				double OtherFunc = Other.FinalFunc;
				if (ThisFunc > OtherFunc)
				{
					res = 1;
				}
				else if (ThisFunc < OtherFunc)
				{
					res = -1;
				}
			}

			return res;
		}	// public Int32 CompareTo(object obj)

		#endregion
	}
}
