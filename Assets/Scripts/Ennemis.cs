using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Audio;

public class Ennemis : MonoBehaviour
{
    private NavMeshAgent navAgent;
    public GameObject cible; 

    public AudioClip sonMort; 
    private Animator animatorEnnemi; 

    // Start is called before the first frame update
    void Start()
    {
        
        animatorEnnemi = GetComponent<Animator>();
        navAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination = cible.transform.position;
        navAgent.SetDestination(destination);

        if(GestionPointage.jeuTerminer == true)
        {
            animatorEnnemi.SetTrigger("idle");
        }
    }

    public void Touche()
    {
        //GetComponent<AudioSource>().PlayOneShot(sonMort);
        animatorEnnemi.SetBool("mort", true);
        navAgent.speed = 0;
        gameObject.tag = "Untagged";
        Destroy(gameObject, 2f);
    }

}
