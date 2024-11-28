using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class AfficherPointageFinal : MonoBehaviour
{

    public TMP_Text annoncerPointage;
    void Start()
    {
    }

    void Update()
    {

        AfficherPointage();
    }

    private void AfficherPointage()
    {
        annoncerPointage.text = "Tu as " + GestionPointage.pointage.ToString() + " points";

    }

}
