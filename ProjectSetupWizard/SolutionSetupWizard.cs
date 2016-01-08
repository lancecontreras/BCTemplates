using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjectSetupWizard
{
  public class SolutionSetupWizard : IWizard
  {
    private SolutionSetupForm inputForm;
    private string ProxyName { get; set; } = "Proxy";
    private string ServerName { get; set; } = "Server";
    public string ClientName { get; set; } = "Client";
    private string OutputDirectory { get; set; }
    public void BeforeOpeningFile(global::EnvDTE.ProjectItem projectItem)
    {
    }

    public void ProjectFinishedGenerating(global::EnvDTE.Project project)
    {

    }

    public void ProjectItemFinishedGenerating(global::EnvDTE.ProjectItem projectItem)
    {
    }

    public void RunFinished()
    {
    }

    public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
    {
      try
      {
        // Display a form to the user. The form collects 
        // input for the custom message.
        inputForm = new SolutionSetupForm();
        inputForm.ShowDialog();

        ProxyName = inputForm.ProxyProjectName;
        ServerName = inputForm.ServerProjectName;
        ClientName = inputForm.ClientProjectName;
        OutputDirectory = string.Format("{0}\\Debug\\", replacementsDictionary["$solutiondirectory$"]);
        if (!Directory.Exists(OutputDirectory))
          Directory.CreateDirectory(OutputDirectory);

        // Add custom parameters.
        replacementsDictionary.Add("$proxyname$", ProxyName);
        replacementsDictionary.Add("$servername$", ServerName);
        replacementsDictionary.Add("$clientname$", ClientName);
        replacementsDictionary.Add("$outputdirectory$", OutputDirectory);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    public bool ShouldAddProjectItem(string filePath)
    {
      return true;
    }
  }
}
