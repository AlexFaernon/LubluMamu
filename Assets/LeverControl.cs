using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverControl : MonoBehaviour
{
    [SerializeField] private bool isOn;
    [SerializeField] private Light component; 
    
    private void OnTriggerEnter(Collider other)
    {
        component.enabled = isOn;
    }
}
