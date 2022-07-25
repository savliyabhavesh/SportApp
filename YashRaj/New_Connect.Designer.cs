using System.Windows.Forms;

namespace YashAksh
{
	public partial class New_Connect : System.Windows.Forms.Form
	{
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
        private Label Label2;
        private Button Button4;
        private Button Button5;
        private Button btnCannectings;
        private CheckBox chkdate;
        private DateTimePicker DTPicker2;
        private Label Label5;
        private DateTimePicker DTPicker1;
        private DataGridView DataGridView1;
        private DataGridViewCheckBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Label Label3;
        private DataGridView DataGridView2;
        private DataGridViewCheckBoxColumn DataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        private DataGridView DataGridView4;
        private DataGridViewTextBoxColumn ca;
        private DataGridViewTextBoxColumn cb;
        private DataGridView DataGridView3;
        private DataGridViewTextBoxColumn cc;
        private DataGridViewTextBoxColumn cd;
        private Label Label4;
        private Label Label9;
        private Label Label7;
        private TextBox txtmatchID;
        private ComboBox ComboBox1;
        private Timer Timer1;
        private Label txtjuma;
        private Label txtneva;
        private TextBox txtsessionID;
        private DataGridView DataGridView5;
        private DataGridView DataGridView6;
        private DataGridView DataGridView5Jama;
        private Panel Panel2;
        private Panel Panel3;
        private Panel Panel4;
        private Panel Panel5;
        private CheckBox CheckBox1;
        private CheckBox CheckBox3;


        private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label2 = new System.Windows.Forms.Label();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.btnCannectings = new System.Windows.Forms.Button();
            this.chkdate = new System.Windows.Forms.CheckBox();
            this.DTPicker2 = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.DTPicker1 = new System.Windows.Forms.DateTimePicker();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label3 = new System.Windows.Forms.Label();
            this.DataGridView2 = new System.Windows.Forms.DataGridView();
            this.DataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView4 = new System.Windows.Forms.DataGridView();
            this.ca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView3 = new System.Windows.Forms.DataGridView();
            this.cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtmatchID = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtjuma = new System.Windows.Forms.Label();
            this.txtneva = new System.Windows.Forms.Label();
            this.txtsessionID = new System.Windows.Forms.TextBox();
            this.DataGridView5 = new System.Windows.Forms.DataGridView();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView6 = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView5Jama = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Panel5 = new System.Windows.Forms.Panel();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.CheckBox3 = new System.Windows.Forms.CheckBox();
            this.btnAgent = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView5Jama)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.Panel5.SuspendLayout();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(0, 66);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(442, 30);
            this.Label2.TabIndex = 13;
            this.Label2.Text = "Matches";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.Location = new System.Drawing.Point(918, 32);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(90, 32);
            this.Button4.TabIndex = 33;
            this.Button4.Text = "E&xit";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.SystemColors.Control;
            this.Button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button5.ForeColor = System.Drawing.Color.Black;
            this.Button5.Location = new System.Drawing.Point(822, 32);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(90, 32);
            this.Button5.TabIndex = 35;
            this.Button5.Text = "&Print";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btnCannectings
            // 
            this.btnCannectings.BackColor = System.Drawing.SystemColors.Control;
            this.btnCannectings.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCannectings.ForeColor = System.Drawing.Color.Black;
            this.btnCannectings.Location = new System.Drawing.Point(601, 32);
            this.btnCannectings.Name = "btnCannectings";
            this.btnCannectings.Size = new System.Drawing.Size(119, 32);
            this.btnCannectings.TabIndex = 32;
            this.btnCannectings.Text = "Profit / Loss";
            this.btnCannectings.UseVisualStyleBackColor = false;
            this.btnCannectings.Click += new System.EventHandler(this.btnCannectings_Click);
            // 
            // chkdate
            // 
            this.chkdate.AutoSize = true;
            this.chkdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdate.ForeColor = System.Drawing.Color.Black;
            this.chkdate.Location = new System.Drawing.Point(4, 36);
            this.chkdate.Name = "chkdate";
            this.chkdate.Size = new System.Drawing.Size(63, 23);
            this.chkdate.TabIndex = 36;
            this.chkdate.Text = "Date";
            this.chkdate.UseVisualStyleBackColor = true;
            // 
            // DTPicker2
            // 
            this.DTPicker2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPicker2.Location = new System.Drawing.Point(458, 34);
            this.DTPicker2.Name = "DTPicker2";
            this.DTPicker2.Size = new System.Drawing.Size(124, 26);
            this.DTPicker2.TabIndex = 30;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(428, 37);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(28, 19);
            this.Label5.TabIndex = 31;
            this.Label5.Text = "To";
            // 
            // DTPicker1
            // 
            this.DTPicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPicker1.Location = new System.Drawing.Point(300, 34);
            this.DTPicker1.Name = "DTPicker1";
            this.DTPicker1.Size = new System.Drawing.Size(122, 26);
            this.DTPicker1.TabIndex = 29;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AllowUserToDeleteRows = false;
            this.DataGridView1.AllowUserToResizeColumns = false;
            this.DataGridView1.AllowUserToResizeRows = false;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.EnableHeadersVisualStyles = false;
            this.DataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView1.Size = new System.Drawing.Size(442, 271);
            this.DataGridView1.TabIndex = 37;
            this.DataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            this.DataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 30;
            // 
            // Column8
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column8.HeaderText = "Sr.No";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 55;
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column2.HeaderText = "Date";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Name";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "Type";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 65;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "Result";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 75;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(0, 373);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(442, 20);
            this.Label3.TabIndex = 38;
            this.Label3.Text = "Sessions";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridView2
            // 
            this.DataGridView2.AllowUserToAddRows = false;
            this.DataGridView2.AllowUserToDeleteRows = false;
            this.DataGridView2.AllowUserToResizeColumns = false;
            this.DataGridView2.AllowUserToResizeRows = false;
            this.DataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewCheckBoxColumn1,
            this.Column9,
            this.Column10,
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.DataGridViewTextBoxColumn4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView2.EnableHeadersVisualStyles = false;
            this.DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridView2.Location = new System.Drawing.Point(0, 0);
            this.DataGridView2.Name = "DataGridView2";
            this.DataGridView2.RowHeadersVisible = false;
            this.DataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView2.Size = new System.Drawing.Size(440, 262);
            this.DataGridView2.TabIndex = 39;
            this.DataGridView2.Click += new System.EventHandler(this.DataGridView2_Click);
            this.DataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2_MouseClick);
            // 
            // DataGridViewCheckBoxColumn1
            // 
            this.DataGridViewCheckBoxColumn1.HeaderText = "";
            this.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1";
            this.DataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCheckBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DataGridViewCheckBoxColumn1.Width = 30;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Sr.No";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "MatchID";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Visible = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "Date";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            this.DataGridViewTextBoxColumn1.Width = 90;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText = "Name";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            this.DataGridViewTextBoxColumn2.ReadOnly = true;
            this.DataGridViewTextBoxColumn2.Width = 155;
            // 
            // DataGridViewTextBoxColumn4
            // 
            this.DataGridViewTextBoxColumn4.HeaderText = "Result";
            this.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4";
            this.DataGridViewTextBoxColumn4.ReadOnly = true;
            this.DataGridViewTextBoxColumn4.Width = 75;
            // 
            // DataGridView4
            // 
            this.DataGridView4.AllowUserToDeleteRows = false;
            this.DataGridView4.AllowUserToResizeColumns = false;
            this.DataGridView4.AllowUserToResizeRows = false;
            this.DataGridView4.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView4.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ca,
            this.cb,
            this.DataGridViewTextBoxColumn3,
            this.DataGridViewTextBoxColumn5,
            this.DataGridViewTextBoxColumn6});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView4.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView4.EnableHeadersVisualStyles = false;
            this.DataGridView4.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView4.Location = new System.Drawing.Point(0, 0);
            this.DataGridView4.Name = "DataGridView4";
            this.DataGridView4.ReadOnly = true;
            this.DataGridView4.RowHeadersVisible = false;
            this.DataGridView4.Size = new System.Drawing.Size(430, 527);
            this.DataGridView4.TabIndex = 40;
            // 
            // ca
            // 
            this.ca.HeaderText = "Name";
            this.ca.Name = "ca";
            this.ca.ReadOnly = true;
            // 
            // cb
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.NullValue = null;
            this.cb.DefaultCellStyle = dataGridViewCellStyle10;
            this.cb.HeaderText = "Amount";
            this.cb.Name = "cb";
            this.cb.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn3
            // 
            this.DataGridViewTextBoxColumn3.HeaderText = "";
            this.DataGridViewTextBoxColumn3.MinimumWidth = 2;
            this.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3";
            this.DataGridViewTextBoxColumn3.ReadOnly = true;
            this.DataGridViewTextBoxColumn3.Width = 3;
            // 
            // DataGridViewTextBoxColumn5
            // 
            this.DataGridViewTextBoxColumn5.HeaderText = "Name";
            this.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5";
            this.DataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn6
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.DataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewTextBoxColumn6.HeaderText = "Amount";
            this.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6";
            this.DataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // DataGridView3
            // 
            this.DataGridView3.AllowUserToDeleteRows = false;
            this.DataGridView3.AllowUserToResizeColumns = false;
            this.DataGridView3.AllowUserToResizeRows = false;
            this.DataGridView3.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cc,
            this.cd,
            this.DataGridViewTextBoxColumn7,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView3.DefaultCellStyle = dataGridViewCellStyle16;
            this.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView3.EnableHeadersVisualStyles = false;
            this.DataGridView3.GridColor = System.Drawing.SystemColors.Control;
            this.DataGridView3.Location = new System.Drawing.Point(0, 0);
            this.DataGridView3.Name = "DataGridView3";
            this.DataGridView3.ReadOnly = true;
            this.DataGridView3.RowHeadersVisible = false;
            this.DataGridView3.Size = new System.Drawing.Size(439, 527);
            this.DataGridView3.TabIndex = 41;
            // 
            // cc
            // 
            this.cc.HeaderText = "Name";
            this.cc.Name = "cc";
            this.cc.ReadOnly = true;
            // 
            // cd
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle14.NullValue = null;
            this.cd.DefaultCellStyle = dataGridViewCellStyle14;
            this.cd.HeaderText = "Amount";
            this.cd.Name = "cd";
            this.cd.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn7
            // 
            this.DataGridViewTextBoxColumn7.HeaderText = "";
            this.DataGridViewTextBoxColumn7.MinimumWidth = 2;
            this.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7";
            this.DataGridViewTextBoxColumn7.ReadOnly = true;
            this.DataGridViewTextBoxColumn7.Width = 3;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column7.HeaderText = "Amount";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(455, 65);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(875, 30);
            this.Label4.TabIndex = 42;
            this.Label4.Text = "Profit && Loss Report";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(891, 629);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(439, 31);
            this.Label9.TabIndex = 44;
            this.Label9.Text = "Debit / Name / Lena Total";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(454, 629);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(431, 31);
            this.Label7.TabIndex = 43;
            this.Label7.Text = "Credit / Jama / Dena Total";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtmatchID
            // 
            this.txtmatchID.Location = new System.Drawing.Point(19, 685);
            this.txtmatchID.Name = "txtmatchID";
            this.txtmatchID.Size = new System.Drawing.Size(100, 23);
            this.txtmatchID.TabIndex = 45;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(125, 685);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 24);
            this.ComboBox1.TabIndex = 46;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            // 
            // txtjuma
            // 
            this.txtjuma.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtjuma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjuma.ForeColor = System.Drawing.Color.Black;
            this.txtjuma.Location = new System.Drawing.Point(691, 631);
            this.txtjuma.Name = "txtjuma";
            this.txtjuma.Size = new System.Drawing.Size(191, 28);
            this.txtjuma.TabIndex = 47;
            this.txtjuma.Text = "0.00";
            this.txtjuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtneva
            // 
            this.txtneva.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtneva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtneva.ForeColor = System.Drawing.Color.Black;
            this.txtneva.Location = new System.Drawing.Point(1135, 631);
            this.txtneva.Name = "txtneva";
            this.txtneva.Size = new System.Drawing.Size(191, 28);
            this.txtneva.TabIndex = 48;
            this.txtneva.Text = "0.00";
            this.txtneva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtsessionID
            // 
            this.txtsessionID.Location = new System.Drawing.Point(252, 686);
            this.txtsessionID.Name = "txtsessionID";
            this.txtsessionID.Size = new System.Drawing.Size(100, 23);
            this.txtsessionID.TabIndex = 49;
            // 
            // DataGridView5
            // 
            this.DataGridView5.AllowUserToDeleteRows = false;
            this.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column11,
            this.Column12});
            this.DataGridView5.Location = new System.Drawing.Point(454, 663);
            this.DataGridView5.Name = "DataGridView5";
            this.DataGridView5.ReadOnly = true;
            this.DataGridView5.Size = new System.Drawing.Size(266, 67);
            this.DataGridView5.TabIndex = 52;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Column11";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Column12";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // DataGridView6
            // 
            this.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn8,
            this.DataGridViewTextBoxColumn9});
            this.DataGridView6.Location = new System.Drawing.Point(987, 663);
            this.DataGridView6.Name = "DataGridView6";
            this.DataGridView6.Size = new System.Drawing.Size(343, 67);
            this.DataGridView6.TabIndex = 53;
            // 
            // DataGridViewTextBoxColumn8
            // 
            this.DataGridViewTextBoxColumn8.HeaderText = "Column11";
            this.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8";
            // 
            // DataGridViewTextBoxColumn9
            // 
            this.DataGridViewTextBoxColumn9.HeaderText = "Column12";
            this.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9";
            // 
            // DataGridView5Jama
            // 
            this.DataGridView5Jama.AllowUserToDeleteRows = false;
            this.DataGridView5Jama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView5Jama.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn10,
            this.DataGridViewTextBoxColumn11});
            this.DataGridView5Jama.Location = new System.Drawing.Point(726, 663);
            this.DataGridView5Jama.Name = "DataGridView5Jama";
            this.DataGridView5Jama.ReadOnly = true;
            this.DataGridView5Jama.Size = new System.Drawing.Size(255, 67);
            this.DataGridView5Jama.TabIndex = 54;
            // 
            // DataGridViewTextBoxColumn10
            // 
            this.DataGridViewTextBoxColumn10.HeaderText = "Column11";
            this.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10";
            this.DataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.HeaderText = "Column12";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.DataGridView1);
            this.Panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel2.Location = new System.Drawing.Point(0, 99);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(442, 271);
            this.Panel2.TabIndex = 55;
            // 
            // Panel3
            // 
            this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel3.Controls.Add(this.DataGridView2);
            this.Panel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel3.Location = new System.Drawing.Point(0, 396);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(442, 264);
            this.Panel3.TabIndex = 56;
            // 
            // Panel4
            // 
            this.Panel4.Controls.Add(this.DataGridView4);
            this.Panel4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(455, 99);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(430, 527);
            this.Panel4.TabIndex = 57;
            // 
            // Panel5
            // 
            this.Panel5.Controls.Add(this.DataGridView3);
            this.Panel5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel5.Location = new System.Drawing.Point(891, 99);
            this.Panel5.Name = "Panel5";
            this.Panel5.Size = new System.Drawing.Size(439, 527);
            this.Panel5.TabIndex = 58;
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CheckBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.ForeColor = System.Drawing.Color.White;
            this.CheckBox1.Location = new System.Drawing.Point(73, 36);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(74, 23);
            this.CheckBox1.TabIndex = 59;
            this.CheckBox1.Text = "Match";
            this.CheckBox1.UseVisualStyleBackColor = false;
            // 
            // CheckBox3
            // 
            this.CheckBox3.AutoSize = true;
            this.CheckBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CheckBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox3.ForeColor = System.Drawing.Color.White;
            this.CheckBox3.Location = new System.Drawing.Point(153, 36);
            this.CheckBox3.Name = "CheckBox3";
            this.CheckBox3.Size = new System.Drawing.Size(90, 23);
            this.CheckBox3.TabIndex = 60;
            this.CheckBox3.Text = "Session";
            this.CheckBox3.UseVisualStyleBackColor = false;
            // 
            // btnAgent
            // 
            this.btnAgent.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgent.ForeColor = System.Drawing.Color.Black;
            this.btnAgent.Location = new System.Drawing.Point(726, 32);
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(90, 32);
            this.btnAgent.TabIndex = 61;
            this.btnAgent.Text = "&Agent";
            this.btnAgent.UseVisualStyleBackColor = false;
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel1.ForeColor = System.Drawing.Color.Black;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1334, 30);
            this.Panel1.TabIndex = 2;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(15, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(108, 19);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Profit && Loss";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(248, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 62;
            this.label6.Text = "From";
            // 
            // New_Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button4;
            this.ClientSize = new System.Drawing.Size(1334, 733);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAgent);
            this.Controls.Add(this.CheckBox3);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.Panel5);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.DataGridView5Jama);
            this.Controls.Add(this.DataGridView6);
            this.Controls.Add(this.DataGridView5);
            this.Controls.Add(this.txtsessionID);
            this.Controls.Add(this.txtneva);
            this.Controls.Add(this.txtjuma);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.txtmatchID);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.btnCannectings);
            this.Controls.Add(this.chkdate);
            this.Controls.Add(this.DTPicker2);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.DTPicker1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Panel1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "New_Connect";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.New_Connect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView5Jama)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel3.ResumeLayout(false);
            this.Panel4.ResumeLayout(false);
            this.Panel5.ResumeLayout(false);
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private System.ComponentModel.IContainer components;
        private Button btnAgent;
        private Panel Panel1;
        private Label Label1;
        private Label label6;
    }
}
