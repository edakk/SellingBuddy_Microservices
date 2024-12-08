﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Events
{
    public class IntegrationEvent
    {
        [JsonProperty]
        public Guid Id { get; private set; }

        [JsonProperty]
        public DateTime CreatedDate { get; private set; }

       
       
        public IntegrationEvent()
        {
            Id= Guid.NewGuid();
            CreatedDate = DateTime.Now;

        }

        [JsonConstructor]
        public IntegrationEvent(DateTime createdDate , Guid id)
        {
            Id= id;
            CreatedDate = createdDate;
        }
    }
}
