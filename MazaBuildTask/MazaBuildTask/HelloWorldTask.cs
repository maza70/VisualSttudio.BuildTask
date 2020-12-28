using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Maza.BuildTasks
{
    public class HelloWorldTask : Microsoft.Build.Utilities.Task
    {

        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Hello World from the HelloWorldTask");
            return true;
        }
    }
}
