using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    public GameObject Org;
    public GameObject Alt;

    void Start()
    {
        if(Alt.activeInHierarchy)
        {
            Org.SetActive(true);
            Alt.SetActive(false);
        }

        if(Alt.activeInHierarchy && Org.activeInHierarchy)
        {
            Org.SetActive(true);
            Alt.SetActive(false);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Surround();
        }
    }

    void Surround()
    {
        if(Org.activeInHierarchy)
        {
            Org.SetActive(false);
            Alt.SetActive(true);
            return;
        }

        if(Alt.activeInHierarchy)
        {
            Org.SetActive(true);
            Alt.SetActive(false);
            return;
        }
    }
}
