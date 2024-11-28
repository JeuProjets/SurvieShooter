using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GestionPointage : MonoBehaviour
{
    public static float pointage;
    public static bool jeuTerminer;

    public TMP_Text textePointage;


    void Start()
    {
        pointage = 0;
        jeuTerminer = false;
    }

    void Update()
    {

        MettreAJourPointage();


    }

    private void MettreAJourPointage()
    {
        textePointage.text = pointage.ToString();

    }

}
