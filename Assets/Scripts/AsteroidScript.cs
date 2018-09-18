using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour {

    public int damageAmount;
    private float damageRate = 1;
    private float lastHurtTime = float.MinValue;
    AudioSource audioData;
    AudioClip m_AudioClip;
    // Use this for initialization
    void Start () {
        gameObject.GetComponent<Rigidbody2D>().AddForce(Random.insideUnitCircle * 200);
        gameObject.GetComponent<Rigidbody2D>().AddTorque(20 * Random.Range(-15, 15));
        audioData = GetComponent<AudioSource>();
        m_AudioClip = audioData.clip;
    }
	
	void Update()
    {
        if (GetComponent<Health>().IsDead())
        {
            if (!audioData.isPlaying)
            {
                audioData.Play();
                Debug.Log("Got here");
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                gameObject.GetComponent<CircleCollider2D>().enabled = false;
                Destroy(gameObject, m_AudioClip.length);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (Input.GetKey(KeyCode.R))
            {
                Debug.Log("Got Here");
            }
            else
            {
                if (Time.time - (1 / damageRate) > lastHurtTime)
                {
                    col.gameObject.GetComponent<Health>().ChangeHealth(-damageAmount);
                    lastHurtTime = Time.time;
                }
            }
        }
    }
}
