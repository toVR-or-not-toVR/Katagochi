using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private List<GameObject> enablePlayScene = new List<GameObject>();
    [SerializeField] private List<GameObject> disablePlayScene = new List<GameObject>();
    [SerializeField] private List<GameObject> enableBedroomScene = new List<GameObject>();
    [SerializeField] private List<GameObject> disableBedroomScene = new List<GameObject>();
    [SerializeField] private List<GameObject> enableBathScene = new List<GameObject>();
    [SerializeField] private List<GameObject> disableBathScene = new List<GameObject>();

    public void PlayScene()
    {

        foreach (var i in enablePlayScene)
        {
            i.SetActive(true);
        }

        foreach (var i in disablePlayScene)
        {
            i.SetActive(false);
        }

    }

    public void BedroomScene()
    {

        foreach (var i in enableBedroomScene)
        {
            Debug.Log(i.name);
            i.SetActive(true);
        }


        foreach (var i in disableBedroomScene)
        {
            i.SetActive(false);
        }

    }

    public void BathScene()
    {
        foreach (var i in enableBathScene)
        {
            i.SetActive(true);
        }

        foreach (var i in disableBathScene)
        {
            i.SetActive(false);
        }

    }



    private void ChangeScene(List<GameObject> enableGameObjects, List<GameObject> disableGameObjects)
    {
        
        foreach(var i in enableGameObjects)
        {
            i.SetActive(true);
        }

        foreach (var i in disableGameObjects)
        {
            i.SetActive(false);
        }
    }
}
