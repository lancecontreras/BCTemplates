namespace ProjectSetupWizard
{
  partial class SolutionSetupForm
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
      this.btnOK = new System.Windows.Forms.Button();
      this.txtProxyProjectName = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtServerProjectName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtClientProjectName = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(196, 172);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 9;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // txtProxyProjectName
      // 
      this.txtProxyProjectName.Location = new System.Drawing.Point(15, 134);
      this.txtProxyProjectName.MaxLength = 120;
      this.txtProxyProjectName.Name = "txtProxyProjectName";
      this.txtProxyProjectName.Size = new System.Drawing.Size(256, 20);
      this.txtProxyProjectName.TabIndex = 8;
      this.txtProxyProjectName.Text = "Proxy";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 118);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Proxy Project Name";
      // 
      // txtServerProjectName
      // 
      this.txtServerProjectName.Location = new System.Drawing.Point(15, 82);
      this.txtServerProjectName.MaxLength = 120;
      this.txtServerProjectName.Name = "txtServerProjectName";
      this.txtServerProjectName.Size = new System.Drawing.Size(256, 20);
      this.txtServerProjectName.TabIndex = 6;
      this.txtServerProjectName.Text = "Server";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 65);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(105, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "Server Project Name";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 9);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 13);
      this.label3.TabIndex = 10;
      this.label3.Text = "Client Project Name";
      // 
      // txtClientProjectName
      // 
      this.txtClientProjectName.Location = new System.Drawing.Point(16, 26);
      this.txtClientProjectName.MaxLength = 120;
      this.txtClientProjectName.Name = "txtClientProjectName";
      this.txtClientProjectName.Size = new System.Drawing.Size(255, 20);
      this.txtClientProjectName.TabIndex = 11;
      this.txtClientProjectName.Text = "Client";
      // 
      // SolutionSetupForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 205);
      this.ControlBox = false;
      this.Controls.Add(this.txtClientProjectName);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtProxyProjectName);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtServerProjectName);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SolutionSetupForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Brokered Component Solution Setup";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.TextBox txtProxyProjectName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtServerProjectName;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtClientProjectName;
  }
}