﻿using System.Runtime.Serialization;

namespace Seggu.Service
{
    [DataContract]
    public class PointerVM
    {
        private string type;

        [DataMember(Name ="__type")]
        public string Type
        {
            get { return "Pointer"; }
        }

        [DataMember]
        public string ClassName { get; set; }
        [DataMember]
        public string ObjectId { get; set; }

        public PointerVM()
        {
        }

        public PointerVM(string className, string objectId)
        {
            this.ClassName = className;
            this.ObjectId = objectId;
        }
    }
}