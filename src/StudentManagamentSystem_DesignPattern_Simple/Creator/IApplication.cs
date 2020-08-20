﻿using StudentManagamentSystem_DesignPattern_Simple.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagamentSystem_DesignPattern_Simple.Creator
{
    public interface IApplication
    {
        IManagementSystem MakeApp();
    }
}
