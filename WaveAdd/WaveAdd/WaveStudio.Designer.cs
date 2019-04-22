namespace WaveAdd
{
    partial class WaveStudio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaveStudio));
            this.principalMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseContainer = new System.Windows.Forms.SplitContainer();
            this.waveContainer = new System.Windows.Forms.SplitContainer();
            this.resultCanvas = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.generalOptions = new System.Windows.Forms.GroupBox();
            this.properties = new System.Windows.Forms.PropertyGrid();
            this.newWaveoptions = new System.Windows.Forms.GroupBox();
            this.addWaveButton = new System.Windows.Forms.Button();
            this.newWaveDelayBox = new System.Windows.Forms.GroupBox();
            this.delayNum = new System.Windows.Forms.NumericUpDown();
            this.delayNo = new System.Windows.Forms.RadioButton();
            this.delayValue = new System.Windows.Forms.RadioButton();
            this.newWaveDurationBox = new System.Windows.Forms.GroupBox();
            this.durationNum = new System.Windows.Forms.NumericUpDown();
            this.valueDuration = new System.Windows.Forms.RadioButton();
            this.infiniteDuration = new System.Windows.Forms.RadioButton();
            this.newWaveValueBox = new System.Windows.Forms.GroupBox();
            this.valueBar = new System.Windows.Forms.TrackBar();
            this.valueNum = new System.Windows.Forms.NumericUpDown();
            this.newWaveTypeBox = new System.Windows.Forms.GroupBox();
            this.absType = new System.Windows.Forms.RadioButton();
            this.acosType = new System.Windows.Forms.RadioButton();
            this.asinType = new System.Windows.Forms.RadioButton();
            this.atanType = new System.Windows.Forms.RadioButton();
            this.tanType = new System.Windows.Forms.RadioButton();
            this.cosType = new System.Windows.Forms.RadioButton();
            this.sinType = new System.Windows.Forms.RadioButton();
            this.newWaveOperationBox = new System.Windows.Forms.GroupBox();
            this.subOperation = new System.Windows.Forms.RadioButton();
            this.addOperation = new System.Windows.Forms.RadioButton();
            this.wavesContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.principalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseContainer)).BeginInit();
            this.baseContainer.Panel1.SuspendLayout();
            this.baseContainer.Panel2.SuspendLayout();
            this.baseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveContainer)).BeginInit();
            this.waveContainer.Panel1.SuspendLayout();
            this.waveContainer.Panel2.SuspendLayout();
            this.waveContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.generalOptions.SuspendLayout();
            this.newWaveoptions.SuspendLayout();
            this.newWaveDelayBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).BeginInit();
            this.newWaveDurationBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationNum)).BeginInit();
            this.newWaveValueBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNum)).BeginInit();
            this.newWaveTypeBox.SuspendLayout();
            this.newWaveOperationBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // principalMenu
            // 
            this.principalMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.principalMenu.Location = new System.Drawing.Point(0, 0);
            this.principalMenu.Name = "principalMenu";
            this.principalMenu.Size = new System.Drawing.Size(1453, 24);
            this.principalMenu.TabIndex = 0;
            this.principalMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarTodoToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // eliminarTodoToolStripMenuItem
            // 
            this.eliminarTodoToolStripMenuItem.Name = "eliminarTodoToolStripMenuItem";
            this.eliminarTodoToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.eliminarTodoToolStripMenuItem.Text = "Eliminar todo";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // baseContainer
            // 
            this.baseContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseContainer.Location = new System.Drawing.Point(0, 24);
            this.baseContainer.Name = "baseContainer";
            // 
            // baseContainer.Panel1
            // 
            this.baseContainer.Panel1.Controls.Add(this.waveContainer);
            // 
            // baseContainer.Panel2
            // 
            this.baseContainer.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.baseContainer.Size = new System.Drawing.Size(1453, 676);
            this.baseContainer.SplitterDistance = 1199;
            this.baseContainer.TabIndex = 1;
            // 
            // waveContainer
            // 
            this.waveContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveContainer.Location = new System.Drawing.Point(0, 0);
            this.waveContainer.Name = "waveContainer";
            this.waveContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // waveContainer.Panel1
            // 
            this.waveContainer.Panel1.Controls.Add(this.wavesContainer);
            // 
            // waveContainer.Panel2
            // 
            this.waveContainer.Panel2.Controls.Add(this.resultCanvas);
            this.waveContainer.Size = new System.Drawing.Size(1199, 676);
            this.waveContainer.SplitterDistance = 463;
            this.waveContainer.TabIndex = 0;
            // 
            // resultCanvas
            // 
            this.resultCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.resultCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultCanvas.Location = new System.Drawing.Point(0, 0);
            this.resultCanvas.Name = "resultCanvas";
            this.resultCanvas.Size = new System.Drawing.Size(1199, 209);
            this.resultCanvas.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.generalOptions);
            this.flowLayoutPanel1.Controls.Add(this.newWaveoptions);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 676);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // generalOptions
            // 
            this.generalOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.generalOptions.Controls.Add(this.properties);
            this.generalOptions.Location = new System.Drawing.Point(3, 3);
            this.generalOptions.Name = "generalOptions";
            this.generalOptions.Size = new System.Drawing.Size(244, 237);
            this.generalOptions.TabIndex = 0;
            this.generalOptions.TabStop = false;
            this.generalOptions.Text = "Propiedades";
            // 
            // properties
            // 
            this.properties.Location = new System.Drawing.Point(6, 19);
            this.properties.Name = "properties";
            this.properties.Size = new System.Drawing.Size(232, 212);
            this.properties.TabIndex = 0;
            // 
            // newWaveoptions
            // 
            this.newWaveoptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newWaveoptions.Controls.Add(this.addWaveButton);
            this.newWaveoptions.Controls.Add(this.newWaveDelayBox);
            this.newWaveoptions.Controls.Add(this.newWaveDurationBox);
            this.newWaveoptions.Controls.Add(this.newWaveValueBox);
            this.newWaveoptions.Controls.Add(this.newWaveTypeBox);
            this.newWaveoptions.Controls.Add(this.newWaveOperationBox);
            this.newWaveoptions.Location = new System.Drawing.Point(3, 246);
            this.newWaveoptions.Name = "newWaveoptions";
            this.newWaveoptions.Size = new System.Drawing.Size(244, 427);
            this.newWaveoptions.TabIndex = 1;
            this.newWaveoptions.TabStop = false;
            this.newWaveoptions.Text = "Crear";
            // 
            // addWaveButton
            // 
            this.addWaveButton.Location = new System.Drawing.Point(6, 366);
            this.addWaveButton.Name = "addWaveButton";
            this.addWaveButton.Size = new System.Drawing.Size(229, 55);
            this.addWaveButton.TabIndex = 5;
            this.addWaveButton.Text = "Añadir";
            this.addWaveButton.UseVisualStyleBackColor = true;
            // 
            // newWaveDelayBox
            // 
            this.newWaveDelayBox.Controls.Add(this.delayNum);
            this.newWaveDelayBox.Controls.Add(this.delayNo);
            this.newWaveDelayBox.Controls.Add(this.delayValue);
            this.newWaveDelayBox.Location = new System.Drawing.Point(6, 308);
            this.newWaveDelayBox.Name = "newWaveDelayBox";
            this.newWaveDelayBox.Size = new System.Drawing.Size(229, 52);
            this.newWaveDelayBox.TabIndex = 4;
            this.newWaveDelayBox.TabStop = false;
            this.newWaveDelayBox.Text = "Retraso";
            // 
            // delayNum
            // 
            this.delayNum.Enabled = false;
            this.delayNum.Location = new System.Drawing.Point(166, 19);
            this.delayNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delayNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.delayNum.Name = "delayNum";
            this.delayNum.Size = new System.Drawing.Size(52, 20);
            this.delayNum.TabIndex = 4;
            this.delayNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // delayNo
            // 
            this.delayNo.AutoSize = true;
            this.delayNo.Checked = true;
            this.delayNo.Location = new System.Drawing.Point(6, 19);
            this.delayNo.Name = "delayNo";
            this.delayNo.Size = new System.Drawing.Size(75, 17);
            this.delayNo.TabIndex = 5;
            this.delayNo.TabStop = true;
            this.delayNo.Text = "Sin retraso";
            this.delayNo.UseVisualStyleBackColor = true;
            // 
            // delayValue
            // 
            this.delayValue.AutoSize = true;
            this.delayValue.Location = new System.Drawing.Point(108, 19);
            this.delayValue.Name = "delayValue";
            this.delayValue.Size = new System.Drawing.Size(52, 17);
            this.delayValue.TabIndex = 6;
            this.delayValue.Text = "Valor:";
            this.delayValue.UseVisualStyleBackColor = true;
            // 
            // newWaveDurationBox
            // 
            this.newWaveDurationBox.Controls.Add(this.durationNum);
            this.newWaveDurationBox.Controls.Add(this.valueDuration);
            this.newWaveDurationBox.Controls.Add(this.infiniteDuration);
            this.newWaveDurationBox.Location = new System.Drawing.Point(6, 250);
            this.newWaveDurationBox.Name = "newWaveDurationBox";
            this.newWaveDurationBox.Size = new System.Drawing.Size(229, 52);
            this.newWaveDurationBox.TabIndex = 3;
            this.newWaveDurationBox.TabStop = false;
            this.newWaveDurationBox.Text = "Duración";
            // 
            // durationNum
            // 
            this.durationNum.Enabled = false;
            this.durationNum.Location = new System.Drawing.Point(166, 19);
            this.durationNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.durationNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.durationNum.Name = "durationNum";
            this.durationNum.Size = new System.Drawing.Size(52, 20);
            this.durationNum.TabIndex = 2;
            this.durationNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // valueDuration
            // 
            this.valueDuration.AutoSize = true;
            this.valueDuration.Location = new System.Drawing.Point(108, 19);
            this.valueDuration.Name = "valueDuration";
            this.valueDuration.Size = new System.Drawing.Size(52, 17);
            this.valueDuration.TabIndex = 3;
            this.valueDuration.Text = "Valor:";
            this.valueDuration.UseVisualStyleBackColor = true;
            // 
            // infiniteDuration
            // 
            this.infiniteDuration.AutoSize = true;
            this.infiniteDuration.Checked = true;
            this.infiniteDuration.Location = new System.Drawing.Point(6, 19);
            this.infiniteDuration.Name = "infiniteDuration";
            this.infiniteDuration.Size = new System.Drawing.Size(56, 17);
            this.infiniteDuration.TabIndex = 2;
            this.infiniteDuration.TabStop = true;
            this.infiniteDuration.Text = "Infinita";
            this.infiniteDuration.UseVisualStyleBackColor = true;
            // 
            // newWaveValueBox
            // 
            this.newWaveValueBox.Controls.Add(this.valueBar);
            this.newWaveValueBox.Controls.Add(this.valueNum);
            this.newWaveValueBox.Location = new System.Drawing.Point(6, 192);
            this.newWaveValueBox.Name = "newWaveValueBox";
            this.newWaveValueBox.Size = new System.Drawing.Size(229, 52);
            this.newWaveValueBox.TabIndex = 2;
            this.newWaveValueBox.TabStop = false;
            this.newWaveValueBox.Text = "Valor";
            // 
            // valueBar
            // 
            this.valueBar.Location = new System.Drawing.Point(69, 19);
            this.valueBar.Maximum = 200;
            this.valueBar.Name = "valueBar";
            this.valueBar.Size = new System.Drawing.Size(154, 45);
            this.valueBar.TabIndex = 1;
            this.valueBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.valueBar.Value = 1;
            // 
            // valueNum
            // 
            this.valueNum.Location = new System.Drawing.Point(6, 19);
            this.valueNum.Name = "valueNum";
            this.valueNum.Size = new System.Drawing.Size(52, 20);
            this.valueNum.TabIndex = 0;
            this.valueNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // newWaveTypeBox
            // 
            this.newWaveTypeBox.Controls.Add(this.absType);
            this.newWaveTypeBox.Controls.Add(this.acosType);
            this.newWaveTypeBox.Controls.Add(this.asinType);
            this.newWaveTypeBox.Controls.Add(this.atanType);
            this.newWaveTypeBox.Controls.Add(this.tanType);
            this.newWaveTypeBox.Controls.Add(this.cosType);
            this.newWaveTypeBox.Controls.Add(this.sinType);
            this.newWaveTypeBox.Location = new System.Drawing.Point(6, 73);
            this.newWaveTypeBox.Name = "newWaveTypeBox";
            this.newWaveTypeBox.Size = new System.Drawing.Size(229, 113);
            this.newWaveTypeBox.TabIndex = 1;
            this.newWaveTypeBox.TabStop = false;
            this.newWaveTypeBox.Text = "Tipo";
            // 
            // absType
            // 
            this.absType.AutoSize = true;
            this.absType.Location = new System.Drawing.Point(6, 88);
            this.absType.Name = "absType";
            this.absType.Size = new System.Drawing.Size(66, 17);
            this.absType.TabIndex = 6;
            this.absType.Text = "Absoluto";
            this.absType.UseVisualStyleBackColor = true;
            // 
            // acosType
            // 
            this.acosType.AutoSize = true;
            this.acosType.Location = new System.Drawing.Point(91, 42);
            this.acosType.Name = "acosType";
            this.acosType.Size = new System.Drawing.Size(82, 17);
            this.acosType.TabIndex = 5;
            this.acosType.Text = "Arcocoseno";
            this.acosType.UseVisualStyleBackColor = true;
            // 
            // asinType
            // 
            this.asinType.AutoSize = true;
            this.asinType.Location = new System.Drawing.Point(6, 42);
            this.asinType.Name = "asinType";
            this.asinType.Size = new System.Drawing.Size(70, 17);
            this.asinType.TabIndex = 4;
            this.asinType.Text = "Arcoseno";
            this.asinType.UseVisualStyleBackColor = true;
            // 
            // atanType
            // 
            this.atanType.AutoSize = true;
            this.atanType.Location = new System.Drawing.Point(91, 65);
            this.atanType.Name = "atanType";
            this.atanType.Size = new System.Drawing.Size(89, 17);
            this.atanType.TabIndex = 3;
            this.atanType.Text = "Arcotangente";
            this.atanType.UseVisualStyleBackColor = true;
            // 
            // tanType
            // 
            this.tanType.AutoSize = true;
            this.tanType.Location = new System.Drawing.Point(6, 65);
            this.tanType.Name = "tanType";
            this.tanType.Size = new System.Drawing.Size(71, 17);
            this.tanType.TabIndex = 2;
            this.tanType.Text = "Tangente";
            this.tanType.UseVisualStyleBackColor = true;
            // 
            // cosType
            // 
            this.cosType.AutoSize = true;
            this.cosType.Location = new System.Drawing.Point(91, 19);
            this.cosType.Name = "cosType";
            this.cosType.Size = new System.Drawing.Size(61, 17);
            this.cosType.TabIndex = 1;
            this.cosType.Text = "Coseno";
            this.cosType.UseVisualStyleBackColor = true;
            // 
            // sinType
            // 
            this.sinType.AutoSize = true;
            this.sinType.Checked = true;
            this.sinType.Location = new System.Drawing.Point(6, 19);
            this.sinType.Name = "sinType";
            this.sinType.Size = new System.Drawing.Size(50, 17);
            this.sinType.TabIndex = 0;
            this.sinType.TabStop = true;
            this.sinType.Text = "Seno";
            this.sinType.UseVisualStyleBackColor = true;
            // 
            // newWaveOperationBox
            // 
            this.newWaveOperationBox.Controls.Add(this.subOperation);
            this.newWaveOperationBox.Controls.Add(this.addOperation);
            this.newWaveOperationBox.Location = new System.Drawing.Point(6, 19);
            this.newWaveOperationBox.Name = "newWaveOperationBox";
            this.newWaveOperationBox.Size = new System.Drawing.Size(229, 48);
            this.newWaveOperationBox.TabIndex = 0;
            this.newWaveOperationBox.TabStop = false;
            this.newWaveOperationBox.Text = "Operación";
            // 
            // subOperation
            // 
            this.subOperation.AutoSize = true;
            this.subOperation.Location = new System.Drawing.Point(64, 19);
            this.subOperation.Name = "subOperation";
            this.subOperation.Size = new System.Drawing.Size(53, 17);
            this.subOperation.TabIndex = 1;
            this.subOperation.Text = "Resta";
            this.subOperation.UseVisualStyleBackColor = true;
            // 
            // addOperation
            // 
            this.addOperation.AutoSize = true;
            this.addOperation.Checked = true;
            this.addOperation.Location = new System.Drawing.Point(6, 19);
            this.addOperation.Name = "addOperation";
            this.addOperation.Size = new System.Drawing.Size(52, 17);
            this.addOperation.TabIndex = 0;
            this.addOperation.TabStop = true;
            this.addOperation.Text = "Suma";
            this.addOperation.UseVisualStyleBackColor = true;
            // 
            // wavesContainer
            // 
            this.wavesContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wavesContainer.Location = new System.Drawing.Point(0, 0);
            this.wavesContainer.Name = "wavesContainer";
            this.wavesContainer.Size = new System.Drawing.Size(1199, 463);
            this.wavesContainer.TabIndex = 0;
            // 
            // WaveStudio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 700);
            this.Controls.Add(this.baseContainer);
            this.Controls.Add(this.principalMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.principalMenu;
            this.Name = "WaveStudio";
            this.Text = "WaveAdd";
            this.principalMenu.ResumeLayout(false);
            this.principalMenu.PerformLayout();
            this.baseContainer.Panel1.ResumeLayout(false);
            this.baseContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.baseContainer)).EndInit();
            this.baseContainer.ResumeLayout(false);
            this.waveContainer.Panel1.ResumeLayout(false);
            this.waveContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveContainer)).EndInit();
            this.waveContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.generalOptions.ResumeLayout(false);
            this.newWaveoptions.ResumeLayout(false);
            this.newWaveDelayBox.ResumeLayout(false);
            this.newWaveDelayBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delayNum)).EndInit();
            this.newWaveDurationBox.ResumeLayout(false);
            this.newWaveDurationBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationNum)).EndInit();
            this.newWaveValueBox.ResumeLayout(false);
            this.newWaveValueBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueNum)).EndInit();
            this.newWaveTypeBox.ResumeLayout(false);
            this.newWaveTypeBox.PerformLayout();
            this.newWaveOperationBox.ResumeLayout(false);
            this.newWaveOperationBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip principalMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.SplitContainer baseContainer;
        private System.Windows.Forms.SplitContainer waveContainer;
        private System.Windows.Forms.Panel resultCanvas;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox generalOptions;
        private System.Windows.Forms.GroupBox newWaveoptions;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid properties;
        private System.Windows.Forms.Button addWaveButton;
        private System.Windows.Forms.GroupBox newWaveDelayBox;
        private System.Windows.Forms.NumericUpDown delayNum;
        private System.Windows.Forms.RadioButton delayNo;
        private System.Windows.Forms.RadioButton delayValue;
        private System.Windows.Forms.GroupBox newWaveDurationBox;
        private System.Windows.Forms.NumericUpDown durationNum;
        private System.Windows.Forms.RadioButton valueDuration;
        private System.Windows.Forms.RadioButton infiniteDuration;
        private System.Windows.Forms.GroupBox newWaveValueBox;
        private System.Windows.Forms.TrackBar valueBar;
        private System.Windows.Forms.NumericUpDown valueNum;
        private System.Windows.Forms.GroupBox newWaveTypeBox;
        private System.Windows.Forms.RadioButton absType;
        private System.Windows.Forms.RadioButton acosType;
        private System.Windows.Forms.RadioButton asinType;
        private System.Windows.Forms.RadioButton atanType;
        private System.Windows.Forms.RadioButton tanType;
        private System.Windows.Forms.RadioButton cosType;
        private System.Windows.Forms.RadioButton sinType;
        private System.Windows.Forms.GroupBox newWaveOperationBox;
        private System.Windows.Forms.RadioButton subOperation;
        private System.Windows.Forms.RadioButton addOperation;
        private System.Windows.Forms.FlowLayoutPanel wavesContainer;
    }
}

