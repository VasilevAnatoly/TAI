using System;

using NUnit.Framework;

namespace SpeciesTest
{
	/// <summary>
	/// Тест для видов
	/// </summary>
	[TestFixture]
	public class SpeciesTest
	{

		public void BitTest1()
		{
			Int32 Count1 = GetOneCount(BitConverter.DoubleToInt64Bits(Double.NaN));
			Int32 Count2 = GetOneCount(BitConverter.DoubleToInt64Bits(-1.2869880633833763));

			//UInt64 x = BitConverter.ToUInt64(BitConverter.GetBytes(-1.2869880633833763), 0);
			Int64 x = BitConverter.DoubleToInt64Bits(-1.2869880633833763);

			Int64 mask = 1;
			mask <<= 62;
			x ^= mask;

			Int32 Count3 = GetOneCount(x);

			double res = BitConverter.Int64BitsToDouble(x);

			Int32 Count4 = GetOneCount(BitConverter.DoubleToInt64Bits(res));
		}

		public Int32 GetOneCount (byte[] x)
		{
			Int32 Count = 0;
			foreach (byte val in x)
			{
				Count += GetOneCount(val);
			}

			return Count;
		}

		public void BitTest2()
		{
			byte[] OriginalBytes = BitConverter.GetBytes(-1.2869880633833763);

			Int32 Count1 = GetOneCount(BitConverter.DoubleToInt64Bits(-1.2869880633833763));
			Int32 Count2 = GetOneCount(BitConverter.ToInt64(OriginalBytes, 0));

			Int64 x = BitConverter.DoubleToInt64Bits(-1.2869880633833763);
			Int64 x2 = BitConverter.ToInt64(OriginalBytes, 0);

			Int64 mask = 1;
			mask <<= 62;
			x ^= mask;

			byte[] bytes = BitConverter.GetBytes(x);

			Int32 Count3 = GetOneCount(bytes);

			double res = BitConverter.ToDouble(bytes, 0);

			Int32 Count4 = GetOneCount(BitConverter.GetBytes(res));
		}

		public static void Main()
		{
			SpeciesTest test = new SpeciesTest();
			test.BitTest1();
			test.BitTest2();
		}

		public SpeciesTest()
		{
		}

		/// <summary>
		/// Подготовим диапазоны изменения хромосом
		/// </summary>
		[SetUp]
		public void PrepareSpecies()
		{
			MySpecies.Min32 = 0;
			MySpecies.Max32 = 5620;

			MySpecies.Min64 = 0;
			MySpecies.Max64 = Int64.MaxValue - 2;

			MySpecies.MaxDouble = 3025.247;
			MySpecies.MinDouble = 1.5;
		}

		/// <summary>
		/// Считает число единиц в слове
		/// </summary>
		/// <param name="x">Слово, в котором считаем число единиц</param>
		/// <returns>Количество единиц</returns>
		private Int32 GetOneCount(Int32 x)
		{
			UInt32 val = BitConverter.ToUInt32(BitConverter.GetBytes(x), 0);
			Int32 Count = 0;

			while (val != 0)
			{
				if ((val & 1) != 0)
				{
					// Остаток от деления на 2 не 0, т.е. на конце единица
					Count++;
				}

				val >>= 1;
			}

			return Count;
		}

		/// <summary>
		/// Считает число единиц в слове
		/// </summary>
		/// <param name="x">Слово, в котором считаем число единиц</param>
		/// <returns>Количество единиц</returns>
		private Int32 GetOneCount(Int64 x)
		{
			Int32 Count = 0;
			UInt64 val = BitConverter.ToUInt64(BitConverter.GetBytes(x), 0);

			while (val != 0)
			{
				if ((val & 1) != 0)
				{
					// Остаток от деления на 2 не 0, т.е. на конце единица
					Count++;
				}

				val >>= 1;
			}

			return Count;
		}

		private void TestDead(MySpecies Species)
		{
			Species.TestChromosomes();

			Assert.IsTrue ((!Species.Dead && Species.I32Val >= MySpecies.Min32 && 
				Species.I32Val <= MySpecies.Max32 &&

				Species.I64Val >= MySpecies.Min64 &&
				Species.I64Val <= MySpecies.Max64 &&

				Species.DoubleVal >= MySpecies.MinDouble &&
				Species.DoubleVal <= MySpecies.MaxDouble) ||

				(Species.Dead && (Species.I32Val < MySpecies.Min32 || 
				Species.I32Val > MySpecies.Max32 ||

				Species.I64Val < MySpecies.Min64 ||
				Species.I64Val > MySpecies.Max64 ||
					
				Species.DoubleVal < MySpecies.MinDouble ||
				Species.DoubleVal > MySpecies.MaxDouble) ||
				Double.IsNaN(Species.DoubleVal)),
				String.Format ("Dead Error: {0}", Species));
		}

		private void Mutation32()
		{
			for (int i = 0; i < 5000; ++i)
			{
				MySpecies Species = new MySpecies();

				Int32 OriginVal = Species.I32Val;
				Int32 OriginCount = GetOneCount(OriginVal);

				Species.Mutation();

				Int32 NewVal = Species.I32Val;
				Int32 NewCount = GetOneCount(NewVal);

				Assert.AreEqual (Math.Abs (OriginCount - NewCount), 1);

				TestDead (Species);
			}
		}

		[Test]
		public void Mutation32Test()
		{
			MySpecies.Min32 = 0;
			MySpecies.Max32 = 5620;

			Mutation32();

			MySpecies.Min32 = -2578;
			MySpecies.Max32 = 0;

			Mutation32();
		}

		private void Mutation64()
		{
			for (int i = 0; i < 5000; ++i)
			{
				MySpecies Species = new MySpecies();

				Int64 OriginVal = Species.I64Val;
				Int64 OriginCount = GetOneCount(OriginVal);

				Species.Mutation();

				Int64 NewVal = Species.I64Val;
				Int64 NewCount = GetOneCount(NewVal);

				Assert.AreEqual (Math.Abs (OriginCount - NewCount), 1);

				TestDead (Species);
			}
		}

		[Test]
		public void Mutation64Test()
		{
			MySpecies.Min64 = 0;
			MySpecies.Max64 = Int64.MaxValue - 2;

			Mutation32();

			MySpecies.Min64 = -98745;
			MySpecies.Max64 = 0;

			Mutation32();
		}

		private void MutationDouble()
		{
			for (int i = 0; i < 5000; ++i)
			{
				MySpecies Species = new MySpecies();

				Double OriginVal = Species.DoubleVal;
				Int64 OriginCount = GetOneCount(BitConverter.DoubleToInt64Bits(OriginVal));

				Species.Mutation();

				Double NewVal = Species.DoubleVal;
				Int32 NewCount = GetOneCount(BitConverter.DoubleToInt64Bits(NewVal));

				Assert.IsTrue (Math.Abs (OriginCount - NewCount) == 1 || Double.IsNaN (NewVal));

				TestDead (Species);
			}
		}

		[Test]
		public void MutationDoubleTest()
		{
			MySpecies.MaxDouble = 3025.247;
			MySpecies.MinDouble = 1.5;

			MutationDouble();

			MySpecies.MaxDouble = 0;
			MySpecies.MinDouble = -1.5;

			MutationDouble();
		}

		[Test]
		public void Cross32Test()
		{
			Boolean res = true;
			for (Int32 i = 0; i < 5000 && res; ++i)
			{
				MySpecies x1 = new MySpecies();
				MySpecies x2 = new MySpecies();
				MySpecies y = (MySpecies)(x1.Cross(x2));

				Int32 n = 1;

				for (Int32 j = 31; j >= 0; --j)
				{
					if (n == 1)
					{
						if ((x1.I32Val & (1 << j)) != (y.I32Val & (1 << j)))
						{
							n = 2;
							j--;
						}
					}
					else
					{
						if ((x2.I32Val & (1 << j)) != (y.I32Val & (1 << j)))
						{
							res = false;
							break;
						}
					}
				}

				Assert.IsTrue (res, String.Format ("{0} + {1} -> {2}", x1.I32Val, x2.I32Val, y.I32Val));
				TestDead (x1);
				TestDead (x2);
				TestDead (y);
			}

		}

		[Test]
		public void Cross64Test()
		{
			Boolean res = true;
			for (Int32 i = 0; i < 5000 && res; ++i)
			{
				MySpecies x1 = new MySpecies();
				MySpecies x2 = new MySpecies();
				MySpecies y = (MySpecies)x1.Cross(x2);

				Int32 n = 1;

				for (Int32 j = 63; j >= 0; --j)
				{
					Int64 mask = 1;
					mask <<= j;
					if (n == 1)
					{

						if ((x1.I64Val & mask) != (y.I64Val & mask))
						{
							n = 2;
							j--;
						}
					}
					else
					{
						if ((x2.I64Val & mask) != (y.I64Val & mask))
						{
							res = false;
							break;
						}
					}
				}
				Assert.IsTrue (res, 
					String.Format ("{0} + {1} -> {2}", x1.I64Val, x2.I64Val, y.I64Val));

				TestDead (x1);
				TestDead (x2);
				TestDead (y);
			}

		}

		[Test]
		public void CrossDoubleTest()
		{
			Boolean res = true;
			for (Int32 i = 0; i < 5000 && res; ++i)
			{
				MySpecies x1 = new MySpecies();
				MySpecies x2 = new MySpecies();
				MySpecies y = (MySpecies)x1.Cross(x2);

				Int32 n = 1;
				Int64 dx1 = BitConverter.DoubleToInt64Bits(x1.DoubleVal);
				Int64 dx2 = BitConverter.DoubleToInt64Bits(x2.DoubleVal);
				Int64 dy = BitConverter.DoubleToInt64Bits(y.DoubleVal);

				for (Int32 j = 63; j >= 0; --j)
				{
					Int64 mask = 1;
					mask <<= j;
					if (n == 1)
					{

						if ((dx1 & mask) != (dy & mask))
						{
							n = 2;
							j--;
						}
					}
					else
					{
						if ((dx2 & mask) != (dy & mask))
						{
							res = false;
							break;
						}
					}
				}
				Assert.IsTrue (res, 
					String.Format ("{0} + {1} -> {2}", x1.DoubleVal, x2.DoubleVal, y.DoubleVal));
				TestDead (x1);
				TestDead (x2);
				TestDead (y);
			}

		}
	}
}
