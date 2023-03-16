namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Calculation = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.tbxWeek = new System.Windows.Forms.TextBox();
            this.tbxDay = new System.Windows.Forms.TextBox();
            this.tbxTotalDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtRented = new System.Windows.Forms.DateTimePicker();
            this.dtReturn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbVehicalNumber = new System.Windows.Forms.ComboBox();
            this.tbxFaulType = new System.Windows.Forms.TextBox();
            this.tbxDailyDriverRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxVehicaModel = new System.Windows.Forms.TextBox();
            this.tbxDailyRate = new System.Windows.Forms.TextBox();
            this.tbxWekklyRate = new System.Windows.Forms.TextBox();
            this.tbxMonthlyRate = new System.Windows.Forms.TextBox();
            this.tbxVehicalType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chbxWithDriver = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxTotalCost = new System.Windows.Forms.TextBox();
            this.btnClaculateTotal = new System.Windows.Forms.Button();
            this.Calculation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Calculation
            // 
            this.Calculation.Controls.Add(this.button1);
            this.Calculation.Controls.Add(this.tbxMonth);
            this.Calculation.Controls.Add(this.tbxWeek);
            this.Calculation.Controls.Add(this.tbxDay);
            this.Calculation.Controls.Add(this.tbxTotalDate);
            this.Calculation.Controls.Add(this.label7);
            this.Calculation.Controls.Add(this.label6);
            this.Calculation.Controls.Add(this.label5);
            this.Calculation.Controls.Add(this.label4);
            this.Calculation.Controls.Add(this.dtRented);
            this.Calculation.Controls.Add(this.dtReturn);
            this.Calculation.Controls.Add(this.label2);
            this.Calculation.Controls.Add(this.label1);
            this.Calculation.Location = new System.Drawing.Point(17, 16);
            this.Calculation.Margin = new System.Windows.Forms.Padding(4);
            this.Calculation.Name = "Calculation";
            this.Calculation.Padding = new System.Windows.Forms.Padding(4);
            this.Calculation.Size = new System.Drawing.Size(981, 268);
            this.Calculation.TabIndex = 0;
            this.Calculation.TabStop = false;
            this.Calculation.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.AllowDrop = true;
            this.button1.AutoEllipsis = true;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 218);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate Total Days";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxMonth
            // 
            this.tbxMonth.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMonth.Location = new System.Drawing.Point(764, 80);
            this.tbxMonth.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.ReadOnly = true;
            this.tbxMonth.Size = new System.Drawing.Size(132, 27);
            this.tbxMonth.TabIndex = 13;
            // 
            // tbxWeek
            // 
            this.tbxWeek.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWeek.Location = new System.Drawing.Point(764, 112);
            this.tbxWeek.Margin = new System.Windows.Forms.Padding(4);
            this.tbxWeek.Name = "tbxWeek";
            this.tbxWeek.ReadOnly = true;
            this.tbxWeek.Size = new System.Drawing.Size(132, 27);
            this.tbxWeek.TabIndex = 12;
            // 
            // tbxDay
            // 
            this.tbxDay.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDay.Location = new System.Drawing.Point(764, 143);
            this.tbxDay.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDay.Name = "tbxDay";
            this.tbxDay.ReadOnly = true;
            this.tbxDay.Size = new System.Drawing.Size(132, 27);
            this.tbxDay.TabIndex = 11;
            // 
            // tbxTotalDate
            // 
            this.tbxTotalDate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalDate.Location = new System.Drawing.Point(764, 43);
            this.tbxTotalDate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTotalDate.Name = "tbxTotalDate";
            this.tbxTotalDate.ReadOnly = true;
            this.tbxTotalDate.Size = new System.Drawing.Size(132, 27);
            this.tbxTotalDate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(601, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Month";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(601, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Week";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(601, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Date";
            // 
            // dtRented
            // 
            this.dtRented.Location = new System.Drawing.Point(211, 71);
            this.dtRented.Margin = new System.Windows.Forms.Padding(4);
            this.dtRented.Name = "dtRented";
            this.dtRented.Size = new System.Drawing.Size(265, 22);
            this.dtRented.TabIndex = 4;
            // 
            // dtReturn
            // 
            this.dtReturn.Location = new System.Drawing.Point(211, 36);
            this.dtReturn.Margin = new System.Windows.Forms.Padding(4);
            this.dtReturn.Name = "dtReturn";
            this.dtReturn.Size = new System.Drawing.Size(265, 22);
            this.dtReturn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rented Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbVehicalNumber);
            this.groupBox1.Controls.Add(this.tbxFaulType);
            this.groupBox1.Controls.Add(this.tbxDailyDriverRate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbxVehicaModel);
            this.groupBox1.Controls.Add(this.tbxDailyRate);
            this.groupBox1.Controls.Add(this.tbxWekklyRate);
            this.groupBox1.Controls.Add(this.tbxMonthlyRate);
            this.groupBox1.Controls.Add(this.tbxVehicalType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(17, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cmbVehicalNumber
            // 
            this.cmbVehicalNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVehicalNumber.FormattingEnabled = true;
            this.cmbVehicalNumber.Location = new System.Drawing.Point(150, 13);
            this.cmbVehicalNumber.Name = "cmbVehicalNumber";
            this.cmbVehicalNumber.Size = new System.Drawing.Size(121, 28);
            this.cmbVehicalNumber.TabIndex = 40;
            this.cmbVehicalNumber.SelectedIndexChanged += new System.EventHandler(this.cmbVehicalNumber_SelectedIndexChanged);
            // 
            // tbxFaulType
            // 
            this.tbxFaulType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFaulType.Location = new System.Drawing.Point(150, 146);
            this.tbxFaulType.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFaulType.Name = "tbxFaulType";
            this.tbxFaulType.Size = new System.Drawing.Size(160, 27);
            this.tbxFaulType.TabIndex = 39;
            // 
            // tbxDailyDriverRate
            // 
            this.tbxDailyDriverRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDailyDriverRate.Location = new System.Drawing.Point(764, 144);
            this.tbxDailyDriverRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDailyDriverRate.Name = "tbxDailyDriverRate";
            this.tbxDailyDriverRate.Size = new System.Drawing.Size(160, 27);
            this.tbxDailyDriverRate.TabIndex = 38;
            this.tbxDailyDriverRate.TextChanged += new System.EventHandler(this.tbxDailyDriverRate_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 151);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 22);
            this.label8.TabIndex = 37;
            this.label8.Text = "Faul Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(585, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 22);
            this.label9.TabIndex = 36;
            this.label9.Text = "Daily Driver Rate";
            // 
            // btnSearch
            // 
            this.btnSearch.AllowDrop = true;
            this.btnSearch.AutoEllipsis = true;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(386, 190);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 28);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbxVehicaModel
            // 
            this.tbxVehicaModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVehicaModel.Location = new System.Drawing.Point(150, 57);
            this.tbxVehicaModel.Margin = new System.Windows.Forms.Padding(4);
            this.tbxVehicaModel.Name = "tbxVehicaModel";
            this.tbxVehicaModel.Size = new System.Drawing.Size(160, 27);
            this.tbxVehicaModel.TabIndex = 32;
            // 
            // tbxDailyRate
            // 
            this.tbxDailyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDailyRate.Location = new System.Drawing.Point(764, 100);
            this.tbxDailyRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDailyRate.Name = "tbxDailyRate";
            this.tbxDailyRate.Size = new System.Drawing.Size(160, 27);
            this.tbxDailyRate.TabIndex = 31;
            // 
            // tbxWekklyRate
            // 
            this.tbxWekklyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWekklyRate.Location = new System.Drawing.Point(764, 59);
            this.tbxWekklyRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxWekklyRate.Name = "tbxWekklyRate";
            this.tbxWekklyRate.Size = new System.Drawing.Size(160, 27);
            this.tbxWekklyRate.TabIndex = 30;
            // 
            // tbxMonthlyRate
            // 
            this.tbxMonthlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMonthlyRate.Location = new System.Drawing.Point(764, 15);
            this.tbxMonthlyRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbxMonthlyRate.Name = "tbxMonthlyRate";
            this.tbxMonthlyRate.Size = new System.Drawing.Size(160, 27);
            this.tbxMonthlyRate.TabIndex = 29;
            // 
            // tbxVehicalType
            // 
            this.tbxVehicalType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxVehicalType.Location = new System.Drawing.Point(150, 100);
            this.tbxVehicalType.Margin = new System.Windows.Forms.Padding(4);
            this.tbxVehicalType.Name = "tbxVehicalType";
            this.tbxVehicalType.Size = new System.Drawing.Size(160, 27);
            this.tbxVehicalType.TabIndex = 28;
            this.tbxVehicalType.TextChanged += new System.EventHandler(this.tbxVehicalType_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(584, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "Monthly Rate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(587, 57);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "Weekly Rate";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(18, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 22);
            this.label12.TabIndex = 24;
            this.label12.Text = "Vehical Type\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(20, 62);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = "Vehical Model";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(585, 105);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 22);
            this.label14.TabIndex = 22;
            this.label14.Text = "Daily Rate";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(18, 18);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 22);
            this.label15.TabIndex = 21;
            this.label15.Text = "Vehical Number";
            // 
            // chbxWithDriver
            // 
            this.chbxWithDriver.AutoSize = true;
            this.chbxWithDriver.Location = new System.Drawing.Point(474, 546);
            this.chbxWithDriver.Name = "chbxWithDriver";
            this.chbxWithDriver.Size = new System.Drawing.Size(104, 21);
            this.chbxWithDriver.TabIndex = 2;
            this.chbxWithDriver.Text = " With Driver";
            this.chbxWithDriver.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(385, 596);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 17);
            this.label16.TabIndex = 38;
            this.label16.Text = "Total Cost";
            // 
            // tbxTotalCost
            // 
            this.tbxTotalCost.Location = new System.Drawing.Point(465, 596);
            this.tbxTotalCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTotalCost.Name = "tbxTotalCost";
            this.tbxTotalCost.Size = new System.Drawing.Size(160, 22);
            this.tbxTotalCost.TabIndex = 39;
            // 
            // btnClaculateTotal
            // 
            this.btnClaculateTotal.Location = new System.Drawing.Point(403, 663);
            this.btnClaculateTotal.Margin = new System.Windows.Forms.Padding(4);
            this.btnClaculateTotal.Name = "btnClaculateTotal";
            this.btnClaculateTotal.Size = new System.Drawing.Size(100, 28);
            this.btnClaculateTotal.TabIndex = 40;
            this.btnClaculateTotal.Text = "Total";
            this.btnClaculateTotal.UseVisualStyleBackColor = true;
            this.btnClaculateTotal.Click += new System.EventHandler(this.btnClaculateTotal_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1060, 719);
            this.Controls.Add(this.btnClaculateTotal);
            this.Controls.Add(this.tbxTotalCost);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chbxWithDriver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Calculation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Rent";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Calculation.ResumeLayout(false);
            this.Calculation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Calculation;
        private System.Windows.Forms.DateTimePicker dtRented;
        private System.Windows.Forms.DateTimePicker dtReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.TextBox tbxWeek;
        private System.Windows.Forms.TextBox tbxDay;
        private System.Windows.Forms.TextBox tbxTotalDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tbxFaulType;
        private System.Windows.Forms.TextBox tbxDailyDriverRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxVehicaModel;
        private System.Windows.Forms.TextBox tbxDailyRate;
        private System.Windows.Forms.TextBox tbxWekklyRate;
        private System.Windows.Forms.TextBox tbxMonthlyRate;
        private System.Windows.Forms.TextBox tbxVehicalType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox chbxWithDriver;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbxTotalCost;
        private System.Windows.Forms.Button btnClaculateTotal;
        private System.Windows.Forms.ComboBox cmbVehicalNumber;
    }
}