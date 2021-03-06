﻿using System;

namespace LiveSplit.Web.SRL
{
    public class SRLIRCUser
    {
        public SRLIRCRights Rights { get; protected set; }
        public String Name { get; protected set; }

        public SRLIRCUser(String name, SRLIRCRights rights = SRLIRCRights.Normal)
        {
            Name = name;
            Rights = rights;
        }
    }
}
