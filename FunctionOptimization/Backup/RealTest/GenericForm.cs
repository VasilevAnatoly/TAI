using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

using Jenyay.Genetic;

namespace RealTest
{
	public abstract class GenericForm<TSpecies>: TestForm 
		where TSpecies: BaseSpecies<TSpecies>, ICloneable
	{
		public GenericForm()
		{
			this.Next10Btn.Click += new System.EventHandler (this.Next10Btn_Click);
			this.Next100Btn.Click += new System.EventHandler (this.Next100Btn_Click);
			this.NextBtn.Click += new System.EventHandler (this.NextBtn_Click);
			this.Next1000Btn.Click += new System.EventHandler (this.Next1000Btn_Click);
			this.CreateBtn.Click += new System.EventHandler (this.CreateBtn_Click);
			this.saveStats.Click += new System.EventHandler (this.saveStats_Click);
		}

		//protected Population<TSpecies> m_Population = new Population<TSpecies> ();
		protected PopulationStats<TSpecies> m_Population = new PopulationStats<TSpecies> ();

		/// <summary>
		/// Показать данные о популяции
		/// </summary>
		abstract protected void ShowData();

		abstract protected void CreateBtn_Click(object sender, EventArgs e);

		private void NextBtn_Click(object sender, EventArgs e)
		{
			Loop(1);
		}

		private void Next10Btn_Click(object sender, EventArgs e)
		{
			Loop(10);
		}

		private void Next100Btn_Click(object sender, EventArgs e)
		{
			Loop(100);
		}

		private void Next1000Btn_Click(object sender, EventArgs e)
		{		
			Loop(1000);
		}
				
		/// <summary>
		/// Выполняет перебор заданного числа поколений.
		/// Все делаем в одном потоке только потому, что это тест.
		/// </summary>
		/// <param name="count">Количество поколений</param>
		private void Loop (int count)
		{
			PerfCounter counter = new PerfCounter();
					
			counter.Start();
			for (int i = 0; i < count; ++i)
			{
				m_Population.NextGeneration();
				ShowData();
				this.Update();
			}
			float res = counter.Finish();
			Perf.Text = res.ToString();

			ShowData();
		}

		private void InitializeComponent ( )
		{
			((System.ComponentModel.ISupportInitialize)(this.popSize)).BeginInit ();
			this.SuspendLayout ();
			// 
			// saveStats
			// 
			this.saveStats.Click += new System.EventHandler (this.saveStats_Click);
			// 
			// GenericForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.ClientSize = new System.Drawing.Size (628, 405);
			this.Name = "GenericForm";
			((System.ComponentModel.ISupportInitialize)(this.popSize)).EndInit ();
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		virtual protected void saveStats_Click (object sender, EventArgs e)
		{
			string fname = "statistic.txt";

			try
			{
				using (StreamWriter sw = File.CreateText (fname))
				{
					foreach (List<TSpecies> species_list in m_Population.BestSpeciesStats)
					{
						// Среднее значение целевой функции
						double average_func = 0.0;

						foreach (TSpecies species in species_list)
						{
							average_func += species.FinalFunc;
						}

						average_func /= species_list.Count;

						sw.WriteLine (string.Format ("{0}", average_func));

					}	// foreach (List<TSpecies> species_list in m_bestSpecies)

				}	// using (StreamWriter sw = File.CreateText (fname))
			}
			catch (IOException)
			{
			}
		}
	}
}
