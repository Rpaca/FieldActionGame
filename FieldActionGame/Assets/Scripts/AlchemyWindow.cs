using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemyWindow : MonoBehaviour
{
    private GameObject target;
    private GameObject inventory;

    private void Start()
    {
        inventory = GameObject.Find("GameRoot");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)
            && Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, this.transform.position) < 5f)
        {
            target = GetClickedObject();


            if (target.Equals(this.gameObject))  //선택된게 나라면
            {
                Debug.Log("open");
                GameObject.Find("UI").transform.GetChild(2).gameObject.SetActive(true);
            }
        }

    }

    private GameObject GetClickedObject()
    {
        RaycastHit hit;
        GameObject target = null;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); //마우스 포인트 근처 좌표를 만든다. 
        if (true == (Physics.Raycast(ray.origin, ray.direction * 10, out hit)))   //마우스 근처에 오브젝트가 있는지 확인
        {
            //있으면 오브젝트를 저장한다.
            target = hit.collider.gameObject;
            Debug.Log(target.name);
        }
        return target;
    }
}
