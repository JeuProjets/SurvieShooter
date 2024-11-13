using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateurEnnemis : MonoBehaviour
{
    public GameObject zomBear;
    public GameObject zomBunny;
    public GameObject hellephant;
    public Transform[] pointsDeSpawn; // Points de spawn pour les ennemis

    void Start()
    {
        InvokeRepeating("GenererEnnemiFaible", 2.0f, 2.0f);
        InvokeRepeating("GenererEnnemiResistant", 5.0f, 5.0f);
    }

    void GenererEnnemiFaible()
    {
        GameObject ennemiFaible = Random.value > 0.5f ? zomBear : zomBunny;
        Transform pointDeSpawn = pointsDeSpawn[Random.Range(0, pointsDeSpawn.Length)];
        Instantiate(ennemiFaible, pointDeSpawn.position, Quaternion.identity);
    }

    void GenererEnnemiResistant()
    {
        Transform pointDeSpawn = pointsDeSpawn[Random.Range(0, pointsDeSpawn.Length)];
        Instantiate(hellephant, pointDeSpawn.position, Quaternion.identity);
    }
}
