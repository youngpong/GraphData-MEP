﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.Revit.DB;

namespace HLApps.Revit.Graph
{
    public abstract class MEPConnector
    {

        public XYZ Origin { get; set; }

    }



    public class RevitConnector : MEPConnector
    {


    }

    public class VirtualConnector : MEPConnector
    {


    }

}
