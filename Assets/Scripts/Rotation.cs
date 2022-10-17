using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public  Vector3 CubeRot;

    void Update()
    {
        transform.Rotate(CubeRot * Time.deltaTime); 
    }
}
