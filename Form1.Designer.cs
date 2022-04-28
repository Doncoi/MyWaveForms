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
			this.groupBoxInteraction = new System.Windows.Forms.GroupBox();
			this.checkBoxCrosshair = new System.Windows.Forms.CheckBox();
			this.checkBoxVerticalZoom = new System.Windows.Forms.CheckBox();
			this.checkBoxHorizontalZoom = new System.Windows.Forms.CheckBox();
			this.checkBoxScrollWheelZoom = new System.Windows.Forms.CheckBox();
			this.checkBoxRightClickDragZoom = new System.Windows.Forms.CheckBox();
			this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
			this.comboBoxLineWidth = new System.Windows.Forms.ComboBox();
			this.comboBoxLineStyle = new System.Windows.Forms.ComboBox();
			this.labelLineStyle = new System.Windows.Forms.Label();
			this.labelLineWidth = new System.Windows.Forms.Label();
			this.comboBoxColorStyle = new System.Windows.Forms.ComboBox();
			this.labelColorStyle = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.tabPageSpectrum = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStripSpectrum = new System.Windows.Forms.ToolStrip();
			this.toolStripButtonSetting = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItemStart = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxStart = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemStop = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxStop = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemBINS = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxBoxCount = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemScale = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxScale = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemAlgorithm = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxAlgorithm = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonSingle = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButtonRun = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItemRightClickDragZoom4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemScrollWheelZoom4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHorizontalZoom4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemVerticalZoom4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxColorStyle4 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxLineStyle4 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxLineWidth4 = new System.Windows.Forms.ToolStripComboBox();
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
			this.tabPageMeter = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
			this.formsPlotMeter = new ScottPlot.FormsPlot();
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.panelMeter = new System.Windows.Forms.Panel();
			this.toolStripMeter = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButtonDisplay3 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxColorStyle3 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxLineStyle3 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxLineWidth3 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabelAddTracer = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tabPageWavegen = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.toolStripWaveGen = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItemColorStyle2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxColorStyle2 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemLineStyle2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxLineStyle2 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemLineWidth2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxLineWidth2 = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButtonInteraction2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItemRightClickDragZoom2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemScrollWheelZoom2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHorizontalZoom2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemVerticalZoom2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
			this.groupBoxWavegen = new System.Windows.Forms.GroupBox();
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
			this.formsPlotWaveGen = new ScottPlot.FormsPlot();
			this.tabPageScope = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
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
			this.labelRunTime = new System.Windows.Forms.Label();
			this.labelDemo = new System.Windows.Forms.Label();
			this.labelFrequency = new System.Windows.Forms.Label();
			this.labelPlotCount = new System.Windows.Forms.Label();
			this.labelMinimum = new System.Windows.Forms.Label();
			this.labelMaximum = new System.Windows.Forms.Label();
			this.labelRunTimeText = new System.Windows.Forms.Label();
			this.toolStripScope = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButtonDisplay = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItemColorStyle = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxColorStyle = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemLineStyle = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxLineStyle = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripMenuItemLineWidth = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripComboBoxLineWidth = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButtonInteraction = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripMenuItemRightClickDragZoom = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemScrollWheelZoom = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHorizontalZoom = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemVerticalZoom = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemCrosshair = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
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
			this.toolStripMenuItemRightClickDragZoom3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemScrollWheelZoom3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemHorizontalZoom3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemVerticalZoom3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButtonInteraction3 = new System.Windows.Forms.ToolStripDropDownButton();
			this.tabPageText.SuspendLayout();
			this.groupBoxInteraction.SuspendLayout();
			this.groupBoxDisplay.SuspendLayout();
			this.tabPageSpectrum.SuspendLayout();
			this.tableLayoutPanel7.SuspendLayout();
			this.toolStripSpectrum.SuspendLayout();
			this.panelSpectrum.SuspendLayout();
			this.groupBoxChannel.SuspendLayout();
			this.groupBoxMagnitude.SuspendLayout();
			this.tabPageMeter.SuspendLayout();
			this.tableLayoutPanel9.SuspendLayout();
			this.tableLayoutPanel8.SuspendLayout();
			this.toolStripMeter.SuspendLayout();
			this.tabPageWavegen.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			this.toolStripWaveGen.SuspendLayout();
			this.groupBoxWavegen.SuspendLayout();
			this.tabPageScope.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.groupBoxControl.SuspendLayout();
			this.groupBoxInfor.SuspendLayout();
			this.toolStripScope.SuspendLayout();
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
			this.tabPageText.Controls.Add(this.groupBoxInteraction);
			this.tabPageText.Controls.Add(this.groupBoxDisplay);
			this.tabPageText.Controls.Add(this.button6);
			this.tabPageText.Controls.Add(this.textBox3);
			this.tabPageText.Location = new System.Drawing.Point(4, 22);
			this.tabPageText.Margin = new System.Windows.Forms.Padding(2);
			this.tabPageText.Name = "tabPageText";
			this.tabPageText.Padding = new System.Windows.Forms.Padding(2);
			this.tabPageText.Size = new System.Drawing.Size(859, 504);
			this.tabPageText.TabIndex = 4;
			this.tabPageText.Text = "测试页";
			this.tabPageText.UseVisualStyleBackColor = true;
			// 
			// groupBoxInteraction
			// 
			this.groupBoxInteraction.Controls.Add(this.checkBoxCrosshair);
			this.groupBoxInteraction.Controls.Add(this.checkBoxVerticalZoom);
			this.groupBoxInteraction.Controls.Add(this.checkBoxHorizontalZoom);
			this.groupBoxInteraction.Controls.Add(this.checkBoxScrollWheelZoom);
			this.groupBoxInteraction.Controls.Add(this.checkBoxRightClickDragZoom);
			this.groupBoxInteraction.Location = new System.Drawing.Point(339, 111);
			this.groupBoxInteraction.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxInteraction.Name = "groupBoxInteraction";
			this.groupBoxInteraction.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxInteraction.Size = new System.Drawing.Size(192, 98);
			this.groupBoxInteraction.TabIndex = 15;
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
			// 
			// groupBoxDisplay
			// 
			this.groupBoxDisplay.Controls.Add(this.comboBoxLineWidth);
			this.groupBoxDisplay.Controls.Add(this.comboBoxLineStyle);
			this.groupBoxDisplay.Controls.Add(this.labelLineStyle);
			this.groupBoxDisplay.Controls.Add(this.labelLineWidth);
			this.groupBoxDisplay.Controls.Add(this.comboBoxColorStyle);
			this.groupBoxDisplay.Controls.Add(this.labelColorStyle);
			this.groupBoxDisplay.Location = new System.Drawing.Point(339, 13);
			this.groupBoxDisplay.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxDisplay.Name = "groupBoxDisplay";
			this.groupBoxDisplay.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxDisplay.Size = new System.Drawing.Size(192, 94);
			this.groupBoxDisplay.TabIndex = 14;
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
			this.tabPageSpectrum.Enter += new System.EventHandler(this.tabPageSpectrum_Enter);
			// 
			// tableLayoutPanel7
			// 
			this.tableLayoutPanel7.ColumnCount = 2;
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
			this.tableLayoutPanel7.Controls.Add(this.toolStripSpectrum, 1, 0);
			this.tableLayoutPanel7.Controls.Add(this.formsPlotSpectrum, 0, 0);
			this.tableLayoutPanel7.Controls.Add(this.panelSpectrum, 1, 1);
			this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel7.Name = "tableLayoutPanel7";
			this.tableLayoutPanel7.RowCount = 2;
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel7.Size = new System.Drawing.Size(859, 504);
			this.tableLayoutPanel7.TabIndex = 0;
			// 
			// toolStripSpectrum
			// 
			this.toolStripSpectrum.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStripSpectrum.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSetting,
            this.toolStripSeparator5,
            this.toolStripButtonSingle,
            this.toolStripSeparator6,
            this.toolStripButtonRun,
            this.toolStripSeparator7,
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton2});
			this.toolStripSpectrum.Location = new System.Drawing.Point(644, 0);
			this.toolStripSpectrum.Name = "toolStripSpectrum";
			this.toolStripSpectrum.Padding = new System.Windows.Forms.Padding(0);
			this.toolStripSpectrum.Size = new System.Drawing.Size(215, 25);
			this.toolStripSpectrum.TabIndex = 2;
			this.toolStripSpectrum.Text = "toolStrip2";
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
			// toolStripMenuItemStart
			// 
			this.toolStripMenuItemStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxStart});
			this.toolStripMenuItemStart.Name = "toolStripMenuItemStart";
			this.toolStripMenuItemStart.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemStart.Text = "最小频率";
			// 
			// toolStripComboBoxStart
			// 
			this.toolStripComboBoxStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
			// toolStripMenuItemStop
			// 
			this.toolStripMenuItemStop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxStop});
			this.toolStripMenuItemStop.Name = "toolStripMenuItemStop";
			this.toolStripMenuItemStop.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemStop.Text = "最大频率";
			// 
			// toolStripComboBoxStop
			// 
			this.toolStripComboBoxStop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
			// toolStripMenuItemBINS
			// 
			this.toolStripMenuItemBINS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxBoxCount});
			this.toolStripMenuItemBINS.Name = "toolStripMenuItemBINS";
			this.toolStripMenuItemBINS.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemBINS.Text = "频率箱点数";
			// 
			// toolStripComboBoxBoxCount
			// 
			this.toolStripComboBoxBoxCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxBoxCount.Items.AddRange(new object[] {
            "Default",
            "4097",
            "2049",
            "1025",
            "513",
            "257",
            "129",
            "65",
            "33",
            "17"});
			this.toolStripComboBoxBoxCount.Name = "toolStripComboBoxBoxCount";
			this.toolStripComboBoxBoxCount.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripMenuItemScale
			// 
			this.toolStripMenuItemScale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxScale});
			this.toolStripMenuItemScale.Name = "toolStripMenuItemScale";
			this.toolStripMenuItemScale.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemScale.Text = "坐标轴放缩";
			// 
			// toolStripComboBoxScale
			// 
			this.toolStripComboBoxScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxScale.Items.AddRange(new object[] {
            "线性",
            "对数"});
			this.toolStripComboBoxScale.Name = "toolStripComboBoxScale";
			this.toolStripComboBoxScale.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripMenuItemAlgorithm
			// 
			this.toolStripMenuItemAlgorithm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxAlgorithm});
			this.toolStripMenuItemAlgorithm.Name = "toolStripMenuItemAlgorithm";
			this.toolStripMenuItemAlgorithm.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemAlgorithm.Text = "分析算法";
			// 
			// toolStripComboBoxAlgorithm
			// 
			this.toolStripComboBoxAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxAlgorithm.Items.AddRange(new object[] {
            "FFT",
            "CZT"});
			this.toolStripComboBoxAlgorithm.Name = "toolStripComboBoxAlgorithm";
			this.toolStripComboBoxAlgorithm.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton5
			// 
			this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRightClickDragZoom4,
            this.toolStripMenuItemScrollWheelZoom4,
            this.toolStripMenuItemHorizontalZoom4,
            this.toolStripMenuItemVerticalZoom4});
			this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
			this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
			this.toolStripDropDownButton5.Size = new System.Drawing.Size(45, 21);
			this.toolStripDropDownButton5.Text = "交互";
			// 
			// toolStripMenuItemRightClickDragZoom4
			// 
			this.toolStripMenuItemRightClickDragZoom4.Checked = true;
			this.toolStripMenuItemRightClickDragZoom4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemRightClickDragZoom4.Name = "toolStripMenuItemRightClickDragZoom4";
			this.toolStripMenuItemRightClickDragZoom4.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemRightClickDragZoom4.Text = "右键缩放";
			// 
			// toolStripMenuItemScrollWheelZoom4
			// 
			this.toolStripMenuItemScrollWheelZoom4.Checked = true;
			this.toolStripMenuItemScrollWheelZoom4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemScrollWheelZoom4.Name = "toolStripMenuItemScrollWheelZoom4";
			this.toolStripMenuItemScrollWheelZoom4.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemScrollWheelZoom4.Text = "滚轮缩放";
			// 
			// toolStripMenuItemHorizontalZoom4
			// 
			this.toolStripMenuItemHorizontalZoom4.Checked = true;
			this.toolStripMenuItemHorizontalZoom4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemHorizontalZoom4.Name = "toolStripMenuItemHorizontalZoom4";
			this.toolStripMenuItemHorizontalZoom4.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemHorizontalZoom4.Text = "水平缩放";
			// 
			// toolStripMenuItemVerticalZoom4
			// 
			this.toolStripMenuItemVerticalZoom4.Checked = true;
			this.toolStripMenuItemVerticalZoom4.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemVerticalZoom4.Name = "toolStripMenuItemVerticalZoom4";
			this.toolStripMenuItemVerticalZoom4.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemVerticalZoom4.Text = "垂直缩放";
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 21);
			this.toolStripDropDownButton2.Text = "显示";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxColorStyle4});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItem1.Text = "色彩模式";
			// 
			// toolStripComboBoxColorStyle4
			// 
			this.toolStripComboBoxColorStyle4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxColorStyle4.Items.AddRange(new object[] {
            "浅色模式",
            "深色模式"});
			this.toolStripComboBoxColorStyle4.Name = "toolStripComboBoxColorStyle4";
			this.toolStripComboBoxColorStyle4.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLineStyle4});
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItem2.Text = "连线样式";
			// 
			// toolStripComboBoxLineStyle4
			// 
			this.toolStripComboBoxLineStyle4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxLineStyle4.Items.AddRange(new object[] {
            "折线",
            "步进显示"});
			this.toolStripComboBoxLineStyle4.Name = "toolStripComboBoxLineStyle4";
			this.toolStripComboBoxLineStyle4.Size = new System.Drawing.Size(121, 25);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLineWidth4});
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItem3.Text = "连线宽度";
			// 
			// toolStripComboBoxLineWidth4
			// 
			this.toolStripComboBoxLineWidth4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxLineWidth4.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
			this.toolStripComboBoxLineWidth4.Name = "toolStripComboBoxLineWidth4";
			this.toolStripComboBoxLineWidth4.Size = new System.Drawing.Size(121, 25);
			// 
			// formsPlotSpectrum
			// 
			this.formsPlotSpectrum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formsPlotSpectrum.Location = new System.Drawing.Point(5, 5);
			this.formsPlotSpectrum.Margin = new System.Windows.Forms.Padding(5);
			this.formsPlotSpectrum.Name = "formsPlotSpectrum";
			this.tableLayoutPanel7.SetRowSpan(this.formsPlotSpectrum, 2);
			this.formsPlotSpectrum.Size = new System.Drawing.Size(634, 494);
			this.formsPlotSpectrum.TabIndex = 0;
			// 
			// panelSpectrum
			// 
			this.panelSpectrum.AutoScroll = true;
			this.panelSpectrum.Controls.Add(this.groupBoxChannel);
			this.panelSpectrum.Controls.Add(this.groupBoxMagnitude);
			this.panelSpectrum.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSpectrum.Location = new System.Drawing.Point(644, 25);
			this.panelSpectrum.Margin = new System.Windows.Forms.Padding(0);
			this.panelSpectrum.Name = "panelSpectrum";
			this.panelSpectrum.Size = new System.Drawing.Size(215, 479);
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
			this.groupBoxChannel.Location = new System.Drawing.Point(0, 130);
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
			this.comboBoxChannelAttenuation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChannelAttenuation.FormattingEnabled = true;
			this.comboBoxChannelAttenuation.Items.AddRange(new object[] {
            "100X",
            "10X",
            "1X",
            "0.1X"});
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
			this.labelChannelRange.Text = "量程";
			// 
			// comboBoxChannelRange
			// 
			this.comboBoxChannelRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChannelRange.FormattingEnabled = true;
			this.comboBoxChannelRange.Items.AddRange(new object[] {
            "Auto",
            "50V",
            "20V",
            "10V",
            "5V",
            "2V",
            "1V",
            "0.5V",
            "0.2V",
            "0.1V",
            "0.05V",
            "0.02V",
            "0.01V",
            "5mV",
            "2mV",
            "1mV"});
			this.comboBoxChannelRange.Location = new System.Drawing.Point(83, 49);
			this.comboBoxChannelRange.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxChannelRange.Name = "comboBoxChannelRange";
			this.comboBoxChannelRange.Size = new System.Drawing.Size(93, 20);
			this.comboBoxChannelRange.TabIndex = 8;
			// 
			// comboBoxChannelOffset
			// 
			this.comboBoxChannelOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxChannelOffset.FormattingEnabled = true;
			this.comboBoxChannelOffset.Items.AddRange(new object[] {
            "25V",
            "10V",
            "5V",
            "2V",
            "1V",
            "0.5V",
            "0.2V",
            "0.1V",
            "0.05V",
            "0.02V",
            "0.01V",
            "5mV",
            "2mV",
            "1mV",
            "0V",
            "-1mV",
            "-2mV",
            "-5mV",
            "-0.01V",
            "-0.02V",
            "-0.05V",
            "-0.1V",
            "-0.2V",
            "-0.5V",
            "-1V",
            "-2V",
            "-5V",
            "-10V",
            "-25V"});
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
			this.groupBoxMagnitude.Location = new System.Drawing.Point(0, 0);
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
			this.comboBoxReference.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxReference.FormattingEnabled = true;
			this.comboBoxReference.Items.AddRange(new object[] {
            "1kV",
            "500V",
            "200V",
            "100V",
            "50V",
            "20V",
            "10V",
            "5V",
            "2V",
            "1V",
            "0.5V",
            "0.2V",
            "0.1V",
            "0.05V",
            "0.02V",
            "0.01V",
            "5mV",
            "2mV",
            "1mV",
            "0.5mV",
            "0.2mV",
            "0.1mV",
            "0.05mV",
            "0.02mV",
            "0.01mV",
            "5uV",
            "2uV",
            "1uV"});
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
			this.comboBoxRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRange.FormattingEnabled = true;
			this.comboBoxRange.Items.AddRange(new object[] {
            "200dBV",
            "190dBV",
            "180dBV",
            "170dBV",
            "160dBV",
            "150dBV",
            "140dBV",
            "130dBV",
            "120dBV",
            "110dBV",
            "100dBV",
            "90dBV",
            "80dBV",
            "70dBV",
            "60dBV",
            "50dBV",
            "40dBV",
            "30dBV",
            "20dBV",
            "10dBV",
            "1dBV"});
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
			this.comboBoxTop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTop.FormattingEnabled = true;
			this.comboBoxTop.Items.AddRange(new object[] {
            "100dBV",
            "90dBV",
            "80dBV",
            "70dBV",
            "60dBV",
            "50dBV",
            "40dBV",
            "30dBV",
            "20dBV",
            "10dBV",
            "0dBV",
            "-10dBV",
            "-20dBV",
            "-30dBV",
            "-40dBV",
            "-50dBV",
            "-60dBV",
            "-70dBV",
            "-80dBV",
            "-90dBV",
            "-100dBV"});
			this.comboBoxTop.Location = new System.Drawing.Point(83, 42);
			this.comboBoxTop.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxTop.Name = "comboBoxTop";
			this.comboBoxTop.Size = new System.Drawing.Size(93, 20);
			this.comboBoxTop.TabIndex = 2;
			// 
			// comboBoxMagnitudeUnit
			// 
			this.comboBoxMagnitudeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMagnitudeUnit.FormattingEnabled = true;
			this.comboBoxMagnitudeUnit.Items.AddRange(new object[] {
            "Vpeak(V)",
            "Vrms",
            "dBV",
            "dBu",
            "dB"});
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
			this.tabPageMeter.Enter += new System.EventHandler(this.tabPageMeter_Enter);
			// 
			// tableLayoutPanel9
			// 
			this.tableLayoutPanel9.ColumnCount = 2;
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
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
			this.formsPlotMeter.Size = new System.Drawing.Size(634, 494);
			this.formsPlotMeter.TabIndex = 0;
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.ColumnCount = 1;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Controls.Add(this.panelMeter, 0, 1);
			this.tableLayoutPanel8.Controls.Add(this.toolStripMeter, 0, 0);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(640, 0);
			this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 2;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.Size = new System.Drawing.Size(215, 500);
			this.tableLayoutPanel8.TabIndex = 1;
			// 
			// panelMeter
			// 
			this.panelMeter.AutoScroll = true;
			this.panelMeter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMeter.Location = new System.Drawing.Point(0, 25);
			this.panelMeter.Margin = new System.Windows.Forms.Padding(0);
			this.panelMeter.Name = "panelMeter";
			this.panelMeter.Size = new System.Drawing.Size(215, 475);
			this.panelMeter.TabIndex = 5;
			// 
			// toolStripMeter
			// 
			this.toolStripMeter.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStripMeter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonDisplay3,
            this.toolStripSeparator4,
            this.toolStripDropDownButtonInteraction3,
            this.toolStripSeparator12,
            this.toolStripLabelAddTracer,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripSeparator3});
			this.toolStripMeter.Location = new System.Drawing.Point(0, 0);
			this.toolStripMeter.Name = "toolStripMeter";
			this.toolStripMeter.Padding = new System.Windows.Forms.Padding(0);
			this.toolStripMeter.Size = new System.Drawing.Size(215, 25);
			this.toolStripMeter.TabIndex = 3;
			this.toolStripMeter.Text = "toolStrip1";
			// 
			// toolStripDropDownButtonDisplay3
			// 
			this.toolStripDropDownButtonDisplay3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButtonDisplay3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
			this.toolStripDropDownButtonDisplay3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonDisplay3.Image")));
			this.toolStripDropDownButtonDisplay3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonDisplay3.Name = "toolStripDropDownButtonDisplay3";
			this.toolStripDropDownButtonDisplay3.Size = new System.Drawing.Size(45, 22);
			this.toolStripDropDownButtonDisplay3.Text = "显示";
			// 
			// toolStripMenuItem9
			// 
			this.toolStripMenuItem9.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxColorStyle3});
			this.toolStripMenuItem9.Name = "toolStripMenuItem9";
			this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem9.Text = "色彩模式";
			// 
			// toolStripComboBoxColorStyle3
			// 
			this.toolStripComboBoxColorStyle3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxColorStyle3.Items.AddRange(new object[] {
            "浅色模式",
            "深色模式"});
			this.toolStripComboBoxColorStyle3.Name = "toolStripComboBoxColorStyle3";
			this.toolStripComboBoxColorStyle3.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxColorStyle3.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxColorStyle3_SelectedIndexChanged);
			// 
			// toolStripMenuItem10
			// 
			this.toolStripMenuItem10.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLineStyle3});
			this.toolStripMenuItem10.Name = "toolStripMenuItem10";
			this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem10.Text = "连线样式";
			// 
			// toolStripComboBoxLineStyle3
			// 
			this.toolStripComboBoxLineStyle3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxLineStyle3.Items.AddRange(new object[] {
            "折线",
            "步进显示"});
			this.toolStripComboBoxLineStyle3.Name = "toolStripComboBoxLineStyle3";
			this.toolStripComboBoxLineStyle3.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxLineStyle3.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxLineStyle3_SelectedIndexChanged);
			// 
			// toolStripMenuItem11
			// 
			this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLineWidth3});
			this.toolStripMenuItem11.Name = "toolStripMenuItem11";
			this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItem11.Text = "连线宽度";
			// 
			// toolStripComboBoxLineWidth3
			// 
			this.toolStripComboBoxLineWidth3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxLineWidth3.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
			this.toolStripComboBoxLineWidth3.Name = "toolStripComboBoxLineWidth3";
			this.toolStripComboBoxLineWidth3.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxLineWidth3.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxLineWidth3_SelectedIndexChanged);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator12
			// 
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabelAddTracer
			// 
			this.toolStripLabelAddTracer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabelAddTracer.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabelAddTracer.Image")));
			this.toolStripLabelAddTracer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabelAddTracer.Name = "toolStripLabelAddTracer";
			this.toolStripLabelAddTracer.Size = new System.Drawing.Size(36, 22);
			this.toolStripLabelAddTracer.Text = "添加";
			this.toolStripLabelAddTracer.Click += new System.EventHandler(this.toolStripLabelAddTracer_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel2.Image")));
			this.toolStripLabel2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(36, 22);
			this.toolStripLabel2.Text = "清空";
			this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
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
			this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
			this.tableLayoutPanel6.Controls.Add(this.toolStripWaveGen, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.groupBoxWavegen, 0, 1);
			this.tableLayoutPanel6.Controls.Add(this.formsPlotWaveGen, 0, 0);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 2);
			this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(855, 500);
			this.tableLayoutPanel6.TabIndex = 0;
			// 
			// toolStripWaveGen
			// 
			this.toolStripWaveGen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.toolStripWaveGen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripSeparator11,
            this.toolStripDropDownButtonInteraction2,
            this.toolStripSeparator10});
			this.toolStripWaveGen.Location = new System.Drawing.Point(640, 0);
			this.toolStripWaveGen.Name = "toolStripWaveGen";
			this.toolStripWaveGen.Padding = new System.Windows.Forms.Padding(0);
			this.toolStripWaveGen.Size = new System.Drawing.Size(215, 25);
			this.toolStripWaveGen.TabIndex = 8;
			this.toolStripWaveGen.Text = "toolStrip4";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemColorStyle2,
            this.toolStripMenuItemLineStyle2,
            this.toolStripMenuItemLineWidth2});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(45, 22);
			this.toolStripDropDownButton1.Text = "显示";
			// 
			// toolStripMenuItemColorStyle2
			// 
			this.toolStripMenuItemColorStyle2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxColorStyle2});
			this.toolStripMenuItemColorStyle2.Name = "toolStripMenuItemColorStyle2";
			this.toolStripMenuItemColorStyle2.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemColorStyle2.Text = "色彩模式";
			// 
			// toolStripComboBoxColorStyle2
			// 
			this.toolStripComboBoxColorStyle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxColorStyle2.Items.AddRange(new object[] {
            "浅色模式",
            "深色模式"});
			this.toolStripComboBoxColorStyle2.Name = "toolStripComboBoxColorStyle2";
			this.toolStripComboBoxColorStyle2.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxColorStyle2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxColorStyle2_SelectedIndexChanged);
			// 
			// toolStripMenuItemLineStyle2
			// 
			this.toolStripMenuItemLineStyle2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLineStyle2});
			this.toolStripMenuItemLineStyle2.Name = "toolStripMenuItemLineStyle2";
			this.toolStripMenuItemLineStyle2.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemLineStyle2.Text = "连线样式";
			// 
			// toolStripComboBoxLineStyle2
			// 
			this.toolStripComboBoxLineStyle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxLineStyle2.Items.AddRange(new object[] {
            "折线",
            "步进显示"});
			this.toolStripComboBoxLineStyle2.Name = "toolStripComboBoxLineStyle2";
			this.toolStripComboBoxLineStyle2.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxLineStyle2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxLineStyle2_SelectedIndexChanged);
			// 
			// toolStripMenuItemLineWidth2
			// 
			this.toolStripMenuItemLineWidth2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLineWidth2});
			this.toolStripMenuItemLineWidth2.Name = "toolStripMenuItemLineWidth2";
			this.toolStripMenuItemLineWidth2.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemLineWidth2.Text = "连线宽度";
			// 
			// toolStripComboBoxLineWidth2
			// 
			this.toolStripComboBoxLineWidth2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxLineWidth2.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
			this.toolStripComboBoxLineWidth2.Name = "toolStripComboBoxLineWidth2";
			this.toolStripComboBoxLineWidth2.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxLineWidth2.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxLineWidth2_SelectedIndexChanged);
			// 
			// toolStripSeparator11
			// 
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButtonInteraction2
			// 
			this.toolStripDropDownButtonInteraction2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButtonInteraction2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRightClickDragZoom2,
            this.toolStripMenuItemScrollWheelZoom2,
            this.toolStripMenuItemHorizontalZoom2,
            this.toolStripMenuItemVerticalZoom2});
			this.toolStripDropDownButtonInteraction2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonInteraction2.Image")));
			this.toolStripDropDownButtonInteraction2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonInteraction2.Name = "toolStripDropDownButtonInteraction2";
			this.toolStripDropDownButtonInteraction2.Size = new System.Drawing.Size(45, 22);
			this.toolStripDropDownButtonInteraction2.Text = "交互";
			// 
			// toolStripMenuItemRightClickDragZoom2
			// 
			this.toolStripMenuItemRightClickDragZoom2.Checked = true;
			this.toolStripMenuItemRightClickDragZoom2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemRightClickDragZoom2.Name = "toolStripMenuItemRightClickDragZoom2";
			this.toolStripMenuItemRightClickDragZoom2.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemRightClickDragZoom2.Text = "右键缩放";
			this.toolStripMenuItemRightClickDragZoom2.Click += new System.EventHandler(this.toolStripMenuItemRightClickDragZoom2_Click);
			// 
			// toolStripMenuItemScrollWheelZoom2
			// 
			this.toolStripMenuItemScrollWheelZoom2.Checked = true;
			this.toolStripMenuItemScrollWheelZoom2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemScrollWheelZoom2.Name = "toolStripMenuItemScrollWheelZoom2";
			this.toolStripMenuItemScrollWheelZoom2.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemScrollWheelZoom2.Text = "滚轮缩放";
			this.toolStripMenuItemScrollWheelZoom2.Click += new System.EventHandler(this.toolStripMenuItemScrollWheelZoom2_Click);
			// 
			// toolStripMenuItemHorizontalZoom2
			// 
			this.toolStripMenuItemHorizontalZoom2.Checked = true;
			this.toolStripMenuItemHorizontalZoom2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemHorizontalZoom2.Name = "toolStripMenuItemHorizontalZoom2";
			this.toolStripMenuItemHorizontalZoom2.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemHorizontalZoom2.Text = "水平缩放";
			this.toolStripMenuItemHorizontalZoom2.Click += new System.EventHandler(this.toolStripMenuItemHorizontalZoom2_Click);
			// 
			// toolStripMenuItemVerticalZoom2
			// 
			this.toolStripMenuItemVerticalZoom2.Checked = true;
			this.toolStripMenuItemVerticalZoom2.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemVerticalZoom2.Name = "toolStripMenuItemVerticalZoom2";
			this.toolStripMenuItemVerticalZoom2.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemVerticalZoom2.Text = "垂直缩放";
			this.toolStripMenuItemVerticalZoom2.Click += new System.EventHandler(this.toolStripMenuItemVerticalZoom2_Click);
			// 
			// toolStripSeparator10
			// 
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
			// 
			// groupBoxWavegen
			// 
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
			this.groupBoxWavegen.Location = new System.Drawing.Point(642, 27);
			this.groupBoxWavegen.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxWavegen.Name = "groupBoxWavegen";
			this.groupBoxWavegen.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxWavegen.Size = new System.Drawing.Size(211, 471);
			this.groupBoxWavegen.TabIndex = 3;
			this.groupBoxWavegen.TabStop = false;
			this.groupBoxWavegen.Text = "控制";
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
			this.buttonRunWavegen.Location = new System.Drawing.Point(62, 200);
			this.buttonRunWavegen.Margin = new System.Windows.Forms.Padding(2);
			this.buttonRunWavegen.Name = "buttonRunWavegen";
			this.buttonRunWavegen.Size = new System.Drawing.Size(68, 27);
			this.buttonRunWavegen.TabIndex = 12;
			this.buttonRunWavegen.Text = "运行";
			this.buttonRunWavegen.UseVisualStyleBackColor = false;
			this.buttonRunWavegen.Click += new System.EventHandler(this.buttonRunWaveGen_Click);
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
			// formsPlotWaveGen
			// 
			this.formsPlotWaveGen.Dock = System.Windows.Forms.DockStyle.Fill;
			this.formsPlotWaveGen.Location = new System.Drawing.Point(3, 3);
			this.formsPlotWaveGen.Name = "formsPlotWaveGen";
			this.tableLayoutPanel6.SetRowSpan(this.formsPlotWaveGen, 2);
			this.formsPlotWaveGen.Size = new System.Drawing.Size(634, 494);
			this.formsPlotWaveGen.TabIndex = 2;
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
			this.tableLayoutPanel5.Controls.Add(this.groupBoxControl, 0, 1);
			this.tableLayoutPanel5.Controls.Add(this.groupBoxInfor, 0, 2);
			this.tableLayoutPanel5.Controls.Add(this.toolStripScope, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(657, 2);
			this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 3;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.66667F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.33333F));
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(196, 496);
			this.tableLayoutPanel5.TabIndex = 3;
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
			this.groupBoxControl.Location = new System.Drawing.Point(2, 27);
			this.groupBoxControl.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxControl.Name = "groupBoxControl";
			this.groupBoxControl.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxControl.Size = new System.Drawing.Size(192, 192);
			this.groupBoxControl.TabIndex = 6;
			this.groupBoxControl.TabStop = false;
			this.groupBoxControl.Text = "控制";
			// 
			// labelTriggerType
			// 
			this.labelTriggerType.AutoSize = true;
			this.labelTriggerType.Location = new System.Drawing.Point(9, 47);
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
			this.comboBoxTriggerType.Location = new System.Drawing.Point(79, 44);
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
			this.comboBoxTimeBase.Location = new System.Drawing.Point(79, 92);
			this.comboBoxTimeBase.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxTimeBase.Name = "comboBoxTimeBase";
			this.comboBoxTimeBase.Size = new System.Drawing.Size(92, 20);
			this.comboBoxTimeBase.TabIndex = 31;
			// 
			// labelTimeBase
			// 
			this.labelTimeBase.AutoSize = true;
			this.labelTimeBase.Location = new System.Drawing.Point(9, 95);
			this.labelTimeBase.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelTimeBase.Name = "labelTimeBase";
			this.labelTimeBase.Size = new System.Drawing.Size(65, 12);
			this.labelTimeBase.TabIndex = 30;
			this.labelTimeBase.Text = "水平灵敏度";
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
			this.comboBoxVerticalSensitivity.Location = new System.Drawing.Point(79, 68);
			this.comboBoxVerticalSensitivity.Margin = new System.Windows.Forms.Padding(2);
			this.comboBoxVerticalSensitivity.Name = "comboBoxVerticalSensitivity";
			this.comboBoxVerticalSensitivity.Size = new System.Drawing.Size(92, 20);
			this.comboBoxVerticalSensitivity.TabIndex = 29;
			// 
			// labelVerticalSensitivity
			// 
			this.labelVerticalSensitivity.AutoSize = true;
			this.labelVerticalSensitivity.Location = new System.Drawing.Point(9, 71);
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
			this.groupBoxInfor.Controls.Add(this.labelRunTime);
			this.groupBoxInfor.Controls.Add(this.labelDemo);
			this.groupBoxInfor.Controls.Add(this.labelFrequency);
			this.groupBoxInfor.Controls.Add(this.labelPlotCount);
			this.groupBoxInfor.Controls.Add(this.labelMinimum);
			this.groupBoxInfor.Controls.Add(this.labelMaximum);
			this.groupBoxInfor.Controls.Add(this.labelRunTimeText);
			this.groupBoxInfor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxInfor.Location = new System.Drawing.Point(2, 223);
			this.groupBoxInfor.Margin = new System.Windows.Forms.Padding(2);
			this.groupBoxInfor.Name = "groupBoxInfor";
			this.groupBoxInfor.Padding = new System.Windows.Forms.Padding(2);
			this.groupBoxInfor.Size = new System.Drawing.Size(192, 271);
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
			// labelRunTime
			// 
			this.labelRunTime.AutoSize = true;
			this.labelRunTime.Location = new System.Drawing.Point(77, 18);
			this.labelRunTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelRunTime.Name = "labelRunTime";
			this.labelRunTime.Size = new System.Drawing.Size(23, 12);
			this.labelRunTime.TabIndex = 21;
			this.labelRunTime.Text = "N/A";
			// 
			// labelDemo
			// 
			this.labelDemo.AutoSize = true;
			this.labelDemo.BackColor = System.Drawing.Color.Tomato;
			this.labelDemo.Location = new System.Drawing.Point(10, 137);
			this.labelDemo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelDemo.Name = "labelDemo";
			this.labelDemo.Size = new System.Drawing.Size(53, 12);
			this.labelDemo.TabIndex = 20;
			this.labelDemo.Text = "Demo模式";
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
			// labelRunTimeText
			// 
			this.labelRunTimeText.AutoSize = true;
			this.labelRunTimeText.Location = new System.Drawing.Point(9, 18);
			this.labelRunTimeText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.labelRunTimeText.Name = "labelRunTimeText";
			this.labelRunTimeText.Size = new System.Drawing.Size(29, 12);
			this.labelRunTimeText.TabIndex = 10;
			this.labelRunTimeText.Text = "时间";
			// 
			// toolStripScope
			// 
			this.toolStripScope.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonDisplay,
            this.toolStripSeparator9,
            this.toolStripDropDownButtonInteraction,
            this.toolStripSeparator8});
			this.toolStripScope.Location = new System.Drawing.Point(0, 0);
			this.toolStripScope.Name = "toolStripScope";
			this.toolStripScope.Size = new System.Drawing.Size(196, 25);
			this.toolStripScope.TabIndex = 7;
			this.toolStripScope.Text = "toolStrip3";
			// 
			// toolStripDropDownButtonDisplay
			// 
			this.toolStripDropDownButtonDisplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButtonDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemColorStyle,
            this.toolStripMenuItemLineStyle,
            this.toolStripMenuItemLineWidth});
			this.toolStripDropDownButtonDisplay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonDisplay.Image")));
			this.toolStripDropDownButtonDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonDisplay.Name = "toolStripDropDownButtonDisplay";
			this.toolStripDropDownButtonDisplay.Size = new System.Drawing.Size(45, 22);
			this.toolStripDropDownButtonDisplay.Text = "显示";
			// 
			// toolStripMenuItemColorStyle
			// 
			this.toolStripMenuItemColorStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxColorStyle});
			this.toolStripMenuItemColorStyle.Name = "toolStripMenuItemColorStyle";
			this.toolStripMenuItemColorStyle.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemColorStyle.Text = "色彩模式";
			// 
			// toolStripComboBoxColorStyle
			// 
			this.toolStripComboBoxColorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxColorStyle.Items.AddRange(new object[] {
            "浅色模式",
            "深色模式"});
			this.toolStripComboBoxColorStyle.Name = "toolStripComboBoxColorStyle";
			this.toolStripComboBoxColorStyle.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxColorStyle.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxColorStyle_SelectedIndexChanged);
			// 
			// toolStripMenuItemLineStyle
			// 
			this.toolStripMenuItemLineStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLineStyle});
			this.toolStripMenuItemLineStyle.Name = "toolStripMenuItemLineStyle";
			this.toolStripMenuItemLineStyle.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemLineStyle.Text = "连线样式";
			// 
			// toolStripComboBoxLineStyle
			// 
			this.toolStripComboBoxLineStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxLineStyle.Items.AddRange(new object[] {
            "折线",
            "步进显示"});
			this.toolStripComboBoxLineStyle.Name = "toolStripComboBoxLineStyle";
			this.toolStripComboBoxLineStyle.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxLineStyle.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxLineStyle_SelectedIndexChanged);
			// 
			// toolStripMenuItemLineWidth
			// 
			this.toolStripMenuItemLineWidth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBoxLineWidth});
			this.toolStripMenuItemLineWidth.Name = "toolStripMenuItemLineWidth";
			this.toolStripMenuItemLineWidth.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemLineWidth.Text = "连线宽度";
			// 
			// toolStripComboBoxLineWidth
			// 
			this.toolStripComboBoxLineWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripComboBoxLineWidth.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "2.5",
            "3"});
			this.toolStripComboBoxLineWidth.Name = "toolStripComboBoxLineWidth";
			this.toolStripComboBoxLineWidth.Size = new System.Drawing.Size(121, 25);
			this.toolStripComboBoxLineWidth.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxLineWidth_SelectedIndexChanged);
			// 
			// toolStripSeparator9
			// 
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButtonInteraction
			// 
			this.toolStripDropDownButtonInteraction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButtonInteraction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRightClickDragZoom,
            this.toolStripMenuItemScrollWheelZoom,
            this.toolStripMenuItemHorizontalZoom,
            this.toolStripMenuItemVerticalZoom,
            this.toolStripMenuItemCrosshair});
			this.toolStripDropDownButtonInteraction.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonInteraction.Image")));
			this.toolStripDropDownButtonInteraction.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonInteraction.Name = "toolStripDropDownButtonInteraction";
			this.toolStripDropDownButtonInteraction.Size = new System.Drawing.Size(45, 22);
			this.toolStripDropDownButtonInteraction.Text = "交互";
			// 
			// toolStripMenuItemRightClickDragZoom
			// 
			this.toolStripMenuItemRightClickDragZoom.Checked = true;
			this.toolStripMenuItemRightClickDragZoom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemRightClickDragZoom.Name = "toolStripMenuItemRightClickDragZoom";
			this.toolStripMenuItemRightClickDragZoom.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemRightClickDragZoom.Text = "右键缩放";
			this.toolStripMenuItemRightClickDragZoom.Click += new System.EventHandler(this.toolStripMenuItemRightClickDragZoom_Click);
			// 
			// toolStripMenuItemScrollWheelZoom
			// 
			this.toolStripMenuItemScrollWheelZoom.Checked = true;
			this.toolStripMenuItemScrollWheelZoom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemScrollWheelZoom.Name = "toolStripMenuItemScrollWheelZoom";
			this.toolStripMenuItemScrollWheelZoom.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemScrollWheelZoom.Text = "滚轮缩放";
			this.toolStripMenuItemScrollWheelZoom.Click += new System.EventHandler(this.toolStripMenuItemScrollWheelZoom_Click);
			// 
			// toolStripMenuItemHorizontalZoom
			// 
			this.toolStripMenuItemHorizontalZoom.Checked = true;
			this.toolStripMenuItemHorizontalZoom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemHorizontalZoom.Name = "toolStripMenuItemHorizontalZoom";
			this.toolStripMenuItemHorizontalZoom.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemHorizontalZoom.Text = "水平缩放";
			this.toolStripMenuItemHorizontalZoom.Click += new System.EventHandler(this.toolStripMenuItemHorizontalZoom_Click);
			// 
			// toolStripMenuItemVerticalZoom
			// 
			this.toolStripMenuItemVerticalZoom.Checked = true;
			this.toolStripMenuItemVerticalZoom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemVerticalZoom.Name = "toolStripMenuItemVerticalZoom";
			this.toolStripMenuItemVerticalZoom.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemVerticalZoom.Text = "垂直缩放";
			this.toolStripMenuItemVerticalZoom.Click += new System.EventHandler(this.toolStripMenuItemVerticalZoom_Click);
			// 
			// toolStripMenuItemCrosshair
			// 
			this.toolStripMenuItemCrosshair.Checked = true;
			this.toolStripMenuItemCrosshair.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemCrosshair.Name = "toolStripMenuItemCrosshair";
			this.toolStripMenuItemCrosshair.Size = new System.Drawing.Size(124, 22);
			this.toolStripMenuItemCrosshair.Text = "十字准线";
			this.toolStripMenuItemCrosshair.Click += new System.EventHandler(this.toolStripMenuItemCrosshair_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
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
			this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(867, 530);
			this.tabControlMain.TabIndex = 0;
			// 
			// toolStripMenuItemRightClickDragZoom3
			// 
			this.toolStripMenuItemRightClickDragZoom3.Checked = true;
			this.toolStripMenuItemRightClickDragZoom3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemRightClickDragZoom3.Name = "toolStripMenuItemRightClickDragZoom3";
			this.toolStripMenuItemRightClickDragZoom3.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemRightClickDragZoom3.Text = "右键缩放";
			this.toolStripMenuItemRightClickDragZoom3.Click += new System.EventHandler(this.toolStripMenuItemRightClickDragZoom3_Click);
			// 
			// toolStripMenuItemScrollWheelZoom3
			// 
			this.toolStripMenuItemScrollWheelZoom3.Checked = true;
			this.toolStripMenuItemScrollWheelZoom3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemScrollWheelZoom3.Name = "toolStripMenuItemScrollWheelZoom3";
			this.toolStripMenuItemScrollWheelZoom3.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemScrollWheelZoom3.Text = "滚轮缩放";
			this.toolStripMenuItemScrollWheelZoom3.Click += new System.EventHandler(this.toolStripMenuItemScrollWheelZoom3_Click);
			// 
			// toolStripMenuItemHorizontalZoom3
			// 
			this.toolStripMenuItemHorizontalZoom3.Checked = true;
			this.toolStripMenuItemHorizontalZoom3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemHorizontalZoom3.Name = "toolStripMenuItemHorizontalZoom3";
			this.toolStripMenuItemHorizontalZoom3.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemHorizontalZoom3.Text = "水平缩放";
			this.toolStripMenuItemHorizontalZoom3.Click += new System.EventHandler(this.toolStripMenuItemHorizontalZoom3_Click);
			// 
			// toolStripMenuItemVerticalZoom3
			// 
			this.toolStripMenuItemVerticalZoom3.Checked = true;
			this.toolStripMenuItemVerticalZoom3.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemVerticalZoom3.Name = "toolStripMenuItemVerticalZoom3";
			this.toolStripMenuItemVerticalZoom3.Size = new System.Drawing.Size(180, 22);
			this.toolStripMenuItemVerticalZoom3.Text = "垂直缩放";
			this.toolStripMenuItemVerticalZoom3.Click += new System.EventHandler(this.toolStripMenuItemVerticalZoom3_Click);
			// 
			// toolStripDropDownButtonInteraction3
			// 
			this.toolStripDropDownButtonInteraction3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButtonInteraction3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRightClickDragZoom3,
            this.toolStripMenuItemScrollWheelZoom3,
            this.toolStripMenuItemHorizontalZoom3,
            this.toolStripMenuItemVerticalZoom3});
			this.toolStripDropDownButtonInteraction3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonInteraction3.Image")));
			this.toolStripDropDownButtonInteraction3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButtonInteraction3.Name = "toolStripDropDownButtonInteraction3";
			this.toolStripDropDownButtonInteraction3.Size = new System.Drawing.Size(45, 22);
			this.toolStripDropDownButtonInteraction3.Text = "交互";
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
			this.groupBoxInteraction.ResumeLayout(false);
			this.groupBoxInteraction.PerformLayout();
			this.groupBoxDisplay.ResumeLayout(false);
			this.groupBoxDisplay.PerformLayout();
			this.tabPageSpectrum.ResumeLayout(false);
			this.tableLayoutPanel7.ResumeLayout(false);
			this.tableLayoutPanel7.PerformLayout();
			this.toolStripSpectrum.ResumeLayout(false);
			this.toolStripSpectrum.PerformLayout();
			this.panelSpectrum.ResumeLayout(false);
			this.groupBoxChannel.ResumeLayout(false);
			this.groupBoxChannel.PerformLayout();
			this.groupBoxMagnitude.ResumeLayout(false);
			this.groupBoxMagnitude.PerformLayout();
			this.tabPageMeter.ResumeLayout(false);
			this.tableLayoutPanel9.ResumeLayout(false);
			this.tableLayoutPanel8.ResumeLayout(false);
			this.tableLayoutPanel8.PerformLayout();
			this.toolStripMeter.ResumeLayout(false);
			this.toolStripMeter.PerformLayout();
			this.tabPageWavegen.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			this.tableLayoutPanel6.PerformLayout();
			this.toolStripWaveGen.ResumeLayout(false);
			this.toolStripWaveGen.PerformLayout();
			this.groupBoxWavegen.ResumeLayout(false);
			this.groupBoxWavegen.PerformLayout();
			this.tabPageScope.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel5.PerformLayout();
			this.groupBoxControl.ResumeLayout(false);
			this.groupBoxControl.PerformLayout();
			this.groupBoxInfor.ResumeLayout(false);
			this.groupBoxInfor.PerformLayout();
			this.toolStripScope.ResumeLayout(false);
			this.toolStripScope.PerformLayout();
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
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TabPage tabPageSpectrum;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
		private ScottPlot.FormsPlot formsPlotSpectrum;
		private System.Windows.Forms.TabPage tabPageMeter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
		private ScottPlot.FormsPlot formsPlotMeter;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private System.Windows.Forms.ToolStrip toolStripMeter;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.TabPage tabPageWavegen;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
		private System.Windows.Forms.TabPage tabPageScope;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
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
		private System.Windows.Forms.Label labelRunTime;
		private System.Windows.Forms.Label labelDemo;
		private System.Windows.Forms.Label labelFrequency;
		private System.Windows.Forms.Label labelPlotCount;
		private System.Windows.Forms.Label labelMinimum;
		private System.Windows.Forms.Label labelMaximum;
		private System.Windows.Forms.Label labelRunTimeText;
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
		private System.Windows.Forms.ToolStripButton toolStripLabelAddTracer;
		private System.Windows.Forms.ToolStripButton toolStripLabel2;
		private System.Windows.Forms.GroupBox groupBoxInteraction;
		private System.Windows.Forms.CheckBox checkBoxCrosshair;
		private System.Windows.Forms.CheckBox checkBoxVerticalZoom;
		private System.Windows.Forms.CheckBox checkBoxHorizontalZoom;
		private System.Windows.Forms.CheckBox checkBoxScrollWheelZoom;
		private System.Windows.Forms.CheckBox checkBoxRightClickDragZoom;
		private System.Windows.Forms.GroupBox groupBoxDisplay;
		private System.Windows.Forms.ComboBox comboBoxLineWidth;
		private System.Windows.Forms.ComboBox comboBoxLineStyle;
		private System.Windows.Forms.Label labelLineStyle;
		private System.Windows.Forms.Label labelLineWidth;
		private System.Windows.Forms.ComboBox comboBoxColorStyle;
		private System.Windows.Forms.Label labelColorStyle;
		private System.Windows.Forms.ToolStrip toolStripScope;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonDisplay;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColorStyle;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxColorStyle;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLineStyle;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLineStyle;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLineWidth;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLineWidth;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonInteraction;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRightClickDragZoom;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScrollWheelZoom;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHorizontalZoom;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVerticalZoom;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCrosshair;
		private System.Windows.Forms.ToolStrip toolStripWaveGen;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColorStyle2;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxColorStyle2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLineStyle2;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLineStyle2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLineWidth2;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLineWidth2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonInteraction2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRightClickDragZoom2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScrollWheelZoom2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHorizontalZoom2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVerticalZoom2;
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
		private ScottPlot.FormsPlot formsPlotWaveGen;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonDisplay3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxColorStyle3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLineStyle3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLineWidth3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.Panel panelMeter;
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
		private System.Windows.Forms.ToolStrip toolStripSpectrum;
		private System.Windows.Forms.ToolStripDropDownButton toolStripButtonSetting;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStart;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxStart;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStop;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxStop;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBINS;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxBoxCount;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScale;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxScale;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAlgorithm;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxAlgorithm;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton toolStripButtonSingle;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton toolStripButtonRun;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRightClickDragZoom4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScrollWheelZoom4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHorizontalZoom4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVerticalZoom4;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxColorStyle4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLineStyle4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripComboBox toolStripComboBoxLineWidth4;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonInteraction3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRightClickDragZoom3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemScrollWheelZoom3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHorizontalZoom3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVerticalZoom3;
	}
}

