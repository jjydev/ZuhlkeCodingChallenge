﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public interface IDataContextFactory
    {
        IDatabaseContext Create();
    }
}
