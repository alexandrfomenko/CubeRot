using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V1V2Umno : MonoBehaviour
{
    public Transform Object1;
    public float Factor;

    void Update()
    {
        transform.position = Object1.position * Factor;
    }
}
