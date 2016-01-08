using System;
using System.Windows.Forms;

namespace ProjectSetupWizard
{
  public partial class SolutionSetupForm : Form
  {
    public string ServerProjectName { get; set; }
    public string ProxyProjectName { get; set; }
    public string ClientProjectName { get; set; }

    public SolutionSetupForm()
    {
      InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.ServerProjectName = this.txtServerProjectName.Text;
      this.ProxyProjectName = this.txtProxyProjectName.Text;
      this.ClientProjectName = this.txtClientProjectName.Text;
      this.Dispose();
    }
  }
}
