using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    private void Update()
    {
        this.gameObject.transform.position = GameObject.Find("Player").transform.position + new Vector3(0.0f, 7.6f, -5.0f);
    }

}
