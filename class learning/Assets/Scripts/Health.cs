using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealth;
    public Image healthBar;

    private float currentHealth = 0;

    public static Health Instance { get; private set; }

    private void Awake() //singleton variable
    {
        // set our singleton value
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            enabled = false;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.fillAmount = currentHealth / maxHealth;
    }

    public void TakeDamage(float amount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= amount;
            Debug.Log("current health is now" + currentHealth);
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex); // we perish
            }
            // subtract health from health bar
            healthBar.fillAmount = currentHealth / maxHealth;
        }
        Debug.Log("Took Damage");
    }
}
