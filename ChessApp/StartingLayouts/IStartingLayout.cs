﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessApp
{
    public interface IStartingLayout
    {
        List<WhatWhere> GetLayout();
    }
}
