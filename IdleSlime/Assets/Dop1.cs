using System;
using System.Collections.Generic;
using UnityEngine;

class Dop1 : MonoBehaviour
{
    Constructor constructor;

    private void Start()
    {
        Debug.Log(SystemInfo.processorType);
        constructor = GetComponent<Constructor>();

        foreach (var name in constructor.names)
        {
            Debug.Log(name);
        }
    }
}

