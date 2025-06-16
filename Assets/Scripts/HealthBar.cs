using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    
    
    private float HP = 100f;
    public Image Bar;

    

    void Start()
    {
       
       
    }

    
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
             HP -= 40;
             Bar.fillAmount = HP / 100;
        }
       
    }
}
