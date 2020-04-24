﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
    public GameObject Tower;
    public Vector3 offset;
    public GameObject curTower;
    public bool empty = true;
    // Start is called before the first frame update
    void OnMouseDown()
    {
        if(empty)
        {
            curTower = GameObject.Instantiate(Tower,transform.position+offset,Quaternion.identity) as GameObject;
            empty = false;
        }
    }

}
