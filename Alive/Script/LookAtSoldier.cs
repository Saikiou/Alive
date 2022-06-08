using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtSoldier : MonoBehaviour
{
    public Transform soldier;
    void Update()
    {
        if(soldier != null)
       {
            transform.LookAt(soldier);
       }
    }
}
