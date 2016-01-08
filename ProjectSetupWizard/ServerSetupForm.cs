using System;
using System.Windows.Forms;

namespace ProjectSetupWizard
{
  public partial class ServerSetupForm : Form
  {
    public string ProxyProjectName { get; set; }
    public ServerSetupForm()
    {
      InitializeComponent();
    }

    private void btnOk_Click(object sender, EventArgs e)
    {
      this.ProxyProjectName = txtProxyProjectName.Text;
      this.Dispose();
    }
  }
}
