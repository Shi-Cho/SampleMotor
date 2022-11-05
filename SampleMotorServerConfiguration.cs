using System.Runtime.Serialization;

namespace SampleMotor
{
    [DataContract(Namespace = Namespaces.SampleMotor)]
    public class SampleMotorServerConfiguration
    {
        public SampleMotorServerConfiguration()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the object during deserialization.
        /// </summary>
        [OnDeserializing()]
        private void Initialize(StreamingContext context)
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private void Initialize()
        {
        }
    }
}
