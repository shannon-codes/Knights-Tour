namespace KnightsTourForm
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
            this.cmbMethod = new System.Windows.Forms.ComboBox();
            this.tbRow = new System.Windows.Forms.TextBox();
            this.tbColumn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNumTrials = new System.Windows.Forms.TextBox();
            this.rtbOrder = new System.Windows.Forms.RichTextBox();
            this.rtbOutcomes = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbMethod
            // 
            this.cmbMethod.FormattingEnabled = true;
            this.cmbMethod.Items.AddRange(new object[] {
            "Non-Intelligent",
            "Heuristic"});
            this.cmbMethod.Location = new System.Drawing.Point(165, 40);
            this.cmbMethod.Name = "cmbMethod";
            this.cmbMethod.Size = new System.Drawing.Size(121, 24);
            this.cmbMethod.TabIndex = 0;
            // 
            // tbRow
            // 
            this.tbRow.Location = new System.Drawing.Point(168, 107);
            this.tbRow.Name = "tbRow";
            this.tbRow.Size = new System.Drawing.Size(100, 22);
            this.tbRow.TabIndex = 1;
            // 
            // tbColumn
            // 
            this.tbColumn.Location = new System.Drawing.Point(168, 151);
            this.tbColumn.Name = "tbColumn";
            this.tbColumn.Size = new System.Drawing.Size(100, 22);
            this.tbColumn.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Method:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Start Knight Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Trials: ";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(165, 244);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 36);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Row";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Column";
            // 
            // tbNumTrials
            // 
            this.tbNumTrials.Location = new System.Drawing.Point(168, 198);
            this.tbNumTrials.Name = "tbNumTrials";
            this.tbNumTrials.Size = new System.Drawing.Size(100, 22);
            this.tbNumTrials.TabIndex = 9;
            // 
            // rtbOrder
            // 
            this.rtbOrder.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbOrder.Location = new System.Drawing.Point(373, 68);
            this.rtbOrder.Name = "rtbOrder";
            this.rtbOrder.ReadOnly = true;
            this.rtbOrder.Size = new System.Drawing.Size(320, 175);
            this.rtbOrder.TabIndex = 11;
            this.rtbOrder.Text = "";
            // 
            // rtbOutcomes
            // 
            this.rtbOutcomes.Location = new System.Drawing.Point(56, 307);
            this.rtbOutcomes.Name = "rtbOutcomes";
            this.rtbOutcomes.Size = new System.Drawing.Size(694, 123);
            this.rtbOutcomes.TabIndex = 12;
            this.rtbOutcomes.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Trial Outcomes:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Order of Knights Moves:";
            // 
            // rtbOrderOfMoves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rtbOutcomes);
            this.Controls.Add(this.rtbOrder);
            this.Controls.Add(this.tbNumTrials);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbColumn);
            this.Controls.Add(this.tbRow);
            this.Controls.Add(this.cmbMethod);
            this.Name = "rtbOrderOfMoves";
            this.Text = "Knight\'s Tour Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMethod;
        private System.Windows.Forms.TextBox tbRow;
        private System.Windows.Forms.TextBox tbColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNumTrials;
        private System.Windows.Forms.RichTextBox rtbOrder;
        private System.Windows.Forms.RichTextBox rtbOutcomes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

