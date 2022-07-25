namespace YashAksh
{
	// Token: 0x0200000C RID: 12
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class Balance_Message : System.Windows.Forms.Form
	{
		// Token: 0x060003D8 RID: 984 RVA: 0x0029FB78 File Offset: 0x0029DF78
		//[System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && this.components != null)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0029FBB8 File Offset: 0x0029DFB8
		//[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(16, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(237, 16);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Sorry Balance Limit over Flow.?";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.White;
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.Label2.Location = new System.Drawing.Point(0, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(288, 16);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Balance Limit";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Button1
            // 
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.Location = new System.Drawing.Point(109, 68);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(63, 26);
            this.Button1.TabIndex = 16;
            this.Button1.Text = "&OK";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 16);
            this.label3.TabIndex = 17;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Balance_Message
            // 
            this.AcceptButton = this.Button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(288, 109);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Balance_Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Balance_Message_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040001C1 RID: 449
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Label label3;
    }
}
