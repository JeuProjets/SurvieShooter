using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionMusique : MonoBehaviour
{
    public static GestionMusique instance;
    public static bool dontDestroyDejaFait = false;

    void Start()
    {
        if(dontDestroyDejaFait == false)
        {
            DontDestroyOnLoad(gameObject);
            dontDestroyDejaFait = true;
        }
        else
        {
            Destroy(gameObject);
        }

    }

}
