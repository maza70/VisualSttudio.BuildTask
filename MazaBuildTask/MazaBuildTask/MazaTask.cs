using Microsoft.Build.Framework;
using System;
using System.Collections;
using System.IO;


namespace Maza.BuildTasks
{
    public class MazaTask : Microsoft.Build.Utilities.Task
    {
        private ITaskItem[] directories;


        /// <summary>
        /// Sample Parameter for the Task
        /// </summary>
        [Required]
       
        public ITaskItem[] Outputpath
        {
            get
            {
                return directories;
            }

            set
            {
                directories = value;
            }
        }

        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, $"MazaTask -->>");

            if (Outputpath != null)
            {
                foreach (var path in Outputpath)
                {
                    Log.LogMessage(MessageImportance.High, $"MAZA:  ItemSpec:{path.ItemSpec}");

                }
            }
          
            Log.LogMessage(MessageImportance.High, $"MAZA: ProjectFileOfTaskNode:{this.BuildEngine7.ProjectFileOfTaskNode}");
            Log.LogMessage(MessageImportance.High, $"MAZA: ColumnNumberOfTaskNode:{this.BuildEngine7.ColumnNumberOfTaskNode}");
            Log.LogMessage(MessageImportance.High, $"MAZA: CWD:{Directory.GetCurrentDirectory()}");
            var prop = BuildEngine7.GetGlobalProperties();
            foreach (var keyValue in prop)
            {
                Log.LogMessage(MessageImportance.High, $"MAZA: global properties {keyValue.Key}:{keyValue.Value}");
            }
            Log.LogMessage(MessageImportance.High, $"<<--MazaTask");
            return true;
        }
    }
}

