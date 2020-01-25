using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ZedGraph;
using System.Linq;

namespace GeneticGUI
{
	public partial class MainForm : Form
	{
		Population<BaseDoubleSpecies<TaskSpecies>> m_Population = 
			new Population<BaseDoubleSpecies<TaskSpecies>> ();

		Analytics<TaskSpecies> m_Analytics = 
			new Analytics<TaskSpecies> ();

		private FunctionParser.xFunction parsingGA = null;
        private FunctionParser.xFunction parsingMEC = null;
        private FunctionParser.xFunction parsingGSO = null;
        private FunctionParser.xFunction parsingEMA = null;
        private FunctionParser.xFunction parsingBA = null;
        private FunctionParser.xFunction parsingHS = null;
        private FunctionParser.xFunction parsingHC = null;

        private double[] minValuesGA;
		private double[] maxValuesGA;

        private double[] minValuesMEC;
        private double[] maxValuesMEC;

        private double[] minValuesGSO;
        private double[] maxValuesGSO;

        private double[] minValuesEMA;
        private double[] maxValuesEMA;

        private double[] minValuesBA;
        private double[] maxValuesBA;

        private double[] minValuesHS;
        private double[] maxValuesHS;

        private double[] minValuesHC;
        private double[] maxValuesHC;

        List<string> default_Functions = new List<string>()//список для функций по умолчанию
		{
			 "100*((x[1]-(x[0]^2))^2)+((1-x[0])^2)",
			"3*((x[0]-4)^2)+5*((x[1]+3)^2)+7*((2*x[2]+1)^2)",
			"8*(x[0]^2)+4*x[1]*x[0]+5*(x[1]^2)",
			"(x[0]^3)+(x[1]^2)-3*x[0]-2*x[1]+2",
			"4*((x[0]-5)^2)+((x[1]-6)^2)",
			"((x[0]-1)^2)+((x[1]-3)^2)+4*((x[2]+5)^2)",
			"(x[0]^2)+3*(x[1]^2)+(3*x[0]*x[1])+x[0]",
			"((x[0]-2)^4)+((x[0]-2*x[1])^2)",
			"((x[1]-(x[0]^2))^2)+((1-x[0])^2)",
			"((x[1]-(x[0]^2))^2)+100*((1-(x[0]^2))^2)",
			"-(12*x[1])+4*(x[0]^2)+4*(x[1]^2)-4*x[0]*x[1]",
			 "4*(x[0]^2)+3*(x[1]^2)-4*x[0]*(x[1]^2)+x[0]",
			 "100*((x[1]-(x[0]^3))^2)+((1-x[0])^2)",
			 "((1,5-x[0]*(1-x[1]))^2)+((2,25-x[0]*(1-(x[1]^2)))^2)+((2,625-x[0]*(1-(x[1]^3)))^2)",
			  "(((x[0]*x[1]*x[2])-1)^2)+5*((x[2]*(x[0]+x[1])-2)^2)+2*((x[0]+x[1]+x[2]-3)^2)"
		};

		public MainForm ()
		{
			InitializeComponent ();
            foreach (var func in default_Functions)
            {
                tasksGAComboBox.Items.Add(func);
                tasksBAComboBox.Items.Add(func);
                tasksEMAComboBox.Items.Add(func);
                tasksGSOComboBox.Items.Add(func);
                tasksHSComboBox.Items.Add(func);
                tasksMECComboBox.Items.Add(func);
                tasksHCComboBox.Items.Add(func);
            }
		}

		private void CreateBtn_Click (object sender, EventArgs e)
		{
			
		}

		private void ShowData ()
		{
			StringBuilder builder = new StringBuilder ();
			builder.AppendLine (m_Population.BestSpecies.ToString ());
			builder.AppendFormat ("Generation = {0}", m_Population.Generation);

			currStatusGA.Text = builder.ToString ();
		}

		private void Loop (int count)
		{
			for (int i = 0; i < count; ++i)
			{
				m_Population.NextGeneration((int)codingCmBGA.SelectedIndex);

				m_Analytics.Add (m_Population.BestSpecies);

				ShowData ();
				this.Update ();
			}

			ShowData ();
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

		private static bool inArray(char a, string arr)
		{
			if (arr.Contains($"{a}"))
				return true;
			else
				return false;
		}

		private static bool isSpace(char a)
		{
			return inArray(a, "; \t\n\r");
		}

		private void ReadMinMaxValues(string input, double[] values)
		{
			string output = String.Empty;
			int x = 0;
			for (int i = 0; i < input.Length; i++)
			{
				if (!isSpace(input[i]))
				{
					if (input[i] == '-')
					{
						i++;
						output = ReadString(input, ref i);
						if (output != "")
						{
							values[x] = (-Convert.ToDouble(output));
							x++;
						}

					}
					else
					{
						output = ReadString(input, ref i);
						if (output != "")
						{
							values[x] = (Convert.ToDouble(output));
							x++;
						}
					}
				}
				else
					i++;
			}
		}

		private string ReadString(string input, ref int i)
		{
			string output = string.Empty; //Строка для хранения выражения
										  //Читаем до разделителя или оператора, что бы получить число

			while (!isSpace(input[i]))
			{
				output += input[i++]; //Добавляем каждую цифру числа к нашей строке

				if (i == input.Length) break; //Если символ - последний, то выходим из цикла
			}
			return output;
		}

		private void nextGen_Click(object sender, EventArgs e)
		{
			
		}

        public void showModalError()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            string caption = "Error!";
            result = MessageBox.Show(@"В записи функции допущена ошибка!", caption, buttons);
            return;
        }

        public void showModalSelectFunction()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            string caption = "Error!";
            result = MessageBox.Show(@"Выберите функцию!", caption, buttons);
            return;
        }

        public void showModalSuccess()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            string caption = "Success!";
            result = MessageBox.Show(@"Функция разобрана!", caption, buttons);
            return;
        }

        private void parseFuncGA_Click(object sender, EventArgs e)
        {
            minValuesGA = new double[(int)dimensionGA.Value];
            maxValuesGA = new double[(int)dimensionGA.Value];
            ReadMinMaxValues(minCoordinatesGA.Text, minValuesGA);
            ReadMinMaxValues(maxCoordinatesGA.Text, maxValuesGA);

            if (tasksGAComboBox.SelectedItem == null)
            {
                showModalSelectFunction();
                return;
            }

            parsingGA = new FunctionParser.xFunction(tasksGAComboBox.SelectedItem.ToString());

            if (parsingGA.was_error)
            {
                showModalError();
            }
            else
            {
                showModalSuccess();
            }
        }

        private void parseFuncHC_Click(object sender, EventArgs e)
        {
            minValuesHC = new double[(int)dimensionHC.Value];
            maxValuesHC = new double[(int)dimensionHC.Value];
            ReadMinMaxValues(minCoordinatesHC.Text, minValuesHC);
            ReadMinMaxValues(maxCoordinatesHC.Text, maxValuesHC);

            if (tasksHCComboBox.SelectedItem == null)
            {
                showModalSelectFunction();
                return;
            }

            parsingHC = new FunctionParser.xFunction(tasksHCComboBox.SelectedItem.ToString());

            if (parsingHC.was_error)
            {
                showModalError();
            }
            else
            {
                showModalSuccess();
            }
        }

        private void parseFuncHS_Click(object sender, EventArgs e)
        {
            minValuesHS = new double[(int)dimensionHS.Value];
            maxValuesHS = new double[(int)dimensionHS.Value];
            ReadMinMaxValues(minCoordinatesHS.Text, minValuesHS);
            ReadMinMaxValues(maxCoordinatesHS.Text, maxValuesHS);

            if (tasksHSComboBox.SelectedItem == null)
            {
                showModalSelectFunction();
                return;
            }

            parsingHS = new FunctionParser.xFunction(tasksHSComboBox.SelectedItem.ToString());

            if (parsingHS.was_error)
            {
                showModalError();
            }
            else
            {
                showModalSuccess();
            }
        }

        private void parseFuncBA_Click(object sender, EventArgs e)
        {
            minValuesBA = new double[(int)dimensionBA.Value];
            maxValuesBA = new double[(int)dimensionBA.Value];
            ReadMinMaxValues(minCoordinatesBA.Text, minValuesBA);
            ReadMinMaxValues(maxCoordinatesBA.Text, maxValuesBA);

            if (tasksBAComboBox.SelectedItem == null)
            {
                showModalSelectFunction();
                return;
            }

            parsingBA = new FunctionParser.xFunction(tasksBAComboBox.SelectedItem.ToString());

            if (parsingBA.was_error)
            {
                showModalError();
            }
            else
            {
                showModalSuccess();
            }
        }

        private void parseFuncEMA_Click(object sender, EventArgs e)
        {
            minValuesEMA = new double[(int)dimensionEMA.Value];
            maxValuesEMA = new double[(int)dimensionEMA.Value];
            ReadMinMaxValues(minCoordinatesEMA.Text, minValuesEMA);
            ReadMinMaxValues(maxCoordinatesEMA.Text, maxValuesEMA);

            if (tasksEMAComboBox.SelectedItem == null)
            {
                showModalSelectFunction();
                return;
            }

            parsingEMA = new FunctionParser.xFunction(tasksEMAComboBox.SelectedItem.ToString());

            if (parsingEMA.was_error)
            {
                showModalError();
            }
            else
            {
                showModalSuccess();
            }
        }

        private void parseFuncGSO_Click(object sender, EventArgs e)
        {
            minValuesGSO = new double[(int)dimensionGSO.Value];
            maxValuesGSO = new double[(int)dimensionGSO.Value];
            ReadMinMaxValues(minCoordinatesGSO.Text, minValuesGSO);
            ReadMinMaxValues(maxCoordinatesGSO.Text, maxValuesGSO);

            if (tasksGSOComboBox.SelectedItem == null)
            {
                showModalSelectFunction();
                return;
            }

            parsingGSO = new FunctionParser.xFunction(tasksGSOComboBox.SelectedItem.ToString());

            if (parsingGSO.was_error)
            {
                showModalError();
            }
            else
            {
                showModalSuccess();
            }
        }

        private void parseFuncMEC_Click(object sender, EventArgs e)
        {
            minValuesMEC = new double[(int)dimensionMEC.Value];
            maxValuesMEC = new double[(int)dimensionMEC.Value];
            ReadMinMaxValues(minCoordinatesMEC.Text, minValuesMEC);
            ReadMinMaxValues(maxCoordinatesMEC.Text, maxValuesMEC);

            if (tasksMECComboBox.SelectedItem == null)
            {
                showModalSelectFunction();
                return;
            }

            parsingMEC = new FunctionParser.xFunction(tasksMECComboBox.SelectedItem.ToString());

            if (parsingMEC.was_error)
            {
                showModalError();
            }
            else
            {
                showModalSuccess();
            }
        }

        private void runAlgorithmHC_Click(object sender, EventArgs e)
        {
            HillClimb hillClimb = new HillClimb((int)dimensionHC.Value, minValuesHC.ToList(), maxValuesHC.ToList());
            HillClimb.Data = parsingHC.Data;
            hillClimb.Run((int)iterationsHC.Value, double.Parse(epsilonHC.Text));

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < hillClimb.bestPoint.Count; i++)
            {
                builder.AppendFormat("x[{0:D1}] = {1}\r\n", i, hillClimb.bestPoint[i]);
            }

            //builder.AppendLine();
            builder.AppendFormat("FinalFunc = {0}\r\n", hillClimb.bestFitness);

            builder.AppendLine();

            currStatusHC.AppendText(builder.ToString());

    }

        private void runAlgorithmHS_Click(object sender, EventArgs e)
        {
            HarmonySearch harmonySearch = new HarmonySearch(double.Parse(bwHS.Text), (int)dimensionHS.Value, double.Parse(hmcrHS.Text), (int)hmsHS.Value, double.Parse(parHS.Text), (int)maxIterHS.Value);

            harmonySearch.setBounds(minValuesHS.ToList(), maxValuesHS.ToList());

            HarmonySearch.Data = parsingHS.Data;

            harmonySearch.Run();

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < harmonySearch.bestHarmony.Length - 1; i++)
            {
                builder.AppendFormat("x[{0:D1}] = {1}\r\n", i, harmonySearch.bestHarmony[i]);
            }

            //builder.AppendLine();
            builder.AppendFormat("FinalFunc = {0}\r\n", harmonySearch.bestHarmony[harmonySearch.bestHarmony.Length - 1]);

            builder.AppendLine();

            currStatusHS.AppendText(builder.ToString());
        }

        private void runAlgorithmMEC_Click(object sender, EventArgs e)
        {
            MindEvolutionary mindEvolutionary = new MindEvolutionary((int)dimensionMEC.Value, minValuesMEC.ToList(), maxValuesMEC.ToList());

            mindEvolutionary.InitGroups((int)domainsCountMEC.Value, (int)groupsCountMEC.Value, (int)leadingGroupsCountMEC.Value, (int)laggingGroupsCountMEC.Value);

            mindEvolutionary.InitGaussian(double.Parse(muMEC.Text), double.Parse(sigmaMEC.Text));

            mindEvolutionary.Start((int)individsCountMEC.Value, parsingMEC.Data);

            mindEvolutionary.Run();

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < mindEvolutionary.leadingGroups[0].bestPoint.Count; i++)
            {
                builder.AppendFormat("x[{0:D1}] = {1}\r\n", i, mindEvolutionary.leadingGroups[0].bestPoint[i]);
            }

            //builder.AppendLine();
            builder.AppendFormat("FinalFunc = {0}\r\n", mindEvolutionary.leadingGroups[0].bestFitness);

            builder.AppendLine();

            currStatusMEC.AppendText(builder.ToString());
        }

        private void runAlgorithmBA_Click(object sender, EventArgs e)
        {
            Hive hive = new Hive((int)beesBestCountBA.Value, (int)beesSelectedCountBA.Value, (int)beesBestCountBA.Value,
                (int)selectedAreasCountBA.Value, (int)bestAreasCountBA.Value, minValuesBA.ToList(), maxValuesBA.ToList(), parsingBA.Data);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < hive.bestPosition.Count; i++)
            {
                builder.AppendFormat("x[{0:D1}] = {1}\r\n", i, hive.bestPosition[i]);
            }

            //builder.AppendLine();
            builder.AppendFormat("FinalFunc = {0}\r\n", hive.bestFitness);

            builder.AppendLine();

            currStatusBA.AppendText(builder.ToString());

        }

        private void runAlgorithmGSO_Click(object sender, EventArgs e)
        {
            FireFlyAlgorithm fireFly = new FireFlyAlgorithm((int)dimensionGSO.Value, minValuesGSO.ToList(), maxValuesGSO.ToList(), (int)firefliesCountGSO.Value);

            fireFly.InitParams(double.Parse(betaGSO.Text), double.Parse(gammaGSO.Text), double.Parse(alphaGSO.Text));

            FireFlyAlgorithm.Data = parsingGSO.Data;

            fireFly.Run((int)iterationsGSO.Value);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < fireFly.bestPosition.Count; i++)
            {
                builder.AppendFormat("x[{0:D1}] = {1}\r\n", i, fireFly.bestPosition[i]);
            }

            //builder.AppendLine();
            builder.AppendFormat("FinalFunc = {0}\r\n", fireFly.bestIntensity);

            builder.AppendLine();

            currStatusGSO.AppendText(builder.ToString());
        }

        private void runAlgorithmEMA_Click(object sender, EventArgs e)
        {
            ElectroMagnetism electroMagnetism = new ElectroMagnetism((int)dimensionEMA.Value, (int)samplePointsCountEMA.Value, minValuesEMA.ToList(), maxValuesEMA.ToList());

            ElectroMagnetism.Data = parsingEMA.Data;

            electroMagnetism.Run((int)maxIterCountEMA.Value, (int)localIterCountEMA.Value);

            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < electroMagnetism.bestPoint.Count; i++)
            {
                builder.AppendFormat("x[{0:D1}] = {1}\r\n", i, electroMagnetism.bestPoint[i]);
            }

            //builder.AppendLine();
            builder.AppendFormat("FinalFunc = {0}\r\n", electroMagnetism.bestFitness);

            builder.AppendLine();

            currStatusEMA.AppendText(builder.ToString());
        }

        private void createPopGABtn_Click(object sender, EventArgs e)
        {
            int count = (int)chromoCountGA.Value;

            // Зададим интервалы изменения хромосом
            Interval[] intervals = new Interval[count];

            for (int i = 0; i < count; i++)
            {
                //intervals[i] = new Interval (-500.0, 500.0);
                intervals[i] = new Interval(minValuesGA[i], maxValuesGA[i]);
            }

            m_Analytics.Clear();

            // Зададим параметры алгоритма
            m_Population.Reset();
            m_Population.MaxSize = (int)popSizeGA.Value;
            m_Population.MutationPossibility = int.Parse(mutationProbabilityGA.Text) / 100.0;
            m_Population.CrossPossibility = int.Parse(crossProbabilityGA.Text) / 100.0;

            // Установим свойства видов
            TaskSpecies.Intervals = intervals;
            TaskSpecies.Data = parsingGA.Data;

            // Добавим виды
            for (int i = 0; i < m_Population.MaxSize; ++i)
            {
                m_Population.Add(new TaskSpecies());
            }
            ShowData();
        }

        private void runAlgorithmGA_Click(object sender, EventArgs e)
        {
            Loop((int)nextGenCountGA.Value);
            UpdateGraph();
        }
    }
}