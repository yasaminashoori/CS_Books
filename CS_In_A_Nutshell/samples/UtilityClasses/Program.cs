using System.Diagnostics;
using System.Text;

namespace UtilityClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console 
            #region Console examples
            Console.WindowWidth = Console.LargestWindowWidth;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("test... 50%");
            Console.CursorLeft -= 3;
            Console.Write("90%"); // test... 90% 
            #endregion


            //Console - redirect the Console’s input and output streams via the SetIn and SetOut methods.
            #region Redirecting
            // First save existing output writer:
            System.IO.TextWriter oldOut = Console.Out;
            // Redirect the console's output to a file:
            using (System.IO.TextWriter w = System.IO.File.CreateText
            ("e:\\output.txt"))
            {
                Console.SetOut(w);
                Console.WriteLine("Hello world");
            }
            // Restore standard console output
            Console.SetOut(oldOut);
            #endregion

            //Environment
            /*
             * Files and folders:
             CurrentDirectory, SystemDirectory, CommandLine
             Computer and operating system:
             MachineName, ProcessorCount, OSVersion, NewLine
             User logon:
             UserName, UserInteractive, UserDomainName
             Diagnostics:
             TickCount, StackTrace, WorkingSet, Version
            */
            #region System.Environment
            // Files and folders
            Console.WriteLine("Current Directory: " + Environment.CurrentDirectory);
            Console.WriteLine("System Directory: " + Environment.SystemDirectory);
            Console.WriteLine("Command Line: " + Environment.CommandLine);

            // Computer and operating system
            Console.WriteLine("Machine Name: " + Environment.MachineName);
            Console.WriteLine("Processor Count: " + Environment.ProcessorCount);
            Console.WriteLine("OS Version: " + Environment.OSVersion);
            Console.WriteLine("New Line: " + Environment.NewLine);

            // User logon
            Console.WriteLine("User Name: " + Environment.UserName);
            Console.WriteLine("User Interactive: " + Environment.UserInteractive);
            Console.WriteLine("User Domain Name: " + Environment.UserDomainName);

            // Diagnostics
            Console.WriteLine("Tick Count: " + Environment.TickCount);
            Console.WriteLine("Stack Trace: " + Environment.StackTrace);
            Console.WriteLine("Working Set: " + Environment.WorkingSet);
            Console.WriteLine("Version: " + Environment.Version);

            // Accessing OS environment variables
            Console.WriteLine("PATH environment variable: " + Environment.GetEnvironmentVariable("PATH"));

            // Setting exit code
            Environment.ExitCode = 1;

            // Failing fast
            Environment.FailFast("Failing fast example");
            #endregion


            //allows you to launch a new process
            #region Process
            //Process Start
            Process.Start("notepad.exe");

            // Process Start Info
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = "/c ipconfig /all",
                RedirectStandardOutput = true,
                UseShellExecute = false
            };
            Process p = Process.Start(psi);
            string result = p.StandardOutput.ReadToEnd();
            Console.WriteLine(result);

            //Opening a file or URL in Windows or Linux
            LaunchFileOrUrl("http://www.albahari.com/nutshell");

            void LaunchFileOrUrl(string url)
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }

            // Process Capturing output and errors streams
            var test1 = Run("ipconfig.exe");
            Console.WriteLine(test1.output + "Output");
            Console.WriteLine(test1.errors + "Errors");

            (string output, string errors) Run(string exePath, string args = "")
            {
                using var p = Process.Start(new ProcessStartInfo(exePath, args)
                {
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                });

                var errors = new StringBuilder();

                // Read from the error stream asynchronously...
                p.ErrorDataReceived += (sender, errorArgs) =>
                {
                    if (errorArgs.Data != null) errors.AppendLine(errorArgs.Data);
                };
                p.BeginErrorReadLine();

                // ...while we read from the output stream synchronously:
                string output = p.StandardOutput.ReadToEnd();

                p.WaitForExit();
                return (output, errors.ToString());
            }
            #endregion

        }
    }
}
