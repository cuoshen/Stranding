﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stranding.Testing; // Delete upon finish

namespace Stranding
{
    /// <summary>
    /// Engine attachable container for events
    /// </summary>
    class Block : MonoBehaviour
    {
        public BlockEvent Event
        {
            get;
            private set;
        }

        private void Start()
        {
            //Event = new DebugBlockEvent();
            //Event = new NotificationEvent("This is a notification.");
            NotificationEvent option1 = new NotificationEvent("You choose option 1");
            NotificationEvent option2 = new NotificationEvent("You choose option 2");
            List<EventOption> outcomes = new List<EventOption>();
            outcomes.Add(new EventOption("option1", option1));
            outcomes.Add(new EventOption("option2", option2));
            Event = new ChoiceEvent("Please make a choice", outcomes);
        }
    }
}

