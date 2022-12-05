using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace part2 {
public class Nurse : GAgent
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        SubGoal s1 = new SubGoal("isWaiting", 1, true);
        goals.Add(s1, 3); 
    }

}
}