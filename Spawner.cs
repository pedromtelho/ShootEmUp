using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject purpleEnemy;
    GameManager gm;
    int tamanho;
    int nEnemies = 1;
    int variante = 0;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GetInstance();
        if (gm.gameState == GameManager.GameState.GAME) {
            Instantiate(purpleEnemy, new Vector3(Random.Range(1.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0.0f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
            Instantiate(asteroid, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
        };
    }


    // Update is called once per frame
    void Update()
    {
        int tamanho = GameObject.FindGameObjectsWithTag("Asteroid").Length;
        if (tamanho < 5)
        {
            Instantiate(asteroid, new Vector3(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f), 0.0f), Quaternion.identity);
        }

        nEnemies = GameObject.FindGameObjectsWithTag("Inimigos").Length;
        if ((nEnemies < 1) && (variante == 0))
        {
            Instantiate(purpleEnemy, new Vector3(Random.Range(1.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0.0f), Quaternion.identity);
            Instantiate(purpleEnemy, new Vector3(Random.Range(1.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0.0f), Quaternion.identity);
            variante = 1;
        }
        if ((nEnemies < 1) && (variante == 1))
        {
            Instantiate(purpleEnemy, new Vector3(Random.Range(1.0f, 3.0f), Random.Range(-3.0f, 3.0f), 0.0f), Quaternion.identity);
            variante = 0;
        }
    }
}
