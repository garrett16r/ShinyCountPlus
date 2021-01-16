using Squirrel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyCountPlus
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            checkForUpdates();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        async static Task checkForUpdates()
        {
            var mgr = UpdateManager.GitHubUpdateManager("https://github.com/Syntthetix/ShinyCountPlus");
            try
            {
                using (mgr)
                {
                    var currVersion = mgr.Result.CheckForUpdate().Result.CurrentlyInstalledVersion.Version.Version;
                    var futureVersion = mgr.Result.CheckForUpdate().Result.FutureReleaseEntry.Version.Version;

                    // Only attempt to update if there is actually an update available on the github repo
                    if (currVersion < futureVersion)
                    {
                        await mgr.Result.UpdateApp();
                    }
                }
            }
            catch (System.Threading.AbandonedMutexException ame)
            {
                ame.Mutex.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                mgr.Dispose();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
