﻿using StudentData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentServiceDefinition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWcfServiceDefinition" in both code and config file together.
    [ServiceContract]
    public interface IWcfServiceDefinition
    {
        [OperationContract]
        List<Student> QueryStudents();
    }
}
