
namespace practica
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.btnOrdenadas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnClear = new System.Windows.Forms.Button();
            this.direcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridView1.Location = new System.Drawing.Point(12, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.Name = "X";
            // 
            // Y
            // 
            this.Y.HeaderText = "Y";
            this.Y.Name = "Y";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(48, 17);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(41, 20);
            this.txtX.TabIndex = 1;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(48, 58);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(41, 20);
            this.txtY.TabIndex = 2;
            // 
            // btnOrdenadas
            // 
            this.btnOrdenadas.Location = new System.Drawing.Point(14, 116);
            this.btnOrdenadas.Name = "btnOrdenadas";
            this.btnOrdenadas.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenadas.TabIndex = 3;
            this.btnOrdenadas.Text = "calcular";
            this.btnOrdenadas.UseVisualStyleBackColor = true;
            this.btnOrdenadas.Click += new System.EventHandler(this.btnOrdenadas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "X1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "X2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(122, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Y2";
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(179, 21);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(41, 20);
            this.txtX2.TabIndex = 8;
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(179, 63);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(41, 20);
            this.txtY2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(278, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pendiente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtPendiente
            // 
            this.txtPendiente.Location = new System.Drawing.Point(281, 206);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.Size = new System.Drawing.Size(67, 20);
            this.txtPendiente.TabIndex = 11;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(481, 34);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Graficar";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(438, 358);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(126, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // direcion
            // 
            this.direcion.AutoSize = true;
            this.direcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direcion.Location = new System.Drawing.Point(277, 264);
            this.direcion.Name = "direcion";
            this.direcion.Size = new System.Drawing.Size(75, 20);
            this.direcion.TabIndex = 17;
            this.direcion.Text = "Direccion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.direcion);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.txtPendiente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtY2);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrdenadas);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Button btnOrdenadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPendiente;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label direcion;
    }
}

