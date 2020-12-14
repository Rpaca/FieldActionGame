using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlchemySystem : MonoBehaviour
{
    private GameObject inventoy;
    private int numOfMush;
    private int numOfGem;
    private int numOfDan;

    void Start()
    {
        inventoy = GameObject.Find("GameRoot");
        numOfMush = 0;
    }

    public void MakePotion()
    {
        // 소재 개수 확인
        for (int i = 0; i < inventoy.GetComponent<Inventory>().mixSize; i++)
        {
            if (inventoy.GetComponent<Inventory>().mixBoxList[i] == ITEM.MUSHROOM)
                numOfMush++;
            else if (inventoy.GetComponent<Inventory>().mixBoxList[i] == ITEM.GEM)
                numOfGem++;
            else if (inventoy.GetComponent<Inventory>().mixBoxList[i] == ITEM.DANDELION)
                numOfDan++;
        }

        // mix상자에 있는 재료 모두 삭제
        for (int i = 0; i < inventoy.GetComponent<Inventory>().mixSize; i++)
        {
            if (inventoy.GetComponent<Inventory>().mixBoxList[i] != ITEM.NUM)
            {
                inventoy.GetComponent<Inventory>().mixBoxList[i] = ITEM.NUM;
                Destroy(GameObject.Find("UI").transform.GetChild(GameObject.Find("UI").transform.childCount-1));
            }
        }


        ////소재에 따른 결과
        //if (numOfMush == 1 && numOfDan == 1)
        //{

        //}

        //else
        //{
        //}
    }
}
