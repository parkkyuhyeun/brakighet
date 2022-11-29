using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public static bool isPause = false;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private float amount = 0;
    public float Amount { get => amount; set => amount = value; }

    private float combat = 0;
    public float Combat { get => combat; set => combat = value; }

    private int upgradePoint = 0;
    public int UpgradePoint { get => upgradePoint; set => upgradePoint = value; }
}
