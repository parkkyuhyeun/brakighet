using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
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
}
