using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjectSetupWizard
{
  public class ServerSetupWizard : IWizard
  {
    private ServerSetupForm inputForm;
    private string ProxyName { get; set; } = "Proxy";
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
        inputForm = new ServerSetupForm();
        inputForm.ShowDialog();

        ProxyName = inputForm.ProxyProjectName;

        // Add custom parameters.
        replacementsDictionary.Add("$proxyname$", ProxyName);
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
