using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : SteerableBehaviour, IShooter, IDamageable
{
    GameManager gm;
    public GameObject bullet;
    public Transform arma01;
    public float shootDelay = 0.1f;
    private float _lastShootTimestamp = 0.0f;
    public AudioClip shootSFX;

    Animator animator;
    
    private void Start()
    {
        animator = GetComponent<Animator>();
        gm = GameManager.GetInstance();
    }

    public void Shoot()
    {
        if (Time.time - _lastShootTimestamp < shootDelay) return;
        AudioManager.PlaySFX(shootSFX);
        _lastShootTimestamp = Time.time;
        Instantiate(bullet, arma01.position, Quaternion.identity);
    }

    public void TakeDamage()
    {
        gm.lifes--;
        if (gm.lifes <= 0) Die();
    }

    public void Die()
    {
        gm.ChangeState(GameManager.GameState.ENDGAME);
    }

    void FixedUpdate()
    {
        if (gm.gameState == GameManager.GameState.GAME)
        {
            float yInput = Input.GetAxis("Vertical");
            float xInput = Input.GetAxis("Horizontal");
            Thrust(xInput, yInput);

            if (Input.GetAxisRaw("Fire1") != 0)
            {
                Shoot();
            }

            if (yInput != 0 || xInput != 0)
            {
                animator.SetFloat("Velocity", 1.0f);
            }
            else
            {
                animator.SetFloat("Velocity", 0.0f);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Inimigos"))
        {
            Destroy(collision.gameObject);
            TakeDamage();
        }
        if (collision.CompareTag("Asteroid"))
        {
            Destroy(collision.gameObject);
            TakeDamage();
            gm.points += 50;
        }
    }

    void Update()
    {
        if (gm.gameState == GameManager.GameState.ENDGAME)
        {
            transform.position = new Vector3(0.0f, -4.0f, 0.0f);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && gm.gameState == GameManager.GameState.GAME)
        {
            gm.ChangeState(GameManager.GameState.PAUSE);
        }
    }
}
