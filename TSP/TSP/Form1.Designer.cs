namespace NearestNeighbor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.coefAlpha = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pherIncr = new System.Windows.Forms.TextBox();
            this.pherDecr = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.totalAntsCount = new System.Windows.Forms.NumericUpDown();
            this.saveMatrix = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.beeProbMistake = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.maxTempAnneal = new System.Windows.Forms.NumericUpDown();
            this.minTempAnneal = new System.Windows.Forms.NumericUpDown();
            this.maxIterAnneal = new System.Windows.Forms.NumericUpDown();
            this.totalBeesCount = new System.Windows.Forms.NumericUpDown();
            this.activeBeesCount = new System.Windows.Forms.NumericUpDown();
            this.maxIterationsBee = new System.Windows.Forms.NumericUpDown();
            this.maxIterationsBeeColony = new System.Windows.Forms.NumericUpDown();
            this.scoutBeesCount = new System.Windows.Forms.NumericUpDown();
            this.maxIterationsHC = new System.Windows.Forms.NumericUpDown();
            this.antColonyTime = new System.Windows.Forms.NumericUpDown();
            this.pheromInfluence = new System.Windows.Forms.NumericUpDown();
            this.lengthInfluence = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAntsCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTempAnneal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTempAnneal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterAnneal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBeesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBeesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsBee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsBeeColony)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoutBeesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.antColonyTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pheromInfluence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInfluence)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(772, 529);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(747, 196);
            this.listBox1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(771, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 491);
            this.dataGridView1.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 77);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Метод ближ.соседа";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Число вершин графа:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(189, 36);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // coefAlpha
            // 
            this.coefAlpha.Location = new System.Drawing.Point(182, 197);
            this.coefAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.coefAlpha.Name = "coefAlpha";
            this.coefAlpha.Size = new System.Drawing.Size(132, 22);
            this.coefAlpha.TabIndex = 21;
            this.coefAlpha.Text = "0,8";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 248);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 28);
            this.button2.TabIndex = 22;
            this.button2.Text = "Метод отжига";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Макс.температура:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Мин.температура:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 176);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Коэф.сниж.темп:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Макс.число итераций:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Влияние длины:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "Увелич.феромона:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 357);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Уменьш.феромона:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Влияние феромона:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 486);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(213, 28);
            this.button3.TabIndex = 32;
            this.button3.Text = "Муравьиный алгоритм";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pherIncr
            // 
            this.pherIncr.Location = new System.Drawing.Point(183, 382);
            this.pherIncr.Margin = new System.Windows.Forms.Padding(4);
            this.pherIncr.Name = "pherIncr";
            this.pherIncr.Size = new System.Drawing.Size(132, 22);
            this.pherIncr.TabIndex = 31;
            this.pherIncr.Text = "2";
            // 
            // pherDecr
            // 
            this.pherDecr.Location = new System.Drawing.Point(27, 382);
            this.pherDecr.Margin = new System.Windows.Forms.Padding(4);
            this.pherDecr.Name = "pherDecr";
            this.pherDecr.Size = new System.Drawing.Size(132, 22);
            this.pherDecr.TabIndex = 29;
            this.pherDecr.Text = "0,01";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 423);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 41;
            this.label13.Text = "Время жизни:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 423);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 17);
            this.label10.TabIndex = 43;
            this.label10.Text = "Число муравьев:";
            // 
            // totalAntsCount
            // 
            this.totalAntsCount.Location = new System.Drawing.Point(182, 444);
            this.totalAntsCount.Margin = new System.Windows.Forms.Padding(4);
            this.totalAntsCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.totalAntsCount.Name = "totalAntsCount";
            this.totalAntsCount.Size = new System.Drawing.Size(133, 22);
            this.totalAntsCount.TabIndex = 44;
            this.totalAntsCount.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // saveMatrix
            // 
            this.saveMatrix.Location = new System.Drawing.Point(348, 30);
            this.saveMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.saveMatrix.Name = "saveMatrix";
            this.saveMatrix.Size = new System.Drawing.Size(167, 28);
            this.saveMatrix.TabIndex = 45;
            this.saveMatrix.Text = "Запомнить матрицу";
            this.saveMatrix.UseVisualStyleBackColor = true;
            this.saveMatrix.Click += new System.EventHandler(this.saveMatrix_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(359, 227);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 17);
            this.label11.TabIndex = 54;
            this.label11.Text = "Кол-во пчел-разведчиков:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 122);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Макс. число итераций:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(359, 176);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(158, 17);
            this.label14.TabIndex = 51;
            this.label14.Text = "Кол-во активных пчел:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(357, 122);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 17);
            this.label15.TabIndex = 50;
            this.label15.Text = "Общее кол-во пчел:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(438, 295);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 28);
            this.button4.TabIndex = 49;
            this.button4.Text = "Метод роя пчел";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(551, 176);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(202, 17);
            this.label16.TabIndex = 56;
            this.label16.Text = "Кол-во неуспешных попыток:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(554, 227);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(156, 17);
            this.label17.TabIndex = 58;
            this.label17.Text = "Вер-ть ошибки пчелы:";
            // 
            // beeProbMistake
            // 
            this.beeProbMistake.Location = new System.Drawing.Point(554, 248);
            this.beeProbMistake.Margin = new System.Windows.Forms.Padding(4);
            this.beeProbMistake.Name = "beeProbMistake";
            this.beeProbMistake.Size = new System.Drawing.Size(132, 22);
            this.beeProbMistake.TabIndex = 57;
            this.beeProbMistake.Text = "0,01";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(356, 361);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(159, 17);
            this.label23.TabIndex = 63;
            this.label23.Text = "Макс. число итераций:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(554, 376);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 28);
            this.button5.TabIndex = 62;
            this.button5.Text = "Метод подъема";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // maxTempAnneal
            // 
            this.maxTempAnneal.Location = new System.Drawing.Point(23, 150);
            this.maxTempAnneal.Margin = new System.Windows.Forms.Padding(4);
            this.maxTempAnneal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxTempAnneal.Name = "maxTempAnneal";
            this.maxTempAnneal.Size = new System.Drawing.Size(133, 22);
            this.maxTempAnneal.TabIndex = 64;
            this.maxTempAnneal.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // minTempAnneal
            // 
            this.minTempAnneal.Location = new System.Drawing.Point(23, 198);
            this.minTempAnneal.Margin = new System.Windows.Forms.Padding(4);
            this.minTempAnneal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minTempAnneal.Name = "minTempAnneal";
            this.minTempAnneal.Size = new System.Drawing.Size(133, 22);
            this.minTempAnneal.TabIndex = 65;
            this.minTempAnneal.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // maxIterAnneal
            // 
            this.maxIterAnneal.Location = new System.Drawing.Point(182, 150);
            this.maxIterAnneal.Margin = new System.Windows.Forms.Padding(4);
            this.maxIterAnneal.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxIterAnneal.Name = "maxIterAnneal";
            this.maxIterAnneal.Size = new System.Drawing.Size(133, 22);
            this.maxIterAnneal.TabIndex = 66;
            this.maxIterAnneal.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // totalBeesCount
            // 
            this.totalBeesCount.Location = new System.Drawing.Point(357, 150);
            this.totalBeesCount.Margin = new System.Windows.Forms.Padding(4);
            this.totalBeesCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.totalBeesCount.Name = "totalBeesCount";
            this.totalBeesCount.Size = new System.Drawing.Size(133, 22);
            this.totalBeesCount.TabIndex = 67;
            this.totalBeesCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // activeBeesCount
            // 
            this.activeBeesCount.Location = new System.Drawing.Point(357, 197);
            this.activeBeesCount.Margin = new System.Windows.Forms.Padding(4);
            this.activeBeesCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.activeBeesCount.Name = "activeBeesCount";
            this.activeBeesCount.Size = new System.Drawing.Size(133, 22);
            this.activeBeesCount.TabIndex = 68;
            this.activeBeesCount.Value = new decimal(new int[] {
            750,
            0,
            0,
            0});
            // 
            // maxIterationsBee
            // 
            this.maxIterationsBee.Location = new System.Drawing.Point(553, 198);
            this.maxIterationsBee.Margin = new System.Windows.Forms.Padding(4);
            this.maxIterationsBee.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxIterationsBee.Name = "maxIterationsBee";
            this.maxIterationsBee.Size = new System.Drawing.Size(133, 22);
            this.maxIterationsBee.TabIndex = 69;
            this.maxIterationsBee.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // maxIterationsBeeColony
            // 
            this.maxIterationsBeeColony.Location = new System.Drawing.Point(553, 150);
            this.maxIterationsBeeColony.Margin = new System.Windows.Forms.Padding(4);
            this.maxIterationsBeeColony.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxIterationsBeeColony.Name = "maxIterationsBeeColony";
            this.maxIterationsBeeColony.Size = new System.Drawing.Size(133, 22);
            this.maxIterationsBeeColony.TabIndex = 70;
            this.maxIterationsBeeColony.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // scoutBeesCount
            // 
            this.scoutBeesCount.Location = new System.Drawing.Point(357, 249);
            this.scoutBeesCount.Margin = new System.Windows.Forms.Padding(4);
            this.scoutBeesCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.scoutBeesCount.Name = "scoutBeesCount";
            this.scoutBeesCount.Size = new System.Drawing.Size(133, 22);
            this.scoutBeesCount.TabIndex = 71;
            this.scoutBeesCount.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // maxIterationsHC
            // 
            this.maxIterationsHC.Location = new System.Drawing.Point(357, 383);
            this.maxIterationsHC.Margin = new System.Windows.Forms.Padding(4);
            this.maxIterationsHC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxIterationsHC.Name = "maxIterationsHC";
            this.maxIterationsHC.Size = new System.Drawing.Size(133, 22);
            this.maxIterationsHC.TabIndex = 72;
            this.maxIterationsHC.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // antColonyTime
            // 
            this.antColonyTime.Location = new System.Drawing.Point(28, 444);
            this.antColonyTime.Margin = new System.Windows.Forms.Padding(4);
            this.antColonyTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.antColonyTime.Name = "antColonyTime";
            this.antColonyTime.Size = new System.Drawing.Size(133, 22);
            this.antColonyTime.TabIndex = 73;
            this.antColonyTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // pheromInfluence
            // 
            this.pheromInfluence.Location = new System.Drawing.Point(28, 323);
            this.pheromInfluence.Margin = new System.Windows.Forms.Padding(4);
            this.pheromInfluence.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.pheromInfluence.Name = "pheromInfluence";
            this.pheromInfluence.Size = new System.Drawing.Size(133, 22);
            this.pheromInfluence.TabIndex = 74;
            this.pheromInfluence.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // lengthInfluence
            // 
            this.lengthInfluence.Location = new System.Drawing.Point(182, 323);
            this.lengthInfluence.Margin = new System.Windows.Forms.Padding(4);
            this.lengthInfluence.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.lengthInfluence.Name = "lengthInfluence";
            this.lengthInfluence.Size = new System.Drawing.Size(133, 22);
            this.lengthInfluence.TabIndex = 75;
            this.lengthInfluence.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 750);
            this.Controls.Add(this.lengthInfluence);
            this.Controls.Add(this.pheromInfluence);
            this.Controls.Add(this.antColonyTime);
            this.Controls.Add(this.maxIterationsHC);
            this.Controls.Add(this.scoutBeesCount);
            this.Controls.Add(this.maxIterationsBeeColony);
            this.Controls.Add(this.maxIterationsBee);
            this.Controls.Add(this.activeBeesCount);
            this.Controls.Add(this.totalBeesCount);
            this.Controls.Add(this.maxIterAnneal);
            this.Controls.Add(this.minTempAnneal);
            this.Controls.Add(this.maxTempAnneal);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.beeProbMistake);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.saveMatrix);
            this.Controls.Add(this.totalAntsCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pherIncr);
            this.Controls.Add(this.pherDecr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.coefAlpha);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Задача о коммивояжере";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalAntsCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxTempAnneal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minTempAnneal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterAnneal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalBeesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activeBeesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsBee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsBeeColony)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoutBeesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterationsHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.antColonyTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pheromInfluence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lengthInfluence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox coefAlpha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox pherIncr;
        private System.Windows.Forms.TextBox pherDecr;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown totalAntsCount;
        private System.Windows.Forms.Button saveMatrix;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox beeProbMistake;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.NumericUpDown maxTempAnneal;
        private System.Windows.Forms.NumericUpDown minTempAnneal;
        private System.Windows.Forms.NumericUpDown maxIterAnneal;
        private System.Windows.Forms.NumericUpDown totalBeesCount;
        private System.Windows.Forms.NumericUpDown activeBeesCount;
        private System.Windows.Forms.NumericUpDown maxIterationsBee;
        private System.Windows.Forms.NumericUpDown maxIterationsBeeColony;
        private System.Windows.Forms.NumericUpDown scoutBeesCount;
        private System.Windows.Forms.NumericUpDown maxIterationsHC;
        private System.Windows.Forms.NumericUpDown antColonyTime;
        private System.Windows.Forms.NumericUpDown pheromInfluence;
        private System.Windows.Forms.NumericUpDown lengthInfluence;
    }
}

