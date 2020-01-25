using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace NearestNeighbor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataTable = new DataTable("Matrix");

            _vertexes = new List<Vertex>();
            _edges = new List<Edge>();
            _gamEdges = new List<Edge>();
        }

        private List<Vertex> _vertexes;
        private List<Edge> _edges;
        private List<Edge> _gamEdges;
        DataTable dataTable;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                string caption = "Ошибка!";
                result = MessageBox.Show("Введите число вершин графа!", caption, buttons);
                return;
            }
            else
            {
                dataTable.Columns.Clear();
                dataTable.Clear();
                dataTable.Rows.Clear();

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    DataColumn column = new DataColumn();
                    column.DataType = System.Type.GetType("System.String");
                    column.ColumnName = (i + 1).ToString();
                    dataTable.Columns.Add(column);
                }


                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    DataRow row = dataTable.NewRow();

                    for (int j = 0; j < numericUpDown1.Value; j++)
                        row[j] = "-";

                    dataTable.Rows.Add(row);
                }

                dataGridView1.DataSource = dataTable;


                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1.Columns[(i + 1).ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    dataGridView1.Rows[i].HeaderCell.Value = (i + 1).ToString();
                }
                dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                _vertexes.Clear();
                _edges.Clear();
                _gamEdges.Clear();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Value == 0)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.
                    string caption = "Ошибка!";
                    result = MessageBox.Show("Введите число вершин графа!", caption, buttons);
                    return;
                }
            }
            catch (Exception)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                string caption = "Ошибка!";
                result = MessageBox.Show("Ошибка во введенных данных!", caption, buttons);
                return;
            }
            int totalLength = Int32.MaxValue;
            string totalPath = "";

            List<Edge> tempGamEdges = new List<Edge>();
            for (int i = 0; i < _vertexes.Count; i++)
            {
                int localLength = 0;
                string path = NearestNeighbor.Algorithm(_vertexes[i], _edges, _vertexes, tempGamEdges, ref localLength);
                if (localLength < totalLength)
                {
                    totalLength = localLength;
                    totalPath = path;
                    _gamEdges = tempGamEdges.ToList();
                }
                _vertexes.ForEach(v => v.IsVisited = false);
                tempGamEdges.Clear();
            }
            listBox1.Items.Add($"Найденный путь методом ближайшего соседа: {totalPath}. Длина пути: {totalLength}" + System.Environment.NewLine);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double alpha;
            if (!Double.TryParse(this.coefAlpha.Text, out alpha))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                string caption = "Ошибка!";
                result = MessageBox.Show("Введите коэффициент снижения температуры!", caption, buttons);
                return;
            }
            
            var trail = Annealing.Algorithm((int)maxIterAnneal.Value, alpha, (int)maxTempAnneal.Value, (int)minTempAnneal.Value, _edges, _vertexes);
            listBox1.Items.Add($"Найденный путь методом отжига: {Utils.GetPathString(trail)}. Длина пути: {Utils.GetPathLength(trail)}" + System.Environment.NewLine);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pherDecr, pherIncr;

            if (!Double.TryParse(this.pherDecr.Text, out pherDecr))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                string caption = "Ошибка!";
                result = MessageBox.Show("Введите коэффициент уменьшения феромона!", caption, buttons);
                return;
            }
            if (!Double.TryParse(this.pherIncr.Text, out pherIncr))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                string caption = "Ошибка!";
                result = MessageBox.Show("Введите коэффициент увеличения феромона!", caption, buttons);
                return;
            }

            MyAntColony.alpha = (int)pheromInfluence.Value;
            MyAntColony.beta = (int)lengthInfluence.Value;
            MyAntColony.rho = pherDecr;
            MyAntColony.Q = pherIncr;

            var trail = MyAntColony.Algorithm((int)totalAntsCount.Value, _edges, _vertexes, (int)antColonyTime.Value);
            listBox1.Items.Add($"Найденный путь муравьиным алгоритмом: {Utils.GetPathString(trail)}. Длина пути: {Utils.GetPathLength(trail)}" + System.Environment.NewLine);
        }

        private void saveMatrix_Click(object sender, EventArgs e)
        {
            _vertexes = new List<Vertex>(Convert.ToInt16(numericUpDown1.Value));

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                _vertexes.Add(new Vertex(i + 1));
            }

            _edges = new List<Edge>();
            _gamEdges = new List<Edge>();

            int value;

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value.ToString() != "-" && dataGridView1.Rows[j].Cells[i].Value.ToString() != "0")
                    {
                        if (Int32.TryParse(dataGridView1.Rows[j].Cells[i].Value.ToString(), out value) == true)
                            _edges.Add(new Edge(_vertexes[j], _vertexes[i], Convert.ToInt16(dataGridView1.Rows[j].Cells[i].Value)));
                        else
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result;

                            // Displays the MessageBox.
                            string caption = "Ошибка!";
                            result = MessageBox.Show("Ошибка при вводе весов ребер!", caption, buttons);
                            return;
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double probMistake;

            if (!Double.TryParse(this.beeProbMistake.Text, out probMistake))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.
                string caption = "Ошибка!";
                result = MessageBox.Show("Введите вероятность ошибки пчелы!", caption, buttons);
                return;
            }

            Hive hive = new Hive((int)totalBeesCount.Value, (int)(totalBeesCount.Value - activeBeesCount.Value - scoutBeesCount.Value), (int)activeBeesCount.Value,
                (int)scoutBeesCount.Value,  (int)maxIterationsBeeColony.Value, (int)maxIterationsBee.Value, probMistake, _vertexes, _edges);

            //string path = hive.Algorithm(out totalLength);

            //listBox1.Items.Add($"Найденный путь методом роя пчел: {path}. Длина пути: {totalLength}" + System.Environment.NewLine);

            var trail = hive.Algorithm();
            listBox1.Items.Add($"Найденный путь методом роя пчел: {Utils.GetPathString(trail)}. Длина пути: {Utils.GetPathLength(trail)}" + System.Environment.NewLine);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int totalLength;
            var trail = HillClimb.Algorithm((int)maxIterationsHC.Value, _edges, _vertexes);

            listBox1.Items.Add($"Найденный путь методом подъема: {Utils.GetPathString(trail)}. Длина пути: {Utils.GetPathLength(trail)}" + System.Environment.NewLine);
        }
    }
}
