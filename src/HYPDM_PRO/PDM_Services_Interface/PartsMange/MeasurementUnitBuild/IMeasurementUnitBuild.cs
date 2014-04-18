﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using PDM_Entity.PartsMange;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
    public interface IMeasurementUnitBuild
    {
        [OperationContract]
        IList<Unit> list1(); //单位信息
        [OperationContract]
        List<Unit> GetUnitListByGroupId(int groupId);
        [OperationContract]
        List<UnitGroup> GetAllUnitGroup(); //单位组信息
        [OperationContract]
        bool AddORUpdateUnitGroup(UnitGroup group);
        [OperationContract]
        bool AddORUpdateUnit(Unit unit);
        [OperationContract]
        List<Unit> GetAllUnit();
    }
}

