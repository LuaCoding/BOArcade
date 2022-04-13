using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loadingbutton : MonoBehaviour
{
    public GameObject background;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //MainMenu..SetActive(false);
    }
    public void whenButtonClicked()
    {
        if (background.activeInHierarchy == true)
            background.SetActive(false);
        else
            background.SetActive(true);
    }
}
