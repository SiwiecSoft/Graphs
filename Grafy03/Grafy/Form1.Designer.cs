namespace Grafy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.panelGraphGraphics = new System.Windows.Forms.Panel();
            this.buttonRandPoints = new System.Windows.Forms.Button();
            this.buttonRandGraph = new System.Windows.Forms.Button();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownEdgeP = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelMinF = new System.Windows.Forms.Label();
            this.buttonGenPop = new System.Windows.Forms.Button();
            this.buttonOneGeneration = new System.Windows.Forms.Button();
            this.numericUpDownPopSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMutP = new System.Windows.Forms.NumericUpDown();
            this.labelMaxF = new System.Windows.Forms.Label();
            this.labelAvgF = new System.Windows.Forms.Label();
            this.buttonEvoluate = new System.Windows.Forms.Button();
            this.numericUpDownGenerations = new System.Windows.Forms.NumericUpDown();
            this.panelParetoGraphics = new System.Windows.Forms.Panel();
            this.chartPareto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonImagGraph = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdgeP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPareto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGraphGraphics
            // 
            this.panelGraphGraphics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGraphGraphics.Location = new System.Drawing.Point(187, 12);
            this.panelGraphGraphics.Margin = new System.Windows.Forms.Padding(2);
            this.panelGraphGraphics.Name = "panelGraphGraphics";
            this.panelGraphGraphics.Size = new System.Drawing.Size(600, 600);
            this.panelGraphGraphics.TabIndex = 0;
            // 
            // buttonRandPoints
            // 
            this.buttonRandPoints.Location = new System.Drawing.Point(11, 441);
            this.buttonRandPoints.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandPoints.Name = "buttonRandPoints";
            this.buttonRandPoints.Size = new System.Drawing.Size(108, 27);
            this.buttonRandPoints.TabIndex = 1;
            this.buttonRandPoints.Text = "Generuj Punkty";
            this.buttonRandPoints.UseVisualStyleBackColor = true;
            this.buttonRandPoints.Visible = false;
            this.buttonRandPoints.Click += new System.EventHandler(this.buttonRandPoints_Click);
            // 
            // buttonRandGraph
            // 
            this.buttonRandGraph.Location = new System.Drawing.Point(11, 43);
            this.buttonRandGraph.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRandGraph.Name = "buttonRandGraph";
            this.buttonRandGraph.Size = new System.Drawing.Size(171, 27);
            this.buttonRandGraph.TabIndex = 2;
            this.buttonRandGraph.Text = "Generuj Graf 2D";
            this.buttonRandGraph.UseVisualStyleBackColor = true;
            this.buttonRandGraph.Click += new System.EventHandler(this.buttonRandGraph_Click);
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.AccessibleDescription = "qqq";
            this.numericUpDownSize.Increment = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownSize.Location = new System.Drawing.Point(15, 75);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            102,
            0,
            0,
            0});
            this.numericUpDownSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownSize.TabIndex = 3;
            this.numericUpDownSize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // numericUpDownEdgeP
            // 
            this.numericUpDownEdgeP.DecimalPlaces = 2;
            this.numericUpDownEdgeP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEdgeP.Location = new System.Drawing.Point(124, 75);
            this.numericUpDownEdgeP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEdgeP.Name = "numericUpDownEdgeP";
            this.numericUpDownEdgeP.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownEdgeP.TabIndex = 3;
            this.numericUpDownEdgeP.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // labelMinF
            // 
            this.labelMinF.AutoSize = true;
            this.labelMinF.Location = new System.Drawing.Point(8, 255);
            this.labelMinF.Name = "labelMinF";
            this.labelMinF.Size = new System.Drawing.Size(35, 13);
            this.labelMinF.TabIndex = 4;
            this.labelMinF.Text = "label1";
            // 
            // buttonGenPop
            // 
            this.buttonGenPop.Enabled = false;
            this.buttonGenPop.Location = new System.Drawing.Point(11, 155);
            this.buttonGenPop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenPop.Name = "buttonGenPop";
            this.buttonGenPop.Size = new System.Drawing.Size(108, 27);
            this.buttonGenPop.TabIndex = 1;
            this.buttonGenPop.Text = "Generuj Populacje";
            this.buttonGenPop.UseVisualStyleBackColor = true;
            this.buttonGenPop.Click += new System.EventHandler(this.buttonGenPop_Click);
            // 
            // buttonOneGeneration
            // 
            this.buttonOneGeneration.Enabled = false;
            this.buttonOneGeneration.Location = new System.Drawing.Point(11, 186);
            this.buttonOneGeneration.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOneGeneration.Name = "buttonOneGeneration";
            this.buttonOneGeneration.Size = new System.Drawing.Size(108, 27);
            this.buttonOneGeneration.TabIndex = 2;
            this.buttonOneGeneration.Text = "Oblicz jedno pok.";
            this.buttonOneGeneration.UseVisualStyleBackColor = true;
            this.buttonOneGeneration.Click += new System.EventHandler(this.buttonOneGeneration_Click);
            // 
            // numericUpDownPopSize
            // 
            this.numericUpDownPopSize.Location = new System.Drawing.Point(124, 160);
            this.numericUpDownPopSize.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownPopSize.Name = "numericUpDownPopSize";
            this.numericUpDownPopSize.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownPopSize.TabIndex = 3;
            this.numericUpDownPopSize.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownMutP
            // 
            this.numericUpDownMutP.DecimalPlaces = 2;
            this.numericUpDownMutP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownMutP.Location = new System.Drawing.Point(124, 191);
            this.numericUpDownMutP.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMutP.Name = "numericUpDownMutP";
            this.numericUpDownMutP.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownMutP.TabIndex = 3;
            this.numericUpDownMutP.Value = new decimal(new int[] {
            40,
            0,
            0,
            131072});
            // 
            // labelMaxF
            // 
            this.labelMaxF.AutoSize = true;
            this.labelMaxF.Location = new System.Drawing.Point(8, 277);
            this.labelMaxF.Name = "labelMaxF";
            this.labelMaxF.Size = new System.Drawing.Size(35, 13);
            this.labelMaxF.TabIndex = 4;
            this.labelMaxF.Text = "label1";
            // 
            // labelAvgF
            // 
            this.labelAvgF.AutoSize = true;
            this.labelAvgF.Location = new System.Drawing.Point(8, 301);
            this.labelAvgF.Name = "labelAvgF";
            this.labelAvgF.Size = new System.Drawing.Size(35, 13);
            this.labelAvgF.TabIndex = 4;
            this.labelAvgF.Text = "label1";
            // 
            // buttonEvoluate
            // 
            this.buttonEvoluate.Enabled = false;
            this.buttonEvoluate.Location = new System.Drawing.Point(11, 217);
            this.buttonEvoluate.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEvoluate.Name = "buttonEvoluate";
            this.buttonEvoluate.Size = new System.Drawing.Size(108, 27);
            this.buttonEvoluate.TabIndex = 1;
            this.buttonEvoluate.Text = "!!! EVOLUCJA !!!";
            this.buttonEvoluate.UseVisualStyleBackColor = true;
            this.buttonEvoluate.Click += new System.EventHandler(this.buttonEvoluate_Click);
            // 
            // numericUpDownGenerations
            // 
            this.numericUpDownGenerations.Location = new System.Drawing.Point(124, 222);
            this.numericUpDownGenerations.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownGenerations.Name = "numericUpDownGenerations";
            this.numericUpDownGenerations.Size = new System.Drawing.Size(58, 20);
            this.numericUpDownGenerations.TabIndex = 3;
            this.numericUpDownGenerations.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // panelParetoGraphics
            // 
            this.panelParetoGraphics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelParetoGraphics.Location = new System.Drawing.Point(791, 12);
            this.panelParetoGraphics.Margin = new System.Windows.Forms.Padding(2);
            this.panelParetoGraphics.Name = "panelParetoGraphics";
            this.panelParetoGraphics.Size = new System.Drawing.Size(482, 299);
            this.panelParetoGraphics.TabIndex = 0;
            // 
            // chartPareto
            // 
            chartArea6.Name = "ChartArea1";
            this.chartPareto.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartPareto.Legends.Add(legend6);
            this.chartPareto.Location = new System.Drawing.Point(791, 316);
            this.chartPareto.Name = "chartPareto";
            this.chartPareto.Size = new System.Drawing.Size(482, 296);
            this.chartPareto.TabIndex = 5;
            this.chartPareto.Text = "chart1";
            // 
            // buttonImagGraph
            // 
            this.buttonImagGraph.Location = new System.Drawing.Point(11, 12);
            this.buttonImagGraph.Margin = new System.Windows.Forms.Padding(2);
            this.buttonImagGraph.Name = "buttonImagGraph";
            this.buttonImagGraph.Size = new System.Drawing.Size(171, 27);
            this.buttonImagGraph.TabIndex = 2;
            this.buttonImagGraph.Text = "Generuj Urojony Graf";
            this.buttonImagGraph.UseVisualStyleBackColor = true;
            this.buttonImagGraph.Click += new System.EventHandler(this.buttonImagGraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 620);
            this.Controls.Add(this.chartPareto);
            this.Controls.Add(this.labelAvgF);
            this.Controls.Add(this.labelMaxF);
            this.Controls.Add(this.labelMinF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMutP);
            this.Controls.Add(this.numericUpDownGenerations);
            this.Controls.Add(this.numericUpDownPopSize);
            this.Controls.Add(this.numericUpDownEdgeP);
            this.Controls.Add(this.numericUpDownSize);
            this.Controls.Add(this.buttonOneGeneration);
            this.Controls.Add(this.buttonEvoluate);
            this.Controls.Add(this.buttonGenPop);
            this.Controls.Add(this.buttonImagGraph);
            this.Controls.Add(this.buttonRandGraph);
            this.Controls.Add(this.buttonRandPoints);
            this.Controls.Add(this.panelParetoGraphics);
            this.Controls.Add(this.panelGraphGraphics);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Grafy i sieci w informatyce 2019/2020 - Radosław Siwiec, Aleksander Słodczyk, Jak" +
    "ub Kocur";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdgeP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPopSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMutP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGenerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPareto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGraphGraphics;
        private System.Windows.Forms.Button buttonRandPoints;
        private System.Windows.Forms.Button buttonRandGraph;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.NumericUpDown numericUpDownEdgeP;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMinF;
        private System.Windows.Forms.Button buttonGenPop;
        private System.Windows.Forms.Button buttonOneGeneration;
        private System.Windows.Forms.NumericUpDown numericUpDownPopSize;
        private System.Windows.Forms.NumericUpDown numericUpDownMutP;
        private System.Windows.Forms.Label labelMaxF;
        private System.Windows.Forms.Label labelAvgF;
        private System.Windows.Forms.Button buttonEvoluate;
        private System.Windows.Forms.NumericUpDown numericUpDownGenerations;
        private System.Windows.Forms.Panel panelParetoGraphics;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPareto;
        private System.Windows.Forms.Button buttonImagGraph;
    }
}

