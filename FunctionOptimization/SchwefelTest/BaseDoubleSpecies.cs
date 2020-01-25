using System;
using System.Collections.Generic;

namespace GeneticGUI
{
	/// <summary>
	/// Summary description for DoubleSpecies.
	/// </summary>
	public abstract class BaseDoubleSpecies<TSpecies> : 
		BaseSpecies<BaseDoubleSpecies<TSpecies>>, ICloneable
		where TSpecies : BaseDoubleSpecies<TSpecies>
	{
		public BaseDoubleSpecies ()
		{
			m_Chromosomes = new double[m_Intervals.Length];

			// Заполним массив хромосом случайными числами в заданном интервале
			for (int i = 0; i < m_Intervals.Length; ++i)
			{
				Interval interval = m_Intervals[i];

				m_Chromosomes[i] = m_Rnd.NextDouble () * (
					interval.MaxValue - interval.MinValue) + interval.MinValue;
			}

			m_FuncVal = CalcFinalFunc();
		}

		public BaseDoubleSpecies (double[] chromosomes)
		{
			m_Chromosomes = (double[])chromosomes.Clone ();
			m_FuncVal = CalcFinalFunc ();
		}

		
		public int ChromoCount
		{
		  get { return m_Chromosomes.Length; }
		}

		/// <summary>
		/// Значение целевой функции
		/// </summary>
		protected double m_FuncVal = double.MaxValue;

		/// <summary>
		/// Расчет целевой функции. 
		/// Возвращаемое значение сохраняется в m_FuncVal
		/// </summary>
		/// <returns></returns>
		abstract protected double CalcFinalFunc();

		/// <summary>
		/// Хромосомы
		/// </summary>
		protected double[] m_Chromosomes;

		public double[] Cromosomes
		{
			get
			{
				return m_Chromosomes;
			}
		}

		static private Interval[] m_Intervals;

		/// <summary>
		/// Интервалы изменения хромосом
		/// </summary>
		public static Interval[] Intervals
		{
			get { return m_Intervals; }
			set { m_Intervals = value; }
		}

		public override BaseDoubleSpecies<TSpecies> Cross (BaseDoubleSpecies<TSpecies> Species)
		{
			if (this == Species)
			{
				return (TSpecies)Activator.CreateInstance (typeof (TSpecies),
					new object[] { m_Chromosomes });
			}

			TSpecies Other = (TSpecies)Species;

            double[] chromosomes = new double[m_Chromosomes.Length];
			for (int i = 0; i < chromosomes.Length; ++i)
			{
				chromosomes[i] = Cross(m_Chromosomes[i], Other.Cromosomes[i]);
			}

			return (TSpecies)Activator.CreateInstance (typeof (TSpecies),
					new object[] { chromosomes });
		}

        public override BaseDoubleSpecies<TSpecies> CrossReal(BaseDoubleSpecies<TSpecies> Species)
        {
            if (this == Species)
            {
                return (TSpecies)Activator.CreateInstance(typeof(TSpecies),
                    new object[] { m_Chromosomes });
            }

            TSpecies Other = (TSpecies)Species;

            double[] chromosomes = new double[m_Chromosomes.Length];

            int delim = chromosomes.Length / 2;

            int rand = m_Rnd.Next(m_Chromosomes.Length);

            if (rand%2 == 0)
            {
                for (int i = 0; i < delim; ++i)
                {
                    chromosomes[i] = m_Chromosomes[i];
                }

                for (int i = delim; i < chromosomes.Length; ++i)
                {
                    chromosomes[i] = Other.Cromosomes[i];
                }
            }
            else
            {
                for (int i = 0; i < delim; ++i)
                {
                    chromosomes[i] = Other.Cromosomes[i];
                }

                for (int i = delim; i < chromosomes.Length; ++i)
                {
                    chromosomes[i] = m_Chromosomes[i];
                }
            }
            return (TSpecies)Activator.CreateInstance(typeof(TSpecies),
                    new object[] { chromosomes });
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
			Int32 n = m_Rnd.Next(m_Chromosomes.Length);
			Interval interval = m_Intervals[n];

			m_Chromosomes[n] = m_Rnd.NextDouble () *
				(interval.MaxValue - interval.MinValue) + interval.MinValue;

			m_FuncVal = CalcFinalFunc();
		}

		public override void TestChromosomes()
		{
			Boolean res = false;
			for (int i = 0; i < m_Chromosomes.Length; i++)
			{
				double chromosome = m_Chromosomes[i];

				if (Double.IsNaN (chromosome) || 
					!m_Intervals[i].IsInside (chromosome))
				{
					res = true;
					break;
				}
			}

			m_Dead = res;
		}

		#region ICloneable Members

		public object Clone ( )
		{
			return Activator.CreateInstance (typeof (TSpecies),
				new object[] { m_Chromosomes }); ;
		}

		#endregion
	}
}
