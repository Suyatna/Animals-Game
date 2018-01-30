using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition_nama : MonoBehaviour {

    private GameObject[] Models;
    private int SelectionIndex = 0; //default index of model
    private int index;

    // Use this for initialization
    void Start()
    {
        Models = new GameObject[transform.childCount];

        for (int i = 0; i < transform.childCount; i++)
        {
            Models[i] = transform.GetChild(i).gameObject;
        }

        foreach (GameObject go in Models)
        {
            go.SetActive(false);
        }

        if (Models[0])
        {
            Models[0].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Prev()
    {
        Models[index].SetActive(false);

        index--;
        if (index < 0)
        {
            index = Models.Length - 1;
        }

        Models[index].SetActive(true);
    }

    public void Next()
    {
        Models[index].SetActive(false);

        index++;
        if (index == Models.Length)
        {
            index = 0;
        }

        Models[index].SetActive(true);
    }
}
