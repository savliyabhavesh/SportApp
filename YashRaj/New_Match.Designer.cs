using System.Windows.Forms;

namespace YashAksh
{
    public partial class New_Match : Form
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

		
		private void InitializeComponent()
		{
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtteam2 = new System.Windows.Forms.TextBox();
            this.txtteam1 = new System.Windows.Forms.TextBox();
            this.txth15 = new System.Windows.Forms.TextBox();
            this.txth14 = new System.Windows.Forms.TextBox();
            this.txth13 = new System.Windows.Forms.TextBox();
            this.txth12 = new System.Windows.Forms.TextBox();
            this.txth11 = new System.Windows.Forms.TextBox();
            this.txth10 = new System.Windows.Forms.TextBox();
            this.txth9 = new System.Windows.Forms.TextBox();
            this.txth8 = new System.Windows.Forms.TextBox();
            this.txth7 = new System.Windows.Forms.TextBox();
            this.txth6 = new System.Windows.Forms.TextBox();
            this.txth5 = new System.Windows.Forms.TextBox();
            this.txth4 = new System.Windows.Forms.TextBox();
            this.txth3 = new System.Windows.Forms.TextBox();
            this.txth2 = new System.Windows.Forms.TextBox();
            this.txth1 = new System.Windows.Forms.TextBox();
            this.txttype = new System.Windows.Forms.ComboBox();
            this.txtdate = new System.Windows.Forms.DateTimePicker();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.Label21 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtid);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.txtteam2);
            this.GroupBox2.Controls.Add(this.txtteam1);
            this.GroupBox2.Controls.Add(this.txth15);
            this.GroupBox2.Controls.Add(this.txth14);
            this.GroupBox2.Controls.Add(this.txth13);
            this.GroupBox2.Controls.Add(this.txth12);
            this.GroupBox2.Controls.Add(this.txth11);
            this.GroupBox2.Controls.Add(this.txth10);
            this.GroupBox2.Controls.Add(this.txth9);
            this.GroupBox2.Controls.Add(this.txth8);
            this.GroupBox2.Controls.Add(this.txth7);
            this.GroupBox2.Controls.Add(this.txth6);
            this.GroupBox2.Controls.Add(this.txth5);
            this.GroupBox2.Controls.Add(this.txth4);
            this.GroupBox2.Controls.Add(this.txth3);
            this.GroupBox2.Controls.Add(this.txth2);
            this.GroupBox2.Controls.Add(this.txth1);
            this.GroupBox2.Controls.Add(this.txttype);
            this.GroupBox2.Controls.Add(this.txtdate);
            this.GroupBox2.Controls.Add(this.Label18);
            this.GroupBox2.Controls.Add(this.Label19);
            this.GroupBox2.Controls.Add(this.Label20);
            this.GroupBox2.Controls.Add(this.Label21);
            this.GroupBox2.Controls.Add(this.Label14);
            this.GroupBox2.Controls.Add(this.Label15);
            this.GroupBox2.Controls.Add(this.Label16);
            this.GroupBox2.Controls.Add(this.Label17);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.Label12);
            this.GroupBox2.Controls.Add(this.Label13);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.ForeColor = System.Drawing.Color.Red;
            this.GroupBox2.Location = new System.Drawing.Point(1, 32);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(924, 393);
            this.GroupBox2.TabIndex = 0;
            this.GroupBox2.TabStop = false;
            // 
            // txtid
            // 
            this.txtid.BackColor = System.Drawing.Color.White;
            this.txtid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(14, 60);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(196, 26);
            this.txtid.TabIndex = 0;
            this.txtid.Text = "1";
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(17, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(193, 25);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Sr. No.";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtteam2
            // 
            this.txtteam2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteam2.Location = new System.Drawing.Point(14, 279);
            this.txtteam2.Name = "txtteam2";
            this.txtteam2.Size = new System.Drawing.Size(195, 26);
            this.txtteam2.TabIndex = 3;
            this.txtteam2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtteam2.TextChanged += new System.EventHandler(this.txtteam2_TextChanged);
            this.txtteam2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txtteam1
            // 
            this.txtteam1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtteam1.Location = new System.Drawing.Point(14, 208);
            this.txtteam1.Name = "txtteam1";
            this.txtteam1.Size = new System.Drawing.Size(195, 26);
            this.txtteam1.TabIndex = 2;
            this.txtteam1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtteam1.TextChanged += new System.EventHandler(this.txtteam1_TextChanged);
            this.txtteam1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth15
            // 
            this.txth15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth15.Location = new System.Drawing.Point(713, 353);
            this.txth15.Name = "txth15";
            this.txth15.Size = new System.Drawing.Size(196, 26);
            this.txth15.TabIndex = 17;
            this.txth15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth15.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth14
            // 
            this.txth14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth14.Location = new System.Drawing.Point(478, 353);
            this.txth14.Name = "txth14";
            this.txth14.Size = new System.Drawing.Size(196, 26);
            this.txth14.TabIndex = 16;
            this.txth14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth14.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth13
            // 
            this.txth13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth13.Location = new System.Drawing.Point(245, 353);
            this.txth13.Name = "txth13";
            this.txth13.Size = new System.Drawing.Size(196, 26);
            this.txth13.TabIndex = 15;
            this.txth13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth13.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth12
            // 
            this.txth12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth12.Location = new System.Drawing.Point(713, 279);
            this.txth12.Name = "txth12";
            this.txth12.Size = new System.Drawing.Size(196, 26);
            this.txth12.TabIndex = 14;
            this.txth12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth12.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth11
            // 
            this.txth11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth11.Location = new System.Drawing.Point(478, 279);
            this.txth11.Name = "txth11";
            this.txth11.Size = new System.Drawing.Size(196, 26);
            this.txth11.TabIndex = 13;
            this.txth11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth11.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth10
            // 
            this.txth10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth10.Location = new System.Drawing.Point(245, 279);
            this.txth10.Name = "txth10";
            this.txth10.Size = new System.Drawing.Size(196, 26);
            this.txth10.TabIndex = 12;
            this.txth10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth10.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth9
            // 
            this.txth9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth9.Location = new System.Drawing.Point(713, 208);
            this.txth9.Name = "txth9";
            this.txth9.Size = new System.Drawing.Size(196, 26);
            this.txth9.TabIndex = 11;
            this.txth9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth8
            // 
            this.txth8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth8.Location = new System.Drawing.Point(478, 208);
            this.txth8.Name = "txth8";
            this.txth8.Size = new System.Drawing.Size(196, 26);
            this.txth8.TabIndex = 10;
            this.txth8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth8.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth7
            // 
            this.txth7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth7.Location = new System.Drawing.Point(245, 208);
            this.txth7.Name = "txth7";
            this.txth7.Size = new System.Drawing.Size(196, 26);
            this.txth7.TabIndex = 9;
            this.txth7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth6
            // 
            this.txth6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth6.Location = new System.Drawing.Point(713, 135);
            this.txth6.Name = "txth6";
            this.txth6.Size = new System.Drawing.Size(196, 26);
            this.txth6.TabIndex = 8;
            this.txth6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth5
            // 
            this.txth5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth5.Location = new System.Drawing.Point(478, 135);
            this.txth5.Name = "txth5";
            this.txth5.Size = new System.Drawing.Size(196, 26);
            this.txth5.TabIndex = 7;
            this.txth5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth4
            // 
            this.txth4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth4.Location = new System.Drawing.Point(245, 135);
            this.txth4.Name = "txth4";
            this.txth4.Size = new System.Drawing.Size(196, 26);
            this.txth4.TabIndex = 6;
            this.txth4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth3
            // 
            this.txth3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth3.Location = new System.Drawing.Point(713, 60);
            this.txth3.Name = "txth3";
            this.txth3.Size = new System.Drawing.Size(196, 26);
            this.txth3.TabIndex = 5;
            this.txth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth2
            // 
            this.txth2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth2.Location = new System.Drawing.Point(478, 60);
            this.txth2.Name = "txth2";
            this.txth2.Size = new System.Drawing.Size(196, 26);
            this.txth2.TabIndex = 28;
            this.txth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txth1
            // 
            this.txth1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txth1.Location = new System.Drawing.Point(245, 60);
            this.txth1.Name = "txth1";
            this.txth1.Size = new System.Drawing.Size(196, 26);
            this.txth1.TabIndex = 27;
            this.txth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txth1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // txttype
            // 
            this.txttype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txttype.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttype.FormattingEnabled = true;
            this.txttype.Items.AddRange(new object[] {
            "TEST",
            "50-50",
            "20-20",
            "10-10",
            "CUP",
            "TOSS"});
            this.txttype.Location = new System.Drawing.Point(14, 353);
            this.txttype.Name = "txttype";
            this.txttype.Size = new System.Drawing.Size(196, 27);
            this.txttype.TabIndex = 4;
            this.txttype.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            this.txttype.Leave += new System.EventHandler(this.txttype_Leave);
            // 
            // txtdate
            // 
            this.txtdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdate.Location = new System.Drawing.Point(14, 135);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(195, 26);
            this.txtdate.TabIndex = 1;
            this.txtdate.Value = new System.DateTime(2012, 2, 5, 14, 59, 37, 0);
            this.txtdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtid_KeyDown);
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label18.ForeColor = System.Drawing.Color.Black;
            this.Label18.Location = new System.Drawing.Point(713, 322);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(196, 25);
            this.Label18.TabIndex = 21;
            this.Label18.Text = "Horse 15";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label19.ForeColor = System.Drawing.Color.Black;
            this.Label19.Location = new System.Drawing.Point(478, 322);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(196, 25);
            this.Label19.TabIndex = 20;
            this.Label19.Text = "Horse 14";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label20
            // 
            this.Label20.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label20.ForeColor = System.Drawing.Color.Black;
            this.Label20.Location = new System.Drawing.Point(245, 322);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(196, 25);
            this.Label20.TabIndex = 19;
            this.Label20.Text = "Horse 13";
            this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label21.ForeColor = System.Drawing.Color.Black;
            this.Label21.Location = new System.Drawing.Point(16, 322);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(193, 25);
            this.Label21.TabIndex = 18;
            this.Label21.Text = "Type";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.ForeColor = System.Drawing.Color.Black;
            this.Label14.Location = new System.Drawing.Point(713, 248);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(196, 25);
            this.Label14.TabIndex = 17;
            this.Label14.Text = "Horse 12";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.ForeColor = System.Drawing.Color.Black;
            this.Label15.Location = new System.Drawing.Point(478, 248);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(196, 25);
            this.Label15.TabIndex = 16;
            this.Label15.Text = "Horse 11";
            this.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.ForeColor = System.Drawing.Color.Black;
            this.Label16.Location = new System.Drawing.Point(245, 248);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(196, 25);
            this.Label16.TabIndex = 15;
            this.Label16.Text = "Horse 10";
            this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.ForeColor = System.Drawing.Color.Black;
            this.Label17.Location = new System.Drawing.Point(16, 248);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(193, 25);
            this.Label17.TabIndex = 14;
            this.Label17.Text = "Team2";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Black;
            this.Label10.Location = new System.Drawing.Point(713, 176);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(196, 25);
            this.Label10.TabIndex = 13;
            this.Label10.Text = "Horse 9";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Black;
            this.Label11.Location = new System.Drawing.Point(478, 176);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(196, 25);
            this.Label11.TabIndex = 12;
            this.Label11.Text = "Horse 8";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.ForeColor = System.Drawing.Color.Black;
            this.Label12.Location = new System.Drawing.Point(245, 176);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(196, 25);
            this.Label12.TabIndex = 11;
            this.Label12.Text = "Horse 7";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.ForeColor = System.Drawing.Color.Black;
            this.Label13.Location = new System.Drawing.Point(16, 176);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(193, 25);
            this.Label13.TabIndex = 10;
            this.Label13.Text = "Team1";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(713, 101);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(196, 25);
            this.Label6.TabIndex = 9;
            this.Label6.Text = "Horse 6";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Black;
            this.Label7.Location = new System.Drawing.Point(478, 101);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(196, 25);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Horse 5";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Black;
            this.Label8.Location = new System.Drawing.Point(245, 101);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(196, 25);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Horse 4";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Black;
            this.Label9.Location = new System.Drawing.Point(16, 101);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(193, 25);
            this.Label9.TabIndex = 6;
            this.Label9.Text = "Date";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Black;
            this.Label5.Location = new System.Drawing.Point(713, 28);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(196, 25);
            this.Label5.TabIndex = 5;
            this.Label5.Text = "Horse 3";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(478, 28);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(196, 25);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "Horse 2";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Black;
            this.Label3.Location = new System.Drawing.Point(245, 28);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(196, 25);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Horse 1";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.SystemColors.Control;
            this.Button1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Black;
            this.Button1.Location = new System.Drawing.Point(6, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(110, 32);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "&Save";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2.ForeColor = System.Drawing.Color.White;
            this.Button2.Location = new System.Drawing.Point(134, 12);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(101, 32);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "&Close";
            this.Button2.UseVisualStyleBackColor = false;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Button1);
            this.GroupBox3.Controls.Add(this.Button2);
            this.GroupBox3.Location = new System.Drawing.Point(682, 427);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(243, 47);
            this.GroupBox3.TabIndex = 4;
            this.GroupBox3.TabStop = false;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Black;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1276, 30);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "New Match";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // New_Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Button2;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "New_Match";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "New_Match";
            this.Deactivate += new System.EventHandler(this.New_Match_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.New_Match_FormClosing);
            this.Load += new System.EventHandler(this.New_Match_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.New_Match_KeyDown);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

	
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.GroupBox GroupBox2;
		private System.Windows.Forms.TextBox txtteam2;
		private System.Windows.Forms.TextBox txtteam1;
		private System.Windows.Forms.TextBox txth15;
		private System.Windows.Forms.TextBox txth14;
		private System.Windows.Forms.TextBox txth13;
		private System.Windows.Forms.TextBox txth12;
		private System.Windows.Forms.TextBox txth11;
		private System.Windows.Forms.TextBox txth10;
		private System.Windows.Forms.TextBox txth9;
		private System.Windows.Forms.TextBox txth8;
		private System.Windows.Forms.TextBox txth7;
		private System.Windows.Forms.TextBox txth6;
		private System.Windows.Forms.TextBox txth5;
		private System.Windows.Forms.TextBox txth4;
		private System.Windows.Forms.TextBox txth3;
		private System.Windows.Forms.TextBox txth2;
		private System.Windows.Forms.TextBox txth1;
		private System.Windows.Forms.ComboBox txttype;
		private System.Windows.Forms.DateTimePicker txtdate;
		private System.Windows.Forms.Label Label18;
		private System.Windows.Forms.Label Label19;
		private System.Windows.Forms.Label Label20;
		private System.Windows.Forms.Label Label21;
		private System.Windows.Forms.Label Label14;
		private System.Windows.Forms.Label Label15;
		private System.Windows.Forms.Label Label16;
		private System.Windows.Forms.Label Label17;
		private System.Windows.Forms.Label Label10;
		private System.Windows.Forms.Label Label11;
		private System.Windows.Forms.Label Label12;
		private System.Windows.Forms.Label Label13;
		private System.Windows.Forms.Label Label6;
		private System.Windows.Forms.Label Label7;
		private System.Windows.Forms.Label Label8;
		private System.Windows.Forms.Label Label9;
		private System.Windows.Forms.Label Label5;
		private System.Windows.Forms.Label Label4;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Button Button1;
		private System.Windows.Forms.Button Button2;
		private System.Windows.Forms.GroupBox GroupBox3;
		private System.Windows.Forms.Label Label1;
        //private MY_DBDataSetTableAdapters.NewmatchTableAdapter newmatchTableAdapter;
    }
}
