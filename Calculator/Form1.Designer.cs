
namespace Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtsecondNumbe = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMSub = new System.Windows.Forms.Button();
            this.btnMadd = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Location = new System.Drawing.Point(143, 35);
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(180, 23);
            this.txtFirstNumber.TabIndex = 1;
            this.txtFirstNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFirstNumber.TextChanged += new System.EventHandler(this.txtFirstNumber_TextChanged);
            this.txtFirstNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFirstNumber_KeyDown);
            // 
            // txtsecondNumbe
            // 
            this.txtsecondNumbe.Location = new System.Drawing.Point(143, 64);
            this.txtsecondNumbe.Name = "txtsecondNumbe";
            this.txtsecondNumbe.Size = new System.Drawing.Size(180, 23);
            this.txtsecondNumbe.TabIndex = 2;
            this.txtsecondNumbe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtsecondNumbe.TextChanged += new System.EventHandler(this.txtsecondNumbe_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(87, 139);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(169, 139);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 23);
            this.btnSub.TabIndex = 5;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(251, 139);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(75, 23);
            this.btnMulti.TabIndex = 6;
            this.btnMulti.Text = "Multi";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(333, 139);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(75, 23);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "Divide";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // txtresult
            // 
            this.txtresult.Location = new System.Drawing.Point(143, 93);
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(180, 23);
            this.txtresult.TabIndex = 9;
            this.txtresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Result";
            // 
            // btnMSub
            // 
            this.btnMSub.Location = new System.Drawing.Point(204, 180);
            this.btnMSub.Name = "btnMSub";
            this.btnMSub.Size = new System.Drawing.Size(75, 23);
            this.btnMSub.TabIndex = 10;
            this.btnMSub.Text = "M-";
            this.btnMSub.UseVisualStyleBackColor = true;
            this.btnMSub.Click += new System.EventHandler(this.btnMSub_Click);
            // 
            // btnMadd
            // 
            this.btnMadd.Location = new System.Drawing.Point(123, 180);
            this.btnMadd.Name = "btnMadd";
            this.btnMadd.Size = new System.Drawing.Size(75, 23);
            this.btnMadd.TabIndex = 11;
            this.btnMadd.Text = "M+";
            this.btnMadd.UseVisualStyleBackColor = true;
            this.btnMadd.Click += new System.EventHandler(this.btnMadd_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(286, 180);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 12;
            this.btnResult.Text = "ResultM";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 232);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnMadd);
            this.Controls.Add(this.btnMSub);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtsecondNumbe);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtsecondNumbe;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMSub;
        private System.Windows.Forms.Button btnMadd;
        private System.Windows.Forms.Button btnResult;
    }
}

