﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataLayer.SR_StudentWcf;
using DataLayer;

namespace ServiceLayerServiceDefinition
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceLayerWcfServiceDefinition" in both code and config file together.
    public class ServiceLayerWcfServiceDefinition : IServiceLayerWcfServiceDefinition
    {
        List<PeopleModel> people = new List<PeopleModel>();
        DataServiceConsumer dl = new DataServiceConsumer();

        public List<PeopleModel> QueryAll()
        {
            return dl.QueryAll();
        }

    }
}
