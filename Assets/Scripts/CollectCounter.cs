using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class CollectCounter : MonoBehaviour
{
    public int count = 0;
    public TextMeshProUGUI CounterText;

    // Start is called before the first frame update
    void Start()
    {
      UpdateUI();  
    }

    public void AddItem()
    {
        count++;
        UpdateUI();
    }


    // Update is called once per frame
    void UpdateUI()
    {
       CounterText.text = "Found: " + count; 
    }
}
