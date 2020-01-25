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
			// Входные параметры
			////////////////////////////////////////////////////////////////

			// Количество хромосом (неизвестных в функции Швефеля)
			int chromosomesCount = 15;

			// Максимальное количество поколений (итераций)
			int maxGeneration = 10000;

			// Максимальное количество поколений (итераций) при постоянном значении целевой функции
			// Если за это количество поколений не найдено более лучшее решение, алгоритм прерывается.
			int maxEqualGeneration = 300;

			// Если на очередной итерации целевая функция изменилась на значение, 
			// меньшее ил равное minDelta, то считаем, что целевая функция не изменилась.
			double minDelta = 1e-8;

			// Максимальный размер популяции
			int populationMaxSize = 100;

			// Вероятность мутации
			double mutationPossibility = 0.1;

			// Вероятность скрещивания
			double crossPossibility = 0.9;

			// Интервал изменений хромосом
			double chromoMinVal = -500;
			double chromoMaxVal = 500;

			////////////////////////////////////////////////////////////////

			// Инициализацйия статических свойств класса SchwefelSpecies
			InitializeSpecies (chromosomesCount, chromoMinVal, chromoMaxVal);

			// Создание и инициализация популяции
			Population<BaseDoubleSpecies<SchwefelSpecies>> population = 
				InitializePopulation ( 
					populationMaxSize, 
					mutationPossibility, 
					crossPossibility);


			// Основной цикл алгоритма
			MainLoop (population, maxGeneration, maxEqualGeneration, minDelta);

			Console.ReadKey ();
		}


		/// <summary>
		/// Основной цикл алгоритма
		/// </summary>
		/// <param name="population">Созданная популяция</param>
		/// <param name="maxGeneration">Максимальное количество поколений</param>
		/// <param name="maxEqualGeneration">Максимальное количество поколений, когда значение целевой функции не изменилось</param>
		/// <param name="minDelta">Минимальное изменение целевой функции, когда считаем, что найдено более лучшее решение</param>
		private static void MainLoop (
			Population<BaseDoubleSpecies<SchwefelSpecies>> population, 
			int maxGeneration, 
			int maxEqualGeneration, 
			double minDelta)
		{
			// Количество поколений, в течение которых значение целевой функции не изменилось
			int equalGenerations = 0;

			// Значение целевой функции на предыдущей итерации
			double oldBestFinalFunc = population.BestFunc;

			// Цикл, ограниченный максимальным номером поколения и 
			// количеством поколений, когда значение целевой функции не изменилось.
			for (int generation = 0;
				generation < maxGeneration && equalGenerations < maxEqualGeneration;
				++generation)
			{
				// Вывод лучшей на данный момент особи в консоль
				WriteBestSpeciesToConsole (population.BestSpecies, generation);

				// Следующая итерация алгоритма. Получение следующего поколения особей.
				population.NextGeneration ();

				// Проверим, найдено ли лучшее решение
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
		/// Инициализация класса особей. Изменяются статические свойства класса SchwefelSpecies
		/// </summary>
		/// <param name="chromosomesCount"></param>
		/// <param name="chromoMinVal"></param>
		/// <param name="chromoMaxVal"></param>
		private static void InitializeSpecies (
			int chromosomesCount,
			double chromoMinVal,
			double chromoMaxVal)
		{
			// Зададим интервалы изменения хромосом
			Interval[] intervals = new Interval[chromosomesCount];

			for (int i = 0; i < chromosomesCount; i++)
			{
				intervals[i] = new Interval (chromoMinVal, chromoMaxVal);
			}

			// Установим свойства видов
			SchwefelSpecies.Intervals = intervals;
		}


		/// <summary>
		/// Создание и инициализация популяции
		/// </summary>
		/// <param name="populationMaxSize">Максимальный размер популяции</param>
		/// <param name="mutationPossibility">Вероятность мутации</param>
		/// <param name="crossPossibility">Вероятность скрещивания</param>
		/// <returns>Возвращает созданный экземпляр популяции.</returns>
		private static Population<BaseDoubleSpecies<SchwefelSpecies>> InitializePopulation (
			int populationMaxSize, 
			double mutationPossibility, 
			double crossPossibility)
		{
			Population<BaseDoubleSpecies<SchwefelSpecies>> population =
				new Population<BaseDoubleSpecies<SchwefelSpecies>> ();

			// Зададим параметры алгоритма
			population.Reset ();
			population.MaxSize = populationMaxSize;
			population.MutationPossibility = mutationPossibility;
			population.CrossPossibility = crossPossibility;

			// Добавим виды
			for (int i = 0; i < population.MaxSize; ++i)
			{
				population.Add (new SchwefelSpecies ());
			}

			return population;
		}


		/// <summary>
		/// Вывод параметров особи в консоль
		/// </summary>
		/// <param name="species">Особь, параметры которой хотим вывести в консоль</param>
		/// <param name="generation">Номер поколения, которой принадлежит особь</param>
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
