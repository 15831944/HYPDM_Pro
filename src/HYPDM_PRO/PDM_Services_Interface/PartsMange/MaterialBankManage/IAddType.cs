﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IAddType
    {
        [OperationContract]
        Material GetAllMaterialcs(string name, string versions, string number, string type);  //得到物料信息
    }
}
