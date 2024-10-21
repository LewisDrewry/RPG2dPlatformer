using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // ‘Text’ needs to reference the UnityEngine.UI library

public class GameManager : MonoBehaviour
{
    public int coinsCounter = 0;
    public Text coinText;

    void Update()
    {
        coinText.text = coinsCounter.ToString();
    }
}
