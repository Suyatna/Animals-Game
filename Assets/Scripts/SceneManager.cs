using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeToMain()
    {
        Application.LoadLevel("main");
    }

    public void ChangeToBeranda()
    {
        Application.LoadLevel("beranda");
    }

    public void ChangeToAnimals_list()
    {
        Application.LoadLevel("Animals_list");
    }

    public void ChangeToPuzzle()
    {
        Application.LoadLevel("PM Sliding Pieces Example");
    }
}
