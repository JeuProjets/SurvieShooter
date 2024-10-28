using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalleScript : MonoBehaviour
{
    //Script à associer à la balle

    /*#################################################
    -- variables publiques à définir dans l'inspecteur
    #################################################*/
    public GameObject impactTir; // Référence au Prefab à instancier lorsque le tir frappe un objet. (Prefab ParticulesHit)
    public GameObject personnage; // Référence au personnage

    /*
     * Fonction OnCollisionEnter. Gère ce qui se passe lorsqu'une balle touche un objet.
     */
    private void OnCollisionEnter(Collision infoCollisions)
    {
        // 1. Création d'une copie de l'objet de particules
        GameObject particulesCopie = Instantiate(impactTir);

        // 2. On place l'objet copié au point de contact de la collision
        particulesCopie.transform.position = infoCollisions.contacts[0].point;

        // 3. On active l'objet copié
        particulesCopie.SetActive(true);

        // 4. On oriente l'objet copié vers le personnage (LookAt)
        particulesCopie.transform.LookAt(personnage.transform);

        // 5. On applique une légère correction de position
        particulesCopie.transform.Translate(0f, 0f, 1f);

        // 6. On détruit l'objet copié après un délai d'une seconde
        Destroy(particulesCopie, 1f);

        // 7. On détruit la balle (immédiatement)
        Destroy(gameObject);
    }
}
