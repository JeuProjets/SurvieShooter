using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MortPersoScript : MonoBehaviour
{
    public Animator animatorPerso; // Référence à l'animator du joueur

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision infoCollisions)
    {
        if (infoCollisions.gameObject.CompareTag("ennemi"))
        {
            // Lancer l'animation de mort du joueur
            animatorPerso.SetTrigger("mort");

            // Définir la variable statique pour indiquer que la partie est terminée
            GestionPointage.jeuTerminer = true;
            

        }



    }
    public void RestartLevel()
    {
        SceneManager.LoadScene("SceneFinale");
        GestionPointage.jeuTerminer = false;
        GestionPointage.pointage = 0;

    }
}
