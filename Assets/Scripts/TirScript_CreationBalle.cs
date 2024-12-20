﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TirScript_CreationBalle : MonoBehaviour
{
    /*#################################################
   -- variables publiques à définir dans l'inspecteur
   #################################################*/
    public GameObject balle; // Référence au gameObject de la balle
    public GameObject particuleBalle; // Référence au gameObject à activer lorsque le personnage tir
    public float vitesseBalle; // Vitesse de la balle

    public AudioClip sonTir;

    /*#################################################
   -- variables privées
   #################################################*/

    private bool peutTirer; // Est-ce que le personnage peut tirer
    private AudioSource audioSource; // Source audio pour jouer le son



    //----------------------------------------------------------------------------------------------
    void Start()
    {
        peutTirer = true; // Au départ, on veut que le personnage puisse tirer
        audioSource = GetComponent<AudioSource>();

    }
    //----------------------------------------------------------------------------------------------


    /*
     * Fonction Update. On appele la fonction Tir() lorsqu'il y a un clic gauche et que
     * le personnage peut tirer
     */
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && peutTirer)
        {
            Tir();
        }
     

    }
    //----------------------------------------------------------------------------------------------


    /*
     * Fonction Tir. Gère le tir d'une nouvelle balle.
     */
    void Tir()
    {
        /* On désactive la capacité de tirer et on appelle la fonction ActiveTir() après
         un délai de 0.1 seconde */
        peutTirer = false;
        


        /* --> partie à compléter...
         * 1. activation de la particuleBalle
         * 2. activation du son "Player GunShot". Que devez-vous ajouter au personnage pour qu'il puisse jouer un son?
         * 3. Création d'une copie de la balle à partir de la balle originale. La position et la rotation du clône
         * doivent être les mêmes que la balle originale.
         * 4. On active le clône. La balle originale doit rester désactivée.
         * 5. On applique une vélocité au clône. (velocité = transform.forward * vitesseBalle)
         * */

        particuleBalle.SetActive(true);
        GetComponent<AudioSource>().PlayOneShot(sonTir);

        GameObject balleCopie = Instantiate(balle);
        balleCopie.transform.position = balle.transform.position;
        balleCopie.transform.rotation = balle.transform.rotation;
        balleCopie.SetActive(true);

        balleCopie.GetComponent<Rigidbody>().velocity = transform.forward * vitesseBalle;

        Invoke("ActiveTir", 0.1f);

    }
    //----------------------------------------------------------------------------------------------


    /*
     * Fonction ActiveTir(). Réactive la capacité de tirer.
     */

    void ActiveTir()
    {
        /* --> partie à compléter...
         * 1. On réactive la capacité de tirer... variable peutTirer...
         * 2. On désactive la particule particuleBalle
         * */
        peutTirer = true;
        particuleBalle.SetActive(false);

    }
}

