using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ITEM
{
    MUSHROOM, GEM, DANDELION, NUM, HEALPOTION, POISONPOTION, CLEARPOTION, EYE, MEAT, SMALLPOTION
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; set; }

    public int stageLevel;

    public GameObject clearUI;
    public GameObject failUI;
    public GameObject EndingUI;


    private void Awake()
    {
        if (instance == null) instance = this;
        else if (instance != this) Destroy(gameObject);
    }
}
