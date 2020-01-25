using System;
using System.Collections.Generic;
using System.Text;

namespace GeneticGUI
{
	public class PopulationStats<TSpecies> : Population<TSpecies> 
		where TSpecies : BaseSpecies<TSpecies>, ICloneable
	{
		/// <summary>
		/// ������ �������. ������ ������ - ����� ���������, ������ - ����� �������.
		/// </summary>
		List<List<TSpecies>> m_bestSpeciesStats = new List<List<TSpecies>> ();

		public List<List<TSpecies>> BestSpeciesStats
		{
			get { return m_bestSpeciesStats; }
		}

		public PopulationStats ()
			:base()
		{
			// ������� � 0-� ������� ������ ������. 0-� ��������� ��� ������������ �� �����
			m_bestSpeciesStats.Add (new List<TSpecies> ());
		}

		public override void NextGeneration (int coding)
		{
			base.NextGeneration (coding);

			if (m_bestSpeciesStats.Count == m_Generation)
			{
				m_bestSpeciesStats.Add (new List<TSpecies> ());
			}

			m_bestSpeciesStats[m_Generation].Add ((TSpecies)this.BestSpecies.Clone());
		}
	}
}
