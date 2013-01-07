namespace ZusiGraph
{
    partial class CMainWindow
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
                MyTCPConnection.Dispose();
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMainWindow));
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.tabEinstellungen = new System.Windows.Forms.TabControl();
            this.tabGraph = new System.Windows.Forms.TabPage();
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.graph1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabAnzeigen1 = new System.Windows.Forms.TabPage();
            this.cbSchalterst = new System.Windows.Forms.CheckBox();
            this.cbAFBLZB = new System.Windows.Forms.CheckBox();
            this.cbGrunddaten = new System.Windows.Forms.CheckBox();
            this.pnlAFBLZB = new System.Windows.Forms.Panel();
            this.cbLZBvziel = new System.Windows.Forms.CheckBox();
            this.cbLZBweg = new System.Windows.Forms.CheckBox();
            this.cbLZBvsoll = new System.Windows.Forms.CheckBox();
            this.cbAFBgeschw = new System.Windows.Forms.CheckBox();
            this.pnlGrunddaten = new System.Windows.Forms.Panel();
            this.cbLmgleiten = new System.Windows.Forms.CheckBox();
            this.cbStreckenmeter = new System.Windows.Forms.CheckBox();
            this.cbGeschwindigkeit = new System.Windows.Forms.CheckBox();
            this.cbFahrstufe = new System.Windows.Forms.CheckBox();
            this.cbLmsifa = new System.Windows.Forms.CheckBox();
            this.cbTueren = new System.Windows.Forms.CheckBox();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.cbLmschleudern = new System.Windows.Forms.CheckBox();
            this.pnlBremsen = new System.Windows.Forms.Panel();
            this.cbZusbremse = new System.Windows.Forms.CheckBox();
            this.cbDruckhbl = new System.Windows.Forms.CheckBox();
            this.cbDruckhlb = new System.Windows.Forms.CheckBox();
            this.cbDynbremse = new System.Windows.Forms.CheckBox();
            this.cbDruckhll = new System.Windows.Forms.CheckBox();
            this.cbDruckbz = new System.Windows.Forms.CheckBox();
            this.cbBremsen = new System.Windows.Forms.CheckBox();
            this.pnlSchalterst = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbMotorsch = new System.Windows.Forms.CheckBox();
            this.cbFahrtrichtg = new System.Windows.Forms.CheckBox();
            this.cbHauptsch = new System.Windows.Forms.CheckBox();
            this.tabDarstellung = new System.Windows.Forms.TabPage();
            this.cbGraphSeparate = new System.Windows.Forms.CheckBox();
            this.grpUnits = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.rbUnitkph = new System.Windows.Forms.RadioButton();
            this.rbUnitmps = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbUnitkm = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbUnitm = new System.Windows.Forms.RadioButton();
            this.cbSettingsSeparate = new System.Windows.Forms.CheckBox();
            this.cbHidesettings = new System.Windows.Forms.CheckBox();
            this.cbTopmost = new System.Windows.Forms.CheckBox();
            this.cbFokusImmerzurueck = new System.Windows.Forms.CheckBox();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.grpManageSettings = new System.Windows.Forms.GroupBox();
            this.btnDefaultSettings = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnLoadSettings = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.grpVerbindung = new System.Windows.Forms.GroupBox();
            this.tbServer = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDebugpanel = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblVerbstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlDebug = new System.Windows.Forms.Panel();
            this.grpDebug = new System.Windows.Forms.GroupBox();
            this.lblDebugKmsprung = new System.Windows.Forms.Label();
            this.btnDebugTickmark = new System.Windows.Forms.Button();
            this.btnDebugGraphSeparated = new System.Windows.Forms.Button();
            this.grpDebugoffline = new System.Windows.Forms.GroupBox();
            this.numDebugsetspeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDebugFokusZusi = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbVerz = new System.Windows.Forms.TextBox();
            this.btnFlag = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.pnlLeft = new System.Windows.Forms.TableLayoutPanel();
            this.btnAufzeichnung = new System.Windows.Forms.Button();
            this.btnNacht = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.timerGraph = new System.Windows.Forms.Timer(this.components);
            this.pnlSettings.SuspendLayout();
            this.tabEinstellungen.SuspendLayout();
            this.tabGraph.SuspendLayout();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph1)).BeginInit();
            this.tabAnzeigen1.SuspendLayout();
            this.pnlAFBLZB.SuspendLayout();
            this.pnlGrunddaten.SuspendLayout();
            this.pnlBremsen.SuspendLayout();
            this.pnlSchalterst.SuspendLayout();
            this.tabDarstellung.SuspendLayout();
            this.grpUnits.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabSystem.SuspendLayout();
            this.grpManageSettings.SuspendLayout();
            this.grpVerbindung.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlDebug.SuspendLayout();
            this.grpDebug.SuspendLayout();
            this.grpDebugoffline.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDebugsetspeed)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSettings
            // 
            this.pnlSettings.AutoSize = true;
            this.pnlSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSettings.Controls.Add(this.tabEinstellungen);
            this.pnlSettings.Location = new System.Drawing.Point(3, 1);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(421, 462);
            this.pnlSettings.TabIndex = 10;
            // 
            // tabEinstellungen
            // 
            this.tabEinstellungen.Controls.Add(this.tabGraph);
            this.tabEinstellungen.Controls.Add(this.tabAnzeigen1);
            this.tabEinstellungen.Controls.Add(this.tabDarstellung);
            this.tabEinstellungen.Controls.Add(this.tabSystem);
            this.tabEinstellungen.Location = new System.Drawing.Point(3, 2);
            this.tabEinstellungen.Name = "tabEinstellungen";
            this.tabEinstellungen.SelectedIndex = 0;
            this.tabEinstellungen.Size = new System.Drawing.Size(415, 457);
            this.tabEinstellungen.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabEinstellungen.TabIndex = 0;
            this.tabEinstellungen.SelectedIndexChanged += new System.EventHandler(this.tabEinstellungen_SelectedIndexChanged);
            this.tabEinstellungen.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabEinstellungen_Selecting);
            // 
            // tabGraph
            // 
            this.tabGraph.BackColor = System.Drawing.SystemColors.Control;
            this.tabGraph.Controls.Add(this.pnlGraph);
            this.tabGraph.Location = new System.Drawing.Point(4, 22);
            this.tabGraph.Name = "tabGraph";
            this.tabGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabGraph.Size = new System.Drawing.Size(407, 431);
            this.tabGraph.TabIndex = 3;
            this.tabGraph.Text = "Graph";
            // 
            // pnlGraph
            // 
            this.pnlGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlGraph.Controls.Add(this.graph1);
            this.pnlGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGraph.Location = new System.Drawing.Point(3, 3);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(401, 425);
            this.pnlGraph.TabIndex = 20;
            // 
            // graph1
            // 
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.LineColor = System.Drawing.Color.Black;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.graph1.ChartAreas.Add(chartArea1);
            this.graph1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.graph1.Legends.Add(legend1);
            this.graph1.Location = new System.Drawing.Point(0, 0);
            this.graph1.Name = "graph1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Geschwindigkeit";
            series1.Name = "geschw";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.LegendText = "Hll-Druck";
            series2.Name = "hlldruck";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Red;
            series3.IsVisibleInLegend = false;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "kmSprung";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series3.YValuesPerPoint = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "geschwMaxZul";
            this.graph1.Series.Add(series1);
            this.graph1.Series.Add(series2);
            this.graph1.Series.Add(series3);
            this.graph1.Series.Add(series4);
            this.graph1.Size = new System.Drawing.Size(401, 425);
            this.graph1.TabIndex = 0;
            this.graph1.DoubleClick += new System.EventHandler(this.graph1_DoubleClick);
            // 
            // tabAnzeigen1
            // 
            this.tabAnzeigen1.BackColor = System.Drawing.SystemColors.Control;
            this.tabAnzeigen1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAnzeigen1.Controls.Add(this.cbSchalterst);
            this.tabAnzeigen1.Controls.Add(this.cbAFBLZB);
            this.tabAnzeigen1.Controls.Add(this.cbGrunddaten);
            this.tabAnzeigen1.Controls.Add(this.pnlAFBLZB);
            this.tabAnzeigen1.Controls.Add(this.pnlGrunddaten);
            this.tabAnzeigen1.Controls.Add(this.pnlBremsen);
            this.tabAnzeigen1.Controls.Add(this.cbBremsen);
            this.tabAnzeigen1.Controls.Add(this.pnlSchalterst);
            this.tabAnzeigen1.Location = new System.Drawing.Point(4, 22);
            this.tabAnzeigen1.Name = "tabAnzeigen1";
            this.tabAnzeigen1.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnzeigen1.Size = new System.Drawing.Size(407, 431);
            this.tabAnzeigen1.TabIndex = 0;
            this.tabAnzeigen1.Text = "Anzeigen";
            this.tabAnzeigen1.Click += new System.EventHandler(this.tabAnzeigen1_Click);
            // 
            // cbSchalterst
            // 
            this.cbSchalterst.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbSchalterst.AutoSize = true;
            this.cbSchalterst.Checked = true;
            this.cbSchalterst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbSchalterst.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbSchalterst.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.cbSchalterst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSchalterst.Location = new System.Drawing.Point(6, 136);
            this.cbSchalterst.Name = "cbSchalterst";
            this.cbSchalterst.Size = new System.Drawing.Size(104, 23);
            this.cbSchalterst.TabIndex = 8;
            this.cbSchalterst.Text = "Schalterstellungen";
            this.cbSchalterst.UseVisualStyleBackColor = true;
            this.cbSchalterst.CheckedChanged += new System.EventHandler(this.cbSchalterst_CheckedChanged);
            // 
            // cbAFBLZB
            // 
            this.cbAFBLZB.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbAFBLZB.AutoSize = true;
            this.cbAFBLZB.Checked = true;
            this.cbAFBLZB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAFBLZB.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbAFBLZB.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.cbAFBLZB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAFBLZB.Location = new System.Drawing.Point(6, 341);
            this.cbAFBLZB.Name = "cbAFBLZB";
            this.cbAFBLZB.Size = new System.Drawing.Size(68, 23);
            this.cbAFBLZB.TabIndex = 26;
            this.cbAFBLZB.Text = "AFB / LZB";
            this.cbAFBLZB.UseVisualStyleBackColor = true;
            this.cbAFBLZB.CheckedChanged += new System.EventHandler(this.cbAFBLZB_CheckedChanged);
            // 
            // cbGrunddaten
            // 
            this.cbGrunddaten.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbGrunddaten.AutoSize = true;
            this.cbGrunddaten.Checked = true;
            this.cbGrunddaten.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGrunddaten.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbGrunddaten.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.cbGrunddaten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGrunddaten.Location = new System.Drawing.Point(6, 9);
            this.cbGrunddaten.Name = "cbGrunddaten";
            this.cbGrunddaten.Size = new System.Drawing.Size(73, 23);
            this.cbGrunddaten.TabIndex = 8;
            this.cbGrunddaten.Text = "Grunddaten";
            this.cbGrunddaten.UseVisualStyleBackColor = true;
            this.cbGrunddaten.CheckedChanged += new System.EventHandler(this.cbGrunddaten_CheckedChanged);
            // 
            // pnlAFBLZB
            // 
            this.pnlAFBLZB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAFBLZB.Controls.Add(this.cbLZBvziel);
            this.pnlAFBLZB.Controls.Add(this.cbLZBweg);
            this.pnlAFBLZB.Controls.Add(this.cbLZBvsoll);
            this.pnlAFBLZB.Controls.Add(this.cbAFBgeschw);
            this.pnlAFBLZB.Location = new System.Drawing.Point(6, 366);
            this.pnlAFBLZB.Name = "pnlAFBLZB";
            this.pnlAFBLZB.Size = new System.Drawing.Size(182, 45);
            this.pnlAFBLZB.TabIndex = 24;
            // 
            // cbLZBvziel
            // 
            this.cbLZBvziel.AutoSize = true;
            this.cbLZBvziel.Enabled = false;
            this.cbLZBvziel.Location = new System.Drawing.Point(86, 4);
            this.cbLZBvziel.Name = "cbLZBvziel";
            this.cbLZBvziel.Size = new System.Drawing.Size(78, 17);
            this.cbLZBvziel.TabIndex = 30;
            this.cbLZBvziel.Text = "LZB - vZiel";
            this.cbLZBvziel.UseVisualStyleBackColor = true;
            this.cbLZBvziel.CheckedChanged += new System.EventHandler(this.cbLZBvziel_CheckedChanged);
            // 
            // cbLZBweg
            // 
            this.cbLZBweg.AutoSize = true;
            this.cbLZBweg.Enabled = false;
            this.cbLZBweg.Location = new System.Drawing.Point(86, 20);
            this.cbLZBweg.Name = "cbLZBweg";
            this.cbLZBweg.Size = new System.Drawing.Size(89, 17);
            this.cbLZBweg.TabIndex = 29;
            this.cbLZBweg.Text = "LZB - Ziel (m)";
            this.cbLZBweg.UseVisualStyleBackColor = true;
            this.cbLZBweg.CheckedChanged += new System.EventHandler(this.cbLZBweg_CheckedChanged);
            // 
            // cbLZBvsoll
            // 
            this.cbLZBvsoll.AutoSize = true;
            this.cbLZBvsoll.Enabled = false;
            this.cbLZBvsoll.Location = new System.Drawing.Point(3, 20);
            this.cbLZBvsoll.Name = "cbLZBvsoll";
            this.cbLZBvsoll.Size = new System.Drawing.Size(78, 17);
            this.cbLZBvsoll.TabIndex = 28;
            this.cbLZBvsoll.Text = "LZB - vSoll";
            this.cbLZBvsoll.UseVisualStyleBackColor = true;
            this.cbLZBvsoll.CheckedChanged += new System.EventHandler(this.cbLZBvsoll_CheckedChanged);
            // 
            // cbAFBgeschw
            // 
            this.cbAFBgeschw.AutoSize = true;
            this.cbAFBgeschw.Enabled = false;
            this.cbAFBgeschw.Location = new System.Drawing.Point(3, 3);
            this.cbAFBgeschw.Name = "cbAFBgeschw";
            this.cbAFBgeschw.Size = new System.Drawing.Size(78, 17);
            this.cbAFBgeschw.TabIndex = 27;
            this.cbAFBgeschw.Text = "AFB - vSoll";
            this.cbAFBgeschw.UseVisualStyleBackColor = true;
            this.cbAFBgeschw.CheckedChanged += new System.EventHandler(this.cbAFBgeschw_CheckedChanged);
            // 
            // pnlGrunddaten
            // 
            this.pnlGrunddaten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrunddaten.Controls.Add(this.cbLmgleiten);
            this.pnlGrunddaten.Controls.Add(this.cbStreckenmeter);
            this.pnlGrunddaten.Controls.Add(this.cbGeschwindigkeit);
            this.pnlGrunddaten.Controls.Add(this.cbFahrstufe);
            this.pnlGrunddaten.Controls.Add(this.cbLmsifa);
            this.pnlGrunddaten.Controls.Add(this.cbTueren);
            this.pnlGrunddaten.Controls.Add(this.cbTime);
            this.pnlGrunddaten.Controls.Add(this.cbLmschleudern);
            this.pnlGrunddaten.Location = new System.Drawing.Point(6, 35);
            this.pnlGrunddaten.Name = "pnlGrunddaten";
            this.pnlGrunddaten.Size = new System.Drawing.Size(182, 95);
            this.pnlGrunddaten.TabIndex = 19;
            // 
            // cbLmgleiten
            // 
            this.cbLmgleiten.AutoSize = true;
            this.cbLmgleiten.Enabled = false;
            this.cbLmgleiten.Location = new System.Drawing.Point(3, 73);
            this.cbLmgleiten.Name = "cbLmgleiten";
            this.cbLmgleiten.Size = new System.Drawing.Size(59, 17);
            this.cbLmgleiten.TabIndex = 8;
            this.cbLmgleiten.Text = "Gleiten";
            this.cbLmgleiten.UseVisualStyleBackColor = true;
            // 
            // cbStreckenmeter
            // 
            this.cbStreckenmeter.AutoSize = true;
            this.cbStreckenmeter.Checked = true;
            this.cbStreckenmeter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStreckenmeter.Location = new System.Drawing.Point(3, 20);
            this.cbStreckenmeter.Name = "cbStreckenmeter";
            this.cbStreckenmeter.Size = new System.Drawing.Size(95, 17);
            this.cbStreckenmeter.TabIndex = 1;
            this.cbStreckenmeter.Text = "Streckenmeter";
            this.cbStreckenmeter.UseVisualStyleBackColor = true;
            this.cbStreckenmeter.CheckedChanged += new System.EventHandler(this.cbStreckenmeter_CheckedChanged);
            // 
            // cbGeschwindigkeit
            // 
            this.cbGeschwindigkeit.AutoSize = true;
            this.cbGeschwindigkeit.Checked = true;
            this.cbGeschwindigkeit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGeschwindigkeit.Location = new System.Drawing.Point(3, 3);
            this.cbGeschwindigkeit.Name = "cbGeschwindigkeit";
            this.cbGeschwindigkeit.Size = new System.Drawing.Size(104, 17);
            this.cbGeschwindigkeit.TabIndex = 0;
            this.cbGeschwindigkeit.Text = "Geschwindigkeit";
            this.cbGeschwindigkeit.UseVisualStyleBackColor = true;
            this.cbGeschwindigkeit.CheckedChanged += new System.EventHandler(this.cbGeschwindigkeit_CheckedChanged);
            // 
            // cbFahrstufe
            // 
            this.cbFahrstufe.AutoSize = true;
            this.cbFahrstufe.Enabled = false;
            this.cbFahrstufe.Location = new System.Drawing.Point(3, 36);
            this.cbFahrstufe.Name = "cbFahrstufe";
            this.cbFahrstufe.Size = new System.Drawing.Size(70, 17);
            this.cbFahrstufe.TabIndex = 7;
            this.cbFahrstufe.Text = "Fahrstufe";
            this.cbFahrstufe.UseVisualStyleBackColor = true;
            this.cbFahrstufe.CheckedChanged += new System.EventHandler(this.cbFahrstufe_CheckedChanged);
            // 
            // cbLmsifa
            // 
            this.cbLmsifa.AutoSize = true;
            this.cbLmsifa.Enabled = false;
            this.cbLmsifa.Location = new System.Drawing.Point(113, 3);
            this.cbLmsifa.Name = "cbLmsifa";
            this.cbLmsifa.Size = new System.Drawing.Size(44, 17);
            this.cbLmsifa.TabIndex = 2;
            this.cbLmsifa.Text = "Sifa";
            this.cbLmsifa.UseVisualStyleBackColor = true;
            this.cbLmsifa.CheckedChanged += new System.EventHandler(this.cbLmsifa_CheckedChanged);
            // 
            // cbTueren
            // 
            this.cbTueren.AutoSize = true;
            this.cbTueren.Enabled = false;
            this.cbTueren.Location = new System.Drawing.Point(113, 20);
            this.cbTueren.Name = "cbTueren";
            this.cbTueren.Size = new System.Drawing.Size(54, 17);
            this.cbTueren.TabIndex = 3;
            this.cbTueren.Text = "Türen";
            this.cbTueren.UseVisualStyleBackColor = true;
            this.cbTueren.CheckedChanged += new System.EventHandler(this.cbLmtueren_CheckedChanged);
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Enabled = false;
            this.cbTime.Location = new System.Drawing.Point(113, 36);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(59, 17);
            this.cbTime.TabIndex = 6;
            this.cbTime.Text = "Uhrzeit";
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.cbTime_CheckedChanged);
            // 
            // cbLmschleudern
            // 
            this.cbLmschleudern.AutoSize = true;
            this.cbLmschleudern.Enabled = false;
            this.cbLmschleudern.Location = new System.Drawing.Point(3, 54);
            this.cbLmschleudern.Name = "cbLmschleudern";
            this.cbLmschleudern.Size = new System.Drawing.Size(80, 17);
            this.cbLmschleudern.TabIndex = 4;
            this.cbLmschleudern.Text = "Schleudern";
            this.cbLmschleudern.UseVisualStyleBackColor = true;
            this.cbLmschleudern.CheckedChanged += new System.EventHandler(this.cbLmschleudern_CheckedChanged);
            // 
            // pnlBremsen
            // 
            this.pnlBremsen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBremsen.Controls.Add(this.cbZusbremse);
            this.pnlBremsen.Controls.Add(this.cbDruckhbl);
            this.pnlBremsen.Controls.Add(this.cbDruckhlb);
            this.pnlBremsen.Controls.Add(this.cbDynbremse);
            this.pnlBremsen.Controls.Add(this.cbDruckhll);
            this.pnlBremsen.Controls.Add(this.cbDruckbz);
            this.pnlBremsen.Location = new System.Drawing.Point(6, 246);
            this.pnlBremsen.Name = "pnlBremsen";
            this.pnlBremsen.Size = new System.Drawing.Size(182, 89);
            this.pnlBremsen.TabIndex = 19;
            // 
            // cbZusbremse
            // 
            this.cbZusbremse.AutoSize = true;
            this.cbZusbremse.Enabled = false;
            this.cbZusbremse.Location = new System.Drawing.Point(3, 24);
            this.cbZusbremse.Name = "cbZusbremse";
            this.cbZusbremse.Size = new System.Drawing.Size(92, 17);
            this.cbZusbremse.TabIndex = 25;
            this.cbZusbremse.Text = "Zusatzbremse";
            this.cbZusbremse.UseVisualStyleBackColor = true;
            // 
            // cbDruckhbl
            // 
            this.cbDruckhbl.AutoSize = true;
            this.cbDruckhbl.Enabled = false;
            this.cbDruckhbl.Location = new System.Drawing.Point(101, 6);
            this.cbDruckhbl.Name = "cbDruckhbl";
            this.cbDruckhbl.Size = new System.Drawing.Size(79, 17);
            this.cbDruckhbl.TabIndex = 11;
            this.cbDruckhbl.Text = "Druck HBL";
            this.cbDruckhbl.UseVisualStyleBackColor = true;
            this.cbDruckhbl.CheckedChanged += new System.EventHandler(this.cbDruckhbl_CheckedChanged);
            // 
            // cbDruckhlb
            // 
            this.cbDruckhlb.AutoSize = true;
            this.cbDruckhlb.Enabled = false;
            this.cbDruckhlb.Location = new System.Drawing.Point(101, 24);
            this.cbDruckhlb.Name = "cbDruckhlb";
            this.cbDruckhlb.Size = new System.Drawing.Size(79, 17);
            this.cbDruckhlb.TabIndex = 10;
            this.cbDruckhlb.Text = "Druck HLB";
            this.cbDruckhlb.UseVisualStyleBackColor = true;
            this.cbDruckhlb.CheckedChanged += new System.EventHandler(this.cbDruckhlb_CheckedChanged);
            // 
            // cbDynbremse
            // 
            this.cbDynbremse.AutoSize = true;
            this.cbDynbremse.Enabled = false;
            this.cbDynbremse.Location = new System.Drawing.Point(3, 43);
            this.cbDynbremse.Name = "cbDynbremse";
            this.cbDynbremse.Size = new System.Drawing.Size(86, 17);
            this.cbDynbremse.TabIndex = 24;
            this.cbDynbremse.Text = "Dyn. Bremse";
            this.cbDynbremse.UseVisualStyleBackColor = true;
            // 
            // cbDruckhll
            // 
            this.cbDruckhll.AutoSize = true;
            this.cbDruckhll.Checked = true;
            this.cbDruckhll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDruckhll.Location = new System.Drawing.Point(3, 6);
            this.cbDruckhll.Name = "cbDruckhll";
            this.cbDruckhll.Size = new System.Drawing.Size(70, 17);
            this.cbDruckhll.TabIndex = 2;
            this.cbDruckhll.Text = "Druck Hll";
            this.cbDruckhll.UseVisualStyleBackColor = true;
            this.cbDruckhll.CheckedChanged += new System.EventHandler(this.cbDruckhll_CheckedChanged);
            // 
            // cbDruckbz
            // 
            this.cbDruckbz.AutoSize = true;
            this.cbDruckbz.Enabled = false;
            this.cbDruckbz.Location = new System.Drawing.Point(3, 63);
            this.cbDruckbz.Name = "cbDruckbz";
            this.cbDruckbz.Size = new System.Drawing.Size(122, 17);
            this.cbDruckbz.TabIndex = 3;
            this.cbDruckbz.Text = "Druck Bremszylinder";
            this.cbDruckbz.UseVisualStyleBackColor = true;
            this.cbDruckbz.CheckedChanged += new System.EventHandler(this.cbDruckbz_CheckedChanged);
            // 
            // cbBremsen
            // 
            this.cbBremsen.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBremsen.AutoSize = true;
            this.cbBremsen.Checked = true;
            this.cbBremsen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBremsen.FlatAppearance.CheckedBackColor = System.Drawing.Color.DarkSeaGreen;
            this.cbBremsen.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.cbBremsen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBremsen.Location = new System.Drawing.Point(6, 222);
            this.cbBremsen.Name = "cbBremsen";
            this.cbBremsen.Size = new System.Drawing.Size(58, 23);
            this.cbBremsen.TabIndex = 9;
            this.cbBremsen.Text = "Bremsen";
            this.cbBremsen.UseVisualStyleBackColor = true;
            this.cbBremsen.CheckedChanged += new System.EventHandler(this.cbBremsen_CheckedChanged);
            // 
            // pnlSchalterst
            // 
            this.pnlSchalterst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSchalterst.Controls.Add(this.checkBox1);
            this.pnlSchalterst.Controls.Add(this.cbMotorsch);
            this.pnlSchalterst.Controls.Add(this.cbFahrtrichtg);
            this.pnlSchalterst.Controls.Add(this.cbHauptsch);
            this.pnlSchalterst.Location = new System.Drawing.Point(6, 162);
            this.pnlSchalterst.Name = "pnlSchalterst";
            this.pnlSchalterst.Size = new System.Drawing.Size(182, 54);
            this.pnlSchalterst.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(101, 30);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Sanden";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbMotorsch
            // 
            this.cbMotorsch.AutoSize = true;
            this.cbMotorsch.Enabled = false;
            this.cbMotorsch.Location = new System.Drawing.Point(101, 7);
            this.cbMotorsch.Name = "cbMotorsch";
            this.cbMotorsch.Size = new System.Drawing.Size(53, 17);
            this.cbMotorsch.TabIndex = 25;
            this.cbMotorsch.Text = "Motor";
            this.cbMotorsch.UseVisualStyleBackColor = true;
            // 
            // cbFahrtrichtg
            // 
            this.cbFahrtrichtg.AutoSize = true;
            this.cbFahrtrichtg.Enabled = false;
            this.cbFahrtrichtg.Location = new System.Drawing.Point(3, 30);
            this.cbFahrtrichtg.Name = "cbFahrtrichtg";
            this.cbFahrtrichtg.Size = new System.Drawing.Size(88, 17);
            this.cbFahrtrichtg.TabIndex = 24;
            this.cbFahrtrichtg.Text = "Fahrtrichtung";
            this.cbFahrtrichtg.UseVisualStyleBackColor = true;
            // 
            // cbHauptsch
            // 
            this.cbHauptsch.AutoSize = true;
            this.cbHauptsch.Enabled = false;
            this.cbHauptsch.Location = new System.Drawing.Point(3, 7);
            this.cbHauptsch.Name = "cbHauptsch";
            this.cbHauptsch.Size = new System.Drawing.Size(92, 17);
            this.cbHauptsch.TabIndex = 22;
            this.cbHauptsch.Text = "Hauptschalter";
            this.cbHauptsch.UseVisualStyleBackColor = true;
            // 
            // tabDarstellung
            // 
            this.tabDarstellung.BackColor = System.Drawing.SystemColors.Control;
            this.tabDarstellung.Controls.Add(this.cbGraphSeparate);
            this.tabDarstellung.Controls.Add(this.grpUnits);
            this.tabDarstellung.Controls.Add(this.cbSettingsSeparate);
            this.tabDarstellung.Controls.Add(this.cbHidesettings);
            this.tabDarstellung.Controls.Add(this.cbTopmost);
            this.tabDarstellung.Controls.Add(this.cbFokusImmerzurueck);
            this.tabDarstellung.Location = new System.Drawing.Point(4, 22);
            this.tabDarstellung.Name = "tabDarstellung";
            this.tabDarstellung.Padding = new System.Windows.Forms.Padding(3);
            this.tabDarstellung.Size = new System.Drawing.Size(407, 431);
            this.tabDarstellung.TabIndex = 1;
            this.tabDarstellung.Text = "Darstellung";
            this.tabDarstellung.Click += new System.EventHandler(this.tabDarstellung_Click);
            // 
            // cbGraphSeparate
            // 
            this.cbGraphSeparate.BackColor = System.Drawing.Color.LightGray;
            this.cbGraphSeparate.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbGraphSeparate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cbGraphSeparate.Location = new System.Drawing.Point(6, 190);
            this.cbGraphSeparate.Name = "cbGraphSeparate";
            this.cbGraphSeparate.Size = new System.Drawing.Size(119, 35);
            this.cbGraphSeparate.TabIndex = 25;
            this.cbGraphSeparate.Text = "Graph in separatem Fenster";
            this.cbGraphSeparate.UseVisualStyleBackColor = false;
            this.cbGraphSeparate.CheckedChanged += new System.EventHandler(this.cbGraphSeparate_CheckedChanged);
            // 
            // grpUnits
            // 
            this.grpUnits.Controls.Add(this.panel2);
            this.grpUnits.Controls.Add(this.panel1);
            this.grpUnits.Enabled = false;
            this.grpUnits.Location = new System.Drawing.Point(6, 11);
            this.grpUnits.Name = "grpUnits";
            this.grpUnits.Size = new System.Drawing.Size(142, 100);
            this.grpUnits.TabIndex = 24;
            this.grpUnits.TabStop = false;
            this.grpUnits.Text = "Einheiten";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.rbUnitkph);
            this.panel2.Controls.Add(this.rbUnitmps);
            this.panel2.Location = new System.Drawing.Point(6, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 39);
            this.panel2.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Geschwindigkeit";
            // 
            // rbUnitkph
            // 
            this.rbUnitkph.AutoSize = true;
            this.rbUnitkph.Location = new System.Drawing.Point(6, 19);
            this.rbUnitkph.Name = "rbUnitkph";
            this.rbUnitkph.Size = new System.Drawing.Size(50, 17);
            this.rbUnitkph.TabIndex = 5;
            this.rbUnitkph.TabStop = true;
            this.rbUnitkph.Text = "km/h";
            this.rbUnitkph.UseVisualStyleBackColor = true;
            this.rbUnitkph.CheckedChanged += new System.EventHandler(this.rbUnitkph_CheckedChanged);
            // 
            // rbUnitmps
            // 
            this.rbUnitmps.AutoSize = true;
            this.rbUnitmps.Location = new System.Drawing.Point(56, 19);
            this.rbUnitmps.Name = "rbUnitmps";
            this.rbUnitmps.Size = new System.Drawing.Size(43, 17);
            this.rbUnitmps.TabIndex = 4;
            this.rbUnitmps.Text = "m/s";
            this.rbUnitmps.UseVisualStyleBackColor = true;
            this.rbUnitmps.CheckedChanged += new System.EventHandler(this.rbUnitmps_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.rbUnitkm);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbUnitm);
            this.panel1.Location = new System.Drawing.Point(6, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 41);
            this.panel1.TabIndex = 20;
            // 
            // rbUnitkm
            // 
            this.rbUnitkm.AutoSize = true;
            this.rbUnitkm.Location = new System.Drawing.Point(6, 21);
            this.rbUnitkm.Name = "rbUnitkm";
            this.rbUnitkm.Size = new System.Drawing.Size(68, 17);
            this.rbUnitkm.TabIndex = 2;
            this.rbUnitkm.TabStop = true;
            this.rbUnitkm.Text = "Kilometer";
            this.rbUnitkm.UseVisualStyleBackColor = true;
            this.rbUnitkm.CheckedChanged += new System.EventHandler(this.rbDarstKm_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Streckenmeter";
            // 
            // rbUnitm
            // 
            this.rbUnitm.AutoSize = true;
            this.rbUnitm.Location = new System.Drawing.Point(76, 21);
            this.rbUnitm.Name = "rbUnitm";
            this.rbUnitm.Size = new System.Drawing.Size(52, 17);
            this.rbUnitm.TabIndex = 1;
            this.rbUnitm.Text = "Meter";
            this.rbUnitm.UseVisualStyleBackColor = true;
            this.rbUnitm.CheckedChanged += new System.EventHandler(this.rbDarstMeter_CheckedChanged);
            // 
            // cbSettingsSeparate
            // 
            this.cbSettingsSeparate.BackColor = System.Drawing.Color.LightGray;
            this.cbSettingsSeparate.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbSettingsSeparate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cbSettingsSeparate.Location = new System.Drawing.Point(6, 155);
            this.cbSettingsSeparate.Name = "cbSettingsSeparate";
            this.cbSettingsSeparate.Size = new System.Drawing.Size(119, 35);
            this.cbSettingsSeparate.TabIndex = 23;
            this.cbSettingsSeparate.Text = "Einstellungen in separatem Fenster";
            this.cbSettingsSeparate.UseVisualStyleBackColor = false;
            this.cbSettingsSeparate.CheckedChanged += new System.EventHandler(this.cbSettingsSeparate_CheckedChanged);
            // 
            // cbHidesettings
            // 
            this.cbHidesettings.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbHidesettings.Enabled = false;
            this.cbHidesettings.Location = new System.Drawing.Point(6, 275);
            this.cbHidesettings.Name = "cbHidesettings";
            this.cbHidesettings.Size = new System.Drawing.Size(159, 33);
            this.cbHidesettings.TabIndex = 22;
            this.cbHidesettings.Text = "Einstellungen automatisch ausblenden";
            this.cbHidesettings.UseVisualStyleBackColor = true;
            this.cbHidesettings.CheckedChanged += new System.EventHandler(this.cbHidesettings_CheckedChanged);
            // 
            // cbTopmost
            // 
            this.cbTopmost.AutoSize = true;
            this.cbTopmost.Location = new System.Drawing.Point(6, 252);
            this.cbTopmost.Name = "cbTopmost";
            this.cbTopmost.Size = new System.Drawing.Size(128, 17);
            this.cbTopmost.TabIndex = 17;
            this.cbTopmost.Text = "Immer im Vordergrund";
            this.cbTopmost.UseVisualStyleBackColor = true;
            this.cbTopmost.CheckedChanged += new System.EventHandler(this.cbTopmost_CheckedChanged);
            // 
            // cbFokusImmerzurueck
            // 
            this.cbFokusImmerzurueck.AutoSize = true;
            this.cbFokusImmerzurueck.Checked = true;
            this.cbFokusImmerzurueck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFokusImmerzurueck.Location = new System.Drawing.Point(6, 331);
            this.cbFokusImmerzurueck.Name = "cbFokusImmerzurueck";
            this.cbFokusImmerzurueck.Size = new System.Drawing.Size(181, 17);
            this.cbFokusImmerzurueck.TabIndex = 16;
            this.cbFokusImmerzurueck.Text = "Fokus nach Klick zurück an Zusi";
            this.cbFokusImmerzurueck.UseVisualStyleBackColor = true;
            this.cbFokusImmerzurueck.CheckedChanged += new System.EventHandler(this.cbFokusImmerzurueck_CheckedChanged);
            // 
            // tabSystem
            // 
            this.tabSystem.BackColor = System.Drawing.SystemColors.Control;
            this.tabSystem.Controls.Add(this.grpManageSettings);
            this.tabSystem.Controls.Add(this.btnAbout);
            this.tabSystem.Controls.Add(this.grpVerbindung);
            this.tabSystem.Controls.Add(this.btnDebugpanel);
            this.tabSystem.Location = new System.Drawing.Point(4, 22);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Size = new System.Drawing.Size(407, 431);
            this.tabSystem.TabIndex = 2;
            this.tabSystem.Text = "System";
            this.tabSystem.Click += new System.EventHandler(this.tabSystem_Click);
            // 
            // grpManageSettings
            // 
            this.grpManageSettings.Controls.Add(this.btnDefaultSettings);
            this.grpManageSettings.Controls.Add(this.btnSaveSettings);
            this.grpManageSettings.Controls.Add(this.btnLoadSettings);
            this.grpManageSettings.Location = new System.Drawing.Point(3, 133);
            this.grpManageSettings.Name = "grpManageSettings";
            this.grpManageSettings.Size = new System.Drawing.Size(174, 92);
            this.grpManageSettings.TabIndex = 15;
            this.grpManageSettings.TabStop = false;
            this.grpManageSettings.Text = "Einstellungen verwalten";
            this.grpManageSettings.Enter += new System.EventHandler(this.grpManageSettings_Enter);
            // 
            // btnDefaultSettings
            // 
            this.btnDefaultSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnDefaultSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDefaultSettings.Location = new System.Drawing.Point(6, 55);
            this.btnDefaultSettings.Name = "btnDefaultSettings";
            this.btnDefaultSettings.Size = new System.Drawing.Size(162, 23);
            this.btnDefaultSettings.TabIndex = 16;
            this.btnDefaultSettings.Text = "Auf Standardwerte";
            this.btnDefaultSettings.UseVisualStyleBackColor = false;
            this.btnDefaultSettings.Click += new System.EventHandler(this.btnDefaultSettings_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSettings.Location = new System.Drawing.Point(90, 25);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(78, 23);
            this.btnSaveSettings.TabIndex = 17;
            this.btnSaveSettings.Text = "Speichern";
            this.btnSaveSettings.UseVisualStyleBackColor = false;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnLoadSettings
            // 
            this.btnLoadSettings.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadSettings.Enabled = false;
            this.btnLoadSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadSettings.Location = new System.Drawing.Point(6, 26);
            this.btnLoadSettings.Name = "btnLoadSettings";
            this.btnLoadSettings.Size = new System.Drawing.Size(78, 23);
            this.btnLoadSettings.TabIndex = 18;
            this.btnLoadSettings.Text = "Laden";
            this.btnLoadSettings.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.Control;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Location = new System.Drawing.Point(3, 251);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(121, 23);
            this.btnAbout.TabIndex = 14;
            this.btnAbout.Text = "Über ZusiGraph";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // grpVerbindung
            // 
            this.grpVerbindung.Controls.Add(this.tbServer);
            this.grpVerbindung.Controls.Add(this.tbPort);
            this.grpVerbindung.Controls.Add(this.btnConnect);
            this.grpVerbindung.Location = new System.Drawing.Point(3, 4);
            this.grpVerbindung.Name = "grpVerbindung";
            this.grpVerbindung.Size = new System.Drawing.Size(122, 114);
            this.grpVerbindung.TabIndex = 12;
            this.grpVerbindung.TabStop = false;
            this.grpVerbindung.Text = "Verbindung";
            // 
            // tbServer
            // 
            this.tbServer.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZusiGraph.Properties.Settings.Default, "tbServer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbServer.Location = new System.Drawing.Point(7, 26);
            this.tbServer.Name = "tbServer";
            this.tbServer.Size = new System.Drawing.Size(74, 20);
            this.tbServer.TabIndex = 13;
            this.tbServer.Text = global::ZusiGraph.Properties.Settings.Default.tbServer;
            // 
            // tbPort
            // 
            this.tbPort.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ZusiGraph.Properties.Settings.Default, "tbPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tbPort.Location = new System.Drawing.Point(7, 52);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(74, 20);
            this.tbPort.TabIndex = 12;
            this.tbPort.Text = global::ZusiGraph.Properties.Settings.Default.tbPort;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 78);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDebugpanel
            // 
            this.btnDebugpanel.BackColor = System.Drawing.Color.Transparent;
            this.btnDebugpanel.FlatAppearance.BorderSize = 0;
            this.btnDebugpanel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnDebugpanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSalmon;
            this.btnDebugpanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebugpanel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDebugpanel.Location = new System.Drawing.Point(159, 10);
            this.btnDebugpanel.Name = "btnDebugpanel";
            this.btnDebugpanel.Size = new System.Drawing.Size(18, 107);
            this.btnDebugpanel.TabIndex = 13;
            this.btnDebugpanel.Text = "DEBUG";
            this.btnDebugpanel.UseVisualStyleBackColor = false;
            this.btnDebugpanel.Click += new System.EventHandler(this.btnDebugpanel_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblVerbstatus});
            this.statusStrip1.Location = new System.Drawing.Point(3, 466);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(129, 23);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Stretch = false;
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblVerbstatus
            // 
            this.lblVerbstatus.Name = "lblVerbstatus";
            this.lblVerbstatus.Size = new System.Drawing.Size(52, 18);
            this.lblVerbstatus.Text = "getrennt";
            // 
            // pnlDebug
            // 
            this.pnlDebug.AutoSize = true;
            this.pnlDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlDebug.Controls.Add(this.grpDebug);
            this.pnlDebug.Location = new System.Drawing.Point(430, 7);
            this.pnlDebug.Name = "pnlDebug";
            this.pnlDebug.Size = new System.Drawing.Size(138, 420);
            this.pnlDebug.TabIndex = 12;
            this.pnlDebug.Visible = false;
            // 
            // grpDebug
            // 
            this.grpDebug.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpDebug.Controls.Add(this.lblDebugKmsprung);
            this.grpDebug.Controls.Add(this.btnDebugTickmark);
            this.grpDebug.Controls.Add(this.btnDebugGraphSeparated);
            this.grpDebug.Controls.Add(this.grpDebugoffline);
            this.grpDebug.Controls.Add(this.btnDebugFokusZusi);
            this.grpDebug.Controls.Add(this.label13);
            this.grpDebug.Controls.Add(this.label12);
            this.grpDebug.Controls.Add(this.tbVerz);
            this.grpDebug.Controls.Add(this.btnFlag);
            this.grpDebug.Location = new System.Drawing.Point(3, 4);
            this.grpDebug.Name = "grpDebug";
            this.grpDebug.Size = new System.Drawing.Size(132, 413);
            this.grpDebug.TabIndex = 12;
            this.grpDebug.TabStop = false;
            this.grpDebug.Text = "Debug";
            // 
            // lblDebugKmsprung
            // 
            this.lblDebugKmsprung.Location = new System.Drawing.Point(6, 320);
            this.lblDebugKmsprung.Name = "lblDebugKmsprung";
            this.lblDebugKmsprung.Size = new System.Drawing.Size(120, 42);
            this.lblDebugKmsprung.TabIndex = 24;
            this.lblDebugKmsprung.Text = "(kmSprung)";
            // 
            // btnDebugTickmark
            // 
            this.btnDebugTickmark.Location = new System.Drawing.Point(12, 227);
            this.btnDebugTickmark.Name = "btnDebugTickmark";
            this.btnDebugTickmark.Size = new System.Drawing.Size(75, 23);
            this.btnDebugTickmark.TabIndex = 23;
            this.btnDebugTickmark.Text = "Tickmark";
            this.btnDebugTickmark.UseVisualStyleBackColor = true;
            this.btnDebugTickmark.Click += new System.EventHandler(this.btnDebugTickmark_Click);
            // 
            // btnDebugGraphSeparated
            // 
            this.btnDebugGraphSeparated.Location = new System.Drawing.Point(12, 197);
            this.btnDebugGraphSeparated.Name = "btnDebugGraphSeparated";
            this.btnDebugGraphSeparated.Size = new System.Drawing.Size(75, 23);
            this.btnDebugGraphSeparated.TabIndex = 22;
            this.btnDebugGraphSeparated.Text = "Graph ->";
            this.btnDebugGraphSeparated.UseVisualStyleBackColor = true;
            this.btnDebugGraphSeparated.Click += new System.EventHandler(this.btnDebugGraphSeparated_Click);
            // 
            // grpDebugoffline
            // 
            this.grpDebugoffline.Controls.Add(this.numDebugsetspeed);
            this.grpDebugoffline.Controls.Add(this.label4);
            this.grpDebugoffline.Controls.Add(this.label5);
            this.grpDebugoffline.Location = new System.Drawing.Point(6, 100);
            this.grpDebugoffline.Name = "grpDebugoffline";
            this.grpDebugoffline.Size = new System.Drawing.Size(107, 68);
            this.grpDebugoffline.TabIndex = 20;
            this.grpDebugoffline.TabStop = false;
            this.grpDebugoffline.Text = "Offline";
            // 
            // numDebugsetspeed
            // 
            this.numDebugsetspeed.Location = new System.Drawing.Point(6, 37);
            this.numDebugsetspeed.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numDebugsetspeed.Name = "numDebugsetspeed";
            this.numDebugsetspeed.Size = new System.Drawing.Size(49, 20);
            this.numDebugsetspeed.TabIndex = 25;
            this.numDebugsetspeed.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numDebugsetspeed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numDebugsetspeed_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Geschwindigkeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "km/h";
            // 
            // btnDebugFokusZusi
            // 
            this.btnDebugFokusZusi.Location = new System.Drawing.Point(6, 52);
            this.btnDebugFokusZusi.Name = "btnDebugFokusZusi";
            this.btnDebugFokusZusi.Size = new System.Drawing.Size(75, 23);
            this.btnDebugFokusZusi.TabIndex = 21;
            this.btnDebugFokusZusi.Text = "Zusi-Fokus";
            this.btnDebugFokusZusi.UseVisualStyleBackColor = true;
            this.btnDebugFokusZusi.Click += new System.EventHandler(this.btnDebugFokusZusi_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "max. Verzögerung";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(48, 289);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "m/s²";
            // 
            // tbVerz
            // 
            this.tbVerz.Location = new System.Drawing.Point(6, 282);
            this.tbVerz.Name = "tbVerz";
            this.tbVerz.Size = new System.Drawing.Size(36, 20);
            this.tbVerz.TabIndex = 18;
            this.tbVerz.Text = "0,5";
            // 
            // btnFlag
            // 
            this.btnFlag.Location = new System.Drawing.Point(6, 25);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(60, 23);
            this.btnFlag.TabIndex = 11;
            this.btnFlag.Text = "lblFlag";
            this.btnFlag.UseVisualStyleBackColor = true;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.AutoSize = true;
            this.pnlRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlRight.Controls.Add(this.pnlSettings);
            this.pnlRight.Controls.Add(this.statusStrip1);
            this.pnlRight.Controls.Add(this.pnlDebug);
            this.pnlRight.Location = new System.Drawing.Point(136, 13);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(571, 489);
            this.pnlRight.TabIndex = 14;
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoSize = true;
            this.pnlLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlLeft.ColumnCount = 1;
            this.pnlLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlLeft.Controls.Add(this.btnAufzeichnung, 0, 2);
            this.pnlLeft.Controls.Add(this.btnNacht, 0, 0);
            this.pnlLeft.Controls.Add(this.btnSettings, 0, 1);
            this.pnlLeft.Location = new System.Drawing.Point(2, 13);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.RowCount = 3;
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlLeft.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.pnlLeft.Size = new System.Drawing.Size(90, 91);
            this.pnlLeft.TabIndex = 19;
            // 
            // btnAufzeichnung
            // 
            this.btnAufzeichnung.AutoSize = true;
            this.btnAufzeichnung.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAufzeichnung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAufzeichnung.Enabled = false;
            this.btnAufzeichnung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAufzeichnung.Location = new System.Drawing.Point(3, 63);
            this.btnAufzeichnung.Name = "btnAufzeichnung";
            this.btnAufzeichnung.Size = new System.Drawing.Size(84, 25);
            this.btnAufzeichnung.TabIndex = 16;
            this.btnAufzeichnung.Text = "Aufzeichnung";
            this.btnAufzeichnung.UseVisualStyleBackColor = true;
            this.btnAufzeichnung.Click += new System.EventHandler(this.btnAufzeichnung_Click);
            // 
            // btnNacht
            // 
            this.btnNacht.AutoSize = true;
            this.btnNacht.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNacht.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNacht.Location = new System.Drawing.Point(3, 3);
            this.btnNacht.Name = "btnNacht";
            this.btnNacht.Size = new System.Drawing.Size(84, 23);
            this.btnNacht.TabIndex = 15;
            this.btnNacht.Text = "Nachtmodus";
            this.btnNacht.UseVisualStyleBackColor = true;
            this.btnNacht.Click += new System.EventHandler(this.btnNacht_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.AutoSize = true;
            this.btnSettings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(3, 32);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(84, 25);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Einstellungen";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // timerGraph
            // 
            this.timerGraph.Tick += new System.EventHandler(this.timerGraph_Tick);
            // 
            // CMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1045, 746);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CMainWindow";
            this.Text = "ZusiGraph - ";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CMainWindow_FormClosing);
            this.Load += new System.EventHandler(this.CMainWindow_Load);
            this.Click += new System.EventHandler(this.CMainWindow_Click);
            this.pnlSettings.ResumeLayout(false);
            this.tabEinstellungen.ResumeLayout(false);
            this.tabGraph.ResumeLayout(false);
            this.pnlGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graph1)).EndInit();
            this.tabAnzeigen1.ResumeLayout(false);
            this.tabAnzeigen1.PerformLayout();
            this.pnlAFBLZB.ResumeLayout(false);
            this.pnlAFBLZB.PerformLayout();
            this.pnlGrunddaten.ResumeLayout(false);
            this.pnlGrunddaten.PerformLayout();
            this.pnlBremsen.ResumeLayout(false);
            this.pnlBremsen.PerformLayout();
            this.pnlSchalterst.ResumeLayout(false);
            this.pnlSchalterst.PerformLayout();
            this.tabDarstellung.ResumeLayout(false);
            this.tabDarstellung.PerformLayout();
            this.grpUnits.ResumeLayout(false);
            this.grpUnits.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabSystem.ResumeLayout(false);
            this.grpManageSettings.ResumeLayout(false);
            this.grpVerbindung.ResumeLayout(false);
            this.grpVerbindung.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlDebug.ResumeLayout(false);
            this.grpDebug.ResumeLayout(false);
            this.grpDebug.PerformLayout();
            this.grpDebugoffline.ResumeLayout(false);
            this.grpDebugoffline.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDebugsetspeed)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grpVerbindung;
        private System.Windows.Forms.TextBox tbServer;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Panel pnlDebug;
        private System.Windows.Forms.GroupBox grpDebug;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbVerz;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnDebugpanel;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.CheckBox cbDruckbz;
        private System.Windows.Forms.CheckBox cbDruckhll;
        private System.Windows.Forms.CheckBox cbStreckenmeter;
        private System.Windows.Forms.CheckBox cbGeschwindigkeit;
        private System.Windows.Forms.TabControl tabEinstellungen;
        private System.Windows.Forms.TabPage tabAnzeigen1;
        private System.Windows.Forms.TabPage tabDarstellung;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.CheckBox cbLmsifa;
        private System.Windows.Forms.CheckBox cbLmschleudern;
        private System.Windows.Forms.CheckBox cbTueren;
        private System.Windows.Forms.CheckBox cbFahrstufe;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.CheckBox cbGrunddaten;
        private System.Windows.Forms.CheckBox cbBremsen;
        private System.Windows.Forms.Panel pnlBremsen;
        private System.Windows.Forms.Panel pnlGrunddaten;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblVerbstatus;
        private System.Windows.Forms.RadioButton rbUnitm;
        private System.Windows.Forms.RadioButton rbUnitkm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbTopmost;
        private System.Windows.Forms.CheckBox cbFokusImmerzurueck;
        private System.Windows.Forms.Panel pnlSchalterst;
        private System.Windows.Forms.CheckBox cbZusbremse;
        private System.Windows.Forms.CheckBox cbDynbremse;
        private System.Windows.Forms.CheckBox cbSchalterst;
        private System.Windows.Forms.CheckBox cbDruckhbl;
        private System.Windows.Forms.CheckBox cbDruckhlb;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox cbMotorsch;
        private System.Windows.Forms.CheckBox cbFahrtrichtg;
        private System.Windows.Forms.CheckBox cbHauptsch;
        private System.Windows.Forms.Panel pnlAFBLZB;
        private System.Windows.Forms.CheckBox cbAFBLZB;
        private System.Windows.Forms.TableLayoutPanel pnlLeft;
        private System.Windows.Forms.CheckBox cbLZBvziel;
        private System.Windows.Forms.CheckBox cbLZBweg;
        private System.Windows.Forms.CheckBox cbLZBvsoll;
        private System.Windows.Forms.CheckBox cbAFBgeschw;
        private System.Windows.Forms.Button btnDebugFokusZusi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numDebugsetspeed;
        private System.Windows.Forms.GroupBox grpDebugoffline;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox cbHidesettings;
        private System.Windows.Forms.CheckBox cbSettingsSeparate;
        private System.Windows.Forms.GroupBox grpUnits;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbUnitmps;
        private System.Windows.Forms.RadioButton rbUnitkph;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpManageSettings;
        private System.Windows.Forms.Button btnDefaultSettings;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnLoadSettings;
        private System.Windows.Forms.Button btnNacht;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.TabPage tabGraph;
        private System.Windows.Forms.Timer timerGraph;
        private System.Windows.Forms.Button btnDebugGraphSeparated;
        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph1;
        private System.Windows.Forms.Button btnAufzeichnung;
        private System.Windows.Forms.CheckBox cbGraphSeparate;
        private System.Windows.Forms.CheckBox cbLmgleiten;
        private System.Windows.Forms.Button btnDebugTickmark;
        private System.Windows.Forms.Label lblDebugKmsprung;

    }


}

