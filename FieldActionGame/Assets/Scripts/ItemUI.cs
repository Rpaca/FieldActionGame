using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemUI : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform _startParent;
    private Vector2 startPosition;
    private Vector2 mixPosition;
    private bool onTrigger = false;
    private GameObject inventory;
    private bool isDraged = false;
    public AudioClip ding;
    public AudioSource audioSource;

    void Start()
    {
        inventory = GameObject.Find("GameRoot");
        mixPosition = new Vector2(0, 0);
        if (transform.parent == GameObject.Find("ItemBox").transform)
        {
            startPosition = transform.position;
            _startParent = transform.parent;
        }
    }

    void Update()
    {
        // 1. 믹박은 초기화DelMixBoxList ㅇㅋ 2. 위치 안돌아옴 3/ 아이템 정보도 인벤토리로 안돌아옴
        //여기서 발생하는 문제
        //마지막 하나만 그냥 여길 걸리지 않았다!
        //왜지?
        if (GameObject.Find("GameRoot").GetComponent<UImanager>().isExitWin && isDraged)
        {
            ReturnPos(); // 이것도 작동을 안한 상황
            inventory.GetComponent<Inventory>().ReturnItem(startPosition, checkObjTag(gameObject)); // 작동 안함

            Debug.Log(name);
            Debug.Log(startPosition);
            //inventory.GetComponent<Inventory>().DelMixBoxList(); // 작동을 했음
            inventory.GetComponent<Inventory>().SearchDelMixBoxList(mixPosition); // 작동을 했음
            mixPosition = new Vector2(0, 0);
            isDraged = false;
            if (inventory.GetComponent<Inventory>().CheckMixBoxIsEmpty()) // 이것도 작동을 했음,  여기서 문제
                GameObject.Find("GameRoot").GetComponent<UImanager>().isExitWin = false;
        }


    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        if (!GameObject.Find("AlchemyWindow"))
            return;
        if (this.gameObject.tag == "Potion")
            return;
        // 여기가 안결려서 생기는 문제 왜??
        isDraged = true;
        if (transform.parent == GameObject.Find("ItemBox").transform)
        {
            startPosition = transform.position;
            _startParent = transform.parent;
        }
        transform.SetParent(GameObject.FindGameObjectWithTag("UI Canvas").transform);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!GameObject.Find("AlchemyWindow"))
            return;
        if (this.gameObject.tag == "Potion")
            return;
        transform.position = eventData.position;
    }

    // 이부분에 추가할 코드가 한가득
    // 1. 합성 박스 위치가 아니면 원래 위치로 돌아가도록
    // 2. 합성박스에 재료가 가득 찼느지 확인(물론 부모 변경해서 순서 달라지게)
    // 물론 올라가면 정보도 업데이트
    // 인벤토리에서는 재료 삭제되고 합성박스에서는 정보 업데이트
    // 3. 합성박스에 이미 재료 있으면 원래 위치로
    public void OnEndDrag(PointerEventData eventData)
    {
        if (!GameObject.Find("AlchemyWindow"))
            return;
        if (this.gameObject.tag == "Potion")
            return;
        audioSource.clip = ding;
        audioSource.Play();
        //처음 합성박스에 올라갈 경우
        if (onTrigger && !inventory.GetComponent<Inventory>().CheckMixBoxIsFull() && mixPosition == new Vector2(0, 0))
        {
            //1. 합성 박스 배열에 아이템 정보 업데이트
            //2. 인벤토리에 있는 아이템 정보 삭제
            //transform.position = eventData.position;
            inventory.GetComponent<Inventory>().DelItem(startPosition);
            transform.SetParent(GameObject.Find("UI").transform);
            transform.position = inventory.GetComponent<Inventory>().AddMixBox(checkObjTag(gameObject));
            mixPosition = transform.position;
        }

        //합성박스에 연속으로 올라갈 경우
        else if (onTrigger && !inventory.GetComponent<Inventory>().CheckMixBoxIsFull() && mixPosition != new Vector2(0, 0))
        {
            transform.position = mixPosition;
        }

        //합성박스가 아닌 위치에 올라갈 경우
        else
        {
            transform.position = startPosition;
            transform.SetParent(_startParent);
            if (mixPosition != new Vector2(0, 0))
            {
                inventory.GetComponent<Inventory>().SearchDelMixBoxList(mixPosition);
                inventory.GetComponent<Inventory>().ReturnItem(startPosition, checkObjTag(gameObject));
                mixPosition = new Vector2(0, 0);
            }
        }

        //디버깅용
        inventory.GetComponent<Inventory>().CheckMixBoxIsEmpty();
    }

    //조합창이 꺼질때로 변경?
    public void ReturnPos()
    {
        transform.position = startPosition;
        transform.SetParent(_startParent);

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "MixBox")
            onTrigger = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.name == "MixBox")
            onTrigger = false;
    }

    ITEM checkObjTag(GameObject obj)
    {
        if (obj.tag == "Mushroom")
            return ITEM.MUSHROOM;
        else if (obj.tag == "Gem")
            return ITEM.GEM;
        else if (obj.tag == "Dandelion")
            return ITEM.DANDELION;
        else if (obj.tag == "Eye")
            return ITEM.EYE;
        else if (obj.tag == "Meat")
            return ITEM.MEAT;
        else
            return ITEM.NUM;
    }
}
