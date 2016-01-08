using System;
using System.Windows.Forms;

namespace ProjectSetupWizard
{
  public partial class ClientSetupForm : Form
  {
    public string ServerProjectName { get; set; }
    public string ProxyProjectName { get; set; }
    public ClientSetupForm()
    {
      InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      this.ServerProjectName = this.txtServerProjectName.Text;
      this.ProxyProjectName = this.txtProxyProjectName.Text;
      this.Dispose();
    }
  }
}
