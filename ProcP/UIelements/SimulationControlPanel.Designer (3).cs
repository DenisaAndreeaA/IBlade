namespace ProcP.UIelements
{
    partial class SimulationControlPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStopSimulation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStopSimulation
            // 
            this.btnStopSimulation.BackColor = System.Drawing.Color.LightCoral;
            this.btnStopSimulation.Location = new System.Drawing.Point(14, 543);
            this.btnStopSimulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopSimulation.Name = "btnStopSimulation";
            this.btnStopSimulation.Size = new System.Drawing.Size(353, 62);
            this.btnStopSimulation.TabIndex = 1;
            this.btnStopSimulation.Text = "Stop Simulation";
            this.btnStopSimulation.UseVisualStyleBackColor = false;
            // 
            // SimulationControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStopSimulation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SimulationControlPanel";
            this.Size = new System.Drawing.Size(390, 650);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStopSimulation;
    }
}
