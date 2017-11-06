using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public static PlayerController Instance;

    public float moveSpeed = 500f;

    private Rigidbody2D playerRigidBody;
    private Animator playerAnimator;

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }


    // Use this for initialization
    void Start () {
        playerRigidBody = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();

	}
	
	// Update is called once per frame
	void Update () {
        //LEFT RIGHT MOVE
		if(Input.GetAxisRaw("Horizontal") != 0f)
        {
            playerRigidBody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, playerRigidBody.velocity.y);
        }
        else
        {
            playerRigidBody.velocity = new Vector2(0f, playerRigidBody.velocity.y);
        }

        //TOP DOWN MOVE
        if(Input.GetAxisRaw("Vertical") != 0f)
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime);
        }
        else
        {
            playerRigidBody.velocity = new Vector2(playerRigidBody.velocity.x, 0f);
        }
	}
}
