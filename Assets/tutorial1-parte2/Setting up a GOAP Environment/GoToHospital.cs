﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace part2 {
public class GoToHospital : GAction
{
    public override bool PrePerform()
    {
        return true;
    }

    public override bool PostPerform()
    {
        return true;
    }
}
}