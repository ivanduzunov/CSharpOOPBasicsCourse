﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SonicHarvester : Harvester
{

    private int sonicFactor;

    public SonicHarvester(string id, double oreOutput, double energyRequirement, int sonicFactor)
        : base(id, oreOutput, energyRequirement)
    {
        this.sonicFactor = sonicFactor;
        this.EnergyRequirement /= this.sonicFactor;

    }
}

