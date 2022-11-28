using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform nextposition;
    public new Camera camera;

    private void Awake()
    {
        nextposition = GetComponent<Transform>();
    }
}