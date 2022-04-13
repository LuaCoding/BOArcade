using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionButton : MonoBehaviour
{
    public GameObject options;
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
        if (options.activeInHierarchy == false)
            options.SetActive(true);
        else
            options.SetActive(false);
    }
}
