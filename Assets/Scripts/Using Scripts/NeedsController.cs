using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NeedsController : MonoBehaviour
{
    
    public int foodTickRate, happinessTickRate, energyTickRate;
    PetManager petManager;
    BarController barController;
    Pet pet;
    private bool _reduceFood;
    private bool _reduceHappy = false;
    private bool _reduceEnergy = false;


    private void Awake()
    {
        Debug.Log("Need" + gameObject.name);
        _reduceFood = true;
        barController = GetComponent<BarController>();
        pet = FindObjectOfType<Pet>();
        petManager = GetComponent<PetManager>();
        StartCoroutine(StartReduceCycle());
    }



    private void Update()
    {
 /*       if(TimingManager.gameHourTimer < 0)
        {
            ChangeFood(-foodTickRate);
            ChangeHappiness(-happinessTickRate);
            ChangeEnergy(-energyTickRate);
        }*/
    }

    public void ChangeFood(int amount)
    {
        PetInf.food += amount;
        isDead();
        barController.UpdateHungerLevel(PetInf.food);
        if (PetInf.food < 50) petManager.LoadSadBunny();
        if (PetInf.food > 100) PetInf.food = 100;
    }

    public void ChangeHappiness(int amount)
    {

        PetInf.happy += amount;
        isDead();
        barController.UpdateHappyLevel(PetInf.happy);
        if (PetInf.happy < 50) petManager.LoadSadBunny();
        if (PetInf.happy > 100) PetInf.happy = 100;
    }

    public void ChangeEnergy(int amount)
    {
        PetInf.energy += amount;
        isDead();
        barController.UpdateEnergyLevel(PetInf.energy);
        if (PetInf.energy < 50) petManager.LoadSadBunny();
        if (PetInf.energy > 100) PetInf.energy = 100;
    }

    IEnumerator StartReduceCycle()
    {
        while (true)
        {
            StartCoroutine(StartReduceFood());
            yield return new WaitUntil(() => _reduceFood == false);
            _reduceEnergy = true;
            StartCoroutine(StartReduceEnergy());
            yield return new WaitUntil(() => _reduceEnergy == false);
            _reduceHappy = true;
            StartCoroutine(StartReduceHappy());
            yield return new WaitUntil(() => _reduceHappy == false);
            _reduceFood = true;
        }

    }

    IEnumerator StartReduceFood()
    {
        while (_reduceFood)
        {
            yield return new WaitForSeconds(1);
            ChangeFood(-foodTickRate);
            if(PetInf.food <= 0)
            {
                _reduceFood = false;
            }
        }        
    }  
    IEnumerator StartReduceEnergy()
    {
        while (_reduceEnergy)
        {
            yield return new WaitForSeconds(1);
            ChangeEnergy(-energyTickRate);
            if(PetInf.energy <= 0)
            {
                _reduceEnergy = false;
            }
        }        
    }    
    
    IEnumerator StartReduceHappy()
    {
        while (_reduceHappy)
        {
            yield return new WaitForSeconds(1);
            ChangeHappiness(-happinessTickRate);
            if(PetInf.happy <= 0)
            {
                _reduceHappy = false;
            }
        }        
    }
    
    public void StopReduceFood()
    {
        _reduceFood = false;
    }

    public void StopReduceEnergy()
    {
        _reduceEnergy = false;
    }

    public void StopReduceHappy()
    {
        _reduceHappy = false;
    }


    void isDead()
    {
        if (PetInf.food <= 0 && PetInf.happy <= 0 && PetInf.energy <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene(4);
    }

}
