﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public class Material_Type
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Mark { get; set; }
        [DataMember]
        public string Is_Last { get; set; }
        [DataMember]
        public string Child_Mark_Length { get; set; }
        [DataMember]
        public string Code_Start { get; set; }
        [DataMember]
        public string Code_Length { get; set; }
        [DataMember]
        public int Parent_Id { get; set; }
        [DataMember]
        public string Is_Delete { get; set; }
        [DataMember]
        public int Create_User_Id { get; set; }
        [DataMember]
        public DateTime Create_Date { get; set; }
        [DataMember]
        public int Modify_User_Id { get; set; }
        [DataMember]
        public DateTime Modify_Date { get; set; }

    }
}
