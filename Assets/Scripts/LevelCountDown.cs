using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelCountDown : MonoBehaviour {

    public float levelTime = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate()
    {
        levelTime -= Time.deltaTime; ;
        //levelTime--;
        gameObject.GetComponent<Text>().text = "Time: " + Mathf.Round(levelTime).ToString();

        if(levelTime <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
