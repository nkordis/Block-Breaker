using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Level : MonoBehaviour {

    //parameters
    [SerializeField] int breakableBlocks = 0; //SerializeField for debugging

    //cached reference
    SceneLoader sceneLoader;

    // Use this for initialization
    void Start () {
      //  breakableBlocks = 0;
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;
    }

    public void RemoveBlock()
    {
        breakableBlocks--;
        if (breakableBlocks == 0)
        {
            sceneLoader.LoadNextScene();
        }
    }


}
