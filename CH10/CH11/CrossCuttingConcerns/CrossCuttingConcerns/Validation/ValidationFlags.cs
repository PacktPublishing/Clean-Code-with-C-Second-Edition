﻿using System;

namespace CrossCuttingConcerns.Validation
{
    [Flags]
    public enum ValidationFlags
    {
        Properties = 1,
        Methods = 2,
        Arguments = 4,
        OutValues = 8,
        ReturnValues = 16,
        NonPublic = 32,
        AllPublicArguments = Properties | Methods | Arguments,
        AllPublic = AllPublicArguments | OutValues | ReturnValues,
        All = AllPublic | NonPublic
    }
}
