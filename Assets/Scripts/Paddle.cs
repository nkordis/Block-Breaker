using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] float screenWidthInUnits = 9f; //16f
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 8f; //15f

    //cashed references
    GameSession theGameSession;
    Ball theBall;

    void Start () {
        theGameSession = FindObjectOfType<GameSession>();
        theBall = FindObjectOfType<Ball>();
		}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("mouse: "+Input.mousePosition.x/Screen.width * screenWidthInUnits);
        Debug.Log("paddle: "+transform.position.x);
        // float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
       paddlePos.x = Mathf.Clamp(GetXPos(), minX, maxX);
       transform.position = paddlePos;
	}

    private float GetXPos()
    {
        if (theGameSession.IsAutoPlayEnabled())
        {
            return theBall.transform.position.x;
        }
        else
        {
            return Input.mousePosition.x / Screen.width * screenWidthInUnits;
           
        }
    }
}
