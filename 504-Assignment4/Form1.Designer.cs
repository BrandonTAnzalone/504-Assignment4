namespace Assignment4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Graph = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinearColor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LinearM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LinearB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.xMinRange = new System.Windows.Forms.NumericUpDown();
            this.xMaxRange = new System.Windows.Forms.NumericUpDown();
            this.yInterval = new System.Windows.Forms.NumericUpDown();
            this.xInterval = new System.Windows.Forms.NumericUpDown();
            this.yMaxRange = new System.Windows.Forms.NumericUpDown();
            this.yMinRange = new System.Windows.Forms.NumericUpDown();
            this.SetGraphButton = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.LinearGraphButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CircleH = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.CircleK = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.CircleR = new System.Windows.Forms.TextBox();
            this.CircleGraphButton = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.CircleColor = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.quadA = new System.Windows.Forms.TextBox();
            this.quadC = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.quadB = new System.Windows.Forms.TextBox();
            this.QuadraticColor = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.QuadraticBtn = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cubicA = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.cubicB = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cubicC = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.cubicD = new System.Windows.Forms.TextBox();
            this.cubicBtn_Click = new System.Windows.Forms.Button();
            this.cubicColor = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.TipSlope = new System.Windows.Forms.ToolTip(this.components);
            this.TipIntercept = new System.Windows.Forms.ToolTip(this.components);
            this.TipConstant = new System.Windows.Forms.ToolTip(this.components);
            this.TipCenter = new System.Windows.Forms.ToolTip(this.components);
            this.TipRadius = new System.Windows.Forms.ToolTip(this.components);
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.label29 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinRange)).BeginInit();
            this.SuspendLayout();
            // 
            // Graph
            // 
            this.Graph.BackColor = System.Drawing.SystemColors.Desktop;
            this.Graph.Location = new System.Drawing.Point(419, 12);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(600, 600);
            this.Graph.TabIndex = 0;
            this.Graph.TabStop = false;
            this.Graph.Click += new System.EventHandler(this.GraphClick);
            this.Graph.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawAxes);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color";
            // 
            // LinearColor
            // 
            this.LinearColor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinearColor.FormattingEnabled = true;
            this.LinearColor.Location = new System.Drawing.Point(274, 163);
            this.LinearColor.Name = "LinearColor";
            this.LinearColor.Size = new System.Drawing.Size(66, 22);
            this.LinearColor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Linear Graph";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "y =";
            // 
            // LinearM
            // 
            this.LinearM.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LinearM.Location = new System.Drawing.Point(44, 162);
            this.LinearM.Name = "LinearM";
            this.LinearM.Size = new System.Drawing.Size(22, 20);
            this.LinearM.TabIndex = 5;
            this.LinearM.Text = "m";
            this.LinearM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipSlope.SetToolTip(this.LinearM, "The slope of the line");
            this.LinearM.Enter += new System.EventHandler(this.Text_Enter);
            this.LinearM.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "x +";
            // 
            // LinearB
            // 
            this.LinearB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.LinearB.Location = new System.Drawing.Point(99, 162);
            this.LinearB.Name = "LinearB";
            this.LinearB.Size = new System.Drawing.Size(22, 20);
            this.LinearB.TabIndex = 7;
            this.LinearB.Text = "b";
            this.LinearB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipIntercept.SetToolTip(this.LinearB, "The y-intercept of the line");
            this.LinearB.Enter += new System.EventHandler(this.Text_Enter);
            this.LinearB.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Range";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(215, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Interval";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "x-min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(94, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "y-min";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "x-max";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(257, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "y";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(215, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 16);
            this.label13.TabIndex = 16;
            this.label13.Text = "x";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(136, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "y-max";
            // 
            // xMinRange
            // 
            this.xMinRange.Location = new System.Drawing.Point(12, 87);
            this.xMinRange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMinRange.Name = "xMinRange";
            this.xMinRange.Size = new System.Drawing.Size(36, 20);
            this.xMinRange.TabIndex = 18;
            this.xMinRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.xMinRange.ValueChanged += new System.EventHandler(this.xMinCheck);
            // 
            // xMaxRange
            // 
            this.xMaxRange.Location = new System.Drawing.Point(54, 87);
            this.xMaxRange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xMaxRange.Name = "xMaxRange";
            this.xMaxRange.Size = new System.Drawing.Size(36, 20);
            this.xMaxRange.TabIndex = 19;
            this.xMaxRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.xMaxRange.ValueChanged += new System.EventHandler(this.xMaxCheck);
            // 
            // yInterval
            // 
            this.yInterval.Location = new System.Drawing.Point(260, 87);
            this.yInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yInterval.Name = "yInterval";
            this.yInterval.Size = new System.Drawing.Size(36, 20);
            this.yInterval.TabIndex = 20;
            this.yInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // xInterval
            // 
            this.xInterval.Location = new System.Drawing.Point(218, 87);
            this.xInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.xInterval.Name = "xInterval";
            this.xInterval.Size = new System.Drawing.Size(36, 20);
            this.xInterval.TabIndex = 21;
            this.xInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // yMaxRange
            // 
            this.yMaxRange.Location = new System.Drawing.Point(139, 87);
            this.yMaxRange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yMaxRange.Name = "yMaxRange";
            this.yMaxRange.Size = new System.Drawing.Size(36, 20);
            this.yMaxRange.TabIndex = 22;
            this.yMaxRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.yMaxRange.ValueChanged += new System.EventHandler(this.yMaxCheck);
            // 
            // yMinRange
            // 
            this.yMinRange.Location = new System.Drawing.Point(94, 87);
            this.yMinRange.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yMinRange.Name = "yMinRange";
            this.yMinRange.Size = new System.Drawing.Size(36, 20);
            this.yMinRange.TabIndex = 23;
            this.yMinRange.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.yMinRange.ValueChanged += new System.EventHandler(this.yMinCheck);
            // 
            // SetGraphButton
            // 
            this.SetGraphButton.Location = new System.Drawing.Point(327, 87);
            this.SetGraphButton.Name = "SetGraphButton";
            this.SetGraphButton.Size = new System.Drawing.Size(75, 23);
            this.SetGraphButton.TabIndex = 24;
            this.SetGraphButton.Text = "Set Graph";
            this.SetGraphButton.UseVisualStyleBackColor = true;
            this.SetGraphButton.Click += new System.EventHandler(this.Set_Bounds);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(8, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(195, 24);
            this.Title.TabIndex = 25;
            this.Title.Text = "Graphing Calculator";
            // 
            // LinearGraphButton
            // 
            this.LinearGraphButton.Location = new System.Drawing.Point(346, 162);
            this.LinearGraphButton.Name = "LinearGraphButton";
            this.LinearGraphButton.Size = new System.Drawing.Size(56, 23);
            this.LinearGraphButton.TabIndex = 26;
            this.LinearGraphButton.Text = "Graph";
            this.LinearGraphButton.UseVisualStyleBackColor = true;
            this.LinearGraphButton.Click += new System.EventHandler(this.LinearGraph);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Circle Graph";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "((x -";
            // 
            // CircleH
            // 
            this.CircleH.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CircleH.Location = new System.Drawing.Point(47, 409);
            this.CircleH.Name = "CircleH";
            this.CircleH.Size = new System.Drawing.Size(22, 20);
            this.CircleH.TabIndex = 29;
            this.CircleH.Text = "h";
            this.CircleH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipCenter.SetToolTip(this.CircleH, "A coordinate of the circle\'s center");
            this.CircleH.Enter += new System.EventHandler(this.Text_Enter);
            this.CircleH.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(75, 407);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 20);
            this.label15.TabIndex = 30;
            this.label15.Text = ")^2 + (y -";
            // 
            // CircleK
            // 
            this.CircleK.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CircleK.Location = new System.Drawing.Point(146, 407);
            this.CircleK.Name = "CircleK";
            this.CircleK.Size = new System.Drawing.Size(22, 20);
            this.CircleK.TabIndex = 31;
            this.CircleK.Text = "k";
            this.CircleK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipCenter.SetToolTip(this.CircleK, "A coordinate of the circle\'s center");
            this.CircleK.Enter += new System.EventHandler(this.Text_Enter);
            this.CircleK.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(174, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 32;
            this.label16.Text = ")^2) =";
            // 
            // CircleR
            // 
            this.CircleR.ForeColor = System.Drawing.SystemColors.GrayText;
            this.CircleR.Location = new System.Drawing.Point(220, 409);
            this.CircleR.Name = "CircleR";
            this.CircleR.Size = new System.Drawing.Size(22, 20);
            this.CircleR.TabIndex = 33;
            this.CircleR.Text = "r";
            this.CircleR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipRadius.SetToolTip(this.CircleR, "The circle\'s radius");
            this.CircleR.Enter += new System.EventHandler(this.Text_Enter);
            this.CircleR.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // CircleGraphButton
            // 
            this.CircleGraphButton.Location = new System.Drawing.Point(346, 409);
            this.CircleGraphButton.Name = "CircleGraphButton";
            this.CircleGraphButton.Size = new System.Drawing.Size(56, 23);
            this.CircleGraphButton.TabIndex = 34;
            this.CircleGraphButton.Text = "Graph";
            this.CircleGraphButton.UseVisualStyleBackColor = true;
            this.CircleGraphButton.Click += new System.EventHandler(this.CircleGraph);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(271, 391);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Color";
            // 
            // CircleColor
            // 
            this.CircleColor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleColor.FormattingEnabled = true;
            this.CircleColor.Location = new System.Drawing.Point(274, 409);
            this.CircleColor.Name = "CircleColor";
            this.CircleColor.Size = new System.Drawing.Size(66, 22);
            this.CircleColor.TabIndex = 36;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 218);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Quadratic Graph";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 299);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 38;
            this.label19.Text = "Cubic Graph";
            // 
            // quadA
            // 
            this.quadA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quadA.Location = new System.Drawing.Point(44, 242);
            this.quadA.Name = "quadA";
            this.quadA.Size = new System.Drawing.Size(22, 20);
            this.quadA.TabIndex = 39;
            this.quadA.Text = "a";
            this.quadA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipConstant.SetToolTip(this.quadA, "A real number coefficient");
            this.quadA.Enter += new System.EventHandler(this.Text_Enter);
            this.quadA.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // quadC
            // 
            this.quadC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quadC.Location = new System.Drawing.Point(161, 242);
            this.quadC.Name = "quadC";
            this.quadC.Size = new System.Drawing.Size(22, 20);
            this.quadC.TabIndex = 41;
            this.quadC.Text = "c";
            this.quadC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipConstant.SetToolTip(this.quadC, "A real number coefficient");
            this.quadC.Enter += new System.EventHandler(this.Text_Enter);
            this.quadC.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(14, 242);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 20);
            this.label20.TabIndex = 42;
            this.label20.Text = "y =";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(66, 242);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 20);
            this.label21.TabIndex = 43;
            this.label21.Text = "x^2 +";
            // 
            // quadB
            // 
            this.quadB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.quadB.Location = new System.Drawing.Point(112, 242);
            this.quadB.Name = "quadB";
            this.quadB.Size = new System.Drawing.Size(22, 20);
            this.quadB.TabIndex = 45;
            this.quadB.Text = "b";
            this.quadB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipConstant.SetToolTip(this.quadB, "A real number coefficient");
            this.quadB.Enter += new System.EventHandler(this.Text_Enter);
            this.quadB.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // QuadraticColor
            // 
            this.QuadraticColor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuadraticColor.FormattingEnabled = true;
            this.QuadraticColor.Location = new System.Drawing.Point(274, 240);
            this.QuadraticColor.Name = "QuadraticColor";
            this.QuadraticColor.Size = new System.Drawing.Size(66, 22);
            this.QuadraticColor.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(271, 224);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(36, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Color";
            // 
            // QuadraticBtn
            // 
            this.QuadraticBtn.Location = new System.Drawing.Point(346, 242);
            this.QuadraticBtn.Name = "QuadraticBtn";
            this.QuadraticBtn.Size = new System.Drawing.Size(56, 23);
            this.QuadraticBtn.TabIndex = 48;
            this.QuadraticBtn.Text = "Graph";
            this.QuadraticBtn.UseVisualStyleBackColor = true;
            this.QuadraticBtn.Click += new System.EventHandler(this.QuadraticBtn_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(14, 321);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 20);
            this.label24.TabIndex = 49;
            this.label24.Text = "y =";
            // 
            // cubicA
            // 
            this.cubicA.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cubicA.Location = new System.Drawing.Point(45, 321);
            this.cubicA.Name = "cubicA";
            this.cubicA.Size = new System.Drawing.Size(22, 20);
            this.cubicA.TabIndex = 50;
            this.cubicA.Text = "a";
            this.cubicA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipConstant.SetToolTip(this.cubicA, "A real number coefficient");
            this.cubicA.Enter += new System.EventHandler(this.Text_Enter);
            this.cubicA.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(69, 321);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 20);
            this.label25.TabIndex = 51;
            this.label25.Text = "x^3 +";
            // 
            // cubicB
            // 
            this.cubicB.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cubicB.Location = new System.Drawing.Point(112, 321);
            this.cubicB.Name = "cubicB";
            this.cubicB.Size = new System.Drawing.Size(22, 20);
            this.cubicB.TabIndex = 52;
            this.cubicB.Text = "b";
            this.cubicB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipConstant.SetToolTip(this.cubicB, "A real number coefficient");
            this.cubicB.Enter += new System.EventHandler(this.Text_Enter);
            this.cubicB.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(135, 321);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 20);
            this.label26.TabIndex = 53;
            this.label26.Text = "x^2 +";
            // 
            // cubicC
            // 
            this.cubicC.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cubicC.Location = new System.Drawing.Point(178, 321);
            this.cubicC.Name = "cubicC";
            this.cubicC.Size = new System.Drawing.Size(22, 20);
            this.cubicC.TabIndex = 54;
            this.cubicC.Text = "c";
            this.cubicC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipConstant.SetToolTip(this.cubicC, "A real number coefficient");
            this.cubicC.Enter += new System.EventHandler(this.Text_Enter);
            this.cubicC.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(135, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 20);
            this.label22.TabIndex = 44;
            this.label22.Text = "x +";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(200, 321);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 20);
            this.label27.TabIndex = 55;
            this.label27.Text = "x +";
            // 
            // cubicD
            // 
            this.cubicD.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cubicD.Location = new System.Drawing.Point(232, 322);
            this.cubicD.Name = "cubicD";
            this.cubicD.Size = new System.Drawing.Size(22, 20);
            this.cubicD.TabIndex = 56;
            this.cubicD.Text = "d";
            this.cubicD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipConstant.SetToolTip(this.cubicD, "A real number coefficient");
            this.cubicD.Enter += new System.EventHandler(this.Text_Enter);
            this.cubicD.Leave += new System.EventHandler(this.Text_Leave);
            // 
            // cubicBtn_Click
            // 
            this.cubicBtn_Click.Location = new System.Drawing.Point(346, 319);
            this.cubicBtn_Click.Name = "cubicBtn_Click";
            this.cubicBtn_Click.Size = new System.Drawing.Size(56, 23);
            this.cubicBtn_Click.TabIndex = 59;
            this.cubicBtn_Click.Text = "Graph";
            this.cubicBtn_Click.UseVisualStyleBackColor = true;
            this.cubicBtn_Click.Click += new System.EventHandler(this.cubicBtn_Click_Click);
            // 
            // cubicColor
            // 
            this.cubicColor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicColor.FormattingEnabled = true;
            this.cubicColor.Location = new System.Drawing.Point(274, 319);
            this.cubicColor.Name = "cubicColor";
            this.cubicColor.Size = new System.Drawing.Size(66, 22);
            this.cubicColor.TabIndex = 58;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(271, 303);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(36, 13);
            this.label28.TabIndex = 57;
            this.label28.Text = "Color";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.InfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoTextBox.Location = new System.Drawing.Point(18, 474);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(384, 111);
            this.InfoTextBox.TabIndex = 60;
            this.InfoTextBox.Text = "";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(242, 409);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(30, 20);
            this.label29.TabIndex = 61;
            this.label29.Text = "^2)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1028, 624);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.cubicBtn_Click);
            this.Controls.Add(this.cubicColor);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.cubicD);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.cubicC);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.cubicB);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.cubicA);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.QuadraticBtn);
            this.Controls.Add(this.QuadraticColor);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.quadB);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.quadC);
            this.Controls.Add(this.quadA);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.CircleColor);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.CircleGraphButton);
            this.Controls.Add(this.CircleR);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.CircleK);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.CircleH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LinearGraphButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.SetGraphButton);
            this.Controls.Add(this.yMinRange);
            this.Controls.Add(this.yMaxRange);
            this.Controls.Add(this.xInterval);
            this.Controls.Add(this.yInterval);
            this.Controls.Add(this.xMaxRange);
            this.Controls.Add(this.xMinRange);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LinearB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LinearM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinearColor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Graph);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Graph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMinRange)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Graph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LinearColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LinearM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LinearB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown xMinRange;
        private System.Windows.Forms.NumericUpDown xMaxRange;
        private System.Windows.Forms.NumericUpDown yInterval;
        private System.Windows.Forms.NumericUpDown xInterval;
        private System.Windows.Forms.NumericUpDown yMaxRange;
        private System.Windows.Forms.NumericUpDown yMinRange;
        private System.Windows.Forms.Button SetGraphButton;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button LinearGraphButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CircleH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox CircleK;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox CircleR;
        private System.Windows.Forms.Button CircleGraphButton;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox CircleColor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox quadA;
        private System.Windows.Forms.TextBox quadC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox quadB;
        private System.Windows.Forms.ComboBox QuadraticColor;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button QuadraticBtn;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox cubicA;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox cubicB;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox cubicC;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox cubicD;
        private System.Windows.Forms.Button cubicBtn_Click;
        private System.Windows.Forms.ComboBox cubicColor;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ToolTip TipSlope;
        private System.Windows.Forms.ToolTip TipIntercept;
        private System.Windows.Forms.ToolTip TipConstant;
        private System.Windows.Forms.ToolTip TipCenter;
        private System.Windows.Forms.ToolTip TipRadius;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.Label label29;
    }
}

