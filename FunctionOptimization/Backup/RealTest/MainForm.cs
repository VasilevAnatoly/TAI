using System;


namespace RealTest
{
	/// <summary>
	/// Summary description for MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button DoubleBtn;
		private System.Windows.Forms.Button IntBtn;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DoubleBtn = new System.Windows.Forms.Button ();
			this.IntBtn = new System.Windows.Forms.Button ();
			this.SuspendLayout ();
			// 
			// DoubleBtn
			// 
			this.DoubleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.DoubleBtn.Location = new System.Drawing.Point (24, 16);
			this.DoubleBtn.Name = "DoubleBtn";
			this.DoubleBtn.Size = new System.Drawing.Size (263, 23);
			this.DoubleBtn.TabIndex = 0;
			this.DoubleBtn.Text = "Тест дробных хромосом…";
			this.DoubleBtn.Click += new System.EventHandler (this.DoubleBtn_Click);
			// 
			// IntBtn
			// 
			this.IntBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.IntBtn.Location = new System.Drawing.Point (24, 45);
			this.IntBtn.Name = "IntBtn";
			this.IntBtn.Size = new System.Drawing.Size (263, 23);
			this.IntBtn.TabIndex = 1;
			this.IntBtn.Text = "Тест целых хромосом…";
			this.IntBtn.Click += new System.EventHandler (this.IntBtn_Click);
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size (5, 13);
			this.ClientSize = new System.Drawing.Size (299, 79);
			this.Controls.Add (this.IntBtn);
			this.Controls.Add (this.DoubleBtn);
			this.Name = "MainForm";
			this.Text = "Тест генетического алгоритма";
			this.ResumeLayout (false);

		}
		#endregion

		private void DoubleBtn_Click(object sender, System.EventArgs e)
		{
			DoubleForm form = new DoubleForm();
			form.ShowDialog();
		}

		private void IntBtn_Click(object sender, System.EventArgs e)
		{
			IntForm form = new IntForm();
			form.ShowDialog();
		}
	}
}
