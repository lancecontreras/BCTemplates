namespace ProjectSetupWizard
{
  partial class ServerSetupForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.txtProxyProjectName = new System.Windows.Forms.TextBox();
      this.btnOk = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Proxy Project Name";
      // 
      // txtProxyProjectName
      // 
      this.txtProxyProjectName.Location = new System.Drawing.Point(16, 30);
      this.txtProxyProjectName.MaxLength = 120;
      this.txtProxyProjectName.Name = "txtProxyProjectName";
      this.txtProxyProjectName.Size = new System.Drawing.Size(256, 20);
      this.txtProxyProjectName.TabIndex = 1;
      this.txtProxyProjectName.Text = "Proxy";
      // 
      // btnOk
      // 
      this.btnOk.Location = new System.Drawing.Point(196, 57);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(75, 23);
      this.btnOk.TabIndex = 2;
      this.btnOk.Text = "OK";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // ServerSetupForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 84);
      this.ControlBox = false;
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.txtProxyProjectName);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ServerSetupForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Brokered Component Server Setup";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtProxyProjectName;
    private System.Windows.Forms.Button btnOk;
  }
}