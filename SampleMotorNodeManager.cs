using Opc.Ua;
using Opc.Ua.Server;
using System.Reflection;

namespace SampleMotor
{
        class SampleMotorNodeManager : CustomNodeManager2
    {
        public SampleMotorNodeManager(IServerInternal server, Opc.Ua.ApplicationConfiguration configuration)
        :
       base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = SampleMotor.Namespaces.SampleMotor;
            namespaceUrls[1] = SampleMotor.Namespaces.SampleMotor + "/Instance";
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<SampleMotorServerConfiguration>();

            // use suitable defaults if no configuration exists.
            if (m_configuration == null)
            {
                m_configuration = new SampleMotorServerConfiguration();
            }
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new NodeStateCollection();
            predefinedNodes.LoadFromBinaryResource(context,
                "C:/Work/cppwork/samples/SampleMotor/SampleMotor.PredefinedNodes.uanodes",
                typeof(SampleMotorNodeManager).GetTypeInfo().Assembly,
                true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReferences)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReferences);

                // find the untyped Batch Plant 1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(SampleMotor.Objects.SampleMotor1, NamespaceIndexes[0]), typeof(BaseObjectState));

                // convert the untyped node to a typed node that can be manipulated within the server.
                m_motor1 = new GenericMotorState(null);
                m_motor1.Create(SystemContext, passiveNode);

                // replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, m_motor1);

                m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
                m_motor1.Speed.Value = 85;

            }
        }

        public void DoSimulation(object state)
        {
            //m_batchPlant1.Mixer.LoadcellTransmitter.Output.Value++;
        }


        private SampleMotorServerConfiguration m_configuration;
        private static GenericMotorState  m_motor1;
        private System.Threading.Timer m_simulationTimer;

    }

}