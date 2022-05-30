namespace Praktikum_Week_14_Elyora
{
    partial class FormTim
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
            this.btnbackbnyk = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnnextbnyk = new System.Windows.Forms.Button();
            this.lblname1 = new System.Windows.Forms.Label();
            this.lblNamaTim = new System.Windows.Forms.Label();
            this.lblmana1 = new System.Windows.Forms.Label();
            this.lblManager = new System.Windows.Forms.Label();
            this.stadi1 = new System.Windows.Forms.Label();
            this.lblStadium = new System.Windows.Forms.Label();
            this.top1 = new System.Windows.Forms.Label();
            this.worst1 = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblWorst = new System.Windows.Forms.Label();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbackbnyk
            // 
            this.btnbackbnyk.Location = new System.Drawing.Point(52, 29);
            this.btnbackbnyk.Name = "btnbackbnyk";
            this.btnbackbnyk.Size = new System.Drawing.Size(89, 54);
            this.btnbackbnyk.TabIndex = 0;
            this.btnbackbnyk.Text = "<<";
            this.btnbackbnyk.UseVisualStyleBackColor = true;
            this.btnbackbnyk.Click += new System.EventHandler(this.btnbackbnyk_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(147, 29);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(89, 54);
            this.btnback.TabIndex = 1;
            this.btnback.Text = "<";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(296, 29);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(89, 54);
            this.btnnext.TabIndex = 2;
            this.btnnext.Text = ">";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnnextbnyk
            // 
            this.btnnextbnyk.Location = new System.Drawing.Point(391, 29);
            this.btnnextbnyk.Name = "btnnextbnyk";
            this.btnnextbnyk.Size = new System.Drawing.Size(89, 54);
            this.btnnextbnyk.TabIndex = 3;
            this.btnnextbnyk.Text = ">>";
            this.btnnextbnyk.UseVisualStyleBackColor = true;
            this.btnnextbnyk.Click += new System.EventHandler(this.btnnextbnyk_Click);
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.Location = new System.Drawing.Point(72, 126);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(99, 20);
            this.lblname1.TabIndex = 4;
            this.lblname1.Text = "Team Name:";
            // 
            // lblNamaTim
            // 
            this.lblNamaTim.AutoSize = true;
            this.lblNamaTim.Location = new System.Drawing.Point(252, 126);
            this.lblNamaTim.Name = "lblNamaTim";
            this.lblNamaTim.Size = new System.Drawing.Size(51, 20);
            this.lblNamaTim.TabIndex = 5;
            this.lblNamaTim.Text = "label2";
            // 
            // lblmana1
            // 
            this.lblmana1.AutoSize = true;
            this.lblmana1.Location = new System.Drawing.Point(72, 164);
            this.lblmana1.Name = "lblmana1";
            this.lblmana1.Size = new System.Drawing.Size(76, 20);
            this.lblmana1.TabIndex = 6;
            this.lblmana1.Text = "Manager:";
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Location = new System.Drawing.Point(252, 164);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(51, 20);
            this.lblManager.TabIndex = 7;
            this.lblManager.Text = "label4";
            // 
            // stadi1
            // 
            this.stadi1.AutoSize = true;
            this.stadi1.Location = new System.Drawing.Point(72, 209);
            this.stadi1.Name = "stadi1";
            this.stadi1.Size = new System.Drawing.Size(72, 20);
            this.stadi1.TabIndex = 8;
            this.stadi1.Text = "Stadium:";
            // 
            // lblStadium
            // 
            this.lblStadium.AutoSize = true;
            this.lblStadium.Location = new System.Drawing.Point(252, 209);
            this.lblStadium.Name = "lblStadium";
            this.lblStadium.Size = new System.Drawing.Size(51, 20);
            this.lblStadium.TabIndex = 9;
            this.lblStadium.Text = "label6";
            // 
            // top1
            // 
            this.top1.AutoSize = true;
            this.top1.Location = new System.Drawing.Point(72, 254);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(91, 20);
            this.top1.TabIndex = 10;
            this.top1.Text = "Top Scorer:";
            // 
            // worst1
            // 
            this.worst1.AutoSize = true;
            this.worst1.Location = new System.Drawing.Point(72, 304);
            this.worst1.Name = "worst1";
            this.worst1.Size = new System.Drawing.Size(126, 20);
            this.worst1.TabIndex = 11;
            this.worst1.Text = "Worst Discipline:";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Location = new System.Drawing.Point(252, 254);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(51, 20);
            this.lblTop.TabIndex = 12;
            this.lblTop.Text = "label9";
            // 
            // lblWorst
            // 
            this.lblWorst.AutoSize = true;
            this.lblWorst.Location = new System.Drawing.Point(252, 304);
            this.lblWorst.Name = "lblWorst";
            this.lblWorst.Size = new System.Drawing.Size(60, 20);
            this.lblWorst.TabIndex = 13;
            this.lblWorst.Text = "label10";
            // 
            // dgvMatch
            // 
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Location = new System.Drawing.Point(46, 346);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.RowHeadersWidth = 62;
            this.dgvMatch.RowTemplate.Height = 28;
            this.dgvMatch.Size = new System.Drawing.Size(867, 217);
            this.dgvMatch.TabIndex = 14;
            // 
            // FormTim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 589);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.lblWorst);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.worst1);
            this.Controls.Add(this.top1);
            this.Controls.Add(this.lblStadium);
            this.Controls.Add(this.stadi1);
            this.Controls.Add(this.lblManager);
            this.Controls.Add(this.lblmana1);
            this.Controls.Add(this.lblNamaTim);
            this.Controls.Add(this.lblname1);
            this.Controls.Add(this.btnnextbnyk);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btnbackbnyk);
            this.Name = "FormTim";
            this.Text = "Team";
            this.Load += new System.EventHandler(this.FormTim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbackbnyk;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnnextbnyk;
        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.Label lblNamaTim;
        private System.Windows.Forms.Label lblmana1;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Label stadi1;
        private System.Windows.Forms.Label lblStadium;
        private System.Windows.Forms.Label top1;
        private System.Windows.Forms.Label worst1;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblWorst;
        private System.Windows.Forms.DataGridView dgvMatch;
    }
}

