using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5;
    public float rotationSpd = 150;
    public GameObject laser;
    public float fireRate = 2;

    private float lastFireTime = float.MinValue;

    public float shieldUse = 0;
    public int ShieldUses = 3;

    AudioSource audioData;
	// Use this for initialization
	void Start () {
        Application.targetFrameRate = 60;
        audioData = GetComponent<AudioSource>();
	}
	
	// Examples for movement below
	void FixedUpdate () {
        //To get frame independant gameplay, factor in DeltaTime. Delta time checks how much time has passed since the last frame
        //
        
            Rigidbody2D rB = gameObject.GetComponent<Rigidbody2D>();
            
            rB.AddForce(Input.GetAxis("Vertical") * speed * gameObject.transform.right);
            rB.AddForce(Input.GetAxis("Horizontal") * speed * gameObject.transform.up);
        if (Input.GetKey(KeyCode.W))
        {
            
        }
        if (Input.GetKey(KeyCode.D))
        {
            
            rB.AddTorque(-rotationSpd);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rB.AddTorque(rotationSpd);
            
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ShieldUses > 0)
            {
                gameObject.GetComponentInChildren<CircleCollider2D>().enabled = true;
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                ShieldUses--;
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            //Realizing the issue of being able to hold shield forever, I added this basic clock to limit how long you can hold the shield
            shieldUse++;
            if(shieldUse > 100)
            {
                gameObject.GetComponentInChildren<CircleCollider2D>().enabled = false;
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                shieldUse = 0;
            }
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            gameObject.GetComponentInChildren<CircleCollider2D>().enabled = false;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

       
	}

    void Update()
    {
        if (laser == null)
        {
            Debug.Log("Need to give a laser game object");
        }
        //if (Input.GetAxis("Laser") > 0)
        //I prefer spam style shooting based on button input
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //Disallow the user to shoot while shielding
                Debug.Log("Nope");
            }
            else
            {

                if (Time.time - (1 / fireRate) > lastFireTime)
                {
                    GameObject obj = Instantiate(laser, transform.GetChild(0).position, transform.rotation);
                    //Removed this for sake of visual clarity
                    //obj.GetComponent<SpriteRenderer>().color = Random.ColorHSV(0, 1, 1, 1, 1,1,1,1);
                    lastFireTime = Time.time;
                    audioData.Play();
                }
            }
        }

    }
}
