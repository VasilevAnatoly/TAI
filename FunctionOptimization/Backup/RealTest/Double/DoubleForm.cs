using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace RealTest
{
	/// <summary>
	/// Summary description for DoubleForm.
	/// </summary>
	public class DoubleForm: GenericForm<DoubleSpecies>
	{
		// Истинные значения параметров a
		double[] m_a = new double[] { 2.2, 1.32, -4.06, -3.1, 4.7, 0.2 };


		double Func (double x0, double x1, double x2, double x3, double x4)
		{
			return m_a[0] +
				m_a[1] * x4 +
				m_a[2] * x3 * x3 +
				m_a[3] * x2 * x2 * x2 +
				m_a[4] * x1 * x1 * x1 * x1 +
				m_a[5] * x0 * x0 * x0 * x0 * x0;
		}

		public DoubleForm(): base()
		{
			WriteRightValues ();
		}


		private void WriteRightValues ()
		{
			StringBuilder builder = new StringBuilder ();

			builder.AppendLine ("Правильные значения:");
			for (int i = 0; i < m_a.Length; i++)
			{
				builder.AppendFormat ("a{0} = {1}", i, m_a[i]);
				builder.AppendLine ();
			}

			rightVals.Text = builder.ToString ();
		}

		protected override void CreateBtn_Click (object sender, EventArgs e)
		{
			double max = 5.0;
			double min = -5.0;

			Random rnd = new Random();

			m_Population.Reset();
			m_Population.MaxSize = (int)popSize.Value;
			m_Population.MutationPossibility = int.Parse (mutation.Text) / 100.0;
			m_Population.CrossPossibility = int.Parse (cross.Text) / 100.0;

			// Установим свойства видов
			DoubleSpecies.MinVal = min;
			DoubleSpecies.MaxVal = max;
			DoubleSpecies.ClearPoints ();

			Debug.Assert(DoubleFuncPoint.FuncSize == 5);

			// Добавим точки
			for (int i = 0; i < 30; ++i)
			{
				double[] x = new double[DoubleFuncPoint.FuncSize];
				for (int j = 0; j < DoubleFuncPoint.FuncSize; ++j)
				{
					x[j] = rnd.NextDouble() * 30.0 - 10.0;
				}

				DoubleSpecies.AddPoint ( new DoubleFuncPoint (x, Func (x[0], x[1], x[2], x[3], x[4]) ) );
			}

			// Добавим виды
			for (int i = 0; i < m_Population.MaxSize; ++i)
			{
				m_Population.Add(new DoubleSpecies());
			}

			ShowData();
		}

		override protected void ShowData()
		{
			// Сначала хромосомы
			DoubleSpecies species = m_Population.BestSpecies;
			a0.Text = species.Cromosomes[0].ToString ("G5");
			a1.Text = species.Cromosomes[1].ToString ("G5");
			a2.Text = species.Cromosomes[2].ToString ("G5");
			a3.Text = species.Cromosomes[3].ToString ("G5");
			a4.Text = species.Cromosomes[4].ToString ("G5");
			a5.Text = species.Cromosomes[5].ToString ("G5");

			// Теперь погрешность (целевую функцию)
			BestFunc.Text = m_Population.BestFunc.ToString();

			// И номер поколения
			Generation.Text = m_Population.Generation.ToString();
		}

		protected override void saveStats_Click (object sender, EventArgs e)
		{
			string fname = "statistic.txt";

			try
			{
				using (StreamWriter sw = File.CreateText (fname))
				{
					sw.WriteLine ("Func    a0    a1    a2    a3    a4    a5");

					foreach (List<DoubleSpecies> species_list in m_Population.BestSpeciesStats)
					{
						// Среднее значение целевой функции
						double average_func = 0.0;
						
						double average_a0 = 0.0;
						double average_a1 = 0.0;
						double average_a2 = 0.0;
						double average_a3 = 0.0;
						double average_a4 = 0.0;
						double average_a5 = 0.0;

						foreach (DoubleSpecies species in species_list)
						{
							average_func += species.FinalFunc;

							average_a0 += species.Cromosomes[0];
							average_a1 += species.Cromosomes[1];
							average_a2 += species.Cromosomes[2];
							average_a3 += species.Cromosomes[3];
							average_a4 += species.Cromosomes[4];
							average_a5 += species.Cromosomes[5];
						}

						average_func /= species_list.Count;

						average_a0 /= species_list.Count;
						average_a1 /= species_list.Count;
						average_a2 /= species_list.Count;
						average_a3 /= species_list.Count;
						average_a4 /= species_list.Count;
						average_a5 /= species_list.Count;

						sw.WriteLine (string.Format ("{0}    {1}    {2}    {3}    {4}    {5}    {6}", average_func, average_a0, average_a1, average_a2, average_a3, average_a4, average_a5));

					}	// foreach (List<TSpecies> species_list in m_bestSpecies)

				}	// using (StreamWriter sw = File.CreateText (fname))
			}
			catch (IOException)
			{
			}
		}
	}
}
