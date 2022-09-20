using System.Numerics;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject seguirOCarro;

    void LateUpdate() 
    {
        transform.position = seguirOCarro.transform.position + new UnityEngine.Vector3 (0, 0, -10);
    }
}
