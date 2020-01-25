using System;
using System.Collections.Generic;
using System.Text;

using Jenyay.Genetic;

namespace ConsoleShwefelTest
{
	class Program
	{
		static void Main (string[] args)
		{
			////////////////////////////////////////////////////////////////
			// ������� ���������
			////////////////////////////////////////////////////////////////

			// ���������� �������� (����������� � ������� �������)
			int chromosomesCount = 15;

			// ������������ ���������� ��������� (��������)
			int maxGeneration = 10000;

			// ������������ ���������� ��������� (��������) ��� ���������� �������� ������� �������
			// ���� �� ��� ���������� ��������� �� ������� ����� ������ �������, �������� �����������.
			int maxEqualGeneration = 300;

			// ���� �� ��������� �������� ������� ������� ���������� �� ��������, 
			// ������� �� ������ minDelta, �� �������, ��� ������� ������� �� ����������.
			double minDelta = 1e-8;

			// ������������ ������ ���������
			int populationMaxSize = 100;

			// ����������� �������
			double mutationPossibility = 0.1;

			// ����������� �����������
			double crossPossibility = 0.9;

			// �������� ��������� ��������
			double chromoMinVal = -500;
			double chromoMaxVal = 500;

			////////////////////////////////////////////////////////////////

			// �������������� ����������� ������� ������ SchwefelSpecies
			InitializeSpecies (chromosomesCount, chromoMinVal, chromoMaxVal);

			// �������� � ������������� ���������
			Population<BaseDoubleSpecies<SchwefelSpecies>> population = 
				InitializePopulation ( 
					populationMaxSize, 
					mutationPossibility, 
					crossPossibility);


			// �������� ���� ���������
			MainLoop (population, maxGeneration, maxEqualGeneration, minDelta);

			Console.ReadKey ();
		}


		/// <summary>
		/// �������� ���� ���������
		/// </summary>
		/// <param name="population">��������� ���������</param>
		/// <param name="maxGeneration">������������ ���������� ���������</param>
		/// <param name="maxEqualGeneration">������������ ���������� ���������, ����� �������� ������� ������� �� ����������</param>
		/// <param name="minDelta">����������� ��������� ������� �������, ����� �������, ��� ������� ����� ������ �������</param>
		private static void MainLoop (
			Population<BaseDoubleSpecies<SchwefelSpecies>> population, 
			int maxGeneration, 
			int maxEqualGeneration, 
			double minDelta)
		{
			// ���������� ���������, � ������� ������� �������� ������� ������� �� ����������
			int equalGenerations = 0;

			// �������� ������� ������� �� ���������� ��������
			double oldBestFinalFunc = population.BestFunc;

			// ����, ������������ ������������ ������� ��������� � 
			// ����������� ���������, ����� �������� ������� ������� �� ����������.
			for (int generation = 0;
				generation < maxGeneration && equalGenerations < maxEqualGeneration;
				++generation)
			{
				// ����� ������ �� ������ ������ ����� � �������
				WriteBestSpeciesToConsole (population.BestSpecies, generation);

				// ��������� �������� ���������. ��������� ���������� ��������� ������.
				population.NextGeneration ();

				// ��������, ������� �� ������ �������
				if (Math.Abs (population.BestFunc - oldBestFinalFunc) <= minDelta)
				{
					equalGenerations++;
				}
				else
				{
					oldBestFinalFunc = population.BestFunc;
				}
			}
		}


		/// <summary>
		/// ������������� ������ ������. ���������� ����������� �������� ������ SchwefelSpecies
		/// </summary>
		/// <param name="chromosomesCount"></param>
		/// <param name="chromoMinVal"></param>
		/// <param name="chromoMaxVal"></param>
		private static void InitializeSpecies (
			int chromosomesCount,
			double chromoMinVal,
			double chromoMaxVal)
		{
			// ������� ��������� ��������� ��������
			Interval[] intervals = new Interval[chromosomesCount];

			for (int i = 0; i < chromosomesCount; i++)
			{
				intervals[i] = new Interval (chromoMinVal, chromoMaxVal);
			}

			// ��������� �������� �����
			SchwefelSpecies.Intervals = intervals;
		}


		/// <summary>
		/// �������� � ������������� ���������
		/// </summary>
		/// <param name="populationMaxSize">������������ ������ ���������</param>
		/// <param name="mutationPossibility">����������� �������</param>
		/// <param name="crossPossibility">����������� �����������</param>
		/// <returns>���������� ��������� ��������� ���������.</returns>
		private static Population<BaseDoubleSpecies<SchwefelSpecies>> InitializePopulation (
			int populationMaxSize, 
			double mutationPossibility, 
			double crossPossibility)
		{
			Population<BaseDoubleSpecies<SchwefelSpecies>> population =
				new Population<BaseDoubleSpecies<SchwefelSpecies>> ();

			// ������� ��������� ���������
			population.Reset ();
			population.MaxSize = populationMaxSize;
			population.MutationPossibility = mutationPossibility;
			population.CrossPossibility = crossPossibility;

			// ������� ����
			for (int i = 0; i < population.MaxSize; ++i)
			{
				population.Add (new SchwefelSpecies ());
			}

			return population;
		}


		/// <summary>
		/// ����� ���������� ����� � �������
		/// </summary>
		/// <param name="species">�����, ��������� ������� ����� ������� � �������</param>
		/// <param name="generation">����� ���������, ������� ����������� �����</param>
		private static void WriteBestSpeciesToConsole (
			BaseDoubleSpecies<SchwefelSpecies> species,
			int generation)
		{
			StringBuilder builder = new StringBuilder ();
			builder.AppendLine (species.ToString ());
			builder.AppendFormat ("Generation = {0}", generation);
			builder.AppendLine ();
			builder.AppendLine ();

			Console.WriteLine (builder.ToString ());
		}
	}
}
