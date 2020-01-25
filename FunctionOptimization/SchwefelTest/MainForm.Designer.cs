namespace GeneticGUI
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label23;
            System.Windows.Forms.Label label24;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label32;
            System.Windows.Forms.Label label31;
            System.Windows.Forms.Label label29;
            System.Windows.Forms.Label label46;
            System.Windows.Forms.Label label48;
            System.Windows.Forms.Label label49;
            System.Windows.Forms.Label label55;
            System.Windows.Forms.Label label57;
            System.Windows.Forms.Label label58;
            System.Windows.Forms.Label label64;
            System.Windows.Forms.Label label66;
            System.Windows.Forms.Label label67;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label40;
            System.Windows.Forms.Label label39;
            System.Windows.Forms.Label label37;
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.runAlgorithmGA = new System.Windows.Forms.Button();
            this.nextGenCountGA = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.parseFuncGA = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.currStatusGA = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.codingCmBGA = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dimensionGA = new System.Windows.Forms.NumericUpDown();
            this.minCoordinatesGA = new System.Windows.Forms.TextBox();
            this.maxCoordinatesGA = new System.Windows.Forms.TextBox();
            this.chromoCountGA = new System.Windows.Forms.NumericUpDown();
            this.popSizeGA = new System.Windows.Forms.NumericUpDown();
            this.mutationProbabilityGA = new System.Windows.Forms.TextBox();
            this.crossProbabilityGA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tasksGAComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createPopGABtn = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabControl8 = new System.Windows.Forms.TabControl();
            this.tabPage24 = new System.Windows.Forms.TabPage();
            this.currStatusMEC = new System.Windows.Forms.TextBox();
            this.tabPage25 = new System.Windows.Forms.TabPage();
            this.zedGraphControl8 = new ZedGraph.ZedGraphControl();
            this.runAlgorithmMEC = new System.Windows.Forms.Button();
            this.parseFuncMEC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sigmaMEC = new System.Windows.Forms.TextBox();
            this.individsCountMEC = new System.Windows.Forms.NumericUpDown();
            this.groupsCountMEC = new System.Windows.Forms.NumericUpDown();
            this.laggingGroupsCountMEC = new System.Windows.Forms.NumericUpDown();
            this.muMEC = new System.Windows.Forms.TextBox();
            this.dimensionMEC = new System.Windows.Forms.NumericUpDown();
            this.minCoordinatesMEC = new System.Windows.Forms.TextBox();
            this.maxCoordinatesMEC = new System.Windows.Forms.TextBox();
            this.leadingGroupsCountMEC = new System.Windows.Forms.NumericUpDown();
            this.domainsCountMEC = new System.Windows.Forms.NumericUpDown();
            this.label74 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tasksMECComboBox = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.runAlgorithmGSO = new System.Windows.Forms.Button();
            this.parseFuncGSO = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.currStatusGSO = new System.Windows.Forms.TextBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alphaGSO = new System.Windows.Forms.TextBox();
            this.iterationsGSO = new System.Windows.Forms.NumericUpDown();
            this.label45 = new System.Windows.Forms.Label();
            this.dimensionGSO = new System.Windows.Forms.NumericUpDown();
            this.minCoordinatesGSO = new System.Windows.Forms.TextBox();
            this.maxCoordinatesGSO = new System.Windows.Forms.TextBox();
            this.firefliesCountGSO = new System.Windows.Forms.NumericUpDown();
            this.gammaGSO = new System.Windows.Forms.TextBox();
            this.betaGSO = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tasksGSOComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.runAlgorithmEMA = new System.Windows.Forms.Button();
            this.parseFuncEMA = new System.Windows.Forms.Button();
            this.tabControl4 = new System.Windows.Forms.TabControl();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.currStatusEMA = new System.Windows.Forms.TextBox();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.localIterCountEMA = new System.Windows.Forms.NumericUpDown();
            this.maxIterCountEMA = new System.Windows.Forms.NumericUpDown();
            this.dimensionEMA = new System.Windows.Forms.NumericUpDown();
            this.minCoordinatesEMA = new System.Windows.Forms.TextBox();
            this.maxCoordinatesEMA = new System.Windows.Forms.TextBox();
            this.samplePointsCountEMA = new System.Windows.Forms.NumericUpDown();
            this.label38 = new System.Windows.Forms.Label();
            this.tasksEMAComboBox = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.runAlgorithmBA = new System.Windows.Forms.Button();
            this.parseFuncBA = new System.Windows.Forms.Button();
            this.tabControl5 = new System.Windows.Forms.TabControl();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.currStatusBA = new System.Windows.Forms.TextBox();
            this.tabPage18 = new System.Windows.Forms.TabPage();
            this.zedGraphControl5 = new ZedGraph.ZedGraphControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.selectedAreasCountBA = new System.Windows.Forms.NumericUpDown();
            this.bestAreasCountBA = new System.Windows.Forms.NumericUpDown();
            this.beesSelectedCountBA = new System.Windows.Forms.NumericUpDown();
            this.beesBestCountBA = new System.Windows.Forms.NumericUpDown();
            this.label41 = new System.Windows.Forms.Label();
            this.dimensionBA = new System.Windows.Forms.NumericUpDown();
            this.minCoordinatesBA = new System.Windows.Forms.TextBox();
            this.maxCoordinatesBA = new System.Windows.Forms.TextBox();
            this.beesScoutCountBA = new System.Windows.Forms.NumericUpDown();
            this.label47 = new System.Windows.Forms.Label();
            this.tasksBAComboBox = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.runAlgorithmHS = new System.Windows.Forms.Button();
            this.parseFuncHS = new System.Windows.Forms.Button();
            this.tabControl6 = new System.Windows.Forms.TabControl();
            this.tabPage19 = new System.Windows.Forms.TabPage();
            this.currStatusHS = new System.Windows.Forms.TextBox();
            this.tabPage20 = new System.Windows.Forms.TabPage();
            this.zedGraphControl6 = new ZedGraph.ZedGraphControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.hmsHS = new System.Windows.Forms.NumericUpDown();
            this.bwHS = new System.Windows.Forms.TextBox();
            this.maxIterHS = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.dimensionHS = new System.Windows.Forms.NumericUpDown();
            this.minCoordinatesHS = new System.Windows.Forms.TextBox();
            this.maxCoordinatesHS = new System.Windows.Forms.TextBox();
            this.parHS = new System.Windows.Forms.NumericUpDown();
            this.hmcrHS = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.tasksHSComboBox = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.tabPage21 = new System.Windows.Forms.TabPage();
            this.runAlgorithmHC = new System.Windows.Forms.Button();
            this.parseFuncHC = new System.Windows.Forms.Button();
            this.tabControl7 = new System.Windows.Forms.TabControl();
            this.tabPage22 = new System.Windows.Forms.TabPage();
            this.currStatusHC = new System.Windows.Forms.TextBox();
            this.tabPage23 = new System.Windows.Forms.TabPage();
            this.zedGraphControl7 = new ZedGraph.ZedGraphControl();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dimensionHC = new System.Windows.Forms.NumericUpDown();
            this.minCoordinatesHC = new System.Windows.Forms.TextBox();
            this.maxCoordinatesHC = new System.Windows.Forms.TextBox();
            this.iterationsHC = new System.Windows.Forms.NumericUpDown();
            this.epsilonHC = new System.Windows.Forms.TextBox();
            this.label65 = new System.Windows.Forms.Label();
            this.tasksHCComboBox = new System.Windows.Forms.ComboBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.numericUpDown25 = new System.Windows.Forms.NumericUpDown();
            this.label36 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.numericUpDown12 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown11 = new System.Windows.Forms.NumericUpDown();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.numericUpDown10 = new System.Windows.Forms.NumericUpDown();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.textBox11 = new System.Windows.Forms.TextBox();
            label21 = new System.Windows.Forms.Label();
            label23 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label32 = new System.Windows.Forms.Label();
            label31 = new System.Windows.Forms.Label();
            label29 = new System.Windows.Forms.Label();
            label46 = new System.Windows.Forms.Label();
            label48 = new System.Windows.Forms.Label();
            label49 = new System.Windows.Forms.Label();
            label55 = new System.Windows.Forms.Label();
            label57 = new System.Windows.Forms.Label();
            label58 = new System.Windows.Forms.Label();
            label64 = new System.Windows.Forms.Label();
            label66 = new System.Windows.Forms.Label();
            label67 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label40 = new System.Windows.Forms.Label();
            label39 = new System.Windows.Forms.Label();
            label37 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextGenCountGA)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chromoCountGA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popSizeGA)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.tabControl8.SuspendLayout();
            this.tabPage24.SuspendLayout();
            this.tabPage25.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individsCountMEC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsCountMEC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laggingGroupsCountMEC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionMEC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadingGroupsCountMEC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainsCountMEC)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsGSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGSO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firefliesCountGSO)).BeginInit();
            this.tabPage11.SuspendLayout();
            this.tabControl4.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localIterCountEMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterCountEMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionEMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplePointsCountEMA)).BeginInit();
            this.tabPage16.SuspendLayout();
            this.tabControl5.SuspendLayout();
            this.tabPage17.SuspendLayout();
            this.tabPage18.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedAreasCountBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestAreasCountBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beesSelectedCountBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beesBestCountBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionBA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beesScoutCountBA)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl6.SuspendLayout();
            this.tabPage19.SuspendLayout();
            this.tabPage20.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hmsHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionHS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parHS)).BeginInit();
            this.tabPage21.SuspendLayout();
            this.tabControl7.SuspendLayout();
            this.tabPage22.SuspendLayout();
            this.tabPage23.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsHC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).BeginInit();
            this.SuspendLayout();
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(8, 66);
            label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(149, 17);
            label21.TabIndex = 77;
            label21.Text = "Размерность задачи:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new System.Drawing.Point(8, 137);
            label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label23.Name = "label23";
            label23.Size = new System.Drawing.Size(252, 17);
            label23.TabIndex = 78;
            label23.Text = "Максимальные значения координат:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new System.Drawing.Point(8, 105);
            label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(246, 17);
            label24.TabIndex = 76;
            label24.Text = "Минимальные значения координат:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(8, 66);
            label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(149, 17);
            label11.TabIndex = 77;
            label11.Text = "Размерность задачи:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(8, 137);
            label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(252, 17);
            label13.TabIndex = 78;
            label13.Text = "Максимальные значения координат:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(8, 105);
            label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(246, 17);
            label14.TabIndex = 76;
            label14.Text = "Минимальные значения координат:";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new System.Drawing.Point(8, 105);
            label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label32.Name = "label32";
            label32.Size = new System.Drawing.Size(246, 17);
            label32.TabIndex = 76;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new System.Drawing.Point(8, 137);
            label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label31.Name = "label31";
            label31.Size = new System.Drawing.Size(252, 17);
            label31.TabIndex = 78;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new System.Drawing.Point(8, 66);
            label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label29.Name = "label29";
            label29.Size = new System.Drawing.Size(145, 17);
            label29.TabIndex = 77;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new System.Drawing.Point(8, 66);
            label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label46.Name = "label46";
            label46.Size = new System.Drawing.Size(149, 17);
            label46.TabIndex = 77;
            label46.Text = "Размерность задачи:";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Location = new System.Drawing.Point(8, 137);
            label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label48.Name = "label48";
            label48.Size = new System.Drawing.Size(252, 17);
            label48.TabIndex = 78;
            label48.Text = "Максимальные значения координат:";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Location = new System.Drawing.Point(8, 105);
            label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label49.Name = "label49";
            label49.Size = new System.Drawing.Size(246, 17);
            label49.TabIndex = 76;
            label49.Text = "Минимальные значения координат:";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.Location = new System.Drawing.Point(8, 66);
            label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label55.Name = "label55";
            label55.Size = new System.Drawing.Size(149, 17);
            label55.TabIndex = 77;
            label55.Text = "Размерность задачи:";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Location = new System.Drawing.Point(8, 137);
            label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label57.Name = "label57";
            label57.Size = new System.Drawing.Size(252, 17);
            label57.TabIndex = 78;
            label57.Text = "Максимальные значения координат:";
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Location = new System.Drawing.Point(8, 105);
            label58.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label58.Name = "label58";
            label58.Size = new System.Drawing.Size(246, 17);
            label58.TabIndex = 76;
            label58.Text = "Минимальные значения координат:";
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Location = new System.Drawing.Point(8, 66);
            label64.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label64.Name = "label64";
            label64.Size = new System.Drawing.Size(149, 17);
            label64.TabIndex = 77;
            label64.Text = "Размерность задачи:";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Location = new System.Drawing.Point(8, 137);
            label66.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label66.Name = "label66";
            label66.Size = new System.Drawing.Size(252, 17);
            label66.TabIndex = 78;
            label66.Text = "Максимальные значения координат:";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.Location = new System.Drawing.Point(8, 105);
            label67.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label67.Name = "label67";
            label67.Size = new System.Drawing.Size(246, 17);
            label67.TabIndex = 76;
            label67.Text = "Минимальные значения координат:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(8, 105);
            label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(246, 17);
            label9.TabIndex = 76;
            label9.Text = "Минимальные значения координат:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(8, 137);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(252, 17);
            label4.TabIndex = 78;
            label4.Text = "Максимальные значения координат:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(8, 66);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(149, 17);
            label5.TabIndex = 77;
            label5.Text = "Размерность задачи:";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Location = new System.Drawing.Point(8, 105);
            label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label40.Name = "label40";
            label40.Size = new System.Drawing.Size(246, 17);
            label40.TabIndex = 76;
            label40.Text = "Минимальные значения координат:";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Location = new System.Drawing.Point(8, 137);
            label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label39.Name = "label39";
            label39.Size = new System.Drawing.Size(252, 17);
            label39.TabIndex = 78;
            label39.Text = "Максимальные значения координат:";
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new System.Drawing.Point(8, 66);
            label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label37.Name = "label37";
            label37.Size = new System.Drawing.Size(149, 17);
            label37.TabIndex = 77;
            label37.Text = "Размерность задачи:";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.Filter = "*.txt|*.txt|Все файлы|*.*";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage16);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage21);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1409, 593);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.runAlgorithmGA);
            this.tabPage1.Controls.Add(this.nextGenCountGA);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.parseFuncGA);
            this.tabPage1.Controls.Add(this.tabControl);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.createPopGABtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1401, 564);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "GA";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // runAlgorithmGA
            // 
            this.runAlgorithmGA.Location = new System.Drawing.Point(75, 508);
            this.runAlgorithmGA.Margin = new System.Windows.Forms.Padding(4);
            this.runAlgorithmGA.Name = "runAlgorithmGA";
            this.runAlgorithmGA.Size = new System.Drawing.Size(331, 28);
            this.runAlgorithmGA.TabIndex = 89;
            this.runAlgorithmGA.Text = "Запуск алгоритма";
            this.runAlgorithmGA.Click += new System.EventHandler(this.runAlgorithmGA_Click);
            // 
            // nextGenCountGA
            // 
            this.nextGenCountGA.Location = new System.Drawing.Point(273, 468);
            this.nextGenCountGA.Margin = new System.Windows.Forms.Padding(4);
            this.nextGenCountGA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nextGenCountGA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nextGenCountGA.Name = "nextGenCountGA";
            this.nextGenCountGA.Size = new System.Drawing.Size(133, 22);
            this.nextGenCountGA.TabIndex = 87;
            this.nextGenCountGA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 470);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 17);
            this.label6.TabIndex = 88;
            this.label6.Text = "Пропустить поколений:";
            // 
            // parseFuncGA
            // 
            this.parseFuncGA.Location = new System.Drawing.Point(75, 378);
            this.parseFuncGA.Margin = new System.Windows.Forms.Padding(4);
            this.parseFuncGA.Name = "parseFuncGA";
            this.parseFuncGA.Size = new System.Drawing.Size(331, 28);
            this.parseFuncGA.TabIndex = 85;
            this.parseFuncGA.Text = "Парсинг функции";
            this.parseFuncGA.Click += new System.EventHandler(this.parseFuncGA_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(526, 16);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(815, 520);
            this.tabControl.TabIndex = 84;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.currStatusGA);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(807, 491);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Решение";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // currStatusGA
            // 
            this.currStatusGA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currStatusGA.Location = new System.Drawing.Point(4, 4);
            this.currStatusGA.Margin = new System.Windows.Forms.Padding(4);
            this.currStatusGA.Multiline = true;
            this.currStatusGA.Name = "currStatusGA";
            this.currStatusGA.ReadOnly = true;
            this.currStatusGA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.currStatusGA.Size = new System.Drawing.Size(799, 483);
            this.currStatusGA.TabIndex = 73;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.zedGraph);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(807, 491);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Сходимость";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // zedGraph
            // 
            this.zedGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraph.IsEnableHZoom = false;
            this.zedGraph.IsShowContextMenu = false;
            this.zedGraph.IsShowCopyMessage = false;
            this.zedGraph.Location = new System.Drawing.Point(4, 4);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(799, 483);
            this.zedGraph.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.codingCmBGA);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dimensionGA);
            this.groupBox1.Controls.Add(this.minCoordinatesGA);
            this.groupBox1.Controls.Add(this.maxCoordinatesGA);
            this.groupBox1.Controls.Add(this.chromoCountGA);
            this.groupBox1.Controls.Add(this.popSizeGA);
            this.groupBox1.Controls.Add(this.mutationProbabilityGA);
            this.groupBox1.Controls.Add(this.crossProbabilityGA);
            this.groupBox1.Controls.Add(label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(label4);
            this.groupBox1.Controls.Add(this.tasksGAComboBox);
            this.groupBox1.Controls.Add(label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 344);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры генетического алгоритма";
            // 
            // codingCmBGA
            // 
            this.codingCmBGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codingCmBGA.FormattingEnabled = true;
            this.codingCmBGA.Items.AddRange(new object[] {
            "Двоичное  кодирование",
            "Вещественное кодирование"});
            this.codingCmBGA.Location = new System.Drawing.Point(184, 299);
            this.codingCmBGA.Margin = new System.Windows.Forms.Padding(4);
            this.codingCmBGA.Name = "codingCmBGA";
            this.codingCmBGA.Size = new System.Drawing.Size(273, 24);
            this.codingCmBGA.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 94;
            this.label7.Text = "Кодирование:";
            // 
            // dimensionGA
            // 
            this.dimensionGA.Location = new System.Drawing.Point(324, 68);
            this.dimensionGA.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionGA.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionGA.Name = "dimensionGA";
            this.dimensionGA.Size = new System.Drawing.Size(133, 22);
            this.dimensionGA.TabIndex = 91;
            this.dimensionGA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // minCoordinatesGA
            // 
            this.minCoordinatesGA.Location = new System.Drawing.Point(324, 100);
            this.minCoordinatesGA.Margin = new System.Windows.Forms.Padding(4);
            this.minCoordinatesGA.Name = "minCoordinatesGA";
            this.minCoordinatesGA.Size = new System.Drawing.Size(132, 22);
            this.minCoordinatesGA.TabIndex = 93;
            this.minCoordinatesGA.Text = "-5,0;-5,0";
            // 
            // maxCoordinatesGA
            // 
            this.maxCoordinatesGA.Location = new System.Drawing.Point(324, 132);
            this.maxCoordinatesGA.Margin = new System.Windows.Forms.Padding(4);
            this.maxCoordinatesGA.Name = "maxCoordinatesGA";
            this.maxCoordinatesGA.Size = new System.Drawing.Size(132, 22);
            this.maxCoordinatesGA.TabIndex = 92;
            this.maxCoordinatesGA.Text = "5,0;5,0";
            // 
            // chromoCountGA
            // 
            this.chromoCountGA.Location = new System.Drawing.Point(324, 260);
            this.chromoCountGA.Margin = new System.Windows.Forms.Padding(4);
            this.chromoCountGA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.chromoCountGA.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.chromoCountGA.Name = "chromoCountGA";
            this.chromoCountGA.Size = new System.Drawing.Size(133, 22);
            this.chromoCountGA.TabIndex = 89;
            this.chromoCountGA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // popSizeGA
            // 
            this.popSizeGA.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.popSizeGA.Location = new System.Drawing.Point(324, 164);
            this.popSizeGA.Margin = new System.Windows.Forms.Padding(4);
            this.popSizeGA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.popSizeGA.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.popSizeGA.Name = "popSizeGA";
            this.popSizeGA.Size = new System.Drawing.Size(133, 22);
            this.popSizeGA.TabIndex = 90;
            this.popSizeGA.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // mutationProbabilityGA
            // 
            this.mutationProbabilityGA.Location = new System.Drawing.Point(324, 228);
            this.mutationProbabilityGA.Margin = new System.Windows.Forms.Padding(4);
            this.mutationProbabilityGA.Name = "mutationProbabilityGA";
            this.mutationProbabilityGA.Size = new System.Drawing.Size(132, 22);
            this.mutationProbabilityGA.TabIndex = 87;
            this.mutationProbabilityGA.Text = "10";
            // 
            // crossProbabilityGA
            // 
            this.crossProbabilityGA.Location = new System.Drawing.Point(324, 196);
            this.crossProbabilityGA.Margin = new System.Windows.Forms.Padding(4);
            this.crossProbabilityGA.Name = "crossProbabilityGA";
            this.crossProbabilityGA.Size = new System.Drawing.Size(132, 22);
            this.crossProbabilityGA.TabIndex = 88;
            this.crossProbabilityGA.Text = "90";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 76;
            this.label3.Text = "Целевая функция:";
            // 
            // tasksGAComboBox
            // 
            this.tasksGAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksGAComboBox.FormattingEnabled = true;
            this.tasksGAComboBox.Location = new System.Drawing.Point(184, 23);
            this.tasksGAComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tasksGAComboBox.Name = "tasksGAComboBox";
            this.tasksGAComboBox.Size = new System.Drawing.Size(272, 24);
            this.tasksGAComboBox.TabIndex = 75;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество хромосом:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Вероятность мутации (%):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Размер популяции:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Вероятность скрещивания (%):";
            // 
            // createPopGABtn
            // 
            this.createPopGABtn.Location = new System.Drawing.Point(75, 423);
            this.createPopGABtn.Margin = new System.Windows.Forms.Padding(4);
            this.createPopGABtn.Name = "createPopGABtn";
            this.createPopGABtn.Size = new System.Drawing.Size(331, 28);
            this.createPopGABtn.TabIndex = 82;
            this.createPopGABtn.Text = "Создать популяцию";
            this.createPopGABtn.Click += new System.EventHandler(this.createPopGABtn_Click);
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tabControl8);
            this.tabPage8.Controls.Add(this.runAlgorithmMEC);
            this.tabPage8.Controls.Add(this.parseFuncMEC);
            this.tabPage8.Controls.Add(this.groupBox3);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1401, 564);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "MEC";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabControl8
            // 
            this.tabControl8.Controls.Add(this.tabPage24);
            this.tabControl8.Controls.Add(this.tabPage25);
            this.tabControl8.Location = new System.Drawing.Point(526, 16);
            this.tabControl8.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl8.Name = "tabControl8";
            this.tabControl8.SelectedIndex = 0;
            this.tabControl8.Size = new System.Drawing.Size(815, 520);
            this.tabControl8.TabIndex = 90;
            // 
            // tabPage24
            // 
            this.tabPage24.Controls.Add(this.currStatusMEC);
            this.tabPage24.Location = new System.Drawing.Point(4, 25);
            this.tabPage24.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage24.Name = "tabPage24";
            this.tabPage24.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage24.Size = new System.Drawing.Size(807, 491);
            this.tabPage24.TabIndex = 0;
            this.tabPage24.Text = "Решение";
            this.tabPage24.UseVisualStyleBackColor = true;
            // 
            // currStatusMEC
            // 
            this.currStatusMEC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currStatusMEC.Location = new System.Drawing.Point(4, 4);
            this.currStatusMEC.Margin = new System.Windows.Forms.Padding(4);
            this.currStatusMEC.Multiline = true;
            this.currStatusMEC.Name = "currStatusMEC";
            this.currStatusMEC.ReadOnly = true;
            this.currStatusMEC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.currStatusMEC.Size = new System.Drawing.Size(799, 483);
            this.currStatusMEC.TabIndex = 73;
            // 
            // tabPage25
            // 
            this.tabPage25.Controls.Add(this.zedGraphControl8);
            this.tabPage25.Location = new System.Drawing.Point(4, 25);
            this.tabPage25.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage25.Name = "tabPage25";
            this.tabPage25.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage25.Size = new System.Drawing.Size(807, 491);
            this.tabPage25.TabIndex = 1;
            this.tabPage25.Text = "Сходимость";
            this.tabPage25.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl8
            // 
            this.zedGraphControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl8.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl8.IsEnableHZoom = false;
            this.zedGraphControl8.IsShowContextMenu = false;
            this.zedGraphControl8.IsShowCopyMessage = false;
            this.zedGraphControl8.Location = new System.Drawing.Point(4, 4);
            this.zedGraphControl8.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl8.Name = "zedGraphControl8";
            this.zedGraphControl8.ScrollGrace = 0D;
            this.zedGraphControl8.ScrollMaxX = 0D;
            this.zedGraphControl8.ScrollMaxY = 0D;
            this.zedGraphControl8.ScrollMaxY2 = 0D;
            this.zedGraphControl8.ScrollMinX = 0D;
            this.zedGraphControl8.ScrollMinY = 0D;
            this.zedGraphControl8.ScrollMinY2 = 0D;
            this.zedGraphControl8.Size = new System.Drawing.Size(799, 483);
            this.zedGraphControl8.TabIndex = 0;
            // 
            // runAlgorithmMEC
            // 
            this.runAlgorithmMEC.Location = new System.Drawing.Point(86, 469);
            this.runAlgorithmMEC.Margin = new System.Windows.Forms.Padding(4);
            this.runAlgorithmMEC.Name = "runAlgorithmMEC";
            this.runAlgorithmMEC.Size = new System.Drawing.Size(331, 28);
            this.runAlgorithmMEC.TabIndex = 89;
            this.runAlgorithmMEC.Text = "Запуск алгоритма";
            this.runAlgorithmMEC.Click += new System.EventHandler(this.runAlgorithmMEC_Click);
            // 
            // parseFuncMEC
            // 
            this.parseFuncMEC.Location = new System.Drawing.Point(86, 427);
            this.parseFuncMEC.Margin = new System.Windows.Forms.Padding(4);
            this.parseFuncMEC.Name = "parseFuncMEC";
            this.parseFuncMEC.Size = new System.Drawing.Size(331, 28);
            this.parseFuncMEC.TabIndex = 85;
            this.parseFuncMEC.Text = "Парсинг функции";
            this.parseFuncMEC.Click += new System.EventHandler(this.parseFuncMEC_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.sigmaMEC);
            this.groupBox3.Controls.Add(this.individsCountMEC);
            this.groupBox3.Controls.Add(this.groupsCountMEC);
            this.groupBox3.Controls.Add(this.laggingGroupsCountMEC);
            this.groupBox3.Controls.Add(this.muMEC);
            this.groupBox3.Controls.Add(this.dimensionMEC);
            this.groupBox3.Controls.Add(this.minCoordinatesMEC);
            this.groupBox3.Controls.Add(this.maxCoordinatesMEC);
            this.groupBox3.Controls.Add(this.leadingGroupsCountMEC);
            this.groupBox3.Controls.Add(this.domainsCountMEC);
            this.groupBox3.Controls.Add(this.label74);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Controls.Add(this.label73);
            this.groupBox3.Controls.Add(label21);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(label23);
            this.groupBox3.Controls.Add(this.tasksMECComboBox);
            this.groupBox3.Controls.Add(label24);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.label28);
            this.groupBox3.Location = new System.Drawing.Point(25, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(465, 394);
            this.groupBox3.TabIndex = 83;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры алгоритма эволюции разума";
            // 
            // sigmaMEC
            // 
            this.sigmaMEC.Location = new System.Drawing.Point(324, 361);
            this.sigmaMEC.Margin = new System.Windows.Forms.Padding(4);
            this.sigmaMEC.Name = "sigmaMEC";
            this.sigmaMEC.Size = new System.Drawing.Size(132, 22);
            this.sigmaMEC.TabIndex = 100;
            this.sigmaMEC.Text = "1";
            // 
            // individsCountMEC
            // 
            this.individsCountMEC.Location = new System.Drawing.Point(324, 228);
            this.individsCountMEC.Margin = new System.Windows.Forms.Padding(4);
            this.individsCountMEC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.individsCountMEC.Name = "individsCountMEC";
            this.individsCountMEC.Size = new System.Drawing.Size(133, 22);
            this.individsCountMEC.TabIndex = 99;
            this.individsCountMEC.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupsCountMEC
            // 
            this.groupsCountMEC.Location = new System.Drawing.Point(324, 196);
            this.groupsCountMEC.Margin = new System.Windows.Forms.Padding(4);
            this.groupsCountMEC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.groupsCountMEC.Name = "groupsCountMEC";
            this.groupsCountMEC.Size = new System.Drawing.Size(133, 22);
            this.groupsCountMEC.TabIndex = 98;
            this.groupsCountMEC.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // laggingGroupsCountMEC
            // 
            this.laggingGroupsCountMEC.Location = new System.Drawing.Point(324, 295);
            this.laggingGroupsCountMEC.Margin = new System.Windows.Forms.Padding(4);
            this.laggingGroupsCountMEC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.laggingGroupsCountMEC.Name = "laggingGroupsCountMEC";
            this.laggingGroupsCountMEC.Size = new System.Drawing.Size(133, 22);
            this.laggingGroupsCountMEC.TabIndex = 97;
            this.laggingGroupsCountMEC.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // muMEC
            // 
            this.muMEC.Location = new System.Drawing.Point(324, 327);
            this.muMEC.Margin = new System.Windows.Forms.Padding(4);
            this.muMEC.Name = "muMEC";
            this.muMEC.Size = new System.Drawing.Size(132, 22);
            this.muMEC.TabIndex = 94;
            this.muMEC.Text = "0";
            // 
            // dimensionMEC
            // 
            this.dimensionMEC.Location = new System.Drawing.Point(324, 68);
            this.dimensionMEC.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionMEC.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionMEC.Name = "dimensionMEC";
            this.dimensionMEC.Size = new System.Drawing.Size(133, 22);
            this.dimensionMEC.TabIndex = 91;
            this.dimensionMEC.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // minCoordinatesMEC
            // 
            this.minCoordinatesMEC.Location = new System.Drawing.Point(324, 100);
            this.minCoordinatesMEC.Margin = new System.Windows.Forms.Padding(4);
            this.minCoordinatesMEC.Name = "minCoordinatesMEC";
            this.minCoordinatesMEC.Size = new System.Drawing.Size(132, 22);
            this.minCoordinatesMEC.TabIndex = 93;
            this.minCoordinatesMEC.Text = "-5,0;-5,0";
            // 
            // maxCoordinatesMEC
            // 
            this.maxCoordinatesMEC.Location = new System.Drawing.Point(324, 132);
            this.maxCoordinatesMEC.Margin = new System.Windows.Forms.Padding(4);
            this.maxCoordinatesMEC.Name = "maxCoordinatesMEC";
            this.maxCoordinatesMEC.Size = new System.Drawing.Size(132, 22);
            this.maxCoordinatesMEC.TabIndex = 92;
            this.maxCoordinatesMEC.Text = "5,0;5,0";
            // 
            // leadingGroupsCountMEC
            // 
            this.leadingGroupsCountMEC.Location = new System.Drawing.Point(324, 260);
            this.leadingGroupsCountMEC.Margin = new System.Windows.Forms.Padding(4);
            this.leadingGroupsCountMEC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.leadingGroupsCountMEC.Name = "leadingGroupsCountMEC";
            this.leadingGroupsCountMEC.Size = new System.Drawing.Size(133, 22);
            this.leadingGroupsCountMEC.TabIndex = 89;
            this.leadingGroupsCountMEC.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // domainsCountMEC
            // 
            this.domainsCountMEC.Location = new System.Drawing.Point(324, 164);
            this.domainsCountMEC.Margin = new System.Windows.Forms.Padding(4);
            this.domainsCountMEC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.domainsCountMEC.Name = "domainsCountMEC";
            this.domainsCountMEC.Size = new System.Drawing.Size(133, 22);
            this.domainsCountMEC.TabIndex = 90;
            this.domainsCountMEC.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Location = new System.Drawing.Point(8, 366);
            this.label74.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(85, 17);
            this.label74.TabIndex = 86;
            this.label74.Text = "Дисперсия:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 333);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(107, 17);
            this.label20.TabIndex = 84;
            this.label20.Text = "Мат.ожидание:";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Location = new System.Drawing.Point(8, 295);
            this.label73.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(206, 17);
            this.label73.TabIndex = 81;
            this.label73.Text = "Количество отстающих групп:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 23);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(131, 17);
            this.label22.TabIndex = 76;
            this.label22.Text = "Целевая функция:";
            // 
            // tasksMECComboBox
            // 
            this.tasksMECComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksMECComboBox.FormattingEnabled = true;
            this.tasksMECComboBox.Location = new System.Drawing.Point(184, 23);
            this.tasksMECComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tasksMECComboBox.Name = "tasksMECComboBox";
            this.tasksMECComboBox.Size = new System.Drawing.Size(272, 24);
            this.tasksMECComboBox.TabIndex = 75;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 260);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(216, 17);
            this.label25.TabIndex = 0;
            this.label25.Text = "Количество лидирующих групп:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 228);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(200, 17);
            this.label26.TabIndex = 0;
            this.label26.Text = "Количество особей в группе:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(8, 164);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(150, 17);
            this.label27.TabIndex = 0;
            this.label27.Text = "Количество доменов:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 196);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(194, 17);
            this.label28.TabIndex = 0;
            this.label28.Text = "Количество групп в домене:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.runAlgorithmGSO);
            this.tabPage5.Controls.Add(this.parseFuncGSO);
            this.tabPage5.Controls.Add(this.tabControl2);
            this.tabPage5.Controls.Add(this.groupBox2);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1401, 564);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "GSO";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // runAlgorithmGSO
            // 
            this.runAlgorithmGSO.Location = new System.Drawing.Point(88, 423);
            this.runAlgorithmGSO.Margin = new System.Windows.Forms.Padding(4);
            this.runAlgorithmGSO.Name = "runAlgorithmGSO";
            this.runAlgorithmGSO.Size = new System.Drawing.Size(331, 28);
            this.runAlgorithmGSO.TabIndex = 97;
            this.runAlgorithmGSO.Text = "Запуск алгоритма";
            this.runAlgorithmGSO.Click += new System.EventHandler(this.runAlgorithmGSO_Click);
            // 
            // parseFuncGSO
            // 
            this.parseFuncGSO.Location = new System.Drawing.Point(88, 381);
            this.parseFuncGSO.Margin = new System.Windows.Forms.Padding(4);
            this.parseFuncGSO.Name = "parseFuncGSO";
            this.parseFuncGSO.Size = new System.Drawing.Size(331, 28);
            this.parseFuncGSO.TabIndex = 96;
            this.parseFuncGSO.Text = "Парсинг функции";
            this.parseFuncGSO.Click += new System.EventHandler(this.parseFuncGSO_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(526, 16);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(815, 520);
            this.tabControl2.TabIndex = 84;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.currStatusGSO);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage6.Size = new System.Drawing.Size(807, 491);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "Решение";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // currStatusGSO
            // 
            this.currStatusGSO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currStatusGSO.Location = new System.Drawing.Point(4, 4);
            this.currStatusGSO.Margin = new System.Windows.Forms.Padding(4);
            this.currStatusGSO.Multiline = true;
            this.currStatusGSO.Name = "currStatusGSO";
            this.currStatusGSO.ReadOnly = true;
            this.currStatusGSO.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.currStatusGSO.Size = new System.Drawing.Size(799, 483);
            this.currStatusGSO.TabIndex = 73;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.zedGraphControl1);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage7.Size = new System.Drawing.Size(807, 491);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "Сходимость";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl1.IsEnableHZoom = false;
            this.zedGraphControl1.IsShowContextMenu = false;
            this.zedGraphControl1.IsShowCopyMessage = false;
            this.zedGraphControl1.Location = new System.Drawing.Point(4, 4);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(799, 483);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alphaGSO);
            this.groupBox2.Controls.Add(this.iterationsGSO);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.dimensionGSO);
            this.groupBox2.Controls.Add(this.minCoordinatesGSO);
            this.groupBox2.Controls.Add(this.maxCoordinatesGSO);
            this.groupBox2.Controls.Add(this.firefliesCountGSO);
            this.groupBox2.Controls.Add(this.gammaGSO);
            this.groupBox2.Controls.Add(this.betaGSO);
            this.groupBox2.Controls.Add(label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(label13);
            this.groupBox2.Controls.Add(this.tasksGSOComboBox);
            this.groupBox2.Controls.Add(label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(25, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(466, 337);
            this.groupBox2.TabIndex = 83;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры алгоритма светлячков";
            // 
            // alphaGSO
            // 
            this.alphaGSO.Location = new System.Drawing.Point(324, 260);
            this.alphaGSO.Margin = new System.Windows.Forms.Padding(4);
            this.alphaGSO.Name = "alphaGSO";
            this.alphaGSO.Size = new System.Drawing.Size(132, 22);
            this.alphaGSO.TabIndex = 103;
            this.alphaGSO.Text = "0,2";
            // 
            // iterationsGSO
            // 
            this.iterationsGSO.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.iterationsGSO.Location = new System.Drawing.Point(323, 290);
            this.iterationsGSO.Margin = new System.Windows.Forms.Padding(4);
            this.iterationsGSO.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterationsGSO.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.iterationsGSO.Name = "iterationsGSO";
            this.iterationsGSO.Size = new System.Drawing.Size(133, 22);
            this.iterationsGSO.TabIndex = 102;
            this.iterationsGSO.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(7, 290);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(120, 17);
            this.label45.TabIndex = 101;
            this.label45.Text = "Число итераций:";
            // 
            // dimensionGSO
            // 
            this.dimensionGSO.Location = new System.Drawing.Point(324, 68);
            this.dimensionGSO.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionGSO.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionGSO.Name = "dimensionGSO";
            this.dimensionGSO.Size = new System.Drawing.Size(133, 22);
            this.dimensionGSO.TabIndex = 98;
            this.dimensionGSO.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // minCoordinatesGSO
            // 
            this.minCoordinatesGSO.Location = new System.Drawing.Point(324, 100);
            this.minCoordinatesGSO.Margin = new System.Windows.Forms.Padding(4);
            this.minCoordinatesGSO.Name = "minCoordinatesGSO";
            this.minCoordinatesGSO.Size = new System.Drawing.Size(132, 22);
            this.minCoordinatesGSO.TabIndex = 100;
            this.minCoordinatesGSO.Text = "-5,0;-5,0";
            // 
            // maxCoordinatesGSO
            // 
            this.maxCoordinatesGSO.Location = new System.Drawing.Point(324, 132);
            this.maxCoordinatesGSO.Margin = new System.Windows.Forms.Padding(4);
            this.maxCoordinatesGSO.Name = "maxCoordinatesGSO";
            this.maxCoordinatesGSO.Size = new System.Drawing.Size(132, 22);
            this.maxCoordinatesGSO.TabIndex = 99;
            this.maxCoordinatesGSO.Text = "5,0;5,0";
            // 
            // firefliesCountGSO
            // 
            this.firefliesCountGSO.Location = new System.Drawing.Point(324, 164);
            this.firefliesCountGSO.Margin = new System.Windows.Forms.Padding(4);
            this.firefliesCountGSO.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.firefliesCountGSO.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.firefliesCountGSO.Name = "firefliesCountGSO";
            this.firefliesCountGSO.Size = new System.Drawing.Size(133, 22);
            this.firefliesCountGSO.TabIndex = 97;
            this.firefliesCountGSO.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // gammaGSO
            // 
            this.gammaGSO.Location = new System.Drawing.Point(324, 228);
            this.gammaGSO.Margin = new System.Windows.Forms.Padding(4);
            this.gammaGSO.Name = "gammaGSO";
            this.gammaGSO.Size = new System.Drawing.Size(132, 22);
            this.gammaGSO.TabIndex = 94;
            this.gammaGSO.Text = "1";
            // 
            // betaGSO
            // 
            this.betaGSO.Location = new System.Drawing.Point(324, 196);
            this.betaGSO.Margin = new System.Windows.Forms.Padding(4);
            this.betaGSO.Name = "betaGSO";
            this.betaGSO.Size = new System.Drawing.Size(132, 22);
            this.betaGSO.TabIndex = 95;
            this.betaGSO.Text = "1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 23);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 17);
            this.label12.TabIndex = 76;
            this.label12.Text = "Целевая функция:";
            // 
            // tasksGSOComboBox
            // 
            this.tasksGSOComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksGSOComboBox.FormattingEnabled = true;
            this.tasksGSOComboBox.Location = new System.Drawing.Point(184, 23);
            this.tasksGSOComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tasksGSOComboBox.Name = "tasksGSOComboBox";
            this.tasksGSOComboBox.Size = new System.Drawing.Size(272, 24);
            this.tasksGSOComboBox.TabIndex = 75;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 260);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "alpha:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 228);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 0;
            this.label16.Text = "gamma:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 164);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(132, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Число светлячков:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 196);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 17);
            this.label18.TabIndex = 0;
            this.label18.Text = "beta:";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.runAlgorithmEMA);
            this.tabPage11.Controls.Add(this.parseFuncEMA);
            this.tabPage11.Controls.Add(this.tabControl4);
            this.tabPage11.Controls.Add(this.groupBox4);
            this.tabPage11.Location = new System.Drawing.Point(4, 25);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1401, 564);
            this.tabPage11.TabIndex = 7;
            this.tabPage11.Text = "EMA";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // runAlgorithmEMA
            // 
            this.runAlgorithmEMA.Location = new System.Drawing.Point(95, 347);
            this.runAlgorithmEMA.Margin = new System.Windows.Forms.Padding(4);
            this.runAlgorithmEMA.Name = "runAlgorithmEMA";
            this.runAlgorithmEMA.Size = new System.Drawing.Size(331, 28);
            this.runAlgorithmEMA.TabIndex = 99;
            this.runAlgorithmEMA.Text = "Запуск алгоритма";
            this.runAlgorithmEMA.Click += new System.EventHandler(this.runAlgorithmEMA_Click);
            // 
            // parseFuncEMA
            // 
            this.parseFuncEMA.Location = new System.Drawing.Point(95, 305);
            this.parseFuncEMA.Margin = new System.Windows.Forms.Padding(4);
            this.parseFuncEMA.Name = "parseFuncEMA";
            this.parseFuncEMA.Size = new System.Drawing.Size(331, 28);
            this.parseFuncEMA.TabIndex = 98;
            this.parseFuncEMA.Text = "Парсинг функции";
            this.parseFuncEMA.Click += new System.EventHandler(this.parseFuncEMA_Click);
            // 
            // tabControl4
            // 
            this.tabControl4.Controls.Add(this.tabPage14);
            this.tabControl4.Controls.Add(this.tabPage15);
            this.tabControl4.Location = new System.Drawing.Point(526, 16);
            this.tabControl4.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl4.Name = "tabControl4";
            this.tabControl4.SelectedIndex = 0;
            this.tabControl4.Size = new System.Drawing.Size(815, 520);
            this.tabControl4.TabIndex = 84;
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.currStatusEMA);
            this.tabPage14.Location = new System.Drawing.Point(4, 25);
            this.tabPage14.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage14.Size = new System.Drawing.Size(807, 491);
            this.tabPage14.TabIndex = 0;
            this.tabPage14.Text = "Решение";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // currStatusEMA
            // 
            this.currStatusEMA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currStatusEMA.Location = new System.Drawing.Point(4, 4);
            this.currStatusEMA.Margin = new System.Windows.Forms.Padding(4);
            this.currStatusEMA.Multiline = true;
            this.currStatusEMA.Name = "currStatusEMA";
            this.currStatusEMA.ReadOnly = true;
            this.currStatusEMA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.currStatusEMA.Size = new System.Drawing.Size(799, 483);
            this.currStatusEMA.TabIndex = 73;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.zedGraphControl4);
            this.tabPage15.Location = new System.Drawing.Point(4, 25);
            this.tabPage15.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage15.Size = new System.Drawing.Size(807, 491);
            this.tabPage15.TabIndex = 1;
            this.tabPage15.Text = "Сходимость";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl4.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl4.IsEnableHZoom = false;
            this.zedGraphControl4.IsShowContextMenu = false;
            this.zedGraphControl4.IsShowCopyMessage = false;
            this.zedGraphControl4.Location = new System.Drawing.Point(4, 4);
            this.zedGraphControl4.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(799, 483);
            this.zedGraphControl4.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.localIterCountEMA);
            this.groupBox4.Controls.Add(this.maxIterCountEMA);
            this.groupBox4.Controls.Add(this.dimensionEMA);
            this.groupBox4.Controls.Add(this.minCoordinatesEMA);
            this.groupBox4.Controls.Add(this.maxCoordinatesEMA);
            this.groupBox4.Controls.Add(this.samplePointsCountEMA);
            this.groupBox4.Controls.Add(label37);
            this.groupBox4.Controls.Add(this.label38);
            this.groupBox4.Controls.Add(label39);
            this.groupBox4.Controls.Add(this.tasksEMAComboBox);
            this.groupBox4.Controls.Add(label40);
            this.groupBox4.Controls.Add(this.label42);
            this.groupBox4.Controls.Add(this.label43);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Location = new System.Drawing.Point(25, 16);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(466, 272);
            this.groupBox4.TabIndex = 83;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Параметры алгоритма ЭМП";
            // 
            // localIterCountEMA
            // 
            this.localIterCountEMA.Location = new System.Drawing.Point(324, 228);
            this.localIterCountEMA.Margin = new System.Windows.Forms.Padding(4);
            this.localIterCountEMA.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.localIterCountEMA.Name = "localIterCountEMA";
            this.localIterCountEMA.Size = new System.Drawing.Size(133, 22);
            this.localIterCountEMA.TabIndex = 108;
            this.localIterCountEMA.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // maxIterCountEMA
            // 
            this.maxIterCountEMA.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxIterCountEMA.Location = new System.Drawing.Point(324, 196);
            this.maxIterCountEMA.Margin = new System.Windows.Forms.Padding(4);
            this.maxIterCountEMA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.maxIterCountEMA.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxIterCountEMA.Name = "maxIterCountEMA";
            this.maxIterCountEMA.Size = new System.Drawing.Size(133, 22);
            this.maxIterCountEMA.TabIndex = 107;
            this.maxIterCountEMA.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // dimensionEMA
            // 
            this.dimensionEMA.Location = new System.Drawing.Point(324, 68);
            this.dimensionEMA.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionEMA.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionEMA.Name = "dimensionEMA";
            this.dimensionEMA.Size = new System.Drawing.Size(133, 22);
            this.dimensionEMA.TabIndex = 104;
            this.dimensionEMA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // minCoordinatesEMA
            // 
            this.minCoordinatesEMA.Location = new System.Drawing.Point(324, 100);
            this.minCoordinatesEMA.Margin = new System.Windows.Forms.Padding(4);
            this.minCoordinatesEMA.Name = "minCoordinatesEMA";
            this.minCoordinatesEMA.Size = new System.Drawing.Size(132, 22);
            this.minCoordinatesEMA.TabIndex = 106;
            this.minCoordinatesEMA.Text = "-5,0;-5,0";
            // 
            // maxCoordinatesEMA
            // 
            this.maxCoordinatesEMA.Location = new System.Drawing.Point(324, 132);
            this.maxCoordinatesEMA.Margin = new System.Windows.Forms.Padding(4);
            this.maxCoordinatesEMA.Name = "maxCoordinatesEMA";
            this.maxCoordinatesEMA.Size = new System.Drawing.Size(132, 22);
            this.maxCoordinatesEMA.TabIndex = 105;
            this.maxCoordinatesEMA.Text = "5,0;5,0";
            // 
            // samplePointsCountEMA
            // 
            this.samplePointsCountEMA.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.samplePointsCountEMA.Location = new System.Drawing.Point(324, 164);
            this.samplePointsCountEMA.Margin = new System.Windows.Forms.Padding(4);
            this.samplePointsCountEMA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.samplePointsCountEMA.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.samplePointsCountEMA.Name = "samplePointsCountEMA";
            this.samplePointsCountEMA.Size = new System.Drawing.Size(133, 22);
            this.samplePointsCountEMA.TabIndex = 103;
            this.samplePointsCountEMA.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(8, 23);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(131, 17);
            this.label38.TabIndex = 76;
            this.label38.Text = "Целевая функция:";
            // 
            // tasksEMAComboBox
            // 
            this.tasksEMAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksEMAComboBox.FormattingEnabled = true;
            this.tasksEMAComboBox.Location = new System.Drawing.Point(184, 23);
            this.tasksEMAComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tasksEMAComboBox.Name = "tasksEMAComboBox";
            this.tasksEMAComboBox.Size = new System.Drawing.Size(272, 24);
            this.tasksEMAComboBox.TabIndex = 75;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(8, 228);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(249, 17);
            this.label42.TabIndex = 0;
            this.label42.Text = "Число итераций локального поиска:";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(8, 164);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(132, 17);
            this.label43.TabIndex = 0;
            this.label43.Text = "Количество точек:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(8, 196);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(120, 17);
            this.label44.TabIndex = 0;
            this.label44.Text = "Число итераций:";
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.runAlgorithmBA);
            this.tabPage16.Controls.Add(this.parseFuncBA);
            this.tabPage16.Controls.Add(this.tabControl5);
            this.tabPage16.Controls.Add(this.groupBox5);
            this.tabPage16.Location = new System.Drawing.Point(4, 25);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(1401, 564);
            this.tabPage16.TabIndex = 8;
            this.tabPage16.Text = "BA";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // runAlgorithmBA
            // 
            this.runAlgorithmBA.Location = new System.Drawing.Point(96, 412);
            this.runAlgorithmBA.Margin = new System.Windows.Forms.Padding(4);
            this.runAlgorithmBA.Name = "runAlgorithmBA";
            this.runAlgorithmBA.Size = new System.Drawing.Size(331, 28);
            this.runAlgorithmBA.TabIndex = 101;
            this.runAlgorithmBA.Text = "Запуск алгоритма";
            this.runAlgorithmBA.Click += new System.EventHandler(this.runAlgorithmBA_Click);
            // 
            // parseFuncBA
            // 
            this.parseFuncBA.Location = new System.Drawing.Point(96, 370);
            this.parseFuncBA.Margin = new System.Windows.Forms.Padding(4);
            this.parseFuncBA.Name = "parseFuncBA";
            this.parseFuncBA.Size = new System.Drawing.Size(331, 28);
            this.parseFuncBA.TabIndex = 100;
            this.parseFuncBA.Text = "Парсинг функции";
            this.parseFuncBA.Click += new System.EventHandler(this.parseFuncBA_Click);
            // 
            // tabControl5
            // 
            this.tabControl5.Controls.Add(this.tabPage17);
            this.tabControl5.Controls.Add(this.tabPage18);
            this.tabControl5.Location = new System.Drawing.Point(526, 16);
            this.tabControl5.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl5.Name = "tabControl5";
            this.tabControl5.SelectedIndex = 0;
            this.tabControl5.Size = new System.Drawing.Size(815, 520);
            this.tabControl5.TabIndex = 84;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.currStatusBA);
            this.tabPage17.Location = new System.Drawing.Point(4, 25);
            this.tabPage17.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage17.Size = new System.Drawing.Size(807, 491);
            this.tabPage17.TabIndex = 0;
            this.tabPage17.Text = "Решение";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // currStatusBA
            // 
            this.currStatusBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currStatusBA.Location = new System.Drawing.Point(4, 4);
            this.currStatusBA.Margin = new System.Windows.Forms.Padding(4);
            this.currStatusBA.Multiline = true;
            this.currStatusBA.Name = "currStatusBA";
            this.currStatusBA.ReadOnly = true;
            this.currStatusBA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.currStatusBA.Size = new System.Drawing.Size(799, 483);
            this.currStatusBA.TabIndex = 73;
            // 
            // tabPage18
            // 
            this.tabPage18.Controls.Add(this.zedGraphControl5);
            this.tabPage18.Location = new System.Drawing.Point(4, 25);
            this.tabPage18.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage18.Name = "tabPage18";
            this.tabPage18.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage18.Size = new System.Drawing.Size(807, 491);
            this.tabPage18.TabIndex = 1;
            this.tabPage18.Text = "Сходимость";
            this.tabPage18.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl5
            // 
            this.zedGraphControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl5.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl5.IsEnableHZoom = false;
            this.zedGraphControl5.IsShowContextMenu = false;
            this.zedGraphControl5.IsShowCopyMessage = false;
            this.zedGraphControl5.Location = new System.Drawing.Point(4, 4);
            this.zedGraphControl5.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl5.Name = "zedGraphControl5";
            this.zedGraphControl5.ScrollGrace = 0D;
            this.zedGraphControl5.ScrollMaxX = 0D;
            this.zedGraphControl5.ScrollMaxY = 0D;
            this.zedGraphControl5.ScrollMaxY2 = 0D;
            this.zedGraphControl5.ScrollMinX = 0D;
            this.zedGraphControl5.ScrollMinY = 0D;
            this.zedGraphControl5.ScrollMinY2 = 0D;
            this.zedGraphControl5.Size = new System.Drawing.Size(799, 483);
            this.zedGraphControl5.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.selectedAreasCountBA);
            this.groupBox5.Controls.Add(this.bestAreasCountBA);
            this.groupBox5.Controls.Add(this.beesSelectedCountBA);
            this.groupBox5.Controls.Add(this.beesBestCountBA);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.dimensionBA);
            this.groupBox5.Controls.Add(this.minCoordinatesBA);
            this.groupBox5.Controls.Add(this.maxCoordinatesBA);
            this.groupBox5.Controls.Add(this.beesScoutCountBA);
            this.groupBox5.Controls.Add(label46);
            this.groupBox5.Controls.Add(this.label47);
            this.groupBox5.Controls.Add(label48);
            this.groupBox5.Controls.Add(this.tasksBAComboBox);
            this.groupBox5.Controls.Add(label49);
            this.groupBox5.Controls.Add(this.label50);
            this.groupBox5.Controls.Add(this.label51);
            this.groupBox5.Controls.Add(this.label52);
            this.groupBox5.Controls.Add(this.label53);
            this.groupBox5.Location = new System.Drawing.Point(25, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(465, 331);
            this.groupBox5.TabIndex = 83;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Параметры алгоритма пчелиной колонии";
            // 
            // selectedAreasCountBA
            // 
            this.selectedAreasCountBA.Location = new System.Drawing.Point(323, 290);
            this.selectedAreasCountBA.Margin = new System.Windows.Forms.Padding(4);
            this.selectedAreasCountBA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.selectedAreasCountBA.Name = "selectedAreasCountBA";
            this.selectedAreasCountBA.Size = new System.Drawing.Size(133, 22);
            this.selectedAreasCountBA.TabIndex = 113;
            this.selectedAreasCountBA.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // bestAreasCountBA
            // 
            this.bestAreasCountBA.Location = new System.Drawing.Point(323, 260);
            this.bestAreasCountBA.Margin = new System.Windows.Forms.Padding(4);
            this.bestAreasCountBA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bestAreasCountBA.Name = "bestAreasCountBA";
            this.bestAreasCountBA.Size = new System.Drawing.Size(133, 22);
            this.bestAreasCountBA.TabIndex = 112;
            this.bestAreasCountBA.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // beesSelectedCountBA
            // 
            this.beesSelectedCountBA.Location = new System.Drawing.Point(323, 228);
            this.beesSelectedCountBA.Margin = new System.Windows.Forms.Padding(4);
            this.beesSelectedCountBA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beesSelectedCountBA.Name = "beesSelectedCountBA";
            this.beesSelectedCountBA.Size = new System.Drawing.Size(133, 22);
            this.beesSelectedCountBA.TabIndex = 111;
            this.beesSelectedCountBA.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // beesBestCountBA
            // 
            this.beesBestCountBA.Location = new System.Drawing.Point(323, 196);
            this.beesBestCountBA.Margin = new System.Windows.Forms.Padding(4);
            this.beesBestCountBA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beesBestCountBA.Name = "beesBestCountBA";
            this.beesBestCountBA.Size = new System.Drawing.Size(133, 22);
            this.beesBestCountBA.TabIndex = 110;
            this.beesBestCountBA.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(7, 290);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(193, 17);
            this.label41.TabIndex = 108;
            this.label41.Text = "Число выбранных участков:";
            // 
            // dimensionBA
            // 
            this.dimensionBA.Location = new System.Drawing.Point(324, 68);
            this.dimensionBA.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionBA.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionBA.Name = "dimensionBA";
            this.dimensionBA.Size = new System.Drawing.Size(133, 22);
            this.dimensionBA.TabIndex = 105;
            this.dimensionBA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // minCoordinatesBA
            // 
            this.minCoordinatesBA.Location = new System.Drawing.Point(324, 100);
            this.minCoordinatesBA.Margin = new System.Windows.Forms.Padding(4);
            this.minCoordinatesBA.Name = "minCoordinatesBA";
            this.minCoordinatesBA.Size = new System.Drawing.Size(132, 22);
            this.minCoordinatesBA.TabIndex = 107;
            this.minCoordinatesBA.Text = "-5,0;-5,0";
            // 
            // maxCoordinatesBA
            // 
            this.maxCoordinatesBA.Location = new System.Drawing.Point(324, 132);
            this.maxCoordinatesBA.Margin = new System.Windows.Forms.Padding(4);
            this.maxCoordinatesBA.Name = "maxCoordinatesBA";
            this.maxCoordinatesBA.Size = new System.Drawing.Size(132, 22);
            this.maxCoordinatesBA.TabIndex = 106;
            this.maxCoordinatesBA.Text = "5,0;5,0";
            // 
            // beesScoutCountBA
            // 
            this.beesScoutCountBA.Location = new System.Drawing.Point(324, 164);
            this.beesScoutCountBA.Margin = new System.Windows.Forms.Padding(4);
            this.beesScoutCountBA.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.beesScoutCountBA.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.beesScoutCountBA.Name = "beesScoutCountBA";
            this.beesScoutCountBA.Size = new System.Drawing.Size(133, 22);
            this.beesScoutCountBA.TabIndex = 104;
            this.beesScoutCountBA.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(8, 23);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(131, 17);
            this.label47.TabIndex = 76;
            this.label47.Text = "Целевая функция:";
            // 
            // tasksBAComboBox
            // 
            this.tasksBAComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksBAComboBox.FormattingEnabled = true;
            this.tasksBAComboBox.Location = new System.Drawing.Point(184, 23);
            this.tasksBAComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tasksBAComboBox.Name = "tasksBAComboBox";
            this.tasksBAComboBox.Size = new System.Drawing.Size(272, 24);
            this.tasksBAComboBox.TabIndex = 75;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(8, 260);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(168, 17);
            this.label50.TabIndex = 0;
            this.label50.Text = "Число лучших участков:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(8, 228);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(244, 17);
            this.label51.TabIndex = 0;
            this.label51.Text = "Число пчел на выбранные участки:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(8, 164);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(178, 17);
            this.label52.TabIndex = 0;
            this.label52.Text = "Число пчел-разведчиков:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(8, 196);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(219, 17);
            this.label53.TabIndex = 0;
            this.label53.Text = "Число пчел на лучшие участки:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.runAlgorithmHS);
            this.tabPage2.Controls.Add(this.parseFuncHS);
            this.tabPage2.Controls.Add(this.tabControl6);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1401, 564);
            this.tabPage2.TabIndex = 9;
            this.tabPage2.Text = "HS";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // runAlgorithmHS
            // 
            this.runAlgorithmHS.Location = new System.Drawing.Point(82, 415);
            this.runAlgorithmHS.Margin = new System.Windows.Forms.Padding(4);
            this.runAlgorithmHS.Name = "runAlgorithmHS";
            this.runAlgorithmHS.Size = new System.Drawing.Size(331, 28);
            this.runAlgorithmHS.TabIndex = 103;
            this.runAlgorithmHS.Text = "Запуск алгоритма";
            this.runAlgorithmHS.Click += new System.EventHandler(this.runAlgorithmHS_Click);
            // 
            // parseFuncHS
            // 
            this.parseFuncHS.Location = new System.Drawing.Point(82, 373);
            this.parseFuncHS.Margin = new System.Windows.Forms.Padding(4);
            this.parseFuncHS.Name = "parseFuncHS";
            this.parseFuncHS.Size = new System.Drawing.Size(331, 28);
            this.parseFuncHS.TabIndex = 102;
            this.parseFuncHS.Text = "Парсинг функции";
            this.parseFuncHS.Click += new System.EventHandler(this.parseFuncHS_Click);
            // 
            // tabControl6
            // 
            this.tabControl6.Controls.Add(this.tabPage19);
            this.tabControl6.Controls.Add(this.tabPage20);
            this.tabControl6.Location = new System.Drawing.Point(526, 16);
            this.tabControl6.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl6.Name = "tabControl6";
            this.tabControl6.SelectedIndex = 0;
            this.tabControl6.Size = new System.Drawing.Size(815, 520);
            this.tabControl6.TabIndex = 84;
            // 
            // tabPage19
            // 
            this.tabPage19.Controls.Add(this.currStatusHS);
            this.tabPage19.Location = new System.Drawing.Point(4, 25);
            this.tabPage19.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage19.Name = "tabPage19";
            this.tabPage19.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage19.Size = new System.Drawing.Size(807, 491);
            this.tabPage19.TabIndex = 0;
            this.tabPage19.Text = "Решение";
            this.tabPage19.UseVisualStyleBackColor = true;
            // 
            // currStatusHS
            // 
            this.currStatusHS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currStatusHS.Location = new System.Drawing.Point(4, 4);
            this.currStatusHS.Margin = new System.Windows.Forms.Padding(4);
            this.currStatusHS.Multiline = true;
            this.currStatusHS.Name = "currStatusHS";
            this.currStatusHS.ReadOnly = true;
            this.currStatusHS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.currStatusHS.Size = new System.Drawing.Size(799, 483);
            this.currStatusHS.TabIndex = 73;
            // 
            // tabPage20
            // 
            this.tabPage20.Controls.Add(this.zedGraphControl6);
            this.tabPage20.Location = new System.Drawing.Point(4, 25);
            this.tabPage20.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage20.Name = "tabPage20";
            this.tabPage20.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage20.Size = new System.Drawing.Size(807, 491);
            this.tabPage20.TabIndex = 1;
            this.tabPage20.Text = "Сходимость";
            this.tabPage20.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl6
            // 
            this.zedGraphControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl6.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl6.IsEnableHZoom = false;
            this.zedGraphControl6.IsShowContextMenu = false;
            this.zedGraphControl6.IsShowCopyMessage = false;
            this.zedGraphControl6.Location = new System.Drawing.Point(4, 4);
            this.zedGraphControl6.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl6.Name = "zedGraphControl6";
            this.zedGraphControl6.ScrollGrace = 0D;
            this.zedGraphControl6.ScrollMaxX = 0D;
            this.zedGraphControl6.ScrollMaxY = 0D;
            this.zedGraphControl6.ScrollMaxY2 = 0D;
            this.zedGraphControl6.ScrollMinX = 0D;
            this.zedGraphControl6.ScrollMinY = 0D;
            this.zedGraphControl6.ScrollMinY2 = 0D;
            this.zedGraphControl6.Size = new System.Drawing.Size(799, 483);
            this.zedGraphControl6.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.hmsHS);
            this.groupBox6.Controls.Add(this.bwHS);
            this.groupBox6.Controls.Add(this.maxIterHS);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.dimensionHS);
            this.groupBox6.Controls.Add(this.minCoordinatesHS);
            this.groupBox6.Controls.Add(this.maxCoordinatesHS);
            this.groupBox6.Controls.Add(this.parHS);
            this.groupBox6.Controls.Add(this.hmcrHS);
            this.groupBox6.Controls.Add(label55);
            this.groupBox6.Controls.Add(this.label56);
            this.groupBox6.Controls.Add(label57);
            this.groupBox6.Controls.Add(this.tasksHSComboBox);
            this.groupBox6.Controls.Add(label58);
            this.groupBox6.Controls.Add(this.label59);
            this.groupBox6.Controls.Add(this.label60);
            this.groupBox6.Controls.Add(this.label61);
            this.groupBox6.Controls.Add(this.label62);
            this.groupBox6.Location = new System.Drawing.Point(25, 16);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(465, 336);
            this.groupBox6.TabIndex = 83;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Параметры алгоритма поиска гармонии";
            // 
            // hmsHS
            // 
            this.hmsHS.Location = new System.Drawing.Point(324, 228);
            this.hmsHS.Margin = new System.Windows.Forms.Padding(4);
            this.hmsHS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.hmsHS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hmsHS.Name = "hmsHS";
            this.hmsHS.Size = new System.Drawing.Size(133, 22);
            this.hmsHS.TabIndex = 97;
            this.hmsHS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // bwHS
            // 
            this.bwHS.Location = new System.Drawing.Point(324, 164);
            this.bwHS.Margin = new System.Windows.Forms.Padding(4);
            this.bwHS.Name = "bwHS";
            this.bwHS.Size = new System.Drawing.Size(132, 22);
            this.bwHS.TabIndex = 96;
            this.bwHS.Text = "90";
            // 
            // maxIterHS
            // 
            this.maxIterHS.Location = new System.Drawing.Point(323, 290);
            this.maxIterHS.Margin = new System.Windows.Forms.Padding(4);
            this.maxIterHS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.maxIterHS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxIterHS.Name = "maxIterHS";
            this.maxIterHS.Size = new System.Drawing.Size(133, 22);
            this.maxIterHS.TabIndex = 95;
            this.maxIterHS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 290);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 17);
            this.label19.TabIndex = 94;
            this.label19.Text = "Число итераций:";
            // 
            // dimensionHS
            // 
            this.dimensionHS.Location = new System.Drawing.Point(324, 68);
            this.dimensionHS.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionHS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionHS.Name = "dimensionHS";
            this.dimensionHS.Size = new System.Drawing.Size(133, 22);
            this.dimensionHS.TabIndex = 91;
            this.dimensionHS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // minCoordinatesHS
            // 
            this.minCoordinatesHS.Location = new System.Drawing.Point(324, 100);
            this.minCoordinatesHS.Margin = new System.Windows.Forms.Padding(4);
            this.minCoordinatesHS.Name = "minCoordinatesHS";
            this.minCoordinatesHS.Size = new System.Drawing.Size(132, 22);
            this.minCoordinatesHS.TabIndex = 93;
            this.minCoordinatesHS.Text = "-5,0;-5,0";
            // 
            // maxCoordinatesHS
            // 
            this.maxCoordinatesHS.Location = new System.Drawing.Point(324, 132);
            this.maxCoordinatesHS.Margin = new System.Windows.Forms.Padding(4);
            this.maxCoordinatesHS.Name = "maxCoordinatesHS";
            this.maxCoordinatesHS.Size = new System.Drawing.Size(132, 22);
            this.maxCoordinatesHS.TabIndex = 92;
            this.maxCoordinatesHS.Text = "5,0;5,0";
            // 
            // parHS
            // 
            this.parHS.Location = new System.Drawing.Point(324, 260);
            this.parHS.Margin = new System.Windows.Forms.Padding(4);
            this.parHS.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.parHS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.parHS.Name = "parHS";
            this.parHS.Size = new System.Drawing.Size(133, 22);
            this.parHS.TabIndex = 89;
            this.parHS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // hmcrHS
            // 
            this.hmcrHS.Location = new System.Drawing.Point(324, 196);
            this.hmcrHS.Margin = new System.Windows.Forms.Padding(4);
            this.hmcrHS.Name = "hmcrHS";
            this.hmcrHS.Size = new System.Drawing.Size(132, 22);
            this.hmcrHS.TabIndex = 88;
            this.hmcrHS.Text = "90";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(8, 23);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(131, 17);
            this.label56.TabIndex = 76;
            this.label56.Text = "Целевая функция:";
            // 
            // tasksHSComboBox
            // 
            this.tasksHSComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksHSComboBox.FormattingEnabled = true;
            this.tasksHSComboBox.Location = new System.Drawing.Point(184, 23);
            this.tasksHSComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tasksHSComboBox.Name = "tasksHSComboBox";
            this.tasksHSComboBox.Size = new System.Drawing.Size(272, 24);
            this.tasksHSComboBox.TabIndex = 75;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(8, 260);
            this.label59.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(36, 17);
            this.label59.TabIndex = 0;
            this.label59.Text = "PAR";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(8, 228);
            this.label60.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(42, 17);
            this.label60.TabIndex = 0;
            this.label60.Text = "HMS:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(8, 164);
            this.label61.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(34, 17);
            this.label61.TabIndex = 0;
            this.label61.Text = "BW:";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(8, 196);
            this.label62.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(52, 17);
            this.label62.TabIndex = 0;
            this.label62.Text = "HMCR:";
            // 
            // tabPage21
            // 
            this.tabPage21.Controls.Add(this.runAlgorithmHC);
            this.tabPage21.Controls.Add(this.parseFuncHC);
            this.tabPage21.Controls.Add(this.tabControl7);
            this.tabPage21.Controls.Add(this.groupBox7);
            this.tabPage21.Location = new System.Drawing.Point(4, 25);
            this.tabPage21.Name = "tabPage21";
            this.tabPage21.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage21.Size = new System.Drawing.Size(1401, 564);
            this.tabPage21.TabIndex = 10;
            this.tabPage21.Text = "HC";
            this.tabPage21.UseVisualStyleBackColor = true;
            // 
            // runAlgorithmHC
            // 
            this.runAlgorithmHC.Location = new System.Drawing.Point(88, 310);
            this.runAlgorithmHC.Margin = new System.Windows.Forms.Padding(4);
            this.runAlgorithmHC.Name = "runAlgorithmHC";
            this.runAlgorithmHC.Size = new System.Drawing.Size(331, 28);
            this.runAlgorithmHC.TabIndex = 105;
            this.runAlgorithmHC.Text = "Запуск алгоритма";
            this.runAlgorithmHC.Click += new System.EventHandler(this.runAlgorithmHC_Click);
            // 
            // parseFuncHC
            // 
            this.parseFuncHC.Location = new System.Drawing.Point(88, 268);
            this.parseFuncHC.Margin = new System.Windows.Forms.Padding(4);
            this.parseFuncHC.Name = "parseFuncHC";
            this.parseFuncHC.Size = new System.Drawing.Size(331, 28);
            this.parseFuncHC.TabIndex = 104;
            this.parseFuncHC.Text = "Парсинг функции";
            this.parseFuncHC.Click += new System.EventHandler(this.parseFuncHC_Click);
            // 
            // tabControl7
            // 
            this.tabControl7.Controls.Add(this.tabPage22);
            this.tabControl7.Controls.Add(this.tabPage23);
            this.tabControl7.Location = new System.Drawing.Point(526, 16);
            this.tabControl7.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl7.Name = "tabControl7";
            this.tabControl7.SelectedIndex = 0;
            this.tabControl7.Size = new System.Drawing.Size(815, 520);
            this.tabControl7.TabIndex = 84;
            // 
            // tabPage22
            // 
            this.tabPage22.Controls.Add(this.currStatusHC);
            this.tabPage22.Location = new System.Drawing.Point(4, 25);
            this.tabPage22.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage22.Name = "tabPage22";
            this.tabPage22.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage22.Size = new System.Drawing.Size(807, 491);
            this.tabPage22.TabIndex = 0;
            this.tabPage22.Text = "Решение";
            this.tabPage22.UseVisualStyleBackColor = true;
            // 
            // currStatusHC
            // 
            this.currStatusHC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currStatusHC.Location = new System.Drawing.Point(4, 4);
            this.currStatusHC.Margin = new System.Windows.Forms.Padding(4);
            this.currStatusHC.Multiline = true;
            this.currStatusHC.Name = "currStatusHC";
            this.currStatusHC.ReadOnly = true;
            this.currStatusHC.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.currStatusHC.Size = new System.Drawing.Size(799, 483);
            this.currStatusHC.TabIndex = 73;
            // 
            // tabPage23
            // 
            this.tabPage23.Controls.Add(this.zedGraphControl7);
            this.tabPage23.Location = new System.Drawing.Point(4, 25);
            this.tabPage23.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage23.Name = "tabPage23";
            this.tabPage23.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage23.Size = new System.Drawing.Size(807, 491);
            this.tabPage23.TabIndex = 1;
            this.tabPage23.Text = "Сходимость";
            this.tabPage23.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl7
            // 
            this.zedGraphControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl7.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl7.IsEnableHZoom = false;
            this.zedGraphControl7.IsShowContextMenu = false;
            this.zedGraphControl7.IsShowCopyMessage = false;
            this.zedGraphControl7.Location = new System.Drawing.Point(4, 4);
            this.zedGraphControl7.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl7.Name = "zedGraphControl7";
            this.zedGraphControl7.ScrollGrace = 0D;
            this.zedGraphControl7.ScrollMaxX = 0D;
            this.zedGraphControl7.ScrollMaxY = 0D;
            this.zedGraphControl7.ScrollMaxY2 = 0D;
            this.zedGraphControl7.ScrollMinX = 0D;
            this.zedGraphControl7.ScrollMinY = 0D;
            this.zedGraphControl7.ScrollMinY2 = 0D;
            this.zedGraphControl7.Size = new System.Drawing.Size(799, 483);
            this.zedGraphControl7.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dimensionHC);
            this.groupBox7.Controls.Add(this.minCoordinatesHC);
            this.groupBox7.Controls.Add(this.maxCoordinatesHC);
            this.groupBox7.Controls.Add(this.iterationsHC);
            this.groupBox7.Controls.Add(this.epsilonHC);
            this.groupBox7.Controls.Add(label64);
            this.groupBox7.Controls.Add(this.label65);
            this.groupBox7.Controls.Add(label66);
            this.groupBox7.Controls.Add(this.tasksHCComboBox);
            this.groupBox7.Controls.Add(label67);
            this.groupBox7.Controls.Add(this.label70);
            this.groupBox7.Controls.Add(this.label71);
            this.groupBox7.Location = new System.Drawing.Point(25, 16);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(465, 235);
            this.groupBox7.TabIndex = 83;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Параметры алгоритма подъема";
            // 
            // dimensionHC
            // 
            this.dimensionHC.Location = new System.Drawing.Point(324, 68);
            this.dimensionHC.Margin = new System.Windows.Forms.Padding(4);
            this.dimensionHC.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.dimensionHC.Name = "dimensionHC";
            this.dimensionHC.Size = new System.Drawing.Size(133, 22);
            this.dimensionHC.TabIndex = 84;
            this.dimensionHC.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // minCoordinatesHC
            // 
            this.minCoordinatesHC.Location = new System.Drawing.Point(324, 100);
            this.minCoordinatesHC.Margin = new System.Windows.Forms.Padding(4);
            this.minCoordinatesHC.Name = "minCoordinatesHC";
            this.minCoordinatesHC.Size = new System.Drawing.Size(132, 22);
            this.minCoordinatesHC.TabIndex = 86;
            this.minCoordinatesHC.Text = "-5,0;-5,0";
            // 
            // maxCoordinatesHC
            // 
            this.maxCoordinatesHC.Location = new System.Drawing.Point(324, 132);
            this.maxCoordinatesHC.Margin = new System.Windows.Forms.Padding(4);
            this.maxCoordinatesHC.Name = "maxCoordinatesHC";
            this.maxCoordinatesHC.Size = new System.Drawing.Size(132, 22);
            this.maxCoordinatesHC.TabIndex = 85;
            this.maxCoordinatesHC.Text = "5,0;5,0";
            // 
            // iterationsHC
            // 
            this.iterationsHC.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.iterationsHC.Location = new System.Drawing.Point(324, 164);
            this.iterationsHC.Margin = new System.Windows.Forms.Padding(4);
            this.iterationsHC.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.iterationsHC.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.iterationsHC.Name = "iterationsHC";
            this.iterationsHC.Size = new System.Drawing.Size(133, 22);
            this.iterationsHC.TabIndex = 83;
            this.iterationsHC.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // epsilonHC
            // 
            this.epsilonHC.Location = new System.Drawing.Point(324, 196);
            this.epsilonHC.Margin = new System.Windows.Forms.Padding(4);
            this.epsilonHC.Name = "epsilonHC";
            this.epsilonHC.Size = new System.Drawing.Size(132, 22);
            this.epsilonHC.TabIndex = 81;
            this.epsilonHC.Text = "0,000001";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(8, 23);
            this.label65.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(131, 17);
            this.label65.TabIndex = 76;
            this.label65.Text = "Целевая функция:";
            // 
            // tasksHCComboBox
            // 
            this.tasksHCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tasksHCComboBox.FormattingEnabled = true;
            this.tasksHCComboBox.Location = new System.Drawing.Point(184, 23);
            this.tasksHCComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tasksHCComboBox.Name = "tasksHCComboBox";
            this.tasksHCComboBox.Size = new System.Drawing.Size(272, 24);
            this.tasksHCComboBox.TabIndex = 75;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Location = new System.Drawing.Point(8, 164);
            this.label70.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(120, 17);
            this.label70.TabIndex = 0;
            this.label70.Text = "Число итераций:";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(8, 196);
            this.label71.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(144, 17);
            this.label71.TabIndex = 0;
            this.label71.Text = "Точность минимума:";
            // 
            // numericUpDown25
            // 
            this.numericUpDown25.Location = new System.Drawing.Point(324, 64);
            this.numericUpDown25.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown25.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown25.Name = "numericUpDown25";
            this.numericUpDown25.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown25.TabIndex = 76;
            this.numericUpDown25.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(8, 196);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(211, 17);
            this.label36.TabIndex = 0;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(324, 192);
            this.textBox15.Margin = new System.Windows.Forms.Padding(4);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(132, 22);
            this.textBox15.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(8, 164);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(132, 17);
            this.label35.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(8, 228);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(178, 17);
            this.label34.TabIndex = 0;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(8, 260);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(153, 17);
            this.label33.TabIndex = 0;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(324, 224);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(132, 22);
            this.textBox14.TabIndex = 1;
            // 
            // numericUpDown12
            // 
            this.numericUpDown12.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown12.Location = new System.Drawing.Point(324, 160);
            this.numericUpDown12.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown12.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown12.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown12.Name = "numericUpDown12";
            this.numericUpDown12.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown12.TabIndex = 2;
            this.numericUpDown12.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // numericUpDown11
            // 
            this.numericUpDown11.Location = new System.Drawing.Point(324, 256);
            this.numericUpDown11.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown11.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown11.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown11.Name = "numericUpDown11";
            this.numericUpDown11.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown11.TabIndex = 2;
            this.numericUpDown11.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(324, 128);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(132, 22);
            this.textBox13.TabIndex = 77;
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(184, 23);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(272, 25);
            this.comboBox6.TabIndex = 75;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 33);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(131, 17);
            this.label30.TabIndex = 76;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(324, 96);
            this.textBox12.Margin = new System.Windows.Forms.Padding(4);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(132, 22);
            this.textBox12.TabIndex = 79;
            // 
            // numericUpDown10
            // 
            this.numericUpDown10.Location = new System.Drawing.Point(324, 64);
            this.numericUpDown10.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown10.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown10.Name = "numericUpDown10";
            this.numericUpDown10.Size = new System.Drawing.Size(133, 22);
            this.numericUpDown10.TabIndex = 76;
            this.numericUpDown10.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 25);
            this.tabPage13.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage13.Size = new System.Drawing.Size(807, 279);
            this.tabPage13.TabIndex = 1;
            this.tabPage13.Text = "Сходимость";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl3.EditButtons = System.Windows.Forms.MouseButtons.None;
            this.zedGraphControl3.IsEnableHZoom = false;
            this.zedGraphControl3.IsShowContextMenu = false;
            this.zedGraphControl3.IsShowCopyMessage = false;
            this.zedGraphControl3.Location = new System.Drawing.Point(4, 4);
            this.zedGraphControl3.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(799, 271);
            this.zedGraphControl3.TabIndex = 0;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 25);
            this.tabPage12.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage12.Size = new System.Drawing.Size(807, 279);
            this.tabPage12.TabIndex = 0;
            this.tabPage12.Text = "Решение";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Location = new System.Drawing.Point(4, 4);
            this.textBox11.Margin = new System.Windows.Forms.Padding(4);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox11.Size = new System.Drawing.Size(799, 271);
            this.textBox11.TabIndex = 73;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 606);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Кодировки ГА";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextGenCountGA)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chromoCountGA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popSizeGA)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabControl8.ResumeLayout(false);
            this.tabPage24.ResumeLayout(false);
            this.tabPage24.PerformLayout();
            this.tabPage25.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.individsCountMEC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupsCountMEC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laggingGroupsCountMEC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionMEC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leadingGroupsCountMEC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domainsCountMEC)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsGSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionGSO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firefliesCountGSO)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabControl4.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabPage14.PerformLayout();
            this.tabPage15.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localIterCountEMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterCountEMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionEMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samplePointsCountEMA)).EndInit();
            this.tabPage16.ResumeLayout(false);
            this.tabControl5.ResumeLayout(false);
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            this.tabPage18.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectedAreasCountBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestAreasCountBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beesSelectedCountBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beesBestCountBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionBA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beesScoutCountBA)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl6.ResumeLayout(false);
            this.tabPage19.ResumeLayout(false);
            this.tabPage19.PerformLayout();
            this.tabPage20.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hmsHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxIterHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionHS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parHS)).EndInit();
            this.tabPage21.ResumeLayout(false);
            this.tabControl7.ResumeLayout(false);
            this.tabPage22.ResumeLayout(false);
            this.tabPage22.PerformLayout();
            this.tabPage23.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dimensionHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsHC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown10)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox codingCmBGA;
        protected System.Windows.Forms.Button runAlgorithmGA;
        private System.Windows.Forms.NumericUpDown nextGenCountGA;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Button parseFuncGA;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox currStatusGA;
        private System.Windows.Forms.TabPage tabPage4;
        private ZedGraph.ZedGraphControl zedGraph;
        protected System.Windows.Forms.Button createPopGABtn;
        private System.Windows.Forms.TabPage tabPage8;
        protected System.Windows.Forms.Button runAlgorithmMEC;
        protected System.Windows.Forms.Button parseFuncMEC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox tasksMECComboBox;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox currStatusGSO;
        private System.Windows.Forms.TabPage tabPage7;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox tasksGSOComboBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TabControl tabControl5;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.TextBox currStatusBA;
        private System.Windows.Forms.TabPage tabPage18;
        private ZedGraph.ZedGraphControl zedGraphControl5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox tasksBAComboBox;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label36;
        protected System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        protected System.Windows.Forms.TextBox textBox14;
        protected System.Windows.Forms.NumericUpDown numericUpDown12;
        protected System.Windows.Forms.NumericUpDown numericUpDown11;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.NumericUpDown numericUpDown10;
        private System.Windows.Forms.TabPage tabPage13;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl6;
        private System.Windows.Forms.TabPage tabPage19;
        private System.Windows.Forms.TextBox currStatusHS;
        private System.Windows.Forms.TabPage tabPage20;
        private ZedGraph.ZedGraphControl zedGraphControl6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.ComboBox tasksHSComboBox;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TabPage tabPage21;
        private System.Windows.Forms.TabControl tabControl7;
        private System.Windows.Forms.TabPage tabPage22;
        private System.Windows.Forms.TextBox currStatusHC;
        private System.Windows.Forms.TabPage tabPage23;
        private ZedGraph.ZedGraphControl zedGraphControl7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numericUpDown25;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox tasksHCComboBox;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tasksGAComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabControl tabControl4;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.TextBox currStatusEMA;
        private System.Windows.Forms.TabPage tabPage15;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox tasksEMAComboBox;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TabControl tabControl8;
        private System.Windows.Forms.TabPage tabPage24;
        private System.Windows.Forms.TextBox currStatusMEC;
        private System.Windows.Forms.TabPage tabPage25;
        private ZedGraph.ZedGraphControl zedGraphControl8;
        protected System.Windows.Forms.NumericUpDown laggingGroupsCountMEC;
        protected System.Windows.Forms.TextBox muMEC;
        private System.Windows.Forms.NumericUpDown dimensionMEC;
        private System.Windows.Forms.TextBox minCoordinatesMEC;
        private System.Windows.Forms.TextBox maxCoordinatesMEC;
        protected System.Windows.Forms.NumericUpDown leadingGroupsCountMEC;
        protected System.Windows.Forms.NumericUpDown domainsCountMEC;
        protected System.Windows.Forms.Button runAlgorithmGSO;
        protected System.Windows.Forms.Button parseFuncGSO;
        private System.Windows.Forms.NumericUpDown dimensionGSO;
        private System.Windows.Forms.TextBox minCoordinatesGSO;
        private System.Windows.Forms.TextBox maxCoordinatesGSO;
        protected System.Windows.Forms.NumericUpDown firefliesCountGSO;
        protected System.Windows.Forms.TextBox gammaGSO;
        protected System.Windows.Forms.TextBox betaGSO;
        protected System.Windows.Forms.Button runAlgorithmEMA;
        protected System.Windows.Forms.Button parseFuncEMA;
        private System.Windows.Forms.NumericUpDown dimensionEMA;
        private System.Windows.Forms.TextBox minCoordinatesEMA;
        private System.Windows.Forms.TextBox maxCoordinatesEMA;
        protected System.Windows.Forms.NumericUpDown samplePointsCountEMA;
        private System.Windows.Forms.NumericUpDown dimensionBA;
        private System.Windows.Forms.TextBox minCoordinatesBA;
        private System.Windows.Forms.TextBox maxCoordinatesBA;
        protected System.Windows.Forms.NumericUpDown beesScoutCountBA;
        protected System.Windows.Forms.Button runAlgorithmBA;
        protected System.Windows.Forms.Button parseFuncBA;
        protected System.Windows.Forms.Button runAlgorithmHS;
        protected System.Windows.Forms.Button parseFuncHS;
        protected System.Windows.Forms.Button runAlgorithmHC;
        protected System.Windows.Forms.Button parseFuncHC;
        private System.Windows.Forms.NumericUpDown dimensionHC;
        private System.Windows.Forms.TextBox minCoordinatesHC;
        private System.Windows.Forms.TextBox maxCoordinatesHC;
        protected System.Windows.Forms.NumericUpDown iterationsHC;
        protected System.Windows.Forms.TextBox epsilonHC;
        private System.Windows.Forms.NumericUpDown dimensionGA;
        private System.Windows.Forms.TextBox minCoordinatesGA;
        private System.Windows.Forms.TextBox maxCoordinatesGA;
        protected System.Windows.Forms.NumericUpDown chromoCountGA;
        protected System.Windows.Forms.NumericUpDown popSizeGA;
        protected System.Windows.Forms.TextBox mutationProbabilityGA;
        private System.Windows.Forms.NumericUpDown dimensionHS;
        private System.Windows.Forms.TextBox minCoordinatesHS;
        private System.Windows.Forms.TextBox maxCoordinatesHS;
        protected System.Windows.Forms.NumericUpDown parHS;
        protected System.Windows.Forms.TextBox hmcrHS;
        internal System.Windows.Forms.TextBox crossProbabilityGA;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.NumericUpDown maxIterHS;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label41;
        protected System.Windows.Forms.NumericUpDown iterationsGSO;
        private System.Windows.Forms.Label label45;
        protected System.Windows.Forms.NumericUpDown groupsCountMEC;
        protected System.Windows.Forms.NumericUpDown individsCountMEC;
        protected System.Windows.Forms.TextBox sigmaMEC;
        protected System.Windows.Forms.TextBox alphaGSO;
        protected System.Windows.Forms.NumericUpDown localIterCountEMA;
        protected System.Windows.Forms.NumericUpDown maxIterCountEMA;
        protected System.Windows.Forms.NumericUpDown beesBestCountBA;
        protected System.Windows.Forms.NumericUpDown selectedAreasCountBA;
        protected System.Windows.Forms.NumericUpDown bestAreasCountBA;
        protected System.Windows.Forms.NumericUpDown beesSelectedCountBA;
        protected System.Windows.Forms.TextBox bwHS;
        protected System.Windows.Forms.NumericUpDown hmsHS;
    }
}

