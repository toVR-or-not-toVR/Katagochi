using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetManager : MonoBehaviour
{
    
    
    public NeedsController needsController;

    public static PetManager instance;

    [SerializeField] Sprite sadBunny;
    [SerializeField] SpriteRenderer bunnyPlayScene;
    [SerializeField] Sprite happyBunny;

    private void Awake()
    {

        PetInf.food = 100;
        PetInf.happy = 100;
        PetInf.energy = 100;

        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one PetManager in the scene");
        

    }
    public void Die()
    {
        Debug.Log("Dead");
    }

    void Update()
    {

    }

    public void LoadSadBunny()
    {
        bunnyPlayScene.sprite = sadBunny;
    }

    public void LoadHappyBunny()
    {
        bunnyPlayScene.sprite = happyBunny;
    }

}
