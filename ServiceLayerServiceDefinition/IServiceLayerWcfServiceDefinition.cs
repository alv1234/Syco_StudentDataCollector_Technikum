using DataLayer.SR_StudentWcf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceLayerServiceDefinition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceLayerWcfServiceDefinition" in both code and config file together.
    [ServiceContract]
    public interface IServiceLayerWcfServiceDefinition
    {
        [OperationContract]
        List<Student> QueryStudents();
    }
}
