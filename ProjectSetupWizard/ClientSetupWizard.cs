using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjectSetupWizard
{
  /// <summary>
  /// Wizard that will launch for client template.
  /// </summary> 
  public class ClientSetupWizard : IWizard
  {
    private ClientSetupForm inputForm;
    private string ProxyName { get; set; } = "Proxy";
    private string ServerName { get; set; } = "Server";
    private string OutputDirectory { get; set; }
    public void BeforeOpeningFile(global::EnvDTE.ProjectItem projectItem)
    {
      string solutionPath = Path.GetFullPath(projectItem.DTE.Solution.FileName);
      OutputDirectory = string.Format("{0}{1}\\", solutionPath, projectItem.DTE.WindowConfigurations.ActiveConfigurationName);
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
        inputForm = new ClientSetupForm();
        inputForm.ShowDialog();

        ProxyName = inputForm.ProxyProjectName;
        ServerName = inputForm.ServerProjectName;
        OutputDirectory = string.Format("{0}\\Debug\\", replacementsDictionary["$solutiondirectory$"]);
        if (!Directory.Exists(OutputDirectory))
          Directory.CreateDirectory(OutputDirectory);

        // Add custom parameters.
        replacementsDictionary.Add("$proxyname$", ProxyName);
        replacementsDictionary.Add("$servername$", ServerName);
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
