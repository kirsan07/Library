namespace Library3
{
	partial class MainForm
	{
		//<summary>
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBoxQuery = new System.Windows.Forms.RichTextBox();
			this.buttonExecute = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBoxQuery
			// 
			this.richTextBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxQuery.Location = new System.Drawing.Point(13, 13);
			this.richTextBoxQuery.MaxLength = 256;
			this.richTextBoxQuery.Multiline = false;
			this.richTextBoxQuery.Name = "richTextBoxQuery";
			this.richTextBoxQuery.Size = new System.Drawing.Size(694, 23);
			this.richTextBoxQuery.TabIndex = 0;
			this.richTextBoxQuery.Text = "";
			// 
			// buttonExecute
			// 
			this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonExecute.Location = new System.Drawing.Point(713, 11);
			this.buttonExecute.Name = "buttonExecute";
			this.buttonExecute.Size = new System.Drawing.Size(75, 23);
			this.buttonExecute.TabIndex = 1;
			this.buttonExecute.Text = "Execute";
			this.buttonExecute.UseVisualStyleBackColor = true;
			this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(13, 43);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(775, 395);
			this.dataGridView.TabIndex = 2;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.buttonExecute);
			this.Controls.Add(this.richTextBoxQuery);
			this.Name = "MainForm";
			this.Text = "Library3";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBoxQuery;
		private System.Windows.Forms.Button buttonExecute;
		private System.Windows.Forms.DataGridView dataGridView;
		//Dream is very strong minecraft player
		//cause he is playing minecraft since 16 now he is 26 years old
		//i think Dream can destroy 100 player for one life if he has big map and more time 
		//But if in team of dreams enemies would be group of skillful players it would be very hard
		//Margelov Vasiliy 
	}
}

