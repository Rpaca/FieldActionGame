using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //인벤토리 관리 체계부터 잘못되었다..
    //배열을 gameobject, item 형식으로 해야했음. 
    public GameObject[] UIImage = new GameObject[4];
    public int itemSize = 5;
    public ITEM[] itemList = new ITEM[4];
    public int mixSize = 2;
    public ITEM[] mixBoxList = new ITEM[1];

    private int numOfMush;
    private int numOfGem;
    private int numOfDan;
    private int numOfEye;
    private int numOfMeat;

    GameStatus game_status;

    public AudioClip dirnkingSound;
    public AudioClip mixSound;
    public AudioClip pickSound;
    public AudioSource audioSource;


    private void Start()
    {
        for (int i = 0; i < itemSize; i++)
            itemList[i] = ITEM.NUM;

        for (int i = 0; i < mixSize; i++)
            mixBoxList[i] = ITEM.NUM;

        game_status = GameObject.Find("GameRoot").GetComponent<GameStatus>();
        //UIImage[0] = Resources.Load<GameObject>("MushIcon");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (itemList[0] == ITEM.HEALPOTION)
            {
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("0").gameObject);
                // 포션 정보 삭제
                itemList[0] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(0.25f);
                audioSource.clip = dirnkingSound;
                audioSource.Play();
            }

            if (itemList[0] == ITEM.POISONPOTION)
            {
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("0").gameObject);
                // 포션 정보 삭제
                itemList[0] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(-0.15f);
                audioSource.clip = dirnkingSound;
                audioSource.Play();
            }

            if (itemList[0] == ITEM.CLEARPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("0").gameObject);
                // 포션 정보 삭제
                itemList[0] = ITEM.NUM;
                // 포션 효과 사용
                // 클리어 팝업 등장
                if(GameManager.instance.stageLevel<2)
                    GameManager.instance.clearUI.SetActive(true);
                else
                    GameManager.instance.EndingUI.SetActive(true);
            }

            if (itemList[0] == ITEM.SMALLPOTION)
            {
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("0").gameObject);
                // 포션 정보 삭제
                itemList[0] = ITEM.NUM;
                // 포션 효과 사용
                GameObject.Find("Player").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                audioSource.clip = dirnkingSound;
                audioSource.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (itemList[1] == ITEM.HEALPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("1").gameObject);
                // 포션 정보 삭제
                itemList[1] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(0.25f);
            }

            if (itemList[1] == ITEM.POISONPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("1").gameObject);
                // 포션 정보 삭제
                itemList[1] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(-0.15f);
            }
            if (itemList[1] == ITEM.CLEARPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("1").gameObject);
                // 포션 정보 삭제
                itemList[1] = ITEM.NUM;
                // 포션 효과 사용
                // 클리어 팝업 등장
                if (GameManager.instance.stageLevel < 2)
                    GameManager.instance.clearUI.SetActive(true);
                else
                    GameManager.instance.EndingUI.SetActive(true);
            }
            if (itemList[1] == ITEM.SMALLPOTION)
            {
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("1").gameObject);
                // 포션 정보 삭제
                itemList[1] = ITEM.NUM;
                // 포션 효과 사용
                GameObject.Find("Player").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                audioSource.clip = dirnkingSound;
                audioSource.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (itemList[2] == ITEM.HEALPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("2").gameObject);
                // 포션 정보 삭제
                itemList[2] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(0.25f);
            }

            if (itemList[2] == ITEM.POISONPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("2").gameObject);
                // 포션 정보 삭제
                itemList[2] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(-0.15f);
            }
            if (itemList[2] == ITEM.CLEARPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("2").gameObject);
                // 포션 정보 삭제
                itemList[2] = ITEM.NUM;
                // 포션 효과 사용
                // 클리어 팝업 등장
                Debug.Log(GameManager.instance.stageLevel);
                if (GameManager.instance.stageLevel < 2)
                    GameManager.instance.clearUI.SetActive(true);
                else
                    GameManager.instance.EndingUI.SetActive(true);
            }
            if (itemList[2] == ITEM.SMALLPOTION)
            {
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("2").gameObject);
                // 포션 정보 삭제
                itemList[2] = ITEM.NUM;
                // 포션 효과 사용
                GameObject.Find("Player").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                audioSource.clip = dirnkingSound;
                audioSource.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            if (itemList[3] == ITEM.HEALPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("3").gameObject);
                // 포션 정보 삭제
                itemList[3] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(0.25f);
            }

            if (itemList[3] == ITEM.POISONPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("3").gameObject);
                // 포션 정보 삭제
                itemList[3] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(-0.15f);
            }
            if (itemList[3] == ITEM.CLEARPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("3").gameObject);
                // 포션 정보 삭제
                itemList[3] = ITEM.NUM;
                // 포션 효과 사용
                // 클리어 팝업 등장
                if (GameManager.instance.stageLevel < 2)
                    GameManager.instance.clearUI.SetActive(true);
                else
                    GameManager.instance.EndingUI.SetActive(true);
            }
            if (itemList[3] == ITEM.SMALLPOTION)
            {
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("3").gameObject);
                // 포션 정보 삭제
                itemList[3] = ITEM.NUM;
                // 포션 효과 사용
                GameObject.Find("Player").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                audioSource.clip = dirnkingSound;
                audioSource.Play();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            if (itemList[4] == ITEM.HEALPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("4").gameObject);
                // 포션 정보 삭제
                itemList[4] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(0.25f);
            }

            if (itemList[4] == ITEM.POISONPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("4").gameObject);
                // 포션 정보 삭제
                itemList[4] = ITEM.NUM;
                // 포션 효과 사용
                this.game_status.addSatiety(-0.15f);
            }
            if (itemList[4] == ITEM.CLEARPOTION)
            {
                audioSource.clip = dirnkingSound;
                audioSource.Play();
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("4").gameObject);
                // 포션 정보 삭제
                itemList[4] = ITEM.NUM;
                // 포션 효과 사용
                // 클리어 팝업 등장
                if (GameManager.instance.stageLevel < 2)
                    GameManager.instance.clearUI.SetActive(true);
                else
                    GameManager.instance.EndingUI.SetActive(true);
            }
            if (itemList[4] == ITEM.SMALLPOTION)
            {
                // 포션 아이콘 삭제Destroy()
                //1. 역시 배열에 게임 오브젝트정보를 저장해서 관리
                Destroy(GameObject.Find("4").gameObject);
                // 포션 정보 삭제
                itemList[4] = ITEM.NUM;
                // 포션 효과 사용
                GameObject.Find("Player").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                audioSource.clip = dirnkingSound;
                audioSource.Play();
            }
        }


    }

    public void AddItem(ITEM item)
    {
        audioSource.clip = pickSound;
        audioSource.Play();
        for (int i = 0; i < itemSize; i++)
        {
            if (itemList[i] == ITEM.NUM)
            {
                itemList[i] = item;
                addUIImage(item, i);
                break;
            }
        }
    }

    // 다른 방식으로 구현
    public void DelItem(Vector3 pos)
    {
        for (int i = 0; i < itemSize; i++)
        {
            if (pos == GameObject.Find("box1").transform.position + new Vector3(0, -150 * i, 0))
            {
                itemList[i] = ITEM.NUM;
                break;
            }
        }
    }

    public void ReturnItem(Vector3 pos, ITEM item)
    {
        for (int i = 0; i < itemSize; i++)
        {
            if (pos == GameObject.Find("box1").transform.position + new Vector3(0, -150 * i, 0)
                && itemList[i] == ITEM.NUM)
            {
                itemList[i] = item;
                break;
            }

        }
    }

    public void addUIImage(ITEM item, int i)
    {
        GameObject newUI;

        if (item == ITEM.MUSHROOM)
            newUI = Instantiate(UIImage[0]);
        else if (item == ITEM.GEM)
            newUI = Instantiate(UIImage[1]);
        else if (item == ITEM.DANDELION)
            newUI = Instantiate(UIImage[2]);
        else if (item == ITEM.HEALPOTION)
            newUI = Instantiate(UIImage[3]);
        else if (item == ITEM.POISONPOTION)
            newUI = Instantiate(UIImage[4]);
        else if (item == ITEM.CLEARPOTION)
            newUI = Instantiate(UIImage[5]);
        else if (item == ITEM.EYE)
            newUI = Instantiate(UIImage[6]);
        else if (item == ITEM.MEAT)
            newUI = Instantiate(UIImage[7]);
        else if (item == ITEM.SMALLPOTION)
            newUI = Instantiate(UIImage[8]);
        else
            newUI = Instantiate(UIImage[0]);

        newUI.transform.parent = GameObject.Find("ItemBox").transform;
        newUI.transform.position = GameObject.Find("box1").transform.position + new Vector3(0, -150 * i, 0);
        newUI.GetComponent<ItemIcon>().SetInfo(GameObject.Find("box1").transform.position + new Vector3(0, -150 * i, 0), GameObject.Find("ItemBox").transform);
        newUI.gameObject.name = i.ToString();
    }

    public bool checkIsFull()
    {
        for (int i = 0; i < itemSize; i++)
        {
            if (itemList[i] == ITEM.NUM)
                return false; 
        }
        return true;
    }


    //합성 재료에 추가하고 현재 가방에서 삭제
    public Vector3 AddMixBox(ITEM item)
    {
        int i = 0;
        for (i = 0; i < mixSize; i++)
        {
            if (mixBoxList[i] == ITEM.NUM)
            {
                mixBoxList[i] = item;
                //위치 정해주기
                break;
            }
        }

        if(i == 0)
            return new Vector3(-100, 0, 0) + GameObject.Find("MixBox").transform.position;

        else if (i == 1)
            return new Vector3(100, 0, 0) + GameObject.Find("MixBox").transform.position;

        else
            return new Vector3(0, 0, 0);
    }

    public bool CheckMixBoxIsFull()
    {
        for (int i = 0; i < mixSize; i++)
        {
            if (mixBoxList[i] == ITEM.NUM)
                return false;
        }
        return true;
    }

    //지우는 과정에서 원래 아이템 리스트에 추가 기능도 추가? ㄴㄴ
    public void DelMixBoxList()
    {
        for (int i = 0; i < mixSize; i++)
        {
            if (mixBoxList[i] != ITEM.NUM)
            {
                mixBoxList[i] = ITEM.NUM;
                return;
            }
        }
    }

    public void SearchDelMixBoxList(Vector3 pos)
    {
        if (pos == new Vector3(-100, 0, 0) + GameObject.Find("MixBox").transform.position)
        {
            mixBoxList[0] = ITEM.NUM;
            return;
        }


        if (pos == new Vector3(100, 0, 0) + GameObject.Find("MixBox").transform.position)
        {
            mixBoxList[1] = ITEM.NUM;
            return;
        }
    }

    public bool CheckMixBoxIsEmpty()
    {
        print("mixBoxList : ");
        for (int i = 0; i < mixSize; i++)
        {
            print("mixBoxList[" + i + "] : " + mixBoxList[i]);
        }

        print("BoxList : ");
        for (int i = 0; i < itemSize; i++)
        {
            print("BoxList[" + i + "] : " + itemList[i]);
        }

        
        for (int i = 0; i < mixSize; i++)
        {
            if (mixBoxList[i] != ITEM.NUM)
                return false;
        }

        return true;
    }


    public void MakePotion()
    {
        numOfMush = 0;
        numOfGem = 0;
        numOfDan = 0;
        numOfEye = 0;
        numOfMeat = 0;

        // 소재 개수 확인
        for (int i = 0; i < mixSize; i++)
        {
            if (mixBoxList[i] == ITEM.MUSHROOM)
                numOfMush++;
            else if (mixBoxList[i] == ITEM.GEM)
                numOfGem++;
            else if (mixBoxList[i] == ITEM.DANDELION)
                numOfDan++;
            else if (mixBoxList[i] == ITEM.EYE)
                numOfEye++;
            else if (mixBoxList[i] == ITEM.MEAT)
                numOfMeat++;
        }

        if (numOfDan + numOfGem + numOfMush + numOfMeat + numOfEye <= 1)
            return;

        audioSource.clip = mixSound;
        audioSource.Play();

        int delSize = 0;

        // mix상자에 있는 재료 모두 삭제
        for (int i = 0; i < mixSize; i++)
        {
            if (mixBoxList[i] != ITEM.NUM)
            {
                //int numOfChild = GameObject.Find("UI").transform.childCount - 1;
                mixBoxList[i] = ITEM.NUM;
                delSize++;
                //Destroy(GameObject.Find("UI").transform.GetChild(numOfChild).gameObject);
            }
        }

        //ui의 자식이 0,1,2의 3개까지만 존재하도록하고 나머지 다 삭제
        for (int i = 1; i <= delSize; i++)
        {
            Destroy(GameObject.Find("UI").transform.GetChild(7 + i).gameObject);
        }


        if (GameManager.instance.stageLevel == 1)
        {
            ////소재에 따른 결과
            if (numOfMush == 1 && numOfGem == 1)
            {
                AddItem(ITEM.CLEARPOTION);
            }

            else if (numOfDan >= 1)
            {
                AddItem(ITEM.HEALPOTION);
            }

            else
            {
                AddItem(ITEM.POISONPOTION);
            }
        }

        if (GameManager.instance.stageLevel == 2)
        {
            ////소재에 따른 결과
            if (numOfEye >= 2)
            {
                AddItem(ITEM.CLEARPOTION);
            }

            else if (numOfDan >= 1)
            {
                AddItem(ITEM.HEALPOTION);
            }

            else if (numOfMush >= 1)
            {
                AddItem(ITEM.SMALLPOTION);
            }

            else
            {
                AddItem(ITEM.POISONPOTION);
            }
        }
    }
}
