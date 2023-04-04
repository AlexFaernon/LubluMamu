using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIInfo : MonoBehaviour
{ 
    private TMP_Text _countText;
    
    private void Awake()
    {
        _countText = GetComponent<TMP_Text>();
    }

    private void Update()
    {
        _countText.text = Gun.Count.ToString();
    }
}
