namespace WindowsFormsApplication1
{
    partial class Form5
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.tbxDriverNightRate = new System.Windows.Forms.TextBox();
            this.tbxNightParkRate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbxExtraHRate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbxExtraKmRate = new System.Windows.Forms.TextBox();
            this.tbxMaxHrs = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbxMaxKm = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cmbPackageId = new System.Windows.Forms.ComboBox();
            this.tbxPackageType = new System.Windows.Forms.TextBox();
            this.tbxPackageRate = new System.Windows.Forms.TextBox();
            this.tbxVehicalType = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbxExtraKm = new System.Windows.Forms.TextBox();
            this.TbxNo_of_Km = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btncaKm = new System.Windows.Forms.Button();
            this.tbxExtraKmcharge = new System.Windows.Forms.TextBox();
            this.tbxStartKm = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxEndKm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Calculation = new System.Windows.Forms.GroupBox();
            this.btncalTotDays = new System.Windows.Forms.Button();
            this.tbxTotalDate = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtRented = new System.Windows.Forms.DateTimePicker();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnTotalLongTour = new System.Windows.Forms.Button();
            this.tbxLongTourTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Calculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.tbxDriverNightRate);
            this.groupBox1.Controls.Add(this.tbxNightParkRate);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.tbxExtraHRate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.tbxExtraKmRate);
            this.groupBox1.Controls.Add(this.tbxMaxHrs);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.tbxMaxKm);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.cmbPackageId);
            this.groupBox1.Controls.Add(this.tbxPackageType);
            this.groupBox1.Controls.Add(this.tbxPackageRate);
            this.groupBox1.Controls.Add(this.tbxVehicalType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(975, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(836, 112);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 70;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(636, 62);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 19);
            this.label21.TabIndex = 69;
            this.label21.Text = "Night Park Rate";
            // 
            // tbxDriverNightRate
            // 
            this.tbxDriverNightRate.Location = new System.Drawing.Point(776, 18);
            this.tbxDriverNightRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDriverNightRate.Name = "tbxDriverNightRate";
            this.tbxDriverNightRate.ReadOnly = true;
            this.tbxDriverNightRate.Size = new System.Drawing.Size(160, 22);
            this.tbxDriverNightRate.TabIndex = 68;
            // 
            // tbxNightParkRate
            // 
            this.tbxNightParkRate.Location = new System.Drawing.Point(776, 59);
            this.tbxNightParkRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNightParkRate.Name = "tbxNightParkRate";
            this.tbxNightParkRate.ReadOnly = true;
            this.tbxNightParkRate.Size = new System.Drawing.Size(160, 22);
            this.tbxNightParkRate.TabIndex = 67;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(636, 25);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 19);
            this.label22.TabIndex = 66;
            this.label22.Text = "Driver Night Rate";
            // 
            // tbxExtraHRate
            // 
            this.tbxExtraHRate.Location = new System.Drawing.Point(462, 115);
            this.tbxExtraHRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxExtraHRate.Name = "tbxExtraHRate";
            this.tbxExtraHRate.ReadOnly = true;
            this.tbxExtraHRate.Size = new System.Drawing.Size(160, 22);
            this.tbxExtraHRate.TabIndex = 65;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(310, 118);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 19);
            this.label11.TabIndex = 64;
            this.label11.Text = "Extra Hours Rate";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(310, 45);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 19);
            this.label18.TabIndex = 63;
            this.label18.Text = "Max Hours";
            // 
            // tbxExtraKmRate
            // 
            this.tbxExtraKmRate.Location = new System.Drawing.Point(462, 80);
            this.tbxExtraKmRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxExtraKmRate.Name = "tbxExtraKmRate";
            this.tbxExtraKmRate.ReadOnly = true;
            this.tbxExtraKmRate.Size = new System.Drawing.Size(160, 22);
            this.tbxExtraKmRate.TabIndex = 62;
            // 
            // tbxMaxHrs
            // 
            this.tbxMaxHrs.Location = new System.Drawing.Point(462, 45);
            this.tbxMaxHrs.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaxHrs.Name = "tbxMaxHrs";
            this.tbxMaxHrs.ReadOnly = true;
            this.tbxMaxHrs.Size = new System.Drawing.Size(160, 22);
            this.tbxMaxHrs.TabIndex = 61;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(310, 80);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(109, 19);
            this.label19.TabIndex = 60;
            this.label19.Text = "Extra KM Rate";
            // 
            // tbxMaxKm
            // 
            this.tbxMaxKm.Location = new System.Drawing.Point(462, 15);
            this.tbxMaxKm.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMaxKm.Name = "tbxMaxKm";
            this.tbxMaxKm.ReadOnly = true;
            this.tbxMaxKm.Size = new System.Drawing.Size(160, 22);
            this.tbxMaxKm.TabIndex = 59;
            this.tbxMaxKm.TextChanged += new System.EventHandler(this.tbxMaxKm_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(310, 15);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 19);
            this.label20.TabIndex = 58;
            this.label20.Text = "Max KM";
            // 
            // cmbPackageId
            // 
            this.cmbPackageId.FormattingEnabled = true;
            this.cmbPackageId.Location = new System.Drawing.Point(130, 18);
            this.cmbPackageId.Name = "cmbPackageId";
            this.cmbPackageId.Size = new System.Drawing.Size(121, 24);
            this.cmbPackageId.TabIndex = 57;
            // 
            // tbxPackageType
            // 
            this.tbxPackageType.Location = new System.Drawing.Point(130, 45);
            this.tbxPackageType.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPackageType.Name = "tbxPackageType";
            this.tbxPackageType.ReadOnly = true;
            this.tbxPackageType.Size = new System.Drawing.Size(160, 22);
            this.tbxPackageType.TabIndex = 56;
            // 
            // tbxPackageRate
            // 
            this.tbxPackageRate.Location = new System.Drawing.Point(130, 75);
            this.tbxPackageRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPackageRate.Name = "tbxPackageRate";
            this.tbxPackageRate.ReadOnly = true;
            this.tbxPackageRate.Size = new System.Drawing.Size(160, 22);
            this.tbxPackageRate.TabIndex = 55;
            // 
            // tbxVehicalType
            // 
            this.tbxVehicalType.Location = new System.Drawing.Point(130, 105);
            this.tbxVehicalType.Margin = new System.Windows.Forms.Padding(4);
            this.tbxVehicalType.Name = "tbxVehicalType";
            this.tbxVehicalType.ReadOnly = true;
            this.tbxVehicalType.Size = new System.Drawing.Size(160, 22);
            this.tbxVehicalType.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 53;
            this.label5.Text = "Vehicle Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 19);
            this.label6.TabIndex = 52;
            this.label6.Text = "Package ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 50);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Package Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = "Package Rate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(-2, 84);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 17);
            this.label10.TabIndex = 49;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbxExtraKm);
            this.groupBox2.Controls.Add(this.TbxNo_of_Km);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btncaKm);
            this.groupBox2.Controls.Add(this.tbxExtraKmcharge);
            this.groupBox2.Controls.Add(this.tbxStartKm);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbxEndKm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(430, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 229);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "KM";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // TbxExtraKm
            // 
            this.TbxExtraKm.Location = new System.Drawing.Point(346, 51);
            this.TbxExtraKm.Margin = new System.Windows.Forms.Padding(4);
            this.TbxExtraKm.Name = "TbxExtraKm";
            this.TbxExtraKm.Size = new System.Drawing.Size(213, 22);
            this.TbxExtraKm.TabIndex = 87;
            // 
            // TbxNo_of_Km
            // 
            this.TbxNo_of_Km.Location = new System.Drawing.Point(346, 16);
            this.TbxNo_of_Km.Margin = new System.Windows.Forms.Padding(4);
            this.TbxNo_of_Km.Name = "TbxNo_of_Km";
            this.TbxNo_of_Km.Size = new System.Drawing.Size(213, 22);
            this.TbxNo_of_Km.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(255, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 84;
            this.label8.Text = "Extra Km";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(251, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 22);
            this.label12.TabIndex = 83;
            this.label12.Text = "No of Km";
            // 
            // btncaKm
            // 
            this.btncaKm.AllowDrop = true;
            this.btncaKm.AutoEllipsis = true;
            this.btncaKm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncaKm.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncaKm.Location = new System.Drawing.Point(176, 153);
            this.btncaKm.Name = "btncaKm";
            this.btncaKm.Size = new System.Drawing.Size(162, 54);
            this.btncaKm.TabIndex = 18;
            this.btncaKm.Text = "Calculate Kilometers";
            this.btncaKm.UseVisualStyleBackColor = true;
            this.btncaKm.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // tbxExtraKmcharge
            // 
            this.tbxExtraKmcharge.Cursor = System.Windows.Forms.Cursors.No;
            this.tbxExtraKmcharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxExtraKmcharge.ForeColor = System.Drawing.SystemColors.Window;
            this.tbxExtraKmcharge.Location = new System.Drawing.Point(178, 104);
            this.tbxExtraKmcharge.Name = "tbxExtraKmcharge";
            this.tbxExtraKmcharge.ReadOnly = true;
            this.tbxExtraKmcharge.Size = new System.Drawing.Size(144, 27);
            this.tbxExtraKmcharge.TabIndex = 10;
            // 
            // tbxStartKm
            // 
            this.tbxStartKm.Location = new System.Drawing.Point(152, 18);
            this.tbxStartKm.Name = "tbxStartKm";
            this.tbxStartKm.Size = new System.Drawing.Size(86, 22);
            this.tbxStartKm.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 21);
            this.label15.TabIndex = 7;
            this.label15.Text = "Extra KM Charge";
            // 
            // tbxEndKm
            // 
            this.tbxEndKm.Location = new System.Drawing.Point(152, 49);
            this.tbxEndKm.Name = "tbxEndKm";
            this.tbxEndKm.Size = new System.Drawing.Size(86, 22);
            this.tbxEndKm.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "End Km Reading";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Start Km Reading";
            // 
            // Calculation
            // 
            this.Calculation.Controls.Add(this.btncalTotDays);
            this.Calculation.Controls.Add(this.tbxTotalDate);
            this.Calculation.Controls.Add(this.label13);
            this.Calculation.Controls.Add(this.dtRented);
            this.Calculation.Controls.Add(this.dtReturn);
            this.Calculation.Controls.Add(this.label23);
            this.Calculation.Controls.Add(this.label24);
            this.Calculation.Location = new System.Drawing.Point(12, 275);
            this.Calculation.Margin = new System.Windows.Forms.Padding(4);
            this.Calculation.Name = "Calculation";
            this.Calculation.Padding = new System.Windows.Forms.Padding(4);
            this.Calculation.Size = new System.Drawing.Size(391, 229);
            this.Calculation.TabIndex = 5;
            this.Calculation.TabStop = false;
            this.Calculation.Text = "Time Reading";
            this.Calculation.Enter += new System.EventHandler(this.Calculation_Enter);
            // 
            // btncalTotDays
            // 
            this.btncalTotDays.AllowDrop = true;
            this.btncalTotDays.AutoEllipsis = true;
            this.btncalTotDays.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncalTotDays.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalTotDays.Location = new System.Drawing.Point(39, 150);
            this.btncalTotDays.Margin = new System.Windows.Forms.Padding(4);
            this.btncalTotDays.Name = "btncalTotDays";
            this.btncalTotDays.Size = new System.Drawing.Size(143, 28);
            this.btncalTotDays.TabIndex = 1;
            this.btncalTotDays.Text = "Total Days";
            this.btncalTotDays.UseVisualStyleBackColor = true;
            this.btncalTotDays.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxTotalDate
            // 
            this.tbxTotalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalDate.Location = new System.Drawing.Point(219, 153);
            this.tbxTotalDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTotalDate.Name = "tbxTotalDate";
            this.tbxTotalDate.ReadOnly = true;
            this.tbxTotalDate.Size = new System.Drawing.Size(132, 27);
            this.tbxTotalDate.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(237, 128);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 17);
            this.label13.TabIndex = 5;
            this.label13.Text = "Total Date";
            // 
            // dtRented
            // 
            this.dtRented.Location = new System.Drawing.Point(110, 88);
            this.dtRented.Margin = new System.Windows.Forms.Padding(4);
            this.dtRented.Name = "dtRented";
            this.dtRented.Size = new System.Drawing.Size(265, 22);
            this.dtRented.TabIndex = 4;
            // 
            // dtReturn
            // 
            this.dtReturn.Location = new System.Drawing.Point(110, 43);
            this.dtReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(265, 22);
            this.dtReturn.TabIndex = 3;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 88);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(96, 19);
            this.label23.TabIndex = 1;
            this.label23.Text = "Rented Date";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(8, 43);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(94, 19);
            this.label24.TabIndex = 0;
            this.label24.Text = "Return Date";
            // 
            // btnTotalLongTour
            // 
            this.btnTotalLongTour.AllowDrop = true;
            this.btnTotalLongTour.AutoEllipsis = true;
            this.btnTotalLongTour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTotalLongTour.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalLongTour.Location = new System.Drawing.Point(1082, 157);
            this.btnTotalLongTour.Name = "btnTotalLongTour";
            this.btnTotalLongTour.Size = new System.Drawing.Size(87, 33);
            this.btnTotalLongTour.TabIndex = 15;
            this.btnTotalLongTour.Text = "Total";
            this.btnTotalLongTour.UseVisualStyleBackColor = true;
            this.btnTotalLongTour.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbxLongTourTotal
            // 
            this.tbxLongTourTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLongTourTotal.Location = new System.Drawing.Point(1209, 158);
            this.tbxLongTourTotal.Name = "tbxLongTourTotal";
            this.tbxLongTourTotal.ReadOnly = true;
            this.tbxLongTourTotal.Size = new System.Drawing.Size(181, 32);
            this.tbxLongTourTotal.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(1206, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Long Tour";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1438, 507);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxLongTourTotal);
            this.Controls.Add(this.btnTotalLongTour);
            this.Controls.Add(this.Calculation);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Logn Tour";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Calculation.ResumeLayout(false);
            this.Calculation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbxNightParkRate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbxExtraHRate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbxExtraKmRate;
        private System.Windows.Forms.TextBox tbxMaxHrs;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxMaxKm;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cmbPackageId;
        private System.Windows.Forms.TextBox tbxPackageType;
        private System.Windows.Forms.TextBox tbxPackageRate;
        private System.Windows.Forms.TextBox tbxVehicalType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxStartKm;
        private System.Windows.Forms.TextBox tbxEndKm;
        private System.Windows.Forms.TextBox tbxExtraKmcharge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Calculation;
        private System.Windows.Forms.Button btncalTotDays;
        private System.Windows.Forms.TextBox tbxTotalDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtRented;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnTotalLongTour;
        private System.Windows.Forms.TextBox tbxLongTourTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDriverNightRate;
        private System.Windows.Forms.Button btncaKm;
        private System.Windows.Forms.TextBox TbxExtraKm;
        private System.Windows.Forms.TextBox TbxNo_of_Km;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
    }
}