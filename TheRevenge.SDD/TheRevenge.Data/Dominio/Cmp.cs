﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Runtime.Serialization;
using System.Collections;

namespace TheRevenge.Data.Dominio
{
    [DataContract]
    public class Cmp
    {
        [DataMember]
        public int IdCmp { get; set; }
        [DataMember]
        public string TxDescripcion { get; set; }
        [DataMember]
        public string TxDoc_Identidad { get; set; }
    }
}
