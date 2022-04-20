
namespace RegexTracer
{
    partial class FrmRegexTracer
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtPattern = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnMatch = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblPattern = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(131, 44);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(1065, 21);
            this.txtInput.TabIndex = 0;
            // 
            // txtPattern
            // 
            this.txtPattern.Location = new System.Drawing.Point(131, 80);
            this.txtPattern.Multiline = true;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.Size = new System.Drawing.Size(1065, 227);
            this.txtPattern.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 40);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(41, 351);
            this.treeView1.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(131, 322);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(1065, 21);
            this.txtResult.TabIndex = 3;
            // 
            // btnMatch
            // 
            this.btnMatch.Location = new System.Drawing.Point(131, 368);
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Size = new System.Drawing.Size(71, 23);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Match";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(74, 53);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(35, 12);
            this.lblInput.TabIndex = 5;
            this.lblInput.Text = "Input";
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Location = new System.Drawing.Point(74, 80);
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(47, 12);
            this.lblPattern.TabIndex = 6;
            this.lblPattern.Text = "Pattern";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tracer";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(76, 325);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(41, 12);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result";
            // 
            // FrmRegexTracer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnMatch);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmRegexTracer";
            this.Text = "FrmRegexTracer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtPattern;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnMatch;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblPattern;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
    }
}

