using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleUIManager : MonoBehaviour
{
    public GameObject Tutorail1;
    public GameObject Tutorial2;

    void Awake()
    {
        Screen.SetResolution(1920, 1080, true);
    }
    public void TutorialOn()
    {
        Tutorail1.gameObject.SetActive(true);
        Tutorial2.gameObject.SetActive(true);
    }

    public void exitUIWiondow()
    {
        if (GameObject.Find("Tutorial1"))
        {
            GameObject.Find("Tutorial1").gameObject.SetActive(false);
            return;
        }

        if (GameObject.Find("Tutorial2"))
        {
            GameObject.Find("Tutorial2").gameObject.SetActive(false);
            return;
        }
    }
}
