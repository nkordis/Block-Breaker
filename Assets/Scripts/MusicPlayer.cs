using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    private void Awake()
    {
        Debug.Log("Awake object " + GetInstanceID());
        if (instance != null)
        {


            Debug.Log("About to Destroy object " + GetInstanceID());
            Destroy(gameObject);
            Debug.Log("Object self destroyed");
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }

    }

    // Use this for initialization
    void Start () {
        Debug.Log("Start object " + GetInstanceID());
        }
	
	// Update is called once per frame
	void Update () {
		
	}
}
