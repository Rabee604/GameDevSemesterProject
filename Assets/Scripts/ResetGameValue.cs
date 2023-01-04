using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGameValue : MonoBehaviour
{
    [SerializeField] private FloatSO scoreSo;
    [SerializeField] private FloatSO healthSo; 
    [SerializeField] private FloatSO timeSo;
    // Start is called before the first frame update
    void Start()
    {
        

    }

    private void Awake()
    {
        scoreSo.Value = 0;
        healthSo.Value = 50;
        timeSo.Value = 120;
    }
}
