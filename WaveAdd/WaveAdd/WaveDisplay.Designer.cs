namespace WaveAdd
{
    partial class WaveDisplay
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.baseWavePanel = new System.Windows.Forms.TableLayoutPanel();
            this.waveCanvas = new System.Windows.Forms.Panel();
            this.waveInfo = new System.Windows.Forms.Panel();
            this.editWave = new System.Windows.Forms.Button();
            this.deleteWave = new System.Windows.Forms.Button();
            this.baseWavePanel.SuspendLayout();
            this.waveInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseWavePanel
            // 
            this.baseWavePanel.ColumnCount = 2;
            this.baseWavePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.baseWavePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.baseWavePanel.Controls.Add(this.waveCanvas, 1, 0);
            this.baseWavePanel.Controls.Add(this.waveInfo, 0, 0);
            this.baseWavePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseWavePanel.Location = new System.Drawing.Point(0, 0);
            this.baseWavePanel.Name = "baseWavePanel";
            this.baseWavePanel.RowCount = 1;
            this.baseWavePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.baseWavePanel.Size = new System.Drawing.Size(746, 167);
            this.baseWavePanel.TabIndex = 0;
            // 
            // waveCanvas
            // 
            this.waveCanvas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(55)))));
            this.waveCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveCanvas.Location = new System.Drawing.Point(189, 3);
            this.waveCanvas.Name = "waveCanvas";
            this.waveCanvas.Size = new System.Drawing.Size(554, 161);
            this.waveCanvas.TabIndex = 0;
            this.waveCanvas.Click += new System.EventHandler(this.waveCanvas_Click);
            // 
            // waveInfo
            // 
            this.waveInfo.Controls.Add(this.editWave);
            this.waveInfo.Controls.Add(this.deleteWave);
            this.waveInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waveInfo.Location = new System.Drawing.Point(3, 3);
            this.waveInfo.Name = "waveInfo";
            this.waveInfo.Size = new System.Drawing.Size(180, 161);
            this.waveInfo.TabIndex = 1;
            // 
            // editWave
            // 
            this.editWave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editWave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.editWave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editWave.ForeColor = System.Drawing.Color.Black;
            this.editWave.Location = new System.Drawing.Point(29, 3);
            this.editWave.Name = "editWave";
            this.editWave.Size = new System.Drawing.Size(149, 21);
            this.editWave.TabIndex = 2;
            this.editWave.Text = "Modificar";
            this.editWave.UseVisualStyleBackColor = false;
            this.editWave.Click += new System.EventHandler(this.editWave_Click);
            // 
            // deleteWave
            // 
            this.deleteWave.BackColor = System.Drawing.Color.DarkRed;
            this.deleteWave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteWave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteWave.ForeColor = System.Drawing.Color.White;
            this.deleteWave.Location = new System.Drawing.Point(3, 3);
            this.deleteWave.Name = "deleteWave";
            this.deleteWave.Size = new System.Drawing.Size(20, 20);
            this.deleteWave.TabIndex = 1;
            this.deleteWave.Text = "X";
            this.deleteWave.UseVisualStyleBackColor = false;
            this.deleteWave.Click += new System.EventHandler(this.deleteWave_Click);
            // 
            // WaveDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.baseWavePanel);
            this.DoubleBuffered = true;
            this.Name = "WaveDisplay";
            this.Size = new System.Drawing.Size(746, 167);
            this.baseWavePanel.ResumeLayout(false);
            this.waveInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel baseWavePanel;
        private System.Windows.Forms.Panel waveCanvas;
        private System.Windows.Forms.Panel waveInfo;
        private System.Windows.Forms.Button editWave;
        private System.Windows.Forms.Button deleteWave;
    }
}
