﻿namespace WcfExtension
{
    using System.Runtime.Serialization;
    using MongoDB.Bson.DefaultSerializer;

    [DataContract(Namespace = "WcfExtension")]
    [BsonIgnoreExtraElementsAttribute]
    public class ClientMessageInfo : WcfMessageInfo, IClientInfo
    {
        [DataMember]
        public string ClientTypeName { get; set; }

        [DataMember]
        [PersistenceColumn(IsIndex = true)]
        public string ContractName { get; set; }
    }
}
