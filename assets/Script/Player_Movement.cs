

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{


    public static Player_Movement instance;

    public float playerSpeed;
  
    public float clampDistanceX;
    public Transform playerModelRoot;

    public CapsuleCollider myCollider;
    public FloatingJoystick joystickMove;

    public float jumpforce;
    private Vector3 jump;
    public float jumph;
  
    private bool isGround;
    Rigidbody rb;

    private Touch touch;
    public float swerveValue;
    private Vector3 myTouchPosition;

    public Animator anim;


    public bool jump_t = false;
    public bool slide = false;
    private Touch initialTouch = new Touch();
    private float distance = 0;
    private bool hasSwiped = false;
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        myCollider = GetComponent<CapsuleCollider>();
        // jump = new Vector3(0, jumph, 0);
        anim = GetComponent<Animator>();
        if (PlayerPrefs.GetInt("level_count") == 1)
        {
            playerSpeed = 4;
            AudioManager.instance.Play("Bg");
        }
        if (PlayerPrefs.GetInt("level_count") == 2)
        {
            playerSpeed = 5;
            AudioManager.instance.Play("Bg1");
        }
        if (PlayerPrefs.GetInt("level_count") == 3)
        {
            playerSpeed = 6;
            AudioManager.instance.Play("Bg2");
        }
        if (PlayerPrefs.GetInt("level_count") == 4)
        {
            playerSpeed = 7;
            AudioManager.instance.Play("Bg3");
        }
      
    }
    IEnumerator JumpController()
    {
        jump_t = true;
        yield return new WaitForSeconds(0.4f);
        jump_t = false;
    }
    IEnumerator SlideController()
    {
        slide = true;
        yield return new WaitForSeconds(0.5f);
        slide = false;
    }
    private void PlayerMovement()
    {
       float  h = Input.GetAxis("Horizontal")* 4 * Time.deltaTime;
       // transform.position = new Vector3(transform.position.x - joystickMove.Horizontal*0.05f, transform.position.y, transform.position.z);

        transform.Translate(h, 0, playerSpeed * Time.deltaTime);
        Vector3 playerPosition = playerModelRoot.localPosition;
        playerPosition.x = Mathf.Clamp(playerPosition.x, -clampDistanceX, clampDistanceX);
        playerModelRoot.localPosition = playerPosition;

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            jump_t = true;
            StartCoroutine(JumpController());
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            slide = true;
            StartCoroutine(SlideController());
        }


       

    }
    private void PlayerMovementor()
    {
        Vector3 runForward = -transform.forward * Time.deltaTime * playerSpeed;

        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                myTouchPosition = touch.deltaPosition;

                transform.position = new Vector3(transform.position.x - myTouchPosition.x * 0.1f*Time.deltaTime, transform.position.y, transform.position.z );

                Vector3 playerPosition = playerModelRoot.localPosition;
                playerPosition.x = Mathf.Clamp(playerPosition.x, -clampDistanceX, clampDistanceX);
                playerModelRoot.localPosition = playerPosition;
            }
        }
        foreach (Touch t in Input.touches)
        {
            if (t.phase == TouchPhase.Began)
            {
                initialTouch = t;
            }
            else if (t.phase == TouchPhase.Moved && !hasSwiped)
            {
                float deltaX = initialTouch.position.x - t.position.x;
                float deltaY = initialTouch.position.y - t.position.y;
                distance = Mathf.Sqrt((deltaX * deltaX) + (deltaY * deltaY));
                bool swipedSideWay = Mathf.Abs(deltaX) > Mathf.Abs(deltaY);

                if (distance > 100f)
                {
                    if (swipedSideWay && deltaX > 0)
                    {
                        // swiped left
                    }
                    if (swipedSideWay && deltaX <= 0)
                    {
                        // swiped right

                    }
                    if (!swipedSideWay && deltaY > 0)
                    {
                        // swiped down
                        slide = true;
                        StartCoroutine(SlideController());
                    }

                    if (!swipedSideWay && deltaY <= 0)
                    {
                        // swiped up
                        jump_t = true;
                        StartCoroutine(JumpController());
                    }

                    hasSwiped = true;
                }
            }
            else if (t.phase == TouchPhase.Ended)
            {
                initialTouch = new Touch();
                hasSwiped = false;
            }
        }


        transform.Translate(runForward);
    }

    void Update()
    {


       

        //if (rb.velocity.y >= 2.25)
        //{
        //if (joystickMove.Vertical == 1 && isGround)
        //{
        //    rb.AddForce(jump * jumpforce, ForceMode.Impulse);
        //    isGround = false;
        //    anim.SetBool("jump", true);
        //}
         

  
    }

    private void FixedUpdate()
    {
       PlayerMovement();
        // PlayerMovementor();
        if (jump_t == true)
        {
            anim.SetBool("jump", true);
            transform.Translate(0, 4f * Time.deltaTime, 0);
        }
        else if (jump_t == false)
        {
            anim.SetBool("jump", false);
        }

        if (slide == true)
        {
            anim.SetBool("slide", slide);
            transform.Translate(0, 0, 0f);
            myCollider.height = 1.4f;
        }
        else if (slide == false)
        {
            anim.SetBool("slide", slide);
            myCollider.height = 1.78f;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("spawn"))
        {
            GameManager.instance.spawnRoad_aftercollision();
        }
        if (other.gameObject.tag == "life")
        {
            Debug.Log("life");
            GameControll.instance.lifeless();

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacle")
        {
            Debug.Log("collide");
            GameControll.instance.lifebk();
            AudioManager.instance.Play("obstacle");
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + 3f);
        }
        //if (collision.gameObject.tag == "floor")
        //{
        //    isGround = true;
        //    Debug.Log("true");
        //    anim.SetBool("jump", false);
        //}
        
    }

}
