using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace part2 {
public class GInventory 
{
    List<GameObject>items = new List<GameObject>();

    public void AddItem(GameObject i)
    {
        items.Add(i);
    }

    public GameObject FindItemWithTag(string tag)
    {
        foreach(GameObject i in items)
        {
            if(i.tag == tag)
            {
                return i;
            }
        }
        return null;
    }

    public void RemoveItem(GameObject i)
    {
        int IndexToRemove = -1;
        foreach(GameObject g in items)
        {
            IndexToRemove++;
            if (g == i) break;
        }
        if(IndexToRemove >= -1)items.RemoveAt(IndexToRemove);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}