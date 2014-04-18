﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace PDM_Entity.PartsMange
{
    [DataContract]
    public class MaterialBaseProperty
    {
        [DataMember(Order = 1)]
        public int id { get; set; }

        [DataMember(Order = 2)]
        public string cn_name { get; set; }

        [DataMember(Order = 3)]
        public string en_name { get; set; }

        [DataMember(Order = 4)]
        public string data_type { get; set; }

        [DataMember(Order = 5)]
        public string data_length { get; set; }

        [DataMember(Order = 6)]
        public string input_type { get; set; }

        [DataMember(Order = 7)]
        public string required { get; set; }

        [DataMember(Order = 8)]
        public string default_value { get; set; }

        [DataMember(Order = 9)]
        public string is_extends { get; set; }

        [DataMember(Order = 10)]
        public string is_query { get; set; }

        [DataMember(Order = 11)]
        public string width { get; set; }

        [DataMember(Order = 12)]
        public string property_type { get; set; }

        [DataMember(Order = 13)]
        public int material_property_type_id { get; set; }

        [DataMember(Order = 14)]
        public int create_user_id { get; set; }

        [DataMember(Order = 15)]
        public DateTime create_date { get; set; }

        [DataMember(Order = 16)]
        public int modify_user_id { get; set; }

        [DataMember(Order = 17)]
        public DateTime modify_date { get; set; }

        [DataMember(Order = 18)]
        public string is_delete { get; set; }

        [DataMember]
        public bool is_show { get; set; }

        [DataMember(Order = 18)]
        public int number { get; set; }

        [DataMember(Order = 19)]
        public string property { get; set; }

        [DataMember(Order = 20)]
        public string variety { get; set; }

        [DataMember(Order = 21)]
        public string weight { get; set; }

        [DataMember(Order = 22)]
        public string type { get; set; }

        [DataMember(Order = 23)]
        public string belong_classify { get; set; }

        [DataMember(Order = 24)]
        public string product_type { get; set; }

        [DataMember(Order = 25)]
        public int original_number { get; set; }

        [DataMember(Order = 26)]
        public string version { get; set; }

        [DataMember(Order = 27)]
        public string unit_measure { get; set; }

        [DataMember(Order = 28)]
        public string unit_measure_group { get; set; }

        [DataMember(Order = 29)]
        public string material { get; set; }

        [DataMember(Order = 30)]
        public string cost_price { get; set; }

        [DataMember(Order = 31)]
        public string norms { get; set; }

        [DataMember(Order = 32)]
        public string remark { set; get; }

        [DataMember]
        public bool checkStatus { get; set; }

        [DataMember]
        public int Order_No { get; set; }
    }
}
