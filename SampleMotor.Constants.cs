/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace SampleMotor
{
    #region Object Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Objects
    {
        /// <summary>
        /// The identifier for the SampleMotor1 Object.
        /// </summary>
        public const uint SampleMotor1 = 16;
    }
    #endregion

    #region ObjectType Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypes
    {
        /// <summary>
        /// The identifier for the GenericMotorType ObjectType.
        /// </summary>
        public const uint GenericMotorType = 1;
    }
    #endregion

    #region Variable Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Variables
    {
        /// <summary>
        /// The identifier for the GenericMotorType_Speed Variable.
        /// </summary>
        public const uint GenericMotorType_Speed = 2;

        /// <summary>
        /// The identifier for the GenericMotorType_Speed_EURange Variable.
        /// </summary>
        public const uint GenericMotorType_Speed_EURange = 6;

        /// <summary>
        /// The identifier for the SampleMotor1_Speed Variable.
        /// </summary>
        public const uint SampleMotor1_Speed = 24;

        /// <summary>
        /// The identifier for the SampleMotor1_Speed_EURange Variable.
        /// </summary>
        public const uint SampleMotor1_Speed_EURange = 28;
    }
    #endregion

    #region Object Node Identifiers
    /// <summary>
    /// A class that declares constants for all Objects in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectIds
    {
        /// <summary>
        /// The identifier for the SampleMotor1 Object.
        /// </summary>
        public static readonly ExpandedNodeId SampleMotor1 = new ExpandedNodeId(SampleMotor.Objects.SampleMotor1, SampleMotor.Namespaces.SampleMotor);
    }
    #endregion

    #region ObjectType Node Identifiers
    /// <summary>
    /// A class that declares constants for all ObjectTypes in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class ObjectTypeIds
    {
        /// <summary>
        /// The identifier for the GenericMotorType ObjectType.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType = new ExpandedNodeId(SampleMotor.ObjectTypes.GenericMotorType, SampleMotor.Namespaces.SampleMotor);
    }
    #endregion

    #region Variable Node Identifiers
    /// <summary>
    /// A class that declares constants for all Variables in the Model Design.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class VariableIds
    {
        /// <summary>
        /// The identifier for the GenericMotorType_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType_Speed = new ExpandedNodeId(SampleMotor.Variables.GenericMotorType_Speed, SampleMotor.Namespaces.SampleMotor);

        /// <summary>
        /// The identifier for the GenericMotorType_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId GenericMotorType_Speed_EURange = new ExpandedNodeId(SampleMotor.Variables.GenericMotorType_Speed_EURange, SampleMotor.Namespaces.SampleMotor);

        /// <summary>
        /// The identifier for the SampleMotor1_Speed Variable.
        /// </summary>
        public static readonly ExpandedNodeId SampleMotor1_Speed = new ExpandedNodeId(SampleMotor.Variables.SampleMotor1_Speed, SampleMotor.Namespaces.SampleMotor);

        /// <summary>
        /// The identifier for the SampleMotor1_Speed_EURange Variable.
        /// </summary>
        public static readonly ExpandedNodeId SampleMotor1_Speed_EURange = new ExpandedNodeId(SampleMotor.Variables.SampleMotor1_Speed_EURange, SampleMotor.Namespaces.SampleMotor);
    }
    #endregion

    #region BrowseName Declarations
    /// <summary>
    /// Declares all of the BrowseNames used in the Model Design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class BrowseNames
    {
        /// <summary>
        /// The BrowseName for the GenericMotorType component.
        /// </summary>
        public const string GenericMotorType = "GenericMotorType";

        /// <summary>
        /// The BrowseName for the SampleMotor1 component.
        /// </summary>
        public const string SampleMotor1 = "Sample Motor #1";

        /// <summary>
        /// The BrowseName for the Speed component.
        /// </summary>
        public const string Speed = "Speed";
    }
    #endregion

    #region Namespace Declarations
    /// <summary>
    /// Defines constants for all namespaces referenced by the model design.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public static partial class Namespaces
    {
        /// <summary>
        /// The URI for the OpcUa namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUa = "http://opcfoundation.org/UA/";

        /// <summary>
        /// The URI for the OpcUaXsd namespace (.NET code namespace is 'Opc.Ua').
        /// </summary>
        public const string OpcUaXsd = "http://opcfoundation.org/UA/2008/02/Types.xsd";

        /// <summary>
        /// The URI for the SampleMotor namespace (.NET code namespace is 'SampleMotor').
        /// </summary>
        public const string SampleMotor = "http://opcfoundation.org/SampleMotor";
    }
    #endregion
}