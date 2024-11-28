using UnityEngine;

public class GenererEnnemisScript : MonoBehaviour
{
    // Références aux préfabs des ennemis
    public GameObject zomBearPrefab;
    public GameObject zomBunnyPrefab;
    public GameObject hellephantPrefab;

    // Positions spécifiques pour chaque type d'ennemi
    public Transform apparitionZomBear;   // Position pour ZomBear
    public Transform apparitionZomBunny;  // Position pour ZomBunny
    public Transform apparitionHellephant; // Position pour Hellephant

    void Start()
    {
        // Appelle la fonction pour générer un ennemi faible (ZomBear ou ZomBunny) toutes les 2 secondes
        InvokeRepeating("GenererEnnemiFaible", 2f, 2f);

        // Appelle la fonction pour générer un ennemi fort (Hellephant) toutes les 5 secondes
        InvokeRepeating("GenererEnnemiFort", 5f, 5f);
    }

    void GenererEnnemiFaible()
    {
        // Choisir un ennemi faible au hasard (ZomBear ou ZomBunny)
        int randomIndex = Random.Range(0, 2); // 0 pour ZomBear, 1 pour ZomBunny

        GameObject ennemi = null;
        Transform spawnPoint = null;

        // Définir l'ennemi et la position en fonction du random
        if (randomIndex == 0)
        {
            ennemi = zomBearPrefab; 
            spawnPoint = apparitionZomBear; 
        }
        else
        {
            ennemi = zomBunnyPrefab;
            spawnPoint = apparitionZomBunny; 
        }

        // Instancier l'ennemi à la position spécifiée
        GameObject clone = Instantiate(ennemi, spawnPoint.position, Quaternion.identity);

        // Assurer que le clone est activé (au cas où il serait désactivé dans le préfabriqué)
        clone.SetActive(true);
    }

    void GenererEnnemiFort()
    {
        // Créer un Hellephant à la position spécifique de Hellephant
        GameObject clone = Instantiate(hellephantPrefab, apparitionHellephant.position, Quaternion.identity);

        // Assurer que le clone est activé
        clone.SetActive(true);
    }
}