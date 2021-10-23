
namespace _2020002309_方泽楠_学生管理
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
            this.btnDown = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.labId = new System.Windows.Forms.Label();
            this.gBC = new System.Windows.Forms.GroupBox();
            this.btnC = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labC = new System.Windows.Forms.Label();
            this.gBD = new System.Windows.Forms.GroupBox();
            this.btnD = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labD = new System.Windows.Forms.Label();
            this.gBR = new System.Windows.Forms.GroupBox();
            this.btnR = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labR = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.gBC.SuspendLayout();
            this.gBD.SuspendLayout();
            this.gBR.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(133, 274);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 26);
            this.btnDown.TabIndex = 1;
            this.btnDown.Text = "降序";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(278, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 304);
            this.listBox1.TabIndex = 2;
            // 
            // labId
            // 
            this.labId.AutoSize = true;
            this.labId.Location = new System.Drawing.Point(295, 86);
            this.labId.Name = "labId";
            this.labId.Size = new System.Drawing.Size(97, 15);
            this.labId.TabIndex = 3;
            this.labId.Text = "班级学号信息";
            // 
            // gBC
            // 
            this.gBC.Controls.Add(this.btnC);
            this.gBC.Controls.Add(this.textBox2);
            this.gBC.Controls.Add(this.textBox1);
            this.gBC.Controls.Add(this.labC);
            this.gBC.Location = new System.Drawing.Point(529, 104);
            this.gBC.Name = "gBC";
            this.gBC.Size = new System.Drawing.Size(377, 81);
            this.gBC.TabIndex = 9;
            this.gBC.TabStop = false;
            this.gBC.Text = "信息添加";
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(296, 52);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 26);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "添加";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 25);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 13;
            // 
            // labC
            // 
            this.labC.AutoSize = true;
            this.labC.Location = new System.Drawing.Point(42, 21);
            this.labC.Name = "labC";
            this.labC.Size = new System.Drawing.Size(172, 15);
            this.labC.TabIndex = 12;
            this.labC.Text = "请输入要添加的学生信息";
            // 
            // gBD
            // 
            this.gBD.Controls.Add(this.btnD);
            this.gBD.Controls.Add(this.textBox3);
            this.gBD.Controls.Add(this.labD);
            this.gBD.Location = new System.Drawing.Point(529, 207);
            this.gBD.Name = "gBD";
            this.gBD.Size = new System.Drawing.Size(377, 80);
            this.gBD.TabIndex = 10;
            this.gBD.TabStop = false;
            this.gBD.Text = "信息删除";
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(296, 48);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(75, 26);
            this.btnD.TabIndex = 15;
            this.btnD.Text = "删除";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 25);
            this.textBox3.TabIndex = 15;
            // 
            // labD
            // 
            this.labD.AutoSize = true;
            this.labD.Location = new System.Drawing.Point(42, 21);
            this.labD.Name = "labD";
            this.labD.Size = new System.Drawing.Size(142, 15);
            this.labD.TabIndex = 13;
            this.labD.Text = "请输入要删除的位置";
            // 
            // gBR
            // 
            this.gBR.Controls.Add(this.btnR);
            this.gBR.Controls.Add(this.textBox4);
            this.gBR.Controls.Add(this.labR);
            this.gBR.Location = new System.Drawing.Point(529, 311);
            this.gBR.Name = "gBR";
            this.gBR.Size = new System.Drawing.Size(377, 85);
            this.gBR.TabIndex = 11;
            this.gBR.TabStop = false;
            this.gBR.Text = "信息查询";
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(296, 49);
            this.btnR.Name = "btnR";
            this.btnR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnR.Size = new System.Drawing.Size(75, 26);
            this.btnR.TabIndex = 16;
            this.btnR.Text = "查询";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnR_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(45, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 25);
            this.textBox4.TabIndex = 16;
            // 
            // labR
            // 
            this.labR.AutoSize = true;
            this.labR.Location = new System.Drawing.Point(42, 21);
            this.labR.Name = "labR";
            this.labR.Size = new System.Drawing.Size(142, 15);
            this.labR.TabIndex = 14;
            this.labR.Text = "请输入要查询的位置";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(133, 207);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 26);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "升序";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 481);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.gBR);
            this.Controls.Add(this.gBD);
            this.Controls.Add(this.gBC);
            this.Controls.Add(this.labId);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDown);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBC.ResumeLayout(false);
            this.gBC.PerformLayout();
            this.gBD.ResumeLayout(false);
            this.gBD.PerformLayout();
            this.gBR.ResumeLayout(false);
            this.gBR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labId;
        private System.Windows.Forms.GroupBox gBC;
        private System.Windows.Forms.GroupBox gBD;
        private System.Windows.Forms.GroupBox gBR;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labD;
        private System.Windows.Forms.Button btnR;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label labR;
        
    }
}

