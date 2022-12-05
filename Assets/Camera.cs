using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public GameObject main;
    public float xOffset, yOffset, zOffset;
    // Update is called once per frame
    void Update()
    {
        transform.position = main.transform.position + new Vector3(xOffset, yOffset, zOffset);
        transform.LookAt(main.transform.position);
    }
}
