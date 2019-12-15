using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;
    public int currentHealth;
    public Slider healthSlider;
    public Image damageImage;
    public AudioClip deathClip;
    public float flashSpeed = 5f;
    public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    public GameObject tiro;
    Animator anim;
    AudioSource playerAudio;
    PlayerMovement playerMovement;
    Shooter shooter;
    //PlayerShooting playerShooting;
    public bool isDead;
    bool damaged;


    void Awake ()
    {
        anim = GetComponent <Animator> ();
        playerAudio = GetComponent <AudioSource> ();
        playerMovement = GetComponent <PlayerMovement> ();
        //playerShooting = GetComponentInChildren <PlayerShooting> ();
        currentHealth = startingHealth;
        shooter = tiro.GetComponent<Shooter>();
        
    }


    void Update ()
    {
        if(damaged || isDead)
        {
            damageImage.color = flashColour;
        }
        else if(!isDead)
        {
            damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
        }
        damaged = false;
    }


    public void TakeDamage (int amount)
    {
        damaged = true;

        currentHealth -= amount;

        healthSlider.value = currentHealth;

        playerAudio.Play ();

        if(currentHealth <= 0 && !isDead)
        {
            Death ();
        }
    }


    void Death ()
    {
        damageImage.color = flashColour;
        isDead = true;

        //playerShooting.DisableEffects ();


        playerAudio.clip = deathClip;
        playerAudio.Play ();

        shooter.enable = false;
        //playerShooting.enabled = false;
    }


    
}
