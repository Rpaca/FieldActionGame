using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemRooting : MonoBehaviour
{
    private GameObject target;
    private GameObject inventory;
    public AudioSource audioSource;
    public AudioClip getSound;

    private void Start()
    {
        inventory = GameObject.Find("GameRoot");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)
            && !inventory.GetComponent<Inventory>().checkIsFull()
            && Vector3.Distance(GameObject.FindGameObjectWithTag("Player").transform.position, this.transform.position) < 2.5f)
        {
            target = GetClickedObject();

            if (target.Equals(this.gameObject))  //선택된게 나라면
            {
                if (this.transform.tag == "Mushroom")
                    GameObject.Find("GameRoot").GetComponent<Inventory>().AddItem(ITEM.MUSHROOM);
                if (this.transform.tag == "Gem")
                    GameObject.Find("GameRoot").GetComponent<Inventory>().AddItem(ITEM.GEM);
                if (this.transform.tag == "Dandelion")
                    GameObject.Find("GameRoot").GetComponent<Inventory>().AddItem(ITEM.DANDELION);
                if (this.transform.tag == "Eye")
                    GameObject.Find("GameRoot").GetComponent<Inventory>().AddItem(ITEM.EYE);
                if (this.transform.tag == "Meat")
                    GameObject.Find("GameRoot").GetComponent<Inventory>().AddItem(ITEM.MEAT);
                Destroy(this.gameObject);
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
