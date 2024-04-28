using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float speedX = 10f;
    public float speedY = 5f;
    public float dirX;
    public float dirY;
    public GameObject button;
    private SoundManager soundManager;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        soundManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<SoundManager>();
        soundManager.playSFX("blod1");
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.acceleration.x * speedX;
        dirY = Input.acceleration.y * speedY;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -14f, 14f), transform.position.y);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, dirY);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Collider")
        {
            soundManager.playSFX("blod2");
            button.SetActive(true);
        }
    }
}
