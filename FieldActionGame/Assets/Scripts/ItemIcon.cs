using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemIcon : MonoBehaviour
{
    Vector3 startPosition;
    Transform _startParent;

    void Update()
    {
    }

    public void ReturnPos()
    {
            Debug.Log(name);
            transform.position = startPosition;
            transform.SetParent(_startParent);
    }

    public void SetInfo(Vector3 vec3, Transform trans)
    {
        startPosition = vec3;
        _startParent = trans;
    }
}
