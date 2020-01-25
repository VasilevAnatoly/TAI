namespace SchwefelTest
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
			this.components = new System.ComponentModel.Container ();
			this.groupBox1 = new System.Windows.Forms.GroupBox ();
			this.chromoCount = new System.Windows.Forms.NumericUpDown ();
			this.popSize = new System.Windows.Forms.NumericUpDown ();
			this.mutation = new System.Windows.Forms.TextBox ();
			this.label1 = new System.Windows.Forms.Label ();
			this.label8 = new System.Windows.Forms.Label ();
			this.label10 = new System.Windows.Forms.Label ();
			this.cross = new System.Windows.Forms.TextBox ();
			this.label2 = new System.Windows.Forms.Label ();
			this.Next1000Btn = new System.Windows.Forms.Button ();
			this.CreateBtn = new System.Windows.Forms.Button ();
			this.Next10Btn = new System.Windows.Forms.Button ();
			this.Next100Btn = new System.Windows.Forms.Button ();
			this.NextBtn = new System.Windows.Forms.Button ();
			this.currStatus = new System.Windows.Forms.TextBox ();
			this.tabControl = new System.Windows.Forms.TabControl ();
			this.tabPage1 = new System.Windows.Forms.TabPage ();
			this.tabPage2 = new System.Windows.Forms.TabPage ();
			this.zedGraph = new ZedGraph.ZedGraphControl ();
			this.saveAnalytic = new System.Windows.Forms.Button ();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog ();
			this.groupBox1.SuspendLayout ();
			((System.ComponentModel.ISupportInitialize)(this.chromoCount)).BeginInit ();
			((System.ComponentModel.ISupportInitialize)(this.popSize)).BeginInit ();
			this.tabControl.SuspendLayout ();
			this.tabPage1.SuspendLayout ();
			this.tabPage2.SuspendLayout ();
			this.SuspendLayout ();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add (this.chromoCount);
			this.groupBox1.Controls.Add (this.popSize);
			this.groupBox1.Controls.Add (this.mutation);
			this.groupBox1.Controls.Add (this.label1);
			this.groupBox1.Controls.Add (this.label8);
			this.groupBox1.Controls.Add (this.label10);
			this.groupBox1.Controls.Add (this.cross);
			this.groupBox1.Controls.Add (this.label2);
			this.groupBox1.Location = new System.Drawing.Point (12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size (307, 139);
			this.groupBox1.TabIndex = 72;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры алгоритма";
			// 
			// chromoCount
			// 
			this.chromoCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.chromoCount.Location = new System.Drawing.Point (201, 97);
			this.chromoCount.Maximum = new decimal (new int[] {
            1000,
            0,
            0,
            0});
			this.chromoCount.Minimum = new decimal (new int[] {
            2,
            0,
            0,
            0});
			this.chromoCount.Name = "chromoCount";
			this.chromoCount.Size = new System.Drawing.Size (100, 20);
			this.chromoCount.TabIndex = 2;
			this.chromoCount.Value = new decimal (new int[] {
            10,
            0,
            0,
            0});
			// 
			// popSize
			// 
			this.popSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.popSize.Increment = new decimal (new int[] {
            10,
            0,
            0,
            0});
			this.popSize.Location = new System.Drawing.Point (201, 19);
			this.popSize.Maximum = new decimal (new int[] {
            100000,
            0,
            0,
            0});
			this.popSize.Minimum = new decimal (new int[] {
            2,
            0,
            0,
            0});
			this.popSize.Name = "popSize";
			this.popSize.Size = new System.Drawing.Size (100, 20);
			this.popSize.TabIndex = 2;
			this.popSize.Value = new decimal (new int[] {
            200,
            0,
            0,
            0});
			// 
			// mutation
			// 
			this.mutation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mutation.Location = new System.Drawing.Point (201, 71);
			this.mutation.Name = "mutation";
			this.mutation.Size = new System.Drawing.Size (100, 20);
			this.mutation.TabIndex = 1;
			this.mutation.Text = "10";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point (6, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (117, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Количество хромосом";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point (6, 74);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size (139, 13);
			this.label8.TabIndex = 0;
			this.label8.Text = "Вероятность мутации (%)";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point (6, 22);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size (99, 13);
			this.label10.TabIndex = 0;
			this.label10.Text = "Размер популяции";
			// 
			// cross
			// 
			this.cross.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cross.Location = new System.Drawing.Point (201, 45);
			this.cross.Name = "cross";
			this.cross.Size = new System.Drawing.Size (100, 20);
			this.cross.TabIndex = 1;
			this.cross.Text = "90";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point (6, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size (165, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Вероятность скрещивания (%)";
			// 
			// Next1000Btn
			// 
			this.Next1000Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Next1000Btn.Location = new System.Drawing.Point (333, 128);
			this.Next1000Btn.Name = "Next1000Btn";
			this.Next1000Btn.Size = new System.Drawing.Size (248, 23);
			this.Next1000Btn.TabIndex = 69;
			this.Next1000Btn.Text = "Пропустить 1000 поколений";
			this.Next1000Btn.Click += new System.EventHandler (this.Next1000Btn_Click);
			// 
			// CreateBtn
			// 
			this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateBtn.Location = new System.Drawing.Point (333, 12);
			this.CreateBtn.Name = "CreateBtn";
			this.CreateBtn.Size = new System.Drawing.Size (248, 23);
			this.CreateBtn.TabIndex = 65;
			this.CreateBtn.Text = "Создать популяцию";
			this.CreateBtn.Click += new System.EventHandler (this.CreateBtn_Click);
			// 
			// Next10Btn
			// 
			this.Next10Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Next10Btn.Location = new System.Drawing.Point (333, 70);
			this.Next10Btn.Name = "Next10Btn";
			this.Next10Btn.Size = new System.Drawing.Size (248, 23);
			this.Next10Btn.TabIndex = 50;
			this.Next10Btn.Text = "Пропустить 10 поколений";
			this.Next10Btn.Click += new System.EventHandler (this.Next10Btn_Click);
			// 
			// Next100Btn
			// 
			this.Next100Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Next100Btn.Location = new System.Drawing.Point (333, 99);
			this.Next100Btn.Name = "Next100Btn";
			this.Next100Btn.Size = new System.Drawing.Size (248, 23);
			this.Next100Btn.TabIndex = 49;
			this.Next100Btn.Text = "Пропустить 100 поколений";
			this.Next100Btn.Click += new System.EventHandler (this.Next100Btn_Click);
			// 
			// NextBtn
			// 
			this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NextBtn.Location = new System.Drawing.Point (333, 41);
			this.NextBtn.Name = "NextBtn";
			this.NextBtn.Size = new System.Drawing.Size (248, 23);
			this.NextBtn.TabIndex = 48;
			this.NextBtn.Text = "Получить следующее поколение";
			this.NextBtn.Click += new System.EventHandler (this.NextBtn_Click);
			// 
			// currStatus
			// 
			this.currStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.currStatus.Location = new System.Drawing.Point (3, 3);
			this.currStatus.Multiline = true;
			this.currStatus.Name = "currStatus";
			this.currStatus.ReadOnly = true;
			this.currStatus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.currStatus.Size = new System.Drawing.Size (555, 231);
			this.currStatus.TabIndex = 73;
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add (this.tabPage1);
			this.tabControl.Controls.Add (this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point (12, 179);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size (569, 263);
			this.tabControl.TabIndex = 74;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add (this.currStatus);
			this.tabPage1.Location = new System.Drawing.Point (4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding (3);
			this.tabPage1.Size = new System.Drawing.Size (561, 237);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Решение";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add (this.zedGraph);
			this.tabPage2.Location = new System.Drawing.Point (4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding (3);
			this.tabPage2.Size = new System.Drawing.Size (561, 259);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Сходимость";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// zedGraph
			// 
			this.zedGraph.Dock = System.Windows.Forms.DockStyle.Fill;
			this.zedGraph.EditButtons = System.Windows.Forms.MouseButtons.None;
			this.zedGraph.IsEnableHZoom = false;
			this.zedGraph.IsShowContextMenu = false;
			this.zedGraph.IsShowCopyMessage = false;
			this.zedGraph.Location = new System.Drawing.Point (3, 3);
			this.zedGraph.Name = "zedGraph";
			this.zedGraph.ScrollGrace = 0;
			this.zedGraph.ScrollMaxX = 0;
			this.zedGraph.ScrollMaxY = 0;
			this.zedGraph.ScrollMaxY2 = 0;
			this.zedGraph.ScrollMinX = 0;
			this.zedGraph.ScrollMinY = 0;
			this.zedGraph.ScrollMinY2 = 0;
			this.zedGraph.Size = new System.Drawing.Size (555, 253);
			this.zedGraph.TabIndex = 0;
			// 
			// saveAnalytic
			// 
			this.saveAnalytic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveAnalytic.Location = new System.Drawing.Point (333, 157);
			this.saveAnalytic.Name = "saveAnalytic";
			this.saveAnalytic.Size = new System.Drawing.Size (248, 23);
			this.saveAnalytic.TabIndex = 69;
			this.saveAnalytic.Text = "Сохранить статистику…";
			this.saveAnalytic.Click += new System.EventHandler (this.saveAnalytic_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.DefaultExt = "txt";
			this.saveFileDialog.Filter = "*.txt|*.txt|Все файлы|*.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (593, 454);
			this.Controls.Add (this.tabControl);
			this.Controls.Add (this.groupBox1);
			this.Controls.Add (this.saveAnalytic);
			this.Controls.Add (this.Next1000Btn);
			this.Controls.Add (this.CreateBtn);
			this.Controls.Add (this.Next10Btn);
			this.Controls.Add (this.Next100Btn);
			this.Controls.Add (this.NextBtn);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.groupBox1.ResumeLayout (false);
			this.groupBox1.PerformLayout ();
			((System.ComponentModel.ISupportInitialize)(this.chromoCount)).EndInit ();
			((System.ComponentModel.ISupportInitialize)(this.popSize)).EndInit ();
			this.tabControl.ResumeLayout (false);
			this.tabPage1.ResumeLayout (false);
			this.tabPage1.PerformLayout ();
			this.tabPage2.ResumeLayout (false);
			this.ResumeLayout (false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		protected System.Windows.Forms.NumericUpDown popSize;
		protected System.Windows.Forms.TextBox mutation;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		protected System.Windows.Forms.TextBox cross;
		private System.Windows.Forms.Label label2;
		protected System.Windows.Forms.Button Next1000Btn;
		protected System.Windows.Forms.Button CreateBtn;
		protected System.Windows.Forms.Button Next10Btn;
		protected System.Windows.Forms.Button Next100Btn;
		protected System.Windows.Forms.Button NextBtn;
		private System.Windows.Forms.TextBox currStatus;
		protected System.Windows.Forms.NumericUpDown chromoCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private ZedGraph.ZedGraphControl zedGraph;
		protected System.Windows.Forms.Button saveAnalytic;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}

