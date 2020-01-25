using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Jenyay.Genetic;

using ZedGraph;

namespace SchwefelTest
{
	public partial class MainForm : Form
	{
		Population<BaseDoubleSpecies<SchwefelSpecies>> m_Population = 
			new Population<BaseDoubleSpecies<SchwefelSpecies>> ();

		Analytics<SchwefelSpecies> m_Analytics = 
			new Analytics<SchwefelSpecies> ();

		public MainForm ()
		{
			InitializeComponent ();
		}

		private void CreateBtn_Click (object sender, EventArgs e)
		{
			int count = (int)chromoCount.Value;

			// Зададим интервалы изменения хромосом
			Interval[] intervals = new Interval[count];

			for (int i = 0; i < count; i++)
			{
				intervals[i] = new Interval (-500.0, 500.0);
			}

			m_Analytics.Clear ();

			// Зададим параметры алгоритма
			m_Population.Reset ();
			m_Population.MaxSize = (int)popSize.Value;
			m_Population.MutationPossibility = int.Parse (mutation.Text) / 100.0;
			m_Population.CrossPossibility = int.Parse (cross.Text) / 100.0;

			// Установим свойства видов
			SchwefelSpecies.Intervals = intervals;

			// Добавим виды
			for (int i = 0; i < m_Population.MaxSize; ++i)
			{
				m_Population.Add (new SchwefelSpecies ());
			}

			ShowData ();
		}

		private void ShowData ()
		{
			StringBuilder builder = new StringBuilder ();
			builder.AppendLine (m_Population.BestSpecies.ToString ());
			builder.AppendFormat ("Generation = {0}", m_Population.Generation);

			currStatus.Text = builder.ToString ();
		}

		private void Loop (int count)
		{
			for (int i = 0; i < count; ++i)
			{
				m_Population.NextGeneration ();

				m_Analytics.Add (m_Population.BestSpecies);

				ShowData ();
				this.Update ();
			}

			ShowData ();
		}

		private void NextBtn_Click (object sender, EventArgs e)
		{
			Loop (1);

			UpdateGraph ();
		}

		private void Next10Btn_Click (object sender, EventArgs e)
		{
			Loop (10);

			UpdateGraph ();
		}

		private void Next100Btn_Click (object sender, EventArgs e)
		{
			Loop (100);

			UpdateGraph ();
		}

		private void Next1000Btn_Click (object sender, EventArgs e)
		{
			Loop (1000);

			UpdateGraph ();
		}

		void UpdateGraph ()
		{
			GraphPane pane = zedGraph.GraphPane;

			pane.XAxis.Title.Text = "Поколение";
			pane.YAxis.Title.Text = "F(x)";

			pane.CurveList.Clear ();

			PointPairList list = new PointPairList ();

			for (int i = 0; i < m_Analytics.BestSpecies.Count; i++)
			{
				list.Add (i, m_Analytics.BestSpecies[i].FinalFunc);
			}

			LineItem myCurve = pane.AddCurve ("", list, Color.Blue, SymbolType.None);

			zedGraph.AxisChange ();

			zedGraph.Invalidate ();
		}

		private void saveAnalytic_Click (object sender, EventArgs e)
		{
			if (saveFileDialog.ShowDialog () == DialogResult.OK)
			{
				using (StreamWriter sw = new StreamWriter (saveFileDialog.FileName))
				{
					sw.Write (m_Analytics.ToString());
				}
			}
		}
	}
}