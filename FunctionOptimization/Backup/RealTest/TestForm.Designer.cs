namespace RealTest
{
	partial class TestForm
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
			this.label = new System.Windows.Forms.Label ();
			this.label4 = new System.Windows.Forms.Label ();
			this.label6 = new System.Windows.Forms.Label ();
			this.label11 = new System.Windows.Forms.Label ();
			this.label9 = new System.Windows.Forms.Label ();
			this.label7 = new System.Windows.Forms.Label ();
			this.label5 = new System.Windows.Forms.Label ();
			this.label3 = new System.Windows.Forms.Label ();
			this.label1 = new System.Windows.Forms.Label ();
			this.Next1000Btn = new System.Windows.Forms.Button ();
			this.CreateBtn = new System.Windows.Forms.Button ();
			this.Next10Btn = new System.Windows.Forms.Button ();
			this.Next100Btn = new System.Windows.Forms.Button ();
			this.NextBtn = new System.Windows.Forms.Button ();
			this.groupBox1 = new System.Windows.Forms.GroupBox ();
			this.popSize = new System.Windows.Forms.NumericUpDown ();
			this.mutation = new System.Windows.Forms.TextBox ();
			this.label8 = new System.Windows.Forms.Label ();
			this.label10 = new System.Windows.Forms.Label ();
			this.cross = new System.Windows.Forms.TextBox ();
			this.label2 = new System.Windows.Forms.Label ();
			this.saveStats = new System.Windows.Forms.Button ();
			this.a0 = new System.Windows.Forms.TextBox ();
			this.a1 = new System.Windows.Forms.TextBox ();
			this.a2 = new System.Windows.Forms.TextBox ();
			this.a3 = new System.Windows.Forms.TextBox ();
			this.a4 = new System.Windows.Forms.TextBox ();
			this.a5 = new System.Windows.Forms.TextBox ();
			this.BestFunc = new System.Windows.Forms.TextBox ();
			this.Generation = new System.Windows.Forms.TextBox ();
			this.Perf = new System.Windows.Forms.TextBox ();
			this.rightVals = new System.Windows.Forms.TextBox ();
			this.groupBox1.SuspendLayout ();
			((System.ComponentModel.ISupportInitialize)(this.popSize)).BeginInit ();
			this.SuspendLayout ();
			// 
			// label
			// 
			this.label.AutoSize = true;
			this.label.Location = new System.Drawing.Point (16, 381);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size (82, 13);
			this.label.TabIndex = 45;
			this.label.Text = "Время работы:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point (16, 355);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size (62, 13);
			this.label4.TabIndex = 42;
			this.label4.Text = "Поколение";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point (16, 329);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size (74, 13);
			this.label6.TabIndex = 39;
			this.label6.Text = "Погрешность";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point (16, 292);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size (33, 13);
			this.label11.TabIndex = 37;
			this.label11.Text = "a5 = ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point (16, 266);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size (33, 13);
			this.label9.TabIndex = 35;
			this.label9.Text = "a4 = ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point (16, 240);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size (33, 13);
			this.label7.TabIndex = 33;
			this.label7.Text = "a3 = ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point (16, 218);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size (33, 13);
			this.label5.TabIndex = 31;
			this.label5.Text = "a2 = ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point (16, 188);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size (33, 13);
			this.label3.TabIndex = 29;
			this.label3.Text = "a1 = ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point (16, 162);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size (33, 13);
			this.label1.TabIndex = 27;
			this.label1.Text = "a0 = ";
			// 
			// Next1000Btn
			// 
			this.Next1000Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Next1000Btn.Location = new System.Drawing.Point (368, 128);
			this.Next1000Btn.Name = "Next1000Btn";
			this.Next1000Btn.Size = new System.Drawing.Size (248, 23);
			this.Next1000Btn.TabIndex = 44;
			this.Next1000Btn.Text = "Пропустить 1000 поколений";
			// 
			// CreateBtn
			// 
			this.CreateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CreateBtn.Location = new System.Drawing.Point (368, 12);
			this.CreateBtn.Name = "CreateBtn";
			this.CreateBtn.Size = new System.Drawing.Size (248, 23);
			this.CreateBtn.TabIndex = 41;
			this.CreateBtn.Text = "Создать популяцию";
			// 
			// Next10Btn
			// 
			this.Next10Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Next10Btn.Location = new System.Drawing.Point (368, 70);
			this.Next10Btn.Name = "Next10Btn";
			this.Next10Btn.Size = new System.Drawing.Size (248, 23);
			this.Next10Btn.TabIndex = 26;
			this.Next10Btn.Text = "Пропустить 10 поколений";
			// 
			// Next100Btn
			// 
			this.Next100Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Next100Btn.Location = new System.Drawing.Point (368, 99);
			this.Next100Btn.Name = "Next100Btn";
			this.Next100Btn.Size = new System.Drawing.Size (248, 23);
			this.Next100Btn.TabIndex = 25;
			this.Next100Btn.Text = "Пропустить 100 поколений";
			// 
			// NextBtn
			// 
			this.NextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NextBtn.Location = new System.Drawing.Point (368, 41);
			this.NextBtn.Name = "NextBtn";
			this.NextBtn.Size = new System.Drawing.Size (248, 23);
			this.NextBtn.TabIndex = 24;
			this.NextBtn.Text = "Получить следующее поколение";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add (this.popSize);
			this.groupBox1.Controls.Add (this.mutation);
			this.groupBox1.Controls.Add (this.label8);
			this.groupBox1.Controls.Add (this.label10);
			this.groupBox1.Controls.Add (this.cross);
			this.groupBox1.Controls.Add (this.label2);
			this.groupBox1.Location = new System.Drawing.Point (12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size (347, 139);
			this.groupBox1.TabIndex = 47;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры алгоритма";
			// 
			// popSize
			// 
			this.popSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.popSize.Increment = new decimal (new int[] {
            10,
            0,
            0,
            0});
			this.popSize.Location = new System.Drawing.Point (241, 19);
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
            5000,
            0,
            0,
            0});
			// 
			// mutation
			// 
			this.mutation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mutation.Location = new System.Drawing.Point (241, 71);
			this.mutation.Name = "mutation";
			this.mutation.Size = new System.Drawing.Size (100, 20);
			this.mutation.TabIndex = 1;
			this.mutation.Text = "10";
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
			this.cross.Location = new System.Drawing.Point (241, 45);
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
			// saveStats
			// 
			this.saveStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.saveStats.Location = new System.Drawing.Point (368, 157);
			this.saveStats.Name = "saveStats";
			this.saveStats.Size = new System.Drawing.Size (248, 23);
			this.saveStats.TabIndex = 44;
			this.saveStats.Text = "Сохранить статистику";
			// 
			// a0
			// 
			this.a0.Location = new System.Drawing.Point (119, 159);
			this.a0.Name = "a0";
			this.a0.ReadOnly = true;
			this.a0.Size = new System.Drawing.Size (240, 20);
			this.a0.TabIndex = 48;
			// 
			// a1
			// 
			this.a1.Location = new System.Drawing.Point (119, 185);
			this.a1.Name = "a1";
			this.a1.ReadOnly = true;
			this.a1.Size = new System.Drawing.Size (240, 20);
			this.a1.TabIndex = 48;
			// 
			// a2
			// 
			this.a2.Location = new System.Drawing.Point (119, 211);
			this.a2.Name = "a2";
			this.a2.ReadOnly = true;
			this.a2.Size = new System.Drawing.Size (240, 20);
			this.a2.TabIndex = 48;
			// 
			// a3
			// 
			this.a3.Location = new System.Drawing.Point (119, 237);
			this.a3.Name = "a3";
			this.a3.ReadOnly = true;
			this.a3.Size = new System.Drawing.Size (240, 20);
			this.a3.TabIndex = 48;
			// 
			// a4
			// 
			this.a4.Location = new System.Drawing.Point (119, 263);
			this.a4.Name = "a4";
			this.a4.ReadOnly = true;
			this.a4.Size = new System.Drawing.Size (240, 20);
			this.a4.TabIndex = 48;
			// 
			// a5
			// 
			this.a5.Location = new System.Drawing.Point (119, 289);
			this.a5.Name = "a5";
			this.a5.ReadOnly = true;
			this.a5.Size = new System.Drawing.Size (240, 20);
			this.a5.TabIndex = 48;
			// 
			// BestFunc
			// 
			this.BestFunc.Location = new System.Drawing.Point (119, 326);
			this.BestFunc.Name = "BestFunc";
			this.BestFunc.ReadOnly = true;
			this.BestFunc.Size = new System.Drawing.Size (240, 20);
			this.BestFunc.TabIndex = 48;
			// 
			// Generation
			// 
			this.Generation.Location = new System.Drawing.Point (119, 352);
			this.Generation.Name = "Generation";
			this.Generation.ReadOnly = true;
			this.Generation.Size = new System.Drawing.Size (240, 20);
			this.Generation.TabIndex = 48;
			// 
			// Perf
			// 
			this.Perf.Location = new System.Drawing.Point (119, 378);
			this.Perf.Name = "Perf";
			this.Perf.ReadOnly = true;
			this.Perf.Size = new System.Drawing.Size (240, 20);
			this.Perf.TabIndex = 48;
			// 
			// rightVals
			// 
			this.rightVals.Location = new System.Drawing.Point (368, 185);
			this.rightVals.Multiline = true;
			this.rightVals.Name = "rightVals";
			this.rightVals.ReadOnly = true;
			this.rightVals.Size = new System.Drawing.Size (248, 213);
			this.rightVals.TabIndex = 49;
			// 
			// TestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF (6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size (628, 423);
			this.Controls.Add (this.rightVals);
			this.Controls.Add (this.Perf);
			this.Controls.Add (this.Generation);
			this.Controls.Add (this.BestFunc);
			this.Controls.Add (this.a5);
			this.Controls.Add (this.a4);
			this.Controls.Add (this.a3);
			this.Controls.Add (this.a2);
			this.Controls.Add (this.a1);
			this.Controls.Add (this.a0);
			this.Controls.Add (this.groupBox1);
			this.Controls.Add (this.label);
			this.Controls.Add (this.label4);
			this.Controls.Add (this.label6);
			this.Controls.Add (this.label11);
			this.Controls.Add (this.label9);
			this.Controls.Add (this.label7);
			this.Controls.Add (this.label5);
			this.Controls.Add (this.label3);
			this.Controls.Add (this.label1);
			this.Controls.Add (this.saveStats);
			this.Controls.Add (this.Next1000Btn);
			this.Controls.Add (this.CreateBtn);
			this.Controls.Add (this.Next10Btn);
			this.Controls.Add (this.Next100Btn);
			this.Controls.Add (this.NextBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "TestForm";
			this.ShowInTaskbar = false;
			this.Text = "Проверка генетического алгоритма";
			this.groupBox1.ResumeLayout (false);
			this.groupBox1.PerformLayout ();
			((System.ComponentModel.ISupportInitialize)(this.popSize)).EndInit ();
			this.ResumeLayout (false);
			this.PerformLayout ();

		}

		#endregion

		protected System.Windows.Forms.Label label;
		protected System.Windows.Forms.Label label4;
		protected System.Windows.Forms.Label label6;
		protected System.Windows.Forms.Label label11;
		protected System.Windows.Forms.Label label9;
		protected System.Windows.Forms.Label label7;
		protected System.Windows.Forms.Label label5;
		protected System.Windows.Forms.Label label3;
		protected System.Windows.Forms.Label label1;
		protected System.Windows.Forms.Button Next1000Btn;
		protected System.Windows.Forms.Button CreateBtn;
		protected System.Windows.Forms.Button Next10Btn;
		protected System.Windows.Forms.Button Next100Btn;
		protected System.Windows.Forms.Button NextBtn;
		private System.Windows.Forms.GroupBox groupBox1;
		protected System.Windows.Forms.TextBox mutation;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label10;
		protected System.Windows.Forms.TextBox cross;
		private System.Windows.Forms.Label label2;
		protected System.Windows.Forms.NumericUpDown popSize;
		protected System.Windows.Forms.Button saveStats;
		protected System.Windows.Forms.TextBox a0;
		protected System.Windows.Forms.TextBox a1;
		protected System.Windows.Forms.TextBox a2;
		protected System.Windows.Forms.TextBox a3;
		protected System.Windows.Forms.TextBox a4;
		protected System.Windows.Forms.TextBox a5;
		protected System.Windows.Forms.TextBox BestFunc;
		protected System.Windows.Forms.TextBox Generation;
		protected System.Windows.Forms.TextBox Perf;
		protected System.Windows.Forms.TextBox rightVals;
	}
}