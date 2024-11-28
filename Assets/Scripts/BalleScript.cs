using System.Collections;
using System.Collections.Generic;
using UnityEditor.DeviceSimulation;
using UnityEngine;

public class BalleScript : MonoBehaviour
{
   
    public GameObject impactTir;
    public GameObject personnage;

    

    private void OnCollisionEnter(Collision infoCollisions)
    {
        if (infoCollisions.gameObject.CompareTag("ennemi"))
        {
            // Récupère le script Ennemis sur l'objet touché
            Ennemis ennemiScript = infoCollisions.gameObject.GetComponent<Ennemis>();
            ennemiScript.Touche();

            if (infoCollisions.gameObject.name.Contains("Hellephant"))
            {
                GestionPointage.pointage += 5;
           
            }
            else if (infoCollisions.gameObject.name.Contains("ZomBunny"))
            {
                GestionPointage.pointage += 2; 
                
            }
            else if (infoCollisions.gameObject.name.Contains("ZomBear"))
            {
                GestionPointage.pointage += 1; 
            }
        }
        


        //Création d'une copie de l'objet de particules
        GameObject particulesCopie = Instantiate(impactTir);

        //On place l'objet copié au point de contact de la collision
        particulesCopie.transform.position = infoCollisions.contacts[0].point;

        // On active l'objet copié
        particulesCopie.SetActive(true);

        // On oriente l'objet copié vers le personnage
        particulesCopie.transform.LookAt(personnage.transform);

        //On applique une légère correction de position
        particulesCopie.transform.Translate(0f, 0f, 1f);

        //On détruit l'objet copié après un délai d'une seconde
        Destroy(particulesCopie, 1f);

        //On détruit la balle
        Destroy(gameObject);
    }
}
