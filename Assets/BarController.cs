using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarController : MonoBehaviour
{
    [SerializeField] private Image hungerImg;
    [SerializeField] private Image energyImg;
    [SerializeField] private Image happyImg;

 

    // Start is called before the first frame update
   

    public void UpdateHungerLevel(float level)
    {
        if (level > 0)
        {
            hungerImg.fillAmount = level / 100;
        }        
  
    }
    public void UpdateEnergyLevel(float level)
    {
        if (level > 0)
        {
            energyImg.fillAmount = level / 100;
        }

    }
    public void UpdateHappyLevel(float level)
    {
        if (level > 0)
        {
            happyImg.fillAmount = level / 100;
        }

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
