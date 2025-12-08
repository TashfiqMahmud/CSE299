using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [Header("Speed Settings")]
    public float forwardSpeed = 10f;
    public float laneSpeed = 10f;
    public float laneLimit = 100f;
    public float forwardLimit = 100f;

    [Header("Jump Settings")]
    public float jumpForce = 0.8f;

    [Header("Ground Check")]
    public float groundCheckDistance = 0.2f;
    public LayerMask groundLayer;

    [Header("UI")]
    public TMP_Text bumpText;               
    public int maxBumps = 5;                
    public GameObject gameOverPanel;       
    public GameObject gameOverTimerPanel;   

    private Rigidbody rb;
    private bool isBlocked = false;
    private int bumpCount = 0;

    void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);

        rb = GetComponent<Rigidbody>();
        if (rb == null) Debug.LogError("PlayerController requires a Rigidbody!");

        rb.interpolation = RigidbodyInterpolation.Interpolate;
        rb.constraints = RigidbodyConstraints.FreezeRotation;

     
        UpdateBumpUI();

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        if (gameOverTimerPanel != null)
            gameOverTimerPanel.SetActive(false);
    }

    void FixedUpdate()
    {
        float moveHorizontal = 0f;
float moveForward = 0f;

if (Input.GetKey(KeyCode.W)) moveForward = 0.8f;
if (Input.GetKey(KeyCode.S)) moveForward = -0.8f;


if (Input.GetKey(KeyCode.A)) moveHorizontal = -0.35f;
if (Input.GetKey(KeyCode.D)) moveHorizontal = 0.35f;


        if (isBlocked) moveForward = 0;

        Vector3 movement = (transform.forward * moveForward * forwardSpeed) +
                           (transform.right * moveHorizontal * laneSpeed);

        movement.y = rb.velocity.y;
        rb.velocity = movement;

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -laneLimit, laneLimit);
        pos.z = Mathf.Clamp(pos.z, -forwardLimit, forwardLimit);
        transform.position = pos;

        if (isBlocked && Mathf.Abs(moveHorizontal) > 0.1f)
            isBlocked = false;
    }

    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            Jump();
        }
    }

    bool IsGrounded()
    {
       
        return Physics.Raycast(transform.position, Vector3.down, groundCheckDistance + 0.01f, groundLayer);
    }

    public void Jump()
    {

        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
     
        if (collision.collider.CompareTag("Obstacle"))
        {
            isBlocked = true;
            rb.velocity = new Vector3(0, rb.velocity.y, 0);

            bumpCount++;
            UpdateBumpUI();

            if (AudioManager.instance != null)
                AudioManager.instance.Play("bump");

            if (bumpCount >= maxBumps)
                GameOver();
        }
    }

    void UpdateBumpUI()
    {
        if (bumpText != null)
            bumpText.text = bumpCount.ToString();
    }

    void GameOver()
    {
        Debug.Log("Game Over!");

        if (gameOverPanel != null)
            gameOverPanel.SetActive(true);

        if (AudioManager.instance != null)
            AudioManager.instance.Play("lostsound");

        Time.timeScale = 0f;
    }

    public void GameOverFromTimer()
    {
        Debug.Log("Game Over from timer!");

        if (gameOverTimerPanel != null)
            gameOverTimerPanel.SetActive(true);

        if (AudioManager.instance != null)
            AudioManager.instance.Play("lostsound");

        Time.timeScale = 0f;
    }

    public void ResetPlayer()
    {
        bumpCount = 0;
        UpdateBumpUI();

        if (gameOverPanel != null)
            gameOverPanel.SetActive(false);

        if (gameOverTimerPanel != null)
            gameOverTimerPanel.SetActive(false);

        Time.timeScale = 1f;
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
    }
}

