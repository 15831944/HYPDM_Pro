﻿using PDM_Entity.Test;
using PDM_Services_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace PDM_Services_Implementation
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple, InstanceContextMode = InstanceContextMode.PerCall, Namespace = "PDM_Services_Implementation")]
     public class TestService : ITestService
    {

        public User GetUser(string name, int age)
        {
            return new User
            {
                Age = age,
                Name = name,
            };
        }
    }
}
