namespace MyWaveForms
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.timerDisplayTime = new System.Windows.Forms.Timer(this.components);
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.tabPageText = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.button5 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.tabPageSpectrum = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.formsPlotSpectrum = new ScottPlot.FormsPlot();
			this.panelSpectrum = new System.Windows.Forms.Panel();
			this.groupBoxChannel = new System.Windows.Forms.GroupBox();
			this.buttonAddTrace = new System.Windows.Forms.Button();
			this.comboBoxChannelAttenuation = new System.Windows.Forms.ComboBox();
			this.labelAttenuation = new System.Windows.Forms.Label();
			this.labelChannelRange = new System.Windows.Forms.Label();
			this.comboBoxChannelRange = new System.Windows.Forms.ComboBox();
			this.comboBoxChannelOffset = new System.Windows.Forms.ComboBox();
			this.labelChannelOffset = new System.Windows.Forms.Label();
			this.groupBoxMagnitude = new System.Windows.Forms.GroupBox();
			this.comboBoxReference = new System.Windows.Forms.ComboBox();
			this.labelReference = new System.Windows.Forms.Label();
			this.comboBoxRange = new System.Windows.Forms.ComboBox();
			this.labelRange = new System.Windows.Forms.Label();
			this.labelTop = new System.Windows.Forms.Label();
			this.comboBoxTop = new System.Windows.Forms.ComboBox();
			this.comboBoxMagnitudeUnit = new System.Windows.Forms.ComboBox();
			this.labelMagnitudeUnit = new System.Windows.Forms.Label();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSetting = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripButtonSingle = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
			this.tabPageMeter = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.formsPlotMeter = new ScottPlot.FormsPlot();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tabPageWavegen = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.formsPlotWaveGen = new ScottPlot.FormsPlot();
			this.groupBoxWavegen = new System.Windows.Forms.GroupBox();
			this.buttonProjectOntoScope = new System.Windows.Forms.Button();
			this.checkBoxRunState = new System.Windows.Forms.CheckBox();
			this.buttonRunWavegen = new System.Windows.Forms.Button();
			this.comboBoxPhase = new System.Windows.Forms.ComboBox();
			this.comboBoxSymmetry = new System.Windows.Forms.ComboBox();
			this.comboBoxOffset = new System.Windows.Forms.ComboBox();
			this.comboBoxAmplitde = new System.Windows.Forms.ComboBox();
			this.comboBoxFrequency = new System.Windows.Forms.ComboBox();
			this.comboBoxWaveType = new System.Windows.Forms.ComboBox();
			this.labelPhase = new System.Windows.Forms.Label();
			this.labelSymmetry = new System.Windows.Forms.Label();
			this.labelOffset = new System.Windows.Forms.Label();
			this.labelAmplitde = new System.Windows.Forms.Label();
			this.labelFrequency_2 = new System.Windows.Forms.Label();
			this.labelType = new System.Windows.Forms.Label();
			this.tabPageScope = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxInteraction = new System.Windows.Forms.GroupBox();
			this.checkBoxCrosshair = new System.Windows.Forms.CheckBox();
			this.checkBoxVerticalZoom = new System.Windows.Forms.CheckBox();
			this.checkBoxHorizontalZoom = new System.Windows.Forms.CheckBox();
			this.checkBoxScrollWheelZoom = new System.Windows.Forms.CheckBox();
			this.checkBoxRightClickDragZoom = new System.Windows.Forms.CheckBox();
			this.groupBoxControl = new System.Windows.Forms.GroupBox();
			this.labelTriggerType = new System.Windows.Forms.Label();
			this.comboBoxTriggerType = new System.Windows.Forms.ComboBox();
			this.comboBoxTimeBase = new System.Windows.Forms.ComboBox();
			this.labelTimeBase = new System.Windows.Forms.Label();
			this.comboBoxVerticalSensitivity = new System.Windows.Forms.ComboBox();
			this.labelVerticalSensitivity = new System.Windows.Forms.Label();
			this.labelCoupledType = new System.Windows.Forms.Label();
			this.comboBoxCoupledType = new System.Windows.Forms.ComboBox();
			this.groupBoxInfor = new System.Windows.Forms.GroupBox();
			this.labelDisplayFrequency = new System.Windows.Forms.Label();
			this.labelDisplayPlotCount = new System.Windows.Forms.Label();
			this.labelDisplayMaximum = new System.Windows.Forms.Label();
			this.labelDisplayMinimum = new System.Windows.Forms.Label();
			this.labelDisplayTime = new System.Windows.Forms.Label();
			this.labelDemo = new System.Windows.Forms.Label();
			this.labelFrequency = new System.Windows.Forms.Label();
			this.labelPlotCount = new System.Windows.Forms.Label();
			this.labelMinimum = new System.Windows.Forms.Label();
			this.labelMaximum = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
			this.comboBoxLineWidth = new System.Windows.Forms.ComboBox();
			this.comboBoxLineStyle = new System.Windows.Forms.ComboBox();
			this.labelLineStyle = new System.Windows.Forms.Label();
			this.labelLineWidth = new System.Windows.Forms.Label();
			this.comboBoxColorStyle = new System.Windows.Forms.ComboBox();
			this.labelColorStyle = new System.Windows.Forms.Label();
			this.formsPlotScope = new ScottPlot.FormsPlot();
			this.tabPageDeviceManage = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxSendSettings = new System.Windows.Forms.GroupBox();
			this.buttonClearSent = new System.Windows.Forms.Button();
			this.radioButtonSendHEX = new System.Windows.Forms.RadioButton();
			this.radioButtonSendASCII = new System.Windows.Forms.RadioButton();
			this.groupBoxReceiveSettings = new System.Windows.Forms.GroupBox();
			this.radioButtonReceiveBIN = new System.Windows.Forms.RadioButton();
			this.checkBoxReceivedBlock = new System.Windows.Forms.CheckBox();
			this.buttonClearReceived = new System.Windows.Forms.Button();
			this.radioButtonReceiveHEX = new System.Windows.Forms.RadioButton();
			this.radioButtonReceiveASCII = new System.Windows.Forms.RadioButton();
			this.groupBoxSerialPortSettings = new System.Windows.Forms.GroupBox();
			this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
			this.labelStopBit = new System.Windows.Forms.Label();
			this.comboBoxCheckBit = new System.Windows.Forms.ComboBox();
			this.labelCheckBit = new System.Windows.Forms.Label();
			this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
			this.labelDataBit = new System.Windows.Forms.Label();
			this.buttonClosePort = new System.Windows.Forms.Button();
			this.buttonOpenPort = new System.Windows.Forms.Button();
			this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
			this.labelBaudRate = new System.Windows.Forms.Label();
			this.comboBoxPort = new System.Windows.Forms.ComboBox();
			this.labelPortNumber = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.textBoxSend = new System.Windows.Forms.TextBox();
			this.textBoxReceived = new System.Windows.Forms.TextBox();
			this.buttonSend = new System.Windows.Forms.Button();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemBINS = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemScale = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemAlgorithm = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxStart = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripComboBoxStop = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripComboBoxScale = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripComboBoxAlgorithm = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.tabPageText.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabPageSpectrum.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.panelSpectrum.SuspendLayout();
			this.groupBoxChannel.SuspendLayout();
			this.groupBoxMagnitude.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.tabPageMeter.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.tabPageWavegen.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.groupBoxWavegen.SuspendLayout();
			this.tabPageScope.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.groupBoxInteraction.SuspendLayout();
			this.groupBoxControl.SuspendLayout();
			this.groupBoxInfor.SuspendLayout();
			this.groupBoxDisplay.SuspendLayout();
			this.tabPageDeviceManage.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBoxSendSettings.SuspendLayout();
			this.groupBoxReceiveSettings.SuspendLayout();
			this.groupBoxSerialPortSettings.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// serialPort1
			// 
			this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
			// 
			// tabPageText
			// 
			this.tabPageText.Controls.Add(this.groupBox2);
			this.tabPageText.Controls.Add(this.groupBox1);
			this.tabPageText.Controls.Add(this.button6);
			this.tabPageText.Controls.Add(this.textBox3);
			this.tabPageText.Controls.Add(this.panel2);
			this.tabPageText.Location = new System.Drawing.Point(4, 22);
			this.tabPageText.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageText.Name = "tabPageText";
			this.tabPageText.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageText.Size = new System.Drawing.Size(859, 504);
			this.tabPageText.TabIndex = 4;
			this.tabPageText.Text = "测试页";
			this.tabPageText.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.checkBox3);
			this.groupBox2.Controls.Add(this.button5);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Location = new System.Drawing.Point(3, 104);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox2.Size = new System.Drawing.Size(294, 94);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "C1 AC RMS";
			this.groupBox2.Visible = false;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(158, 61);
			this.button4.Margin = new System.Windows.Forms.Padding(2);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(50, 22);
			this.button4.TabIndex = 8;
			this.button4.Text = "选色";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Checked = true;
			this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox3.Location = new System.Drawing.Point(140, 17);
			this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(96, 16);
			this.checkBox3.TabIndex = 7;
			this.checkBox3.Text = "显示在绘图区";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(158, 34);
			this.button5.Margin = new System.Windows.Forms.Padding(2);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(50, 24);
			this.button5.TabIndex = 6;
			this.button5.Text = "设置";
			this.button5.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(56, 71);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(23, 12);
			this.label9.TabIndex = 5;
			this.label9.Text = "N/A";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(56, 46);
			this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 12);
			this.label10.TabIndex = 4;
			this.label10.Text = "N/A";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(56, 22);
			this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(23, 12);
			this.label11.TabIndex = 3;
			this.label11.Text = "N/A";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 71);
			this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 12);
			this.label12.TabIndex = 2;
			this.label12.Text = "最大值";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(3, 46);
			this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(41, 12);
			this.label13.TabIndex = 1;
			this.label13.Text = "最小值";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(3, 22);
			this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 12);
			this.label14.TabIndex = 0;
			this.label14.Text = "当前值";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.checkBox2);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(3, 8);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
			this.groupBox1.Size = new System.Drawing.Size(294, 94);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "C1 True RMS";
			this.groupBox1.Visible = false;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(158, 58);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(50, 20);
			this.button3.TabIndex = 8;
			this.button3.Text = "选色";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Checked = true;
			this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox2.Location = new System.Drawing.Point(140, 17);
			this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(96, 16);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "显示在绘图区";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(158, 34);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(50, 20);
			this.button2.TabIndex = 6;
			this.button2.Text = "设置";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(56, 71);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(23, 12);
			this.label8.TabIndex = 5;
			this.label8.Text = "N/A";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(56, 46);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(23, 12);
			this.label7.TabIndex = 4;
			this.label7.Text = "N/A";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(56, 22);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(23, 12);
			this.label6.TabIndex = 3;
			this.label6.Text = "N/A";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 71);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 12);
			this.label5.TabIndex = 2;
			this.label5.Text = "最大值";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 46);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 12);
			this.label4.TabIndex = 1;
			this.label4.Text = "最小值";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 22);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "当前值";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(696, 480);
			this.button6.Margin = new System.Windows.Forms.Padding(2);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(83, 26);
			this.button6.TabIndex = 11;
			this.button6.Text = "button6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(612, 13);
			this.textBox3.Margin = new System.Windows.Forms.Padding(2);
			this.textBox3.Multiline = true;
			this.textBox3.Name = "textBox3";
			this.textBox3.ReadOnly = true;
			this.textBox3.Size = new System.Drawing.Size(238, 428);
			this.textBox3.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.comboBox1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.comboBox2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.textBox2);
			this.panel2.Controls.Add(this.checkBox1);
			this.panel2.Location = new System.Drawing.Point(0, 200);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(198, 130);
			this.panel2.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(62, 99);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 22);
			this.button1.TabIndex = 20;
			this.button1.Text = "删除";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(62, 68);
			this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(120, 20);
			this.comboBox1.TabIndex = 19;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 69);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 18;
			this.label1.Text = "计数点";
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(62, 42);
			this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(120, 20);
			this.comboBox2.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 43);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 16;
			this.label2.Text = "类型";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(8, 10);
			this.textBox2.Margin = new System.Windows.Forms.Padding(2);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(130, 21);
			this.textBox2.TabIndex = 15;
			this.textBox2.Text = "Trace1";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Checked = true;
			this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox1.Location = new System.Drawing.Point(146, 11);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(48, 16);
			this.checkBox1.TabIndex = 14;
			this.checkBox1.Text = "显示";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// tabPageSpectrum
			// 
			this.tabPageSpectrum.Controls.Add(this.tableLayoutPanel7);
			this.tabPageSpectrum.Location = new System.Drawing.Point(4, 22);
			this.tabPageSpectrum.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageSpectrum.Name = "tabPageSpectrum";
			this.tabPageSpectrum.Size = new System.Drawing.Size(859, 504);
			this.tabPageSpectrum.TabIndex = 3;
			this.tabPageSpectrum.Text = "频谱分析仪";
			this.tabPageSpectrum.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 2;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
			this.tableLayoutPanel7.Controls.Add(this.formsPlotSpectrum, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.panelSpectrum, 1, 0);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 1;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(859, 504);
			this.tableLayoutPanel7.TabIndex = 0;
			// 
			// formsPlotSpectrum
			// 
			this.formsPlotSpectrum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formsPlotSpectrum.Location = new System.Drawing.Point(5, 5);
			this.formsPlotSpectrum.Margin = new System.Windows.Forms.Padding(5);
			this.formsPlotSpectrum.Name = "formsPlotSpectrum";
			this.formsPlotSpectrum.Size = new System.Drawing.Size(634, 494);
			this.formsPlotSpectrum.TabIndex = 0;
			// 
			// panelSpectrum
			// 
			this.panelSpectrum.AutoScroll = true;
			this.panelSpectrum.Controls.Add(this.groupBoxChannel);
			this.panelSpectrum.Controls.Add(this.groupBoxMagnitude);
			this.panelSpectrum.Controls.Add(this.toolStrip2);
			this.panelSpectrum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSpectrum.Location = new System.Drawing.Point(644, 0);
			this.panelSpectrum.Margin = new System.Windows.Forms.Padding(0);
			this.panelSpectrum.Name = "panelSpectrum";
			this.panelSpectrum.Size = new System.Drawing.Size(215, 504);
			this.panelSpectrum.TabIndex = 1;
			// 
			// groupBoxChannel
			// 
			this.groupBoxChannel.Controls.Add(this.buttonAddTrace);
			this.groupBoxChannel.Controls.Add(this.comboBoxChannelAttenuation);
			this.groupBoxChannel.Controls.Add(this.labelAttenuation);
			this.groupBoxChannel.Controls.Add(this.labelChannelRange);
			this.groupBoxChannel.Controls.Add(this.comboBoxChannelRange);
			this.groupBoxChannel.Controls.Add(this.comboBoxChannelOffset);
			this.groupBoxChannel.Controls.Add(this.labelChannelOffset);
			this.groupBoxChannel.Location = new System.Drawing.Point(0, 166);
			this.groupBoxChannel.Margin = new System.Windows.Forms.Padding(0);
			this.groupBoxChannel.MaximumSize = new System.Drawing.Size(198, 130);
			this.groupBoxChannel.MinimumSize = new System.Drawing.Size(198, 130);
			this.groupBoxChannel.Name = "groupBoxChannel";
			this.groupBoxChannel.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxChannel.Size = new System.Drawing.Size(198, 130);
			this.groupBoxChannel.TabIndex = 14;
			this.groupBoxChannel.TabStop = false;
			this.groupBoxChannel.Text = "信道设置";
			// 
			// buttonAddTrace
			// 
			this.buttonAddTrace.Location = new System.Drawing.Point(52, 101);
			this.buttonAddTrace.Margin = new System.Windows.Forms.Padding(2);
			this.buttonAddTrace.Name = "buttonAddTrace";
			this.buttonAddTrace.Size = new System.Drawing.Size(85, 22);
			this.buttonAddTrace.TabIndex = 12;
			this.buttonAddTrace.Text = "添加追踪器";
			this.buttonAddTrace.UseVisualStyleBackColor = true;
			this.buttonAddTrace.Click += new System.EventHandler(this.buttonAddTrace_Click);
			// 
			// comboBoxChannelAttenuation
			// 
			this.comboBoxChannelAttenuation.FormattingEnabled = true;
			this.comboBoxChannelAttenuation.Location = new System.Drawing.Point(83, 75);
			this.comboBoxChannelAttenuation.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxChannelAttenuation.Name = "comboBoxChannelAttenuation";
			this.comboBoxChannelAttenuation.Size = new System.Drawing.Size(93, 20);
			this.comboBoxChannelAttenuation.TabIndex = 11;
			// 
			// labelAttenuation
			// 
			this.labelAttenuation.AutoSize = true;
			this.labelAttenuation.Location = new System.Drawing.Point(20, 77);
			this.labelAttenuation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelAttenuation.Name = "labelAttenuation";
			this.labelAttenuation.Size = new System.Drawing.Size(29, 12);
			this.labelAttenuation.TabIndex = 10;
			this.labelAttenuation.Text = "衰减";
			// 
			// labelChannelRange
			// 
			this.labelChannelRange.AutoSize = true;
			this.labelChannelRange.Location = new System.Drawing.Point(20, 50);
			this.labelChannelRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelChannelRange.Name = "labelChannelRange";
			this.labelChannelRange.Size = new System.Drawing.Size(29, 12);
			this.labelChannelRange.TabIndex = 9;
			this.labelChannelRange.Text = "范围";
			// 
			// comboBoxChannelRange
			// 
			this.comboBoxChannelRange.FormattingEnabled = true;
			this.comboBoxChannelRange.Location = new System.Drawing.Point(83, 49);
			this.comboBoxChannelRange.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxChannelRange.Name = "comboBoxChannelRange";
			this.comboBoxChannelRange.Size = new System.Drawing.Size(93, 20);
			this.comboBoxChannelRange.TabIndex = 8;
			// 
			// comboBoxChannelOffset
			// 
			this.comboBoxChannelOffset.FormattingEnabled = true;
			this.comboBoxChannelOffset.Location = new System.Drawing.Point(83, 22);
			this.comboBoxChannelOffset.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxChannelOffset.Name = "comboBoxChannelOffset";
			this.comboBoxChannelOffset.Size = new System.Drawing.Size(93, 20);
			this.comboBoxChannelOffset.TabIndex = 7;
			// 
			// labelChannelOffset
			// 
			this.labelChannelOffset.AutoSize = true;
			this.labelChannelOffset.Location = new System.Drawing.Point(20, 24);
			this.labelChannelOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelChannelOffset.Name = "labelChannelOffset";
			this.labelChannelOffset.Size = new System.Drawing.Size(29, 12);
			this.labelChannelOffset.TabIndex = 6;
			this.labelChannelOffset.Text = "偏移";
			// 
			// groupBoxMagnitude
			// 
			this.groupBoxMagnitude.Controls.Add(this.comboBoxReference);
			this.groupBoxMagnitude.Controls.Add(this.labelReference);
			this.groupBoxMagnitude.Controls.Add(this.comboBoxRange);
			this.groupBoxMagnitude.Controls.Add(this.labelRange);
			this.groupBoxMagnitude.Controls.Add(this.labelTop);
			this.groupBoxMagnitude.Controls.Add(this.comboBoxTop);
			this.groupBoxMagnitude.Controls.Add(this.comboBoxMagnitudeUnit);
			this.groupBoxMagnitude.Controls.Add(this.labelMagnitudeUnit);
			this.groupBoxMagnitude.Location = new System.Drawing.Point(0, 28);
			this.groupBoxMagnitude.Margin = new System.Windows.Forms.Padding(0);
			this.groupBoxMagnitude.MaximumSize = new System.Drawing.Size(198, 130);
			this.groupBoxMagnitude.MinimumSize = new System.Drawing.Size(198, 130);
			this.groupBoxMagnitude.Name = "groupBoxMagnitude";
			this.groupBoxMagnitude.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxMagnitude.Size = new System.Drawing.Size(198, 130);
			this.groupBoxMagnitude.TabIndex = 13;
			this.groupBoxMagnitude.TabStop = false;
			this.groupBoxMagnitude.Text = "振幅设置";
			// 
			// comboBoxReference
			// 
			this.comboBoxReference.FormattingEnabled = true;
			this.comboBoxReference.Location = new System.Drawing.Point(83, 90);
			this.comboBoxReference.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxReference.Name = "comboBoxReference";
			this.comboBoxReference.Size = new System.Drawing.Size(93, 20);
			this.comboBoxReference.TabIndex = 7;
			// 
			// labelReference
			// 
			this.labelReference.AutoSize = true;
			this.labelReference.Location = new System.Drawing.Point(19, 93);
			this.labelReference.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelReference.Name = "labelReference";
			this.labelReference.Size = new System.Drawing.Size(53, 12);
			this.labelReference.TabIndex = 6;
			this.labelReference.Text = "参考电压";
			// 
			// comboBoxRange
			// 
			this.comboBoxRange.FormattingEnabled = true;
			this.comboBoxRange.Location = new System.Drawing.Point(83, 66);
			this.comboBoxRange.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxRange.Name = "comboBoxRange";
			this.comboBoxRange.Size = new System.Drawing.Size(93, 20);
			this.comboBoxRange.TabIndex = 5;
			// 
			// labelRange
			// 
			this.labelRange.AutoSize = true;
			this.labelRange.Location = new System.Drawing.Point(20, 68);
			this.labelRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelRange.Name = "labelRange";
			this.labelRange.Size = new System.Drawing.Size(29, 12);
			this.labelRange.TabIndex = 4;
			this.labelRange.Text = "量程";
			// 
			// labelTop
			// 
			this.labelTop.AutoSize = true;
			this.labelTop.Location = new System.Drawing.Point(20, 43);
			this.labelTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTop.Name = "labelTop";
			this.labelTop.Size = new System.Drawing.Size(29, 12);
			this.labelTop.TabIndex = 3;
			this.labelTop.Text = "上限";
			// 
			// comboBoxTop
			// 
			this.comboBoxTop.FormattingEnabled = true;
			this.comboBoxTop.Location = new System.Drawing.Point(83, 42);
			this.comboBoxTop.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxTop.Name = "comboBoxTop";
			this.comboBoxTop.Size = new System.Drawing.Size(93, 20);
			this.comboBoxTop.TabIndex = 2;
			// 
			// comboBoxMagnitudeUnit
			// 
			this.comboBoxMagnitudeUnit.FormattingEnabled = true;
			this.comboBoxMagnitudeUnit.Location = new System.Drawing.Point(83, 17);
			this.comboBoxMagnitudeUnit.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxMagnitudeUnit.Name = "comboBoxMagnitudeUnit";
			this.comboBoxMagnitudeUnit.Size = new System.Drawing.Size(93, 20);
			this.comboBoxMagnitudeUnit.TabIndex = 1;
			// 
			// labelMagnitudeUnit
			// 
			this.labelMagnitudeUnit.AutoSize = true;
			this.labelMagnitudeUnit.Location = new System.Drawing.Point(20, 18);
			this.labelMagnitudeUnit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMagnitudeUnit.Name = "labelMagnitudeUnit";
			this.labelMagnitudeUnit.Size = new System.Drawing.Size(29, 12);
			this.labelMagnitudeUnit.TabIndex = 0;
			this.labelMagnitudeUnit.Text = "单位";
			// 
			// toolStrip2
			// 
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSetting,
            this.toolStripSeparator5,
            this.toolStripButtonSingle,
            this.toolStripSeparator6,
            this.toolStripButtonRun,
            this.toolStripSeparator7});
			this.toolStrip2.Location = new System.Drawing.Point(0, 0);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Padding = new System.Windows.Forms.Padding(0);
			this.toolStrip2.Size = new System.Drawing.Size(215, 25);
			this.toolStrip2.TabIndex = 0;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripButtonSetting
			// 
			this.toolStripButtonSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemStart,
            this.toolStripMenuItemStop,
            this.toolStripMenuItemBINS,
            this.toolStripMenuItemScale,
            this.toolStripMenuItemAlgorithm});
			this.toolStripButtonSetting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSetting.Image")));
			this.toolStripButtonSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSetting.Name = "toolStripButtonSetting";
			this.toolStripButtonSetting.Size = new System.Drawing.Size(69, 22);
			this.toolStripButtonSetting.Text = "频谱设置";
			// 
			// toolStripButtonSingle
			// 
			this.toolStripButtonSingle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonSingle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSingle.Image")));
			this.toolStripButtonSingle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonSingle.Name = "toolStripButtonSingle";
			this.toolStripButtonSingle.Size = new System.Drawing.Size(60, 22);
			this.toolStripButtonSingle.Text = "单次采集";
			// 
			// toolStripButtonRun
			// 
			this.toolStripButtonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButtonRun.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRun.Image")));
			this.toolStripButtonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButtonRun.Name = "toolStripButtonRun";
			this.toolStripButtonRun.Size = new System.Drawing.Size(36, 22);
			this.toolStripButtonRun.Text = "运行";
			// 
			// tabPageMeter
			// 
			this.tabPageMeter.Controls.Add(this.tableLayoutPanel9);
			this.tabPageMeter.Location = new System.Drawing.Point(4, 22);
			this.tabPageMeter.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageMeter.Name = "tabPageMeter";
			this.tabPageMeter.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageMeter.Size = new System.Drawing.Size(859, 504);
			this.tabPageMeter.TabIndex = 5;
			this.tabPageMeter.Text = "电压电流计";
			this.tabPageMeter.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.ColumnCount = 2;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanel9.Controls.Add(this.formsPlotMeter, 0, 0);
			this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel8, 1, 0);
			this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel9.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel9.Name = "tableLayoutPanel9";
			this.tableLayoutPanel9.RowCount = 1;
			this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel9.Size = new System.Drawing.Size(855, 500);
			this.tableLayoutPanel9.TabIndex = 0;
			// 
			// formsPlotMeter
			// 
			this.formsPlotMeter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formsPlotMeter.Location = new System.Drawing.Point(3, 3);
			this.formsPlotMeter.Name = "formsPlotMeter";
			this.formsPlotMeter.Size = new System.Drawing.Size(599, 494);
			this.formsPlotMeter.TabIndex = 0;
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.ColumnCount = 1;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Controls.Add(this.toolStrip1, 0, 0);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(607, 2);
			this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(246, 496);
			this.tableLayoutPanel8.TabIndex = 1;
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripSeparator3,
            this.toolStripLabel4,
            this.toolStripSeparator4});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
			this.toolStrip1.Size = new System.Drawing.Size(246, 25);
			this.toolStrip1.TabIndex = 3;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 20);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 20);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 20);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 20);
			// 
			// tabPageWavegen
			// 
			this.tabPageWavegen.Controls.Add(this.tableLayoutPanel6);
			this.tabPageWavegen.Location = new System.Drawing.Point(4, 22);
			this.tabPageWavegen.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageWavegen.Name = "tabPageWavegen";
			this.tabPageWavegen.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageWavegen.Size = new System.Drawing.Size(859, 504);
			this.tabPageWavegen.TabIndex = 2;
			this.tabPageWavegen.Text = "信号发生器";
			this.tabPageWavegen.UseVisualStyleBackColor = true;
			this.tabPageWavegen.Enter += new System.EventHandler(this.tabPageWavegen_Enter);
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 2;
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel6.Controls.Add(this.formsPlotWaveGen, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.groupBoxWavegen, 1, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 1;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(855, 500);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// formsPlotWaveGen
			// 
			this.formsPlotWaveGen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formsPlotWaveGen.Location = new System.Drawing.Point(3, 3);
			this.formsPlotWaveGen.Name = "formsPlotWaveGen";
			this.formsPlotWaveGen.Size = new System.Drawing.Size(649, 494);
			this.formsPlotWaveGen.TabIndex = 0;
			// 
			// groupBoxWavegen
			// 
			this.groupBoxWavegen.Controls.Add(this.buttonProjectOntoScope);
			this.groupBoxWavegen.Controls.Add(this.checkBoxRunState);
			this.groupBoxWavegen.Controls.Add(this.buttonRunWavegen);
			this.groupBoxWavegen.Controls.Add(this.comboBoxPhase);
			this.groupBoxWavegen.Controls.Add(this.comboBoxSymmetry);
			this.groupBoxWavegen.Controls.Add(this.comboBoxOffset);
			this.groupBoxWavegen.Controls.Add(this.comboBoxAmplitde);
			this.groupBoxWavegen.Controls.Add(this.comboBoxFrequency);
			this.groupBoxWavegen.Controls.Add(this.comboBoxWaveType);
			this.groupBoxWavegen.Controls.Add(this.labelPhase);
			this.groupBoxWavegen.Controls.Add(this.labelSymmetry);
			this.groupBoxWavegen.Controls.Add(this.labelOffset);
			this.groupBoxWavegen.Controls.Add(this.labelAmplitde);
			this.groupBoxWavegen.Controls.Add(this.labelFrequency_2);
			this.groupBoxWavegen.Controls.Add(this.labelType);
			this.groupBoxWavegen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxWavegen.Location = new System.Drawing.Point(657, 2);
			this.groupBoxWavegen.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxWavegen.Name = "groupBoxWavegen";
			this.groupBoxWavegen.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxWavegen.Size = new System.Drawing.Size(196, 496);
			this.groupBoxWavegen.TabIndex = 1;
			this.groupBoxWavegen.TabStop = false;
			this.groupBoxWavegen.Text = "控制";
			// 
			// buttonProjectOntoScope
			// 
			this.buttonProjectOntoScope.Enabled = false;
			this.buttonProjectOntoScope.Location = new System.Drawing.Point(52, 242);
			this.buttonProjectOntoScope.Name = "buttonProjectOntoScope";
			this.buttonProjectOntoScope.Size = new System.Drawing.Size(90, 27);
			this.buttonProjectOntoScope.TabIndex = 14;
			this.buttonProjectOntoScope.Text = "投射到示波器";
			this.buttonProjectOntoScope.UseVisualStyleBackColor = true;
			this.buttonProjectOntoScope.Visible = false;
			// 
			// checkBoxRunState
			// 
			this.checkBoxRunState.AutoSize = true;
			this.checkBoxRunState.Location = new System.Drawing.Point(90, 180);
			this.checkBoxRunState.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxRunState.Name = "checkBoxRunState";
			this.checkBoxRunState.Size = new System.Drawing.Size(30, 16);
			this.checkBoxRunState.TabIndex = 13;
			this.checkBoxRunState.Text = " ";
			this.checkBoxRunState.UseVisualStyleBackColor = true;
			this.checkBoxRunState.Visible = false;
			// 
			// buttonRunWavegen
			// 
			this.buttonRunWavegen.BackColor = System.Drawing.Color.LimeGreen;
			this.buttonRunWavegen.Location = new System.Drawing.Point(62, 200);
			this.buttonRunWavegen.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRunWavegen.Name = "buttonRunWavegen";
			this.buttonRunWavegen.Size = new System.Drawing.Size(68, 27);
			this.buttonRunWavegen.TabIndex = 12;
			this.buttonRunWavegen.Text = "运行";
			this.buttonRunWavegen.UseVisualStyleBackColor = false;
			this.buttonRunWavegen.Click += new System.EventHandler(this.buttonRunStop_Click);
			// 
			// comboBoxPhase
			// 
			this.comboBoxPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPhase.FormattingEnabled = true;
			this.comboBoxPhase.Items.AddRange(new object[] {
            "0°",
            "15°",
            "30°",
            "45°",
            "60°",
            "75°",
            "90°",
            "105°",
            "120°",
            "135°",
            "150°",
            "165°",
            "180°",
            "195°",
            "210°",
            "225°",
            "240°",
            "255°",
            "270°",
            "285°",
            "300°",
            "315°",
            "330°",
            "345°",
            "360°"});
			this.comboBoxPhase.Location = new System.Drawing.Point(62, 132);
			this.comboBoxPhase.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxPhase.Name = "comboBoxPhase";
			this.comboBoxPhase.Size = new System.Drawing.Size(112, 20);
			this.comboBoxPhase.TabIndex = 11;
			this.comboBoxPhase.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhase_SelectedIndexChanged);
			// 
			// comboBoxSymmetry
			// 
			this.comboBoxSymmetry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSymmetry.Enabled = false;
			this.comboBoxSymmetry.FormattingEnabled = true;
			this.comboBoxSymmetry.Items.AddRange(new object[] {
            "100%",
            "95%",
            "90%",
            "85%",
            "80%",
            "75%",
            "70%",
            "65%",
            "60%",
            "55%",
            "50%",
            "45%",
            "40%",
            "35%",
            "30%",
            "25%",
            "20%",
            "15%",
            "10%",
            "5%",
            "0%"});
			this.comboBoxSymmetry.Location = new System.Drawing.Point(62, 158);
			this.comboBoxSymmetry.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxSymmetry.Name = "comboBoxSymmetry";
			this.comboBoxSymmetry.Size = new System.Drawing.Size(112, 20);
			this.comboBoxSymmetry.TabIndex = 10;
			this.comboBoxSymmetry.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymmetry_SelectedIndexChanged);
			// 
			// comboBoxOffset
			// 
			this.comboBoxOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOffset.FormattingEnabled = true;
			this.comboBoxOffset.Items.AddRange(new object[] {
            "5V",
            "2V",
            "1V",
            "0.5V",
            "0.2V",
            "0.1V",
            "0.05V",
            "0.02V",
            "0.01V",
            "0V",
            "-0.01V",
            "-0.02V",
            "-0.05V",
            "-0.1V",
            "-0.2V",
            "-0.5V",
            "-1V",
            "-2V",
            "-5V"});
			this.comboBoxOffset.Location = new System.Drawing.Point(62, 106);
			this.comboBoxOffset.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxOffset.Name = "comboBoxOffset";
			this.comboBoxOffset.Size = new System.Drawing.Size(112, 20);
			this.comboBoxOffset.TabIndex = 9;
			this.comboBoxOffset.SelectedIndexChanged += new System.EventHandler(this.comboBoxOffset_SelectedIndexChanged);
			// 
			// comboBoxAmplitde
			// 
			this.comboBoxAmplitde.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAmplitde.FormattingEnabled = true;
			this.comboBoxAmplitde.Items.AddRange(new object[] {
            "5V",
            "2V",
            "1V",
            "0.5V",
            "0.2V",
            "0.1V",
            "0.05V",
            "0.02V",
            "0.01V",
            "0V",
            "-0.01V",
            "-0.02V",
            "-0.05V",
            "-0.1V",
            "-0.2V",
            "-0.5V",
            "-1V",
            "-2V",
            "-5V"});
			this.comboBoxAmplitde.Location = new System.Drawing.Point(62, 80);
			this.comboBoxAmplitde.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxAmplitde.Name = "comboBoxAmplitde";
			this.comboBoxAmplitde.Size = new System.Drawing.Size(112, 20);
			this.comboBoxAmplitde.TabIndex = 8;
			this.comboBoxAmplitde.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmplitde_SelectedIndexChanged);
			// 
			// comboBoxFrequency
			// 
			this.comboBoxFrequency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFrequency.FormattingEnabled = true;
			this.comboBoxFrequency.Items.AddRange(new object[] {
            "10MHz",
            "5MHz",
            "2MHz",
            "1MHz",
            "500kHz",
            "200kHz",
            "100kHz",
            "50kHz",
            "20kHz",
            "10kHz",
            "5kHz",
            "2kHz",
            "1kHz",
            "500Hz",
            "200Hz",
            "100Hz",
            "50Hz",
            "20Hz",
            "10Hz",
            "5Hz",
            "2Hz",
            "1Hz",
            "0.5Hz",
            "0.2Hz",
            "0.1Hz"});
			this.comboBoxFrequency.Location = new System.Drawing.Point(62, 54);
			this.comboBoxFrequency.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxFrequency.Name = "comboBoxFrequency";
			this.comboBoxFrequency.Size = new System.Drawing.Size(112, 20);
			this.comboBoxFrequency.TabIndex = 7;
			this.comboBoxFrequency.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrequency_SelectedIndexChanged);
			// 
			// comboBoxWaveType
			// 
			this.comboBoxWaveType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxWaveType.FormattingEnabled = true;
			this.comboBoxWaveType.Items.AddRange(new object[] {
            "直流电源 DC",
            "正弦波 Sine",
            "三角波 Triganle",
            "方波 Square",
            "上升波形 RampUp",
            "下降波形 Ramp Down",
            "噪声 Noise",
            "梯形波 Trapezium",
            "Test"});
			this.comboBoxWaveType.Location = new System.Drawing.Point(62, 29);
			this.comboBoxWaveType.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxWaveType.Name = "comboBoxWaveType";
			this.comboBoxWaveType.Size = new System.Drawing.Size(112, 20);
			this.comboBoxWaveType.TabIndex = 6;
			this.comboBoxWaveType.SelectedIndexChanged += new System.EventHandler(this.comboBoxWaveType_SelectedIndexChanged);
			// 
			// labelPhase
			// 
			this.labelPhase.AutoSize = true;
			this.labelPhase.Location = new System.Drawing.Point(13, 133);
			this.labelPhase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPhase.Name = "labelPhase";
			this.labelPhase.Size = new System.Drawing.Size(29, 12);
			this.labelPhase.TabIndex = 5;
			this.labelPhase.Text = "相位";
			// 
			// labelSymmetry
			// 
			this.labelSymmetry.AutoSize = true;
			this.labelSymmetry.Enabled = false;
			this.labelSymmetry.Location = new System.Drawing.Point(13, 160);
			this.labelSymmetry.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelSymmetry.Name = "labelSymmetry";
			this.labelSymmetry.Size = new System.Drawing.Size(29, 12);
			this.labelSymmetry.TabIndex = 4;
			this.labelSymmetry.Text = "对称";
			// 
			// labelOffset
			// 
			this.labelOffset.AutoSize = true;
			this.labelOffset.Location = new System.Drawing.Point(13, 106);
			this.labelOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelOffset.Name = "labelOffset";
			this.labelOffset.Size = new System.Drawing.Size(29, 12);
			this.labelOffset.TabIndex = 3;
			this.labelOffset.Text = "偏移";
			// 
			// labelAmplitde
			// 
			this.labelAmplitde.AutoSize = true;
			this.labelAmplitde.Location = new System.Drawing.Point(13, 80);
			this.labelAmplitde.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelAmplitde.Name = "labelAmplitde";
			this.labelAmplitde.Size = new System.Drawing.Size(29, 12);
			this.labelAmplitde.TabIndex = 2;
			this.labelAmplitde.Text = "幅值";
			// 
			// labelFrequency_2
			// 
			this.labelFrequency_2.AutoSize = true;
			this.labelFrequency_2.Location = new System.Drawing.Point(13, 54);
			this.labelFrequency_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelFrequency_2.Name = "labelFrequency_2";
			this.labelFrequency_2.Size = new System.Drawing.Size(29, 12);
			this.labelFrequency_2.TabIndex = 1;
			this.labelFrequency_2.Text = "频率";
			// 
			// labelType
			// 
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(13, 29);
			this.labelType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(29, 12);
			this.labelType.TabIndex = 0;
			this.labelType.Text = "类型";
			// 
			// tabPageScope
			// 
			this.tabPageScope.Controls.Add(this.tableLayoutPanel4);
			this.tabPageScope.Location = new System.Drawing.Point(4, 22);
			this.tabPageScope.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageScope.Name = "tabPageScope";
			this.tabPageScope.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageScope.Size = new System.Drawing.Size(859, 504);
			this.tabPageScope.TabIndex = 1;
			this.tabPageScope.Text = "示波器";
			this.tabPageScope.UseVisualStyleBackColor = true;
			this.tabPageScope.Enter += new System.EventHandler(this.tabPageScope_Enter);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.formsPlotScope, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(855, 500);
			this.tableLayoutPanel4.TabIndex = 5;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 1;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Controls.Add(this.groupBoxInteraction, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.groupBoxControl, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this.groupBoxInfor, 0, 3);
			this.tableLayoutPanel5.Controls.Add(this.groupBoxDisplay, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(657, 2);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 4;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.81308F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.74766F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.76636F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.6729F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(196, 496);
			this.tableLayoutPanel5.TabIndex = 3;
			// 
			// groupBoxInteraction
			// 
			this.groupBoxInteraction.Controls.Add(this.checkBoxCrosshair);
			this.groupBoxInteraction.Controls.Add(this.checkBoxVerticalZoom);
			this.groupBoxInteraction.Controls.Add(this.checkBoxHorizontalZoom);
			this.groupBoxInteraction.Controls.Add(this.checkBoxScrollWheelZoom);
			this.groupBoxInteraction.Controls.Add(this.checkBoxRightClickDragZoom);
			this.groupBoxInteraction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxInteraction.Location = new System.Drawing.Point(2, 100);
			this.groupBoxInteraction.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxInteraction.Name = "groupBoxInteraction";
			this.groupBoxInteraction.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxInteraction.Size = new System.Drawing.Size(192, 98);
			this.groupBoxInteraction.TabIndex = 7;
			this.groupBoxInteraction.TabStop = false;
			this.groupBoxInteraction.Text = "交互";
			// 
			// checkBoxCrosshair
			// 
			this.checkBoxCrosshair.AutoSize = true;
			this.checkBoxCrosshair.Checked = true;
			this.checkBoxCrosshair.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxCrosshair.Location = new System.Drawing.Point(11, 74);
			this.checkBoxCrosshair.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxCrosshair.Name = "checkBoxCrosshair";
			this.checkBoxCrosshair.Size = new System.Drawing.Size(72, 16);
			this.checkBoxCrosshair.TabIndex = 4;
			this.checkBoxCrosshair.Text = "十字准线";
			this.checkBoxCrosshair.UseVisualStyleBackColor = true;
			this.checkBoxCrosshair.CheckedChanged += new System.EventHandler(this.checkBoxCrosshair_CheckedChanged);
			// 
			// checkBoxVerticalZoom
			// 
			this.checkBoxVerticalZoom.AutoSize = true;
			this.checkBoxVerticalZoom.Checked = true;
			this.checkBoxVerticalZoom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxVerticalZoom.Location = new System.Drawing.Point(114, 46);
			this.checkBoxVerticalZoom.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxVerticalZoom.Name = "checkBoxVerticalZoom";
			this.checkBoxVerticalZoom.Size = new System.Drawing.Size(72, 16);
			this.checkBoxVerticalZoom.TabIndex = 3;
			this.checkBoxVerticalZoom.Text = "垂直缩放";
			this.checkBoxVerticalZoom.UseVisualStyleBackColor = true;
			this.checkBoxVerticalZoom.CheckedChanged += new System.EventHandler(this.checkBoxVerticalZoom_CheckedChanged);
			// 
			// checkBoxHorizontalZoom
			// 
			this.checkBoxHorizontalZoom.AutoSize = true;
			this.checkBoxHorizontalZoom.Checked = true;
			this.checkBoxHorizontalZoom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxHorizontalZoom.Location = new System.Drawing.Point(12, 46);
			this.checkBoxHorizontalZoom.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxHorizontalZoom.Name = "checkBoxHorizontalZoom";
			this.checkBoxHorizontalZoom.Size = new System.Drawing.Size(72, 16);
			this.checkBoxHorizontalZoom.TabIndex = 2;
			this.checkBoxHorizontalZoom.Text = "水平缩放";
			this.checkBoxHorizontalZoom.UseVisualStyleBackColor = true;
			this.checkBoxHorizontalZoom.CheckedChanged += new System.EventHandler(this.checkBoxHorizontalZoom_CheckedChanged);
			// 
			// checkBoxScrollWheelZoom
			// 
			this.checkBoxScrollWheelZoom.AutoSize = true;
			this.checkBoxScrollWheelZoom.Checked = true;
			this.checkBoxScrollWheelZoom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxScrollWheelZoom.Location = new System.Drawing.Point(114, 20);
			this.checkBoxScrollWheelZoom.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxScrollWheelZoom.Name = "checkBoxScrollWheelZoom";
			this.checkBoxScrollWheelZoom.Size = new System.Drawing.Size(72, 16);
			this.checkBoxScrollWheelZoom.TabIndex = 1;
			this.checkBoxScrollWheelZoom.Text = "滚轮缩放";
			this.checkBoxScrollWheelZoom.UseVisualStyleBackColor = true;
			this.checkBoxScrollWheelZoom.CheckedChanged += new System.EventHandler(this.checkBoxScrollWheelZoom_CheckedChanged);
			// 
			// checkBoxRightClickDragZoom
			// 
			this.checkBoxRightClickDragZoom.AutoSize = true;
			this.checkBoxRightClickDragZoom.Checked = true;
			this.checkBoxRightClickDragZoom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxRightClickDragZoom.Location = new System.Drawing.Point(12, 20);
			this.checkBoxRightClickDragZoom.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxRightClickDragZoom.Name = "checkBoxRightClickDragZoom";
			this.checkBoxRightClickDragZoom.Size = new System.Drawing.Size(102, 16);
			this.checkBoxRightClickDragZoom.TabIndex = 0;
			this.checkBoxRightClickDragZoom.Text = "右键拖动/缩放";
			this.checkBoxRightClickDragZoom.UseVisualStyleBackColor = true;
			this.checkBoxRightClickDragZoom.CheckedChanged += new System.EventHandler(this.checkBoxRightClickDragZoom_CheckedChanged);
			// 
			// groupBoxControl
			// 
			this.groupBoxControl.Controls.Add(this.labelTriggerType);
			this.groupBoxControl.Controls.Add(this.comboBoxTriggerType);
			this.groupBoxControl.Controls.Add(this.comboBoxTimeBase);
			this.groupBoxControl.Controls.Add(this.labelTimeBase);
			this.groupBoxControl.Controls.Add(this.comboBoxVerticalSensitivity);
			this.groupBoxControl.Controls.Add(this.labelVerticalSensitivity);
			this.groupBoxControl.Controls.Add(this.labelCoupledType);
			this.groupBoxControl.Controls.Add(this.comboBoxCoupledType);
			this.groupBoxControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxControl.Location = new System.Drawing.Point(2, 202);
			this.groupBoxControl.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxControl.Name = "groupBoxControl";
			this.groupBoxControl.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxControl.Size = new System.Drawing.Size(192, 118);
			this.groupBoxControl.TabIndex = 6;
			this.groupBoxControl.TabStop = false;
			this.groupBoxControl.Text = "控制";
			// 
			// labelTriggerType
			// 
			this.labelTriggerType.AutoSize = true;
			this.labelTriggerType.Location = new System.Drawing.Point(9, 44);
			this.labelTriggerType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTriggerType.Name = "labelTriggerType";
			this.labelTriggerType.Size = new System.Drawing.Size(53, 12);
			this.labelTriggerType.TabIndex = 33;
			this.labelTriggerType.Text = "触发方式";
			// 
			// comboBoxTriggerType
			// 
			this.comboBoxTriggerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTriggerType.FormattingEnabled = true;
			this.comboBoxTriggerType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboBoxTriggerType.Items.AddRange(new object[] {
            "上升沿",
            "下降沿",
            "同时触发"});
			this.comboBoxTriggerType.Location = new System.Drawing.Point(79, 43);
			this.comboBoxTriggerType.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxTriggerType.Name = "comboBoxTriggerType";
			this.comboBoxTriggerType.Size = new System.Drawing.Size(92, 20);
			this.comboBoxTriggerType.TabIndex = 32;
			// 
			// comboBoxTimeBase
			// 
			this.comboBoxTimeBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTimeBase.FormattingEnabled = true;
			this.comboBoxTimeBase.Items.AddRange(new object[] {
            "1μs",
            "2μs",
            "5μs",
            "10μs",
            "20μs",
            "50μs",
            "100μs",
            "200μs",
            "500μs",
            "1ms",
            "2ms",
            "5ms",
            "10ms",
            "20ms",
            "50ms"});
			this.comboBoxTimeBase.Location = new System.Drawing.Point(79, 88);
			this.comboBoxTimeBase.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxTimeBase.Name = "comboBoxTimeBase";
			this.comboBoxTimeBase.Size = new System.Drawing.Size(92, 20);
			this.comboBoxTimeBase.TabIndex = 31;
			// 
			// labelTimeBase
			// 
			this.labelTimeBase.AutoSize = true;
			this.labelTimeBase.Location = new System.Drawing.Point(9, 90);
			this.labelTimeBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTimeBase.Name = "labelTimeBase";
			this.labelTimeBase.Size = new System.Drawing.Size(29, 12);
			this.labelTimeBase.TabIndex = 30;
			this.labelTimeBase.Text = "时基";
			// 
			// comboBoxVerticalSensitivity
			// 
			this.comboBoxVerticalSensitivity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxVerticalSensitivity.FormattingEnabled = true;
			this.comboBoxVerticalSensitivity.Items.AddRange(new object[] {
            "1V",
            "0.5V",
            "0.1V",
            "0.05V",
            "0.01V"});
			this.comboBoxVerticalSensitivity.Location = new System.Drawing.Point(79, 66);
			this.comboBoxVerticalSensitivity.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxVerticalSensitivity.Name = "comboBoxVerticalSensitivity";
			this.comboBoxVerticalSensitivity.Size = new System.Drawing.Size(92, 20);
			this.comboBoxVerticalSensitivity.TabIndex = 29;
			// 
			// labelVerticalSensitivity
			// 
			this.labelVerticalSensitivity.AutoSize = true;
			this.labelVerticalSensitivity.Location = new System.Drawing.Point(9, 68);
			this.labelVerticalSensitivity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelVerticalSensitivity.Name = "labelVerticalSensitivity";
			this.labelVerticalSensitivity.Size = new System.Drawing.Size(65, 12);
			this.labelVerticalSensitivity.TabIndex = 28;
			this.labelVerticalSensitivity.Text = "垂直灵敏度";
			// 
			// labelCoupledType
			// 
			this.labelCoupledType.AutoSize = true;
			this.labelCoupledType.Location = new System.Drawing.Point(9, 21);
			this.labelCoupledType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCoupledType.Name = "labelCoupledType";
			this.labelCoupledType.Size = new System.Drawing.Size(53, 12);
			this.labelCoupledType.TabIndex = 27;
			this.labelCoupledType.Text = "耦合方式";
			// 
			// comboBoxCoupledType
			// 
			this.comboBoxCoupledType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCoupledType.FormattingEnabled = true;
			this.comboBoxCoupledType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboBoxCoupledType.Items.AddRange(new object[] {
            "DC",
            "AC"});
			this.comboBoxCoupledType.Location = new System.Drawing.Point(79, 20);
			this.comboBoxCoupledType.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCoupledType.Name = "comboBoxCoupledType";
			this.comboBoxCoupledType.Size = new System.Drawing.Size(92, 20);
			this.comboBoxCoupledType.TabIndex = 26;
			// 
			// groupBoxInfor
			// 
			this.groupBoxInfor.Controls.Add(this.labelDisplayFrequency);
			this.groupBoxInfor.Controls.Add(this.labelDisplayPlotCount);
			this.groupBoxInfor.Controls.Add(this.labelDisplayMaximum);
			this.groupBoxInfor.Controls.Add(this.labelDisplayMinimum);
			this.groupBoxInfor.Controls.Add(this.labelDisplayTime);
			this.groupBoxInfor.Controls.Add(this.labelDemo);
			this.groupBoxInfor.Controls.Add(this.labelFrequency);
			this.groupBoxInfor.Controls.Add(this.labelPlotCount);
			this.groupBoxInfor.Controls.Add(this.labelMinimum);
			this.groupBoxInfor.Controls.Add(this.labelMaximum);
			this.groupBoxInfor.Controls.Add(this.labelTime);
			this.groupBoxInfor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxInfor.Location = new System.Drawing.Point(2, 324);
			this.groupBoxInfor.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxInfor.Name = "groupBoxInfor";
			this.groupBoxInfor.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxInfor.Size = new System.Drawing.Size(192, 170);
			this.groupBoxInfor.TabIndex = 5;
			this.groupBoxInfor.TabStop = false;
			this.groupBoxInfor.Text = "信息";
			// 
			// labelDisplayFrequency
			// 
			this.labelDisplayFrequency.AutoSize = true;
			this.labelDisplayFrequency.Location = new System.Drawing.Point(77, 110);
			this.labelDisplayFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDisplayFrequency.Name = "labelDisplayFrequency";
			this.labelDisplayFrequency.Size = new System.Drawing.Size(23, 12);
			this.labelDisplayFrequency.TabIndex = 25;
			this.labelDisplayFrequency.Text = "N/A";
			// 
			// labelDisplayPlotCount
			// 
			this.labelDisplayPlotCount.AutoSize = true;
			this.labelDisplayPlotCount.Location = new System.Drawing.Point(77, 86);
			this.labelDisplayPlotCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDisplayPlotCount.Name = "labelDisplayPlotCount";
			this.labelDisplayPlotCount.Size = new System.Drawing.Size(23, 12);
			this.labelDisplayPlotCount.TabIndex = 24;
			this.labelDisplayPlotCount.Text = "N/A";
			// 
			// labelDisplayMaximum
			// 
			this.labelDisplayMaximum.AutoSize = true;
			this.labelDisplayMaximum.Location = new System.Drawing.Point(77, 40);
			this.labelDisplayMaximum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDisplayMaximum.Name = "labelDisplayMaximum";
			this.labelDisplayMaximum.Size = new System.Drawing.Size(23, 12);
			this.labelDisplayMaximum.TabIndex = 23;
			this.labelDisplayMaximum.Text = "N/A";
			// 
			// labelDisplayMinimum
			// 
			this.labelDisplayMinimum.AutoSize = true;
			this.labelDisplayMinimum.Location = new System.Drawing.Point(77, 64);
			this.labelDisplayMinimum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDisplayMinimum.Name = "labelDisplayMinimum";
			this.labelDisplayMinimum.Size = new System.Drawing.Size(23, 12);
			this.labelDisplayMinimum.TabIndex = 22;
			this.labelDisplayMinimum.Text = "N/A";
			// 
			// labelDisplayTime
			// 
			this.labelDisplayTime.AutoSize = true;
			this.labelDisplayTime.Location = new System.Drawing.Point(77, 18);
			this.labelDisplayTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDisplayTime.Name = "labelDisplayTime";
			this.labelDisplayTime.Size = new System.Drawing.Size(23, 12);
			this.labelDisplayTime.TabIndex = 21;
			this.labelDisplayTime.Text = "N/A";
			// 
			// labelDemo
			// 
			this.labelDemo.AutoSize = true;
			this.labelDemo.BackColor = System.Drawing.Color.Tomato;
			this.labelDemo.Location = new System.Drawing.Point(10, 137);
			this.labelDemo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDemo.Name = "labelDemo";
			this.labelDemo.Size = new System.Drawing.Size(173, 12);
			this.labelDemo.TabIndex = 20;
			this.labelDemo.Text = "Demo模式：引入信号发生器波形";
			this.labelDemo.Click += new System.EventHandler(this.labelDemo_Click);
			// 
			// labelFrequency
			// 
			this.labelFrequency.AutoSize = true;
			this.labelFrequency.Location = new System.Drawing.Point(10, 110);
			this.labelFrequency.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelFrequency.Name = "labelFrequency";
			this.labelFrequency.Size = new System.Drawing.Size(53, 12);
			this.labelFrequency.TabIndex = 14;
			this.labelFrequency.Text = "采样频率";
			// 
			// labelPlotCount
			// 
			this.labelPlotCount.AutoSize = true;
			this.labelPlotCount.Location = new System.Drawing.Point(9, 86);
			this.labelPlotCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPlotCount.Name = "labelPlotCount";
			this.labelPlotCount.Size = new System.Drawing.Size(53, 12);
			this.labelPlotCount.TabIndex = 13;
			this.labelPlotCount.Text = "采样点数";
			// 
			// labelMinimum
			// 
			this.labelMinimum.AutoSize = true;
			this.labelMinimum.Location = new System.Drawing.Point(9, 64);
			this.labelMinimum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMinimum.Name = "labelMinimum";
			this.labelMinimum.Size = new System.Drawing.Size(41, 12);
			this.labelMinimum.TabIndex = 12;
			this.labelMinimum.Text = "最小值";
			// 
			// labelMaximum
			// 
			this.labelMaximum.AutoSize = true;
			this.labelMaximum.Location = new System.Drawing.Point(9, 40);
			this.labelMaximum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelMaximum.Name = "labelMaximum";
			this.labelMaximum.Size = new System.Drawing.Size(41, 12);
			this.labelMaximum.TabIndex = 11;
			this.labelMaximum.Text = "最大值";
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(9, 18);
			this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(29, 12);
			this.labelTime.TabIndex = 10;
			this.labelTime.Text = "时间";
			// 
			// groupBoxDisplay
			// 
			this.groupBoxDisplay.Controls.Add(this.comboBoxLineWidth);
			this.groupBoxDisplay.Controls.Add(this.comboBoxLineStyle);
			this.groupBoxDisplay.Controls.Add(this.labelLineStyle);
			this.groupBoxDisplay.Controls.Add(this.labelLineWidth);
			this.groupBoxDisplay.Controls.Add(this.comboBoxColorStyle);
			this.groupBoxDisplay.Controls.Add(this.labelColorStyle);
			this.groupBoxDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxDisplay.Location = new System.Drawing.Point(2, 2);
			this.groupBoxDisplay.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxDisplay.Name = "groupBoxDisplay";
			this.groupBoxDisplay.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxDisplay.Size = new System.Drawing.Size(192, 94);
			this.groupBoxDisplay.TabIndex = 3;
			this.groupBoxDisplay.TabStop = false;
			this.groupBoxDisplay.Text = "显示";
			// 
			// comboBoxLineWidth
			// 
			this.comboBoxLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLineWidth.FormattingEnabled = true;
			this.comboBoxLineWidth.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
			this.comboBoxLineWidth.Location = new System.Drawing.Point(79, 68);
			this.comboBoxLineWidth.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxLineWidth.Name = "comboBoxLineWidth";
			this.comboBoxLineWidth.Size = new System.Drawing.Size(92, 20);
			this.comboBoxLineWidth.TabIndex = 33;
			this.comboBoxLineWidth.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineWidth_SelectedIndexChanged);
			// 
			// comboBoxLineStyle
			// 
			this.comboBoxLineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLineStyle.FormattingEnabled = true;
			this.comboBoxLineStyle.Items.AddRange(new object[] {
            "折线",
            "阶梯显示"});
			this.comboBoxLineStyle.Location = new System.Drawing.Point(79, 43);
			this.comboBoxLineStyle.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxLineStyle.Name = "comboBoxLineStyle";
			this.comboBoxLineStyle.Size = new System.Drawing.Size(92, 20);
			this.comboBoxLineStyle.TabIndex = 32;
			this.comboBoxLineStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxLineStyle_SelectedIndexChanged);
			// 
			// labelLineStyle
			// 
			this.labelLineStyle.AutoSize = true;
			this.labelLineStyle.Location = new System.Drawing.Point(9, 44);
			this.labelLineStyle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelLineStyle.Name = "labelLineStyle";
			this.labelLineStyle.Size = new System.Drawing.Size(29, 12);
			this.labelLineStyle.TabIndex = 31;
			this.labelLineStyle.Text = "线型";
			// 
			// labelLineWidth
			// 
			this.labelLineWidth.AutoSize = true;
			this.labelLineWidth.Location = new System.Drawing.Point(9, 69);
			this.labelLineWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelLineWidth.Name = "labelLineWidth";
			this.labelLineWidth.Size = new System.Drawing.Size(53, 12);
			this.labelLineWidth.TabIndex = 28;
			this.labelLineWidth.Text = "线条粗细";
			// 
			// comboBoxColorStyle
			// 
			this.comboBoxColorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxColorStyle.FormattingEnabled = true;
			this.comboBoxColorStyle.Items.AddRange(new object[] {
            "浅色",
            "深色"});
			this.comboBoxColorStyle.Location = new System.Drawing.Point(79, 18);
			this.comboBoxColorStyle.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxColorStyle.Name = "comboBoxColorStyle";
			this.comboBoxColorStyle.Size = new System.Drawing.Size(92, 20);
			this.comboBoxColorStyle.TabIndex = 27;
			this.comboBoxColorStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxColorStyle_SelectedIndexChanged);
			// 
			// labelColorStyle
			// 
			this.labelColorStyle.AutoSize = true;
			this.labelColorStyle.Location = new System.Drawing.Point(9, 20);
			this.labelColorStyle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelColorStyle.Name = "labelColorStyle";
			this.labelColorStyle.Size = new System.Drawing.Size(53, 12);
			this.labelColorStyle.TabIndex = 26;
			this.labelColorStyle.Text = "色彩模式";
			// 
			// formsPlotScope
			// 
			this.formsPlotScope.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formsPlotScope.Location = new System.Drawing.Point(3, 3);
			this.formsPlotScope.Name = "formsPlotScope";
			this.formsPlotScope.Size = new System.Drawing.Size(649, 494);
			this.formsPlotScope.TabIndex = 4;
			this.formsPlotScope.MouseEnter += new System.EventHandler(this.formsPlotMain_MouseEnter);
			this.formsPlotScope.MouseLeave += new System.EventHandler(this.formsPlotMain_MouseLeave);
			this.formsPlotScope.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formsPlotMain_MouseMove);
			// 
			// tabPageDeviceManage
			// 
			this.tabPageDeviceManage.Controls.Add(this.tableLayoutPanel1);
			this.tabPageDeviceManage.Location = new System.Drawing.Point(4, 22);
			this.tabPageDeviceManage.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageDeviceManage.Name = "tabPageDeviceManage";
			this.tabPageDeviceManage.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageDeviceManage.Size = new System.Drawing.Size(859, 504);
			this.tabPageDeviceManage.TabIndex = 0;
			this.tabPageDeviceManage.Text = "设备管理";
			this.tabPageDeviceManage.UseVisualStyleBackColor = true;
			this.tabPageDeviceManage.Enter += new System.EventHandler(this.tabPageAUARTAssist_Enter);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 500);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.groupBoxSendSettings, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.groupBoxReceiveSettings, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.groupBoxSerialPortSettings, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(246, 496);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// groupBoxSendSettings
			// 
			this.groupBoxSendSettings.Controls.Add(this.buttonClearSent);
			this.groupBoxSendSettings.Controls.Add(this.radioButtonSendHEX);
			this.groupBoxSendSettings.Controls.Add(this.radioButtonSendASCII);
			this.groupBoxSendSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxSendSettings.Location = new System.Drawing.Point(2, 398);
			this.groupBoxSendSettings.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxSendSettings.Name = "groupBoxSendSettings";
			this.groupBoxSendSettings.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxSendSettings.Size = new System.Drawing.Size(242, 96);
			this.groupBoxSendSettings.TabIndex = 8;
			this.groupBoxSendSettings.TabStop = false;
			this.groupBoxSendSettings.Text = "发送设置";
			// 
			// buttonClearSent
			// 
			this.buttonClearSent.Location = new System.Drawing.Point(160, 18);
			this.buttonClearSent.Margin = new System.Windows.Forms.Padding(2);
			this.buttonClearSent.Name = "buttonClearSent";
			this.buttonClearSent.Size = new System.Drawing.Size(62, 27);
			this.buttonClearSent.TabIndex = 5;
			this.buttonClearSent.Text = "清空发送";
			this.buttonClearSent.UseVisualStyleBackColor = true;
			this.buttonClearSent.Click += new System.EventHandler(this.buttonClearSent_Click);
			// 
			// radioButtonSendHEX
			// 
			this.radioButtonSendHEX.AutoSize = true;
			this.radioButtonSendHEX.Location = new System.Drawing.Point(92, 24);
			this.radioButtonSendHEX.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonSendHEX.Name = "radioButtonSendHEX";
			this.radioButtonSendHEX.Size = new System.Drawing.Size(41, 16);
			this.radioButtonSendHEX.TabIndex = 1;
			this.radioButtonSendHEX.TabStop = true;
			this.radioButtonSendHEX.Text = "HEX";
			this.radioButtonSendHEX.UseVisualStyleBackColor = true;
			// 
			// radioButtonSendASCII
			// 
			this.radioButtonSendASCII.AutoSize = true;
			this.radioButtonSendASCII.Checked = true;
			this.radioButtonSendASCII.Location = new System.Drawing.Point(26, 24);
			this.radioButtonSendASCII.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonSendASCII.Name = "radioButtonSendASCII";
			this.radioButtonSendASCII.Size = new System.Drawing.Size(53, 16);
			this.radioButtonSendASCII.TabIndex = 0;
			this.radioButtonSendASCII.TabStop = true;
			this.radioButtonSendASCII.Text = "ASCII";
			this.radioButtonSendASCII.UseVisualStyleBackColor = true;
			// 
			// groupBoxReceiveSettings
			// 
			this.groupBoxReceiveSettings.Controls.Add(this.radioButtonReceiveBIN);
			this.groupBoxReceiveSettings.Controls.Add(this.checkBoxReceivedBlock);
			this.groupBoxReceiveSettings.Controls.Add(this.buttonClearReceived);
			this.groupBoxReceiveSettings.Controls.Add(this.radioButtonReceiveHEX);
			this.groupBoxReceiveSettings.Controls.Add(this.radioButtonReceiveASCII);
			this.groupBoxReceiveSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxReceiveSettings.Location = new System.Drawing.Point(2, 298);
			this.groupBoxReceiveSettings.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxReceiveSettings.Name = "groupBoxReceiveSettings";
			this.groupBoxReceiveSettings.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxReceiveSettings.Size = new System.Drawing.Size(242, 96);
			this.groupBoxReceiveSettings.TabIndex = 4;
			this.groupBoxReceiveSettings.TabStop = false;
			this.groupBoxReceiveSettings.Text = "接收设置";
			// 
			// radioButtonReceiveBIN
			// 
			this.radioButtonReceiveBIN.AutoSize = true;
			this.radioButtonReceiveBIN.Location = new System.Drawing.Point(144, 24);
			this.radioButtonReceiveBIN.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonReceiveBIN.Name = "radioButtonReceiveBIN";
			this.radioButtonReceiveBIN.Size = new System.Drawing.Size(41, 16);
			this.radioButtonReceiveBIN.TabIndex = 7;
			this.radioButtonReceiveBIN.TabStop = true;
			this.radioButtonReceiveBIN.Text = "BIN";
			this.radioButtonReceiveBIN.UseVisualStyleBackColor = true;
			// 
			// checkBoxReceivedBlock
			// 
			this.checkBoxReceivedBlock.AutoSize = true;
			this.checkBoxReceivedBlock.Location = new System.Drawing.Point(26, 51);
			this.checkBoxReceivedBlock.Margin = new System.Windows.Forms.Padding(2);
			this.checkBoxReceivedBlock.Name = "checkBoxReceivedBlock";
			this.checkBoxReceivedBlock.Size = new System.Drawing.Size(96, 16);
			this.checkBoxReceivedBlock.TabIndex = 6;
			this.checkBoxReceivedBlock.Text = "屏蔽接收数据";
			this.checkBoxReceivedBlock.UseVisualStyleBackColor = true;
			this.checkBoxReceivedBlock.CheckedChanged += new System.EventHandler(this.checkBoxReceivedBlock_CheckedChanged);
			// 
			// buttonClearReceived
			// 
			this.buttonClearReceived.Location = new System.Drawing.Point(160, 46);
			this.buttonClearReceived.Margin = new System.Windows.Forms.Padding(2);
			this.buttonClearReceived.Name = "buttonClearReceived";
			this.buttonClearReceived.Size = new System.Drawing.Size(62, 27);
			this.buttonClearReceived.TabIndex = 5;
			this.buttonClearReceived.Text = "清空接收";
			this.buttonClearReceived.UseVisualStyleBackColor = true;
			this.buttonClearReceived.Click += new System.EventHandler(this.buttonClearReceived_Click);
			// 
			// radioButtonReceiveHEX
			// 
			this.radioButtonReceiveHEX.AutoSize = true;
			this.radioButtonReceiveHEX.Location = new System.Drawing.Point(92, 24);
			this.radioButtonReceiveHEX.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonReceiveHEX.Name = "radioButtonReceiveHEX";
			this.radioButtonReceiveHEX.Size = new System.Drawing.Size(41, 16);
			this.radioButtonReceiveHEX.TabIndex = 1;
			this.radioButtonReceiveHEX.TabStop = true;
			this.radioButtonReceiveHEX.Text = "HEX";
			this.radioButtonReceiveHEX.UseVisualStyleBackColor = true;
			// 
			// radioButtonReceiveASCII
			// 
			this.radioButtonReceiveASCII.AutoSize = true;
			this.radioButtonReceiveASCII.Checked = true;
			this.radioButtonReceiveASCII.Location = new System.Drawing.Point(26, 24);
			this.radioButtonReceiveASCII.Margin = new System.Windows.Forms.Padding(2);
			this.radioButtonReceiveASCII.Name = "radioButtonReceiveASCII";
			this.radioButtonReceiveASCII.Size = new System.Drawing.Size(53, 16);
			this.radioButtonReceiveASCII.TabIndex = 0;
			this.radioButtonReceiveASCII.TabStop = true;
			this.radioButtonReceiveASCII.Text = "ASCII";
			this.radioButtonReceiveASCII.UseVisualStyleBackColor = true;
			// 
			// groupBoxSerialPortSettings
			// 
			this.groupBoxSerialPortSettings.Controls.Add(this.comboBoxStopBit);
			this.groupBoxSerialPortSettings.Controls.Add(this.labelStopBit);
			this.groupBoxSerialPortSettings.Controls.Add(this.comboBoxCheckBit);
			this.groupBoxSerialPortSettings.Controls.Add(this.labelCheckBit);
			this.groupBoxSerialPortSettings.Controls.Add(this.comboBoxDataBit);
			this.groupBoxSerialPortSettings.Controls.Add(this.labelDataBit);
			this.groupBoxSerialPortSettings.Controls.Add(this.buttonClosePort);
			this.groupBoxSerialPortSettings.Controls.Add(this.buttonOpenPort);
			this.groupBoxSerialPortSettings.Controls.Add(this.comboBoxBaudRate);
			this.groupBoxSerialPortSettings.Controls.Add(this.labelBaudRate);
			this.groupBoxSerialPortSettings.Controls.Add(this.comboBoxPort);
			this.groupBoxSerialPortSettings.Controls.Add(this.labelPortNumber);
			this.groupBoxSerialPortSettings.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxSerialPortSettings.Location = new System.Drawing.Point(2, 2);
			this.groupBoxSerialPortSettings.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxSerialPortSettings.Name = "groupBoxSerialPortSettings";
			this.groupBoxSerialPortSettings.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxSerialPortSettings.Size = new System.Drawing.Size(242, 292);
			this.groupBoxSerialPortSettings.TabIndex = 3;
			this.groupBoxSerialPortSettings.TabStop = false;
			this.groupBoxSerialPortSettings.Text = "串口设置";
			// 
			// comboBoxStopBit
			// 
			this.comboBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStopBit.FormattingEnabled = true;
			this.comboBoxStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
			this.comboBoxStopBit.Location = new System.Drawing.Point(92, 128);
			this.comboBoxStopBit.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxStopBit.Name = "comboBoxStopBit";
			this.comboBoxStopBit.Size = new System.Drawing.Size(88, 20);
			this.comboBoxStopBit.TabIndex = 11;
			// 
			// labelStopBit
			// 
			this.labelStopBit.AutoSize = true;
			this.labelStopBit.Location = new System.Drawing.Point(36, 130);
			this.labelStopBit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelStopBit.Name = "labelStopBit";
			this.labelStopBit.Size = new System.Drawing.Size(41, 12);
			this.labelStopBit.TabIndex = 10;
			this.labelStopBit.Text = "停止位";
			// 
			// comboBoxCheckBit
			// 
			this.comboBoxCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCheckBit.FormattingEnabled = true;
			this.comboBoxCheckBit.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
			this.comboBoxCheckBit.Location = new System.Drawing.Point(92, 103);
			this.comboBoxCheckBit.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxCheckBit.Name = "comboBoxCheckBit";
			this.comboBoxCheckBit.Size = new System.Drawing.Size(88, 20);
			this.comboBoxCheckBit.TabIndex = 9;
			// 
			// labelCheckBit
			// 
			this.labelCheckBit.AutoSize = true;
			this.labelCheckBit.Location = new System.Drawing.Point(36, 104);
			this.labelCheckBit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelCheckBit.Name = "labelCheckBit";
			this.labelCheckBit.Size = new System.Drawing.Size(41, 12);
			this.labelCheckBit.TabIndex = 8;
			this.labelCheckBit.Text = "校验位";
			// 
			// comboBoxDataBit
			// 
			this.comboBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDataBit.FormattingEnabled = true;
			this.comboBoxDataBit.Items.AddRange(new object[] {
            "7",
            "8"});
			this.comboBoxDataBit.Location = new System.Drawing.Point(92, 78);
			this.comboBoxDataBit.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxDataBit.Name = "comboBoxDataBit";
			this.comboBoxDataBit.Size = new System.Drawing.Size(88, 20);
			this.comboBoxDataBit.TabIndex = 7;
			// 
			// labelDataBit
			// 
			this.labelDataBit.AutoSize = true;
			this.labelDataBit.Location = new System.Drawing.Point(36, 80);
			this.labelDataBit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDataBit.Name = "labelDataBit";
			this.labelDataBit.Size = new System.Drawing.Size(41, 12);
			this.labelDataBit.TabIndex = 6;
			this.labelDataBit.Text = "数据位";
			// 
			// buttonClosePort
			// 
			this.buttonClosePort.Location = new System.Drawing.Point(160, 182);
			this.buttonClosePort.Margin = new System.Windows.Forms.Padding(2);
			this.buttonClosePort.Name = "buttonClosePort";
			this.buttonClosePort.Size = new System.Drawing.Size(62, 27);
			this.buttonClosePort.TabIndex = 5;
			this.buttonClosePort.Text = "关闭串口";
			this.buttonClosePort.UseVisualStyleBackColor = true;
			this.buttonClosePort.Click += new System.EventHandler(this.buttonClosePort_Click);
			// 
			// buttonOpenPort
			// 
			this.buttonOpenPort.Location = new System.Drawing.Point(26, 182);
			this.buttonOpenPort.Margin = new System.Windows.Forms.Padding(2);
			this.buttonOpenPort.Name = "buttonOpenPort";
			this.buttonOpenPort.Size = new System.Drawing.Size(62, 27);
			this.buttonOpenPort.TabIndex = 4;
			this.buttonOpenPort.Text = "打开串口";
			this.buttonOpenPort.UseVisualStyleBackColor = true;
			this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
			// 
			// comboBoxBaudRate
			// 
			this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxBaudRate.FormattingEnabled = true;
			this.comboBoxBaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
			this.comboBoxBaudRate.Location = new System.Drawing.Point(92, 54);
			this.comboBoxBaudRate.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxBaudRate.Name = "comboBoxBaudRate";
			this.comboBoxBaudRate.Size = new System.Drawing.Size(88, 20);
			this.comboBoxBaudRate.TabIndex = 3;
			// 
			// labelBaudRate
			// 
			this.labelBaudRate.AutoSize = true;
			this.labelBaudRate.Location = new System.Drawing.Point(36, 56);
			this.labelBaudRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelBaudRate.Name = "labelBaudRate";
			this.labelBaudRate.Size = new System.Drawing.Size(41, 12);
			this.labelBaudRate.TabIndex = 2;
			this.labelBaudRate.Text = "波特率";
			// 
			// comboBoxPort
			// 
			this.comboBoxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPort.FormattingEnabled = true;
			this.comboBoxPort.Location = new System.Drawing.Point(92, 30);
			this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxPort.Name = "comboBoxPort";
			this.comboBoxPort.Size = new System.Drawing.Size(88, 20);
			this.comboBoxPort.TabIndex = 1;
			// 
			// labelPortNumber
			// 
			this.labelPortNumber.AutoSize = true;
			this.labelPortNumber.Location = new System.Drawing.Point(36, 32);
			this.labelPortNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelPortNumber.Name = "labelPortNumber";
			this.labelPortNumber.Size = new System.Drawing.Size(41, 12);
			this.labelPortNumber.TabIndex = 0;
			this.labelPortNumber.Text = "串口号";
			this.labelPortNumber.Click += new System.EventHandler(this.labelSerialPortNumber_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
			this.tableLayoutPanel3.Controls.Add(this.textBoxSend, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.textBoxReceived, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.buttonSend, 1, 1);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(252, 2);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 2;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.02898F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.97101F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(603, 496);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// textBoxSend
			// 
			this.textBoxSend.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxSend.Location = new System.Drawing.Point(2, 408);
			this.textBoxSend.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxSend.Multiline = true;
			this.textBoxSend.Name = "textBoxSend";
			this.textBoxSend.Size = new System.Drawing.Size(504, 86);
			this.textBoxSend.TabIndex = 9;
			// 
			// textBoxReceived
			// 
			this.tableLayoutPanel3.SetColumnSpan(this.textBoxReceived, 2);
			this.textBoxReceived.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBoxReceived.Location = new System.Drawing.Point(2, 2);
			this.textBoxReceived.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxReceived.Multiline = true;
			this.textBoxReceived.Name = "textBoxReceived";
			this.textBoxReceived.ReadOnly = true;
			this.textBoxReceived.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxReceived.Size = new System.Drawing.Size(599, 402);
			this.textBoxReceived.TabIndex = 8;
			// 
			// buttonSend
			// 
			this.buttonSend.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonSend.Location = new System.Drawing.Point(510, 467);
			this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSend.Name = "buttonSend";
			this.buttonSend.Size = new System.Drawing.Size(91, 27);
			this.buttonSend.TabIndex = 10;
			this.buttonSend.Text = "发送";
			this.buttonSend.UseVisualStyleBackColor = true;
			this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageDeviceManage);
			this.tabControlMain.Controls.Add(this.tabPageScope);
			this.tabControlMain.Controls.Add(this.tabPageWavegen);
			this.tabControlMain.Controls.Add(this.tabPageMeter);
			this.tabControlMain.Controls.Add(this.tabPageSpectrum);
			this.tabControlMain.Controls.Add(this.tabPageText);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Location = new System.Drawing.Point(0, 0);
			this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(867, 530);
			this.tabControlMain.TabIndex = 0;
			// 
			// toolStripMenuItemStart
			// 
			this.toolStripMenuItemStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxStart});
			this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
			this.toolStripMenuItemStart.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemStart.Text = "最小频率";
			// 
			// toolStripMenuItemStop
			// 
			this.toolStripMenuItemStop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxStop});
			this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
			this.toolStripMenuItemStop.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemStop.Text = "最大频率";
			// 
			// toolStripMenuItemBINS
			// 
			this.toolStripMenuItemBINS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
			this.toolStripMenuItemBINS.Name = "toolStripMenuItemBINS";
			this.toolStripMenuItemBINS.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemBINS.Text = "频率箱点数";
			// 
			// toolStripMenuItemScale
			// 
			this.toolStripMenuItemScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxScale});
			this.toolStripMenuItemScale.Name = "toolStripMenuItemScale";
			this.toolStripMenuItemScale.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemScale.Text = "坐标轴放缩";
			// 
			// toolStripMenuItemAlgorithm
			// 
			this.toolStripMenuItemAlgorithm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxAlgorithm});
			this.toolStripMenuItemAlgorithm.Name = "toolStripMenuItemAlgorithm";
			this.toolStripMenuItemAlgorithm.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemAlgorithm.Text = "分析算法";
			// 
			// toolStripComboBoxStart
			// 
			this.toolStripComboBoxStart.Items.AddRange(new object[] {
            "5MHz",
            "2MHz",
            "1MHz",
            "500kHz",
            "200kHz",
            "100kHz",
            "50kHz",
            "20kHz",
            "10kHz",
            "5kHz",
            "2kHz",
            "1kHz",
            "500Hz",
            "200Hz",
            "100Hz",
            "50Hz",
            "20Hz",
            "10Hz",
            "5Hz",
            "2Hz",
            "1Hz",
            "0Hz"});
			this.toolStripComboBoxStart.Name = "toolStripComboBoxStart";
			this.toolStripComboBoxStart.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripComboBoxStop
			// 
			this.toolStripComboBoxStop.Items.AddRange(new object[] {
            "5MHz",
            "2MHz",
            "1MHz",
            "500kHz",
            "200kHz",
            "100kHz",
            "50kHz",
            "20kHz",
            "10kHz",
            "5kHz",
            "2kHz",
            "1kHz",
            "500Hz",
            "200Hz",
            "100Hz",
            "50Hz",
            "20Hz",
            "10Hz",
            "5Hz",
            "2Hz",
            "1Hz",
            "0Hz"});
			this.toolStripComboBoxStop.Name = "toolStripComboBoxStop";
			this.toolStripComboBoxStop.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripComboBox3
			// 
			this.toolStripComboBox3.Items.AddRange(new object[] {
            "4097",
            "2049",
            "1025",
            "513",
            "257",
            "129",
            "65",
            "33",
            "17"});
			this.toolStripComboBox3.Name = "toolStripComboBox3";
			this.toolStripComboBox3.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripComboBoxScale
			// 
			this.toolStripComboBoxScale.Items.AddRange(new object[] {
            "线性",
            "对数"});
			this.toolStripComboBoxScale.Name = "toolStripComboBoxScale";
			this.toolStripComboBoxScale.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripComboBoxAlgorithm
			// 
			this.toolStripComboBoxAlgorithm.Items.AddRange(new object[] {
            "FFT",
            "CZT"});
			this.toolStripComboBoxAlgorithm.Name = "toolStripComboBoxAlgorithm";
			this.toolStripComboBoxAlgorithm.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
			this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
			this.toolStripLabel1.Text = "添加";
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
			this.toolStripLabel2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
			this.toolStripLabel2.Text = "移除";
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel3.Image")));
			this.toolStripLabel3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(36, 22);
			this.toolStripLabel3.Text = "编辑";
			// 
			// toolStripLabel4
			// 
			this.toolStripLabel4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
			this.toolStripLabel4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel4.Name = "toolStripLabel4";
			this.toolStripLabel4.Size = new System.Drawing.Size(36, 22);
			this.toolStripLabel4.Text = "运行";
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(867, 530);
			this.Controls.Add(this.tabControlMain);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabPageText.ResumeLayout(false);
			this.tabPageText.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabPageSpectrum.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.panelSpectrum.ResumeLayout(false);
			this.panelSpectrum.PerformLayout();
			this.groupBoxChannel.ResumeLayout(false);
			this.groupBoxChannel.PerformLayout();
			this.groupBoxMagnitude.ResumeLayout(false);
			this.groupBoxMagnitude.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.tabPageMeter.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.tabPageWavegen.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.groupBoxWavegen.ResumeLayout(false);
			this.groupBoxWavegen.PerformLayout();
			this.tabPageScope.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.groupBoxInteraction.ResumeLayout(false);
			this.groupBoxInteraction.PerformLayout();
			this.groupBoxControl.ResumeLayout(false);
			this.groupBoxControl.PerformLayout();
			this.groupBoxInfor.ResumeLayout(false);
			this.groupBoxInfor.PerformLayout();
			this.groupBoxDisplay.ResumeLayout(false);
			this.groupBoxDisplay.PerformLayout();
			this.tabPageDeviceManage.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBoxSendSettings.ResumeLayout(false);
			this.groupBoxSendSettings.PerformLayout();
			this.groupBoxReceiveSettings.ResumeLayout(false);
			this.groupBoxReceiveSettings.PerformLayout();
			this.groupBoxSerialPortSettings.ResumeLayout(false);
			this.groupBoxSerialPortSettings.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel3.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.Timer timerDisplayTime;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.TabPage tabPageText;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.TabPage tabPageSpectrum;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private ScottPlot.FormsPlot formsPlotSpectrum;
		private System.Windows.Forms.Panel panelSpectrum;
		private System.Windows.Forms.GroupBox groupBoxChannel;
		private System.Windows.Forms.Button buttonAddTrace;
		private System.Windows.Forms.ComboBox comboBoxChannelAttenuation;
		private System.Windows.Forms.Label labelAttenuation;
		private System.Windows.Forms.Label labelChannelRange;
		private System.Windows.Forms.ComboBox comboBoxChannelRange;
		private System.Windows.Forms.ComboBox comboBoxChannelOffset;
		private System.Windows.Forms.Label labelChannelOffset;
		private System.Windows.Forms.GroupBox groupBoxMagnitude;
		private System.Windows.Forms.ComboBox comboBoxReference;
		private System.Windows.Forms.Label labelReference;
		private System.Windows.Forms.ComboBox comboBoxRange;
		private System.Windows.Forms.Label labelRange;
		private System.Windows.Forms.Label labelTop;
		private System.Windows.Forms.ComboBox comboBoxTop;
		private System.Windows.Forms.ComboBox comboBoxMagnitudeUnit;
		private System.Windows.Forms.Label labelMagnitudeUnit;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSetting;
		private System.Windows.Forms.ToolStripButton toolStripButtonSingle;
		private System.Windows.Forms.ToolStripButton toolStripButtonRun;
		private System.Windows.Forms.TabPage tabPageMeter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private ScottPlot.FormsPlot formsPlotMeter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.TabPage tabPageWavegen;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private ScottPlot.FormsPlot formsPlotWaveGen;
		private System.Windows.Forms.GroupBox groupBoxWavegen;
		private System.Windows.Forms.CheckBox checkBoxRunState;
		private System.Windows.Forms.Button buttonRunWavegen;
		private System.Windows.Forms.ComboBox comboBoxPhase;
		private System.Windows.Forms.ComboBox comboBoxSymmetry;
		private System.Windows.Forms.ComboBox comboBoxOffset;
		private System.Windows.Forms.ComboBox comboBoxAmplitde;
		private System.Windows.Forms.ComboBox comboBoxFrequency;
		private System.Windows.Forms.ComboBox comboBoxWaveType;
		private System.Windows.Forms.Label labelPhase;
		private System.Windows.Forms.Label labelSymmetry;
		private System.Windows.Forms.Label labelOffset;
		private System.Windows.Forms.Label labelAmplitde;
		private System.Windows.Forms.Label labelFrequency_2;
		private System.Windows.Forms.Label labelType;
		private System.Windows.Forms.TabPage tabPageScope;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.GroupBox groupBoxInteraction;
		private System.Windows.Forms.CheckBox checkBoxCrosshair;
		private System.Windows.Forms.CheckBox checkBoxVerticalZoom;
		private System.Windows.Forms.CheckBox checkBoxHorizontalZoom;
		private System.Windows.Forms.CheckBox checkBoxScrollWheelZoom;
		private System.Windows.Forms.CheckBox checkBoxRightClickDragZoom;
		private System.Windows.Forms.GroupBox groupBoxControl;
		private System.Windows.Forms.Label labelTriggerType;
		private System.Windows.Forms.ComboBox comboBoxTriggerType;
		private System.Windows.Forms.ComboBox comboBoxTimeBase;
		private System.Windows.Forms.Label labelTimeBase;
		private System.Windows.Forms.ComboBox comboBoxVerticalSensitivity;
		private System.Windows.Forms.Label labelVerticalSensitivity;
		private System.Windows.Forms.Label labelCoupledType;
		private System.Windows.Forms.ComboBox comboBoxCoupledType;
		private System.Windows.Forms.GroupBox groupBoxInfor;
		private System.Windows.Forms.Label labelDisplayFrequency;
		private System.Windows.Forms.Label labelDisplayPlotCount;
		private System.Windows.Forms.Label labelDisplayMaximum;
		private System.Windows.Forms.Label labelDisplayMinimum;
		private System.Windows.Forms.Label labelDisplayTime;
		private System.Windows.Forms.Label labelDemo;
		private System.Windows.Forms.Label labelFrequency;
		private System.Windows.Forms.Label labelPlotCount;
		private System.Windows.Forms.Label labelMinimum;
		private System.Windows.Forms.Label labelMaximum;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.GroupBox groupBoxDisplay;
		private System.Windows.Forms.ComboBox comboBoxLineWidth;
		private System.Windows.Forms.ComboBox comboBoxLineStyle;
		private System.Windows.Forms.Label labelLineStyle;
		private System.Windows.Forms.Label labelLineWidth;
		private System.Windows.Forms.ComboBox comboBoxColorStyle;
		private System.Windows.Forms.Label labelColorStyle;
		private ScottPlot.FormsPlot formsPlotScope;
		private System.Windows.Forms.TabPage tabPageDeviceManage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBoxSendSettings;
		private System.Windows.Forms.Button buttonClearSent;
		private System.Windows.Forms.RadioButton radioButtonSendHEX;
		private System.Windows.Forms.RadioButton radioButtonSendASCII;
		private System.Windows.Forms.GroupBox groupBoxReceiveSettings;
		private System.Windows.Forms.RadioButton radioButtonReceiveBIN;
		private System.Windows.Forms.CheckBox checkBoxReceivedBlock;
		private System.Windows.Forms.Button buttonClearReceived;
		private System.Windows.Forms.RadioButton radioButtonReceiveHEX;
		private System.Windows.Forms.RadioButton radioButtonReceiveASCII;
		private System.Windows.Forms.GroupBox groupBoxSerialPortSettings;
		private System.Windows.Forms.ComboBox comboBoxStopBit;
		private System.Windows.Forms.Label labelStopBit;
		private System.Windows.Forms.ComboBox comboBoxCheckBit;
		private System.Windows.Forms.Label labelCheckBit;
		private System.Windows.Forms.ComboBox comboBoxDataBit;
		private System.Windows.Forms.Label labelDataBit;
		private System.Windows.Forms.Button buttonClosePort;
		private System.Windows.Forms.Button buttonOpenPort;
		private System.Windows.Forms.ComboBox comboBoxBaudRate;
		private System.Windows.Forms.Label labelBaudRate;
		private System.Windows.Forms.ComboBox comboBoxPort;
		private System.Windows.Forms.Label labelPortNumber;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.TextBox textBoxSend;
		private System.Windows.Forms.TextBox textBoxReceived;
		private System.Windows.Forms.Button buttonSend;
		private System.Windows.Forms.TabControl tabControlMain;
		private System.Windows.Forms.Button buttonProjectOntoScope;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxStart;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxStop;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBINS;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxScale;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAlgorithm;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxAlgorithm;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripLabel2;
		private System.Windows.Forms.ToolStripButton toolStripLabel3;
		private System.Windows.Forms.ToolStripButton toolStripLabel4;
	}
}

