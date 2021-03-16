using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolantBehaviour : SteerableBehaviour, IDamageable
{
    float angle = 0;
    private int lifes;
    GameManager gm;

    private void Start()
    {
        lifes = 1;
        gm = GameManager.GetInstance();
    }

    public void TakeDamage()
    {
        lifes--;
        if (lifes <= 0) Die();
        if (gm.points >= 10000 && gm.gameState == GameManager.GameState.GAME)
        {
            gm.ChangeState(GameManager.GameState.ENDGAME);
        }
    }

    public void Die()
    {
        gm.points += 50;
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        

        if (gm.gameState == GameManager.GameState.GAME)
        {
            angle += 0.1f;
            if (angle > 2.0f * Mathf.PI) angle = 0.0f;
            Thrust(0, Mathf.Cos(angle));

        }
        else
        {
            Thrust(0.0f, 0.0f);
        }
    }
}
