using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : SteerableBehaviour, IShooter, IDamageable
{
    private int lifes;
    public GameObject tiro;
    GameManager gm;

    public void Shoot()
    {
        if (gm.gameState == GameManager.GameState.GAME) {
            Instantiate(tiro, transform.position, Quaternion.identity);
        }
    }

    private void Start()
    {
        lifes = 3;
        gm = GameManager.GetInstance();
    }

    public void TakeDamage()
    {
        lifes--;
        if (lifes <= 0) Die();
        gm.points += 100;
        if (gm.points >= 10000 && gm.gameState == GameManager.GameState.GAME)
        {
            gm.ChangeState(GameManager.GameState.ENDGAME);
        }
    }

    public void Die()
    {
        Destroy(gameObject);        
    }

    float angle = 0;

    private void FixedUpdate()
    {
        if (gm.gameState == GameManager.GameState.GAME)
        {
            angle += 0.1f;
            Mathf.Clamp(angle, 0.0f, 2.0f * Mathf.PI);
            float x = Mathf.Sin(angle);
            float y = Mathf.Cos(angle);
            Thrust(x, y);

        }
        else
        {
            Thrust(0.0f, 0.0f);
        }

    }
}
