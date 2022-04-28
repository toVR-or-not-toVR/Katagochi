using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodAnimations : MonoBehaviour
{
    [SerializeField] private Animator anim;
    

    public void StartAnim()
    {

        anim.SetInteger("IndexFood", Random.Range(0, 4));
        anim.SetTrigger("New Trigger");
    }

}
