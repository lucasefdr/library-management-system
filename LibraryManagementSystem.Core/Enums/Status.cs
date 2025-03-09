﻿using System.Runtime.Serialization;

namespace LibraryManagementSystem.Core.Enums;

public enum Status
{
    [EnumMember(Value = "Unavailable")]
    Unavailable = 0,

    [EnumMember(Value = "Available")]
    Available = 1
}
