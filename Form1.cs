using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

namespace SampleMotor
{
    public partial class Form1 : Form
    {
        private ApplicationInstance m_application;
        private StandardServer m_server;
        private Opc.Ua.ApplicationConfiguration m_configuration;



        public Form1(ApplicationInstance application)
        {
            InitializeComponent();

            m_application = application;
            m_server = application.Server as StandardServer;
            m_configuration = application.ApplicationConfiguration;

            comboBox1.Items.Clear();

            foreach (EndpointDescription endpoint in m_server.GetEndpoints())
            {
                if (comboBox1.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    comboBox1.Items.Add(endpoint.EndpointUrl);
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}