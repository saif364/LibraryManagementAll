﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementModels.BusinessModels
{
    public enum EnumAction
    {
        Create,
        Update,
        Delete
    }

    public enum EnumStatus
    {
        Created,
        Updated,
        Deleted,
        Approved,
        Rejected,
        PendingForApproval
    }
}
