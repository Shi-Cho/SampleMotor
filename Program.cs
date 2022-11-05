using Opc.Ua;
using Opc.Ua.Configuration;

namespace SampleMotor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            ApplicationInstance application = new ApplicationInstance();
            application.ApplicationType = ApplicationType.Server;
            application.ConfigSectionName = "SampleMotorServer";

            try
            {
                if (application.ProcessCommandLine())
                {
                    return;
                }

                // check if running as a service.
                if (!Environment.UserInteractive)
                {
                    application.StartAsService(new SampleMotorServer());
                    return;
                }
                application.LoadApplicationConfiguration("C:/Work/cppwork/samples/SampleMotor/SampleMotor.Config.xml", false).Wait();

                // check the application certificate.
                application.CheckApplicationInstanceCertificate(false, 0).Wait();

                // start the server.
                application.Start(new SampleMotorServer()).Wait();
                Application.Run(new Form1(application));
            }
            catch (Exception e)
            {
                string text = "Exception: " + e.Message;
                if (e.InnerException != null)
                {
                    text += "\r\nInner exception: ";
                    text += e.InnerException.Message;
                }
                MessageBox.Show(text, application.ApplicationName);
            }

        }

    }
}