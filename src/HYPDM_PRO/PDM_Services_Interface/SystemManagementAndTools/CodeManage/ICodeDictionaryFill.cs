﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace PDM_Services_Interface
{
    [ServiceContract(Namespace = "PDM_Services_Interface")]
	public interface ICodeDictionaryFill
	{
        [OperationContract]
        bool AddCodeDictionary();
        

	}
}
