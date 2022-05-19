namespace OperacionesMatematicas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textNUM_1 = new System.Windows.Forms.TextBox();
            this.btnSUMA = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textNUM_2 = new System.Windows.Forms.TextBox();
            this.btnRESTA = new System.Windows.Forms.Button();
            this.btnMULT = new System.Windows.Forms.Button();
            this.btnDIV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(246, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO_1";
            // 
            // textNUM_1
            // 
            this.textNUM_1.Location = new System.Drawing.Point(341, 114);
            this.textNUM_1.Name = "textNUM_1";
            this.textNUM_1.Size = new System.Drawing.Size(197, 23);
            this.textNUM_1.TabIndex = 1;
            // 
            // btnSUMA
            // 
            this.btnSUMA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSUMA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSUMA.Location = new System.Drawing.Point(183, 283);
            this.btnSUMA.Name = "btnSUMA";
            this.btnSUMA.Size = new System.Drawing.Size(75, 33);
            this.btnSUMA.TabIndex = 2;
            this.btnSUMA.Text = "SUMA";
            this.btnSUMA.UseVisualStyleBackColor = false;
            this.btnSUMA.Click += new System.EventHandler(this.btnSUMA_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(244, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "NUMERO_2";
            // 
            // textNUM_2
            // 
            this.textNUM_2.Location = new System.Drawing.Point(341, 179);
            this.textNUM_2.Name = "textNUM_2";
            this.textNUM_2.Size = new System.Drawing.Size(197, 23);
            this.textNUM_2.TabIndex = 4;
            // 
            // btnRESTA
            // 
            this.btnRESTA.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRESTA.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRESTA.Location = new System.Drawing.Point(282, 283);
            this.btnRESTA.Name = "btnRESTA";
            this.btnRESTA.Size = new System.Drawing.Size(75, 33);
            this.btnRESTA.TabIndex = 5;
            this.btnRESTA.Text = "RESTA";
            this.btnRESTA.UseVisualStyleBackColor = false;
            this.btnRESTA.Click += new System.EventHandler(this.btnRESTA_Click);
            // 
            // btnMULT
            // 
            this.btnMULT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMULT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMULT.Location = new System.Drawing.Point(377, 283);
            this.btnMULT.Name = "btnMULT";
            this.btnMULT.Size = new System.Drawing.Size(131, 33);
            this.btnMULT.TabIndex = 6;
            this.btnMULT.Text = "MULTIPLICAR";
            this.btnMULT.UseVisualStyleBackColor = false;
            this.btnMULT.Click += new System.EventHandler(this.btnMULT_Click);
            // 
            // btnDIV
            // 
            this.btnDIV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDIV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDIV.Location = new System.Drawing.Point(530, 283);
            this.btnDIV.Name = "btnDIV";
            this.btnDIV.Size = new System.Drawing.Size(75, 33);
            this.btnDIV.TabIndex = 7;
            this.btnDIV.Text = "DIVIDIR";
            this.btnDIV.UseVisualStyleBackColor = false;
            this.btnDIV.Click += new System.EventHandler(this.btnDIV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(803, 401);
            this.Controls.Add(this.btnDIV);
            this.Controls.Add(this.btnMULT);
            this.Controls.Add(this.btnRESTA);
            this.Controls.Add(this.textNUM_2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSUMA);
            this.Controls.Add(this.textNUM_1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "OperacionesMatematicas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textNUM_1;
        private Button btnSUMA;
        private Label label2;
        private TextBox textNUM_2;
        private Button btnRESTA;
        private Button btnMULT;
        private Button btnDIV;
    }
}