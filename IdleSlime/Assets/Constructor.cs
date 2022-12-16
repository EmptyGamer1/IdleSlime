using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Constructor:MonoBehaviour
{
    public List<string> names = new List<string>();

    private void Awake()
    {
        names.Add("Naruto");
        names.Add("Saske");
        names.Add("Uchiha");
        names.Add("Sakura");
    }
}

