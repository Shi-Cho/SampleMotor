using Opc.Ua;
using Opc.Ua.Server;
using System;
using System.Collections.Generic;

namespace SampleMotor
{
    class SampleMotorServer : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, Opc.Ua.ApplicationConfiguration configuration)
        {
            Utils.Trace("Creating the Node Managers.");

            List<INodeManager> nodeManagers = new List<INodeManager>();

            // create the custom node managers.
            nodeManagers.Add(new SampleMotorNodeManager(server, configuration));

            // create master node manager.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new ServerProperties();

            properties.ManufacturerName = "CSC";
            properties.ProductName = "SampleMotor InformationModel Server";
            properties.ProductUri = "http://opcfoundation.org/SampleMotor/InformationModelServer/v1.0";
            properties.SoftwareVersion = Utils.GetAssemblySoftwareVersion();
            properties.BuildNumber = Utils.GetAssemblyBuildNumber();
            properties.BuildDate = Utils.GetAssemblyTimestamp();

            return properties;
        }

    }
}
