using System;
using System.Text;

namespace RealTest
{
	/// <summary>
	/// Форма для тестирования целых хромосом
	/// </summary>
	public class IntForm: GenericForm<IntSpecies>
	{
		Int32[] m_a = new Int32[] { 5, -21, 10, -13, 1, -0 };

		Int64 Func (Int32 x0, Int32 x1, Int32 x2, Int32 x3, Int32 x4)
		{
			return m_a[0] +
				m_a[1] * x4 +
				m_a[2] * x3 * x3 +
				m_a[3] * x2 * x2 * x2 +
				m_a[4] * x1 * x1 * x1 * x1 +
				m_a[5] * x0 * x0 * x0 * x0 * x0;
		}

		public IntForm():base()
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

		protected override void CreateBtn_Click(object sender, EventArgs e)
		{
			Int32 max32 = 50;
			Int32 min32 = -50;

			Int64 max64 = 150;
			Int64 min64 = -150;

			Random rnd = new Random();

			m_Population.Reset();
			m_Population.MaxSize = (int)popSize.Value;
			m_Population.MutationPossibility = int.Parse (mutation.Text) / 100.0;
			m_Population.CrossPossibility = int.Parse (cross.Text) / 100.0;

			// Установим свойства видов
			IntSpecies.Min32Val = min32;
			IntSpecies.Max32Val = max32;

			IntSpecies.Min64Val = min64;
			IntSpecies.Max64Val = max64;

			IntSpecies.ClearPoints ();

			// Добавим точки
			for (int i = 0; i < 30; ++i)
			{
				Int32[] x = new Int32[5];
				for (int j = 0; j < 5; ++j)
				{
					x[j] = rnd.Next(30) - 15;
				}

				IntSpecies.AddPoint ( new IntFuncPoint (x, Func (x[0], x[1], x[2], x[3], x[4]) ) );
			}

			// Добавим виды
			for (int i = 0; i < m_Population.MaxSize; ++i)
			{
				m_Population.Add(new IntSpecies());
			}

			ShowData();
		}

		override protected void ShowData()
		{
			// Сначала хромосомы
			IntSpecies species = m_Population.BestSpecies;
			a0.Text = species.A0.ToString();
			a1.Text = species.A1.ToString();
			a2.Text = species.A2.ToString();
			a3.Text = species.A3.ToString();
			a4.Text = species.A4.ToString();
			a5.Text = species.A5.ToString();

			// Теперь погрешность (целевую функцию)
			BestFunc.Text = m_Population.BestFunc.ToString();

			// И номер поколения
			Generation.Text = m_Population.Generation.ToString();
		}

	}
}
