using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonClick : MonoBehaviour
{

    public GameObject mainmenu;
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
            if(mainmenu.activeInHierarchy == true)
                mainmenu.SetActive(false);
            else
                mainmenu.SetActive(true);
    }
}
