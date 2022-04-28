using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{

    public int food, happiness, energy;

    [SerializeField] GameObject happyState;
    [SerializeField] GameObject sleepyState;
    [SerializeField] GameObject bathState;


    SceneLoader sceneLoader;
    private void Awake()
    {
        food = 100;
        happiness = 100;
        energy = 100;

        sceneLoader = FindObjectOfType<SceneLoader>();
        GameObject[] objs = GameObject.FindGameObjectsWithTag("pet");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);


        HappyOnStart();
    }


    public void Die()
    {
        Debug.Log("Dead");
    }


    public void HappyOnStart()
    {
        happyState.SetActive(true); 
    }

    public void HappyOnExit()
    {
        happyState.SetActive(false);
    }

   
    public void SleepStatefromHappy()
    {
        HappyOnExit();
        SleepOnEnter();     
    }

    public void SleepOnEnter()
    {
        sceneLoader.LoadSleepScene();
        sleepyState.SetActive(true);
    }

   




}
