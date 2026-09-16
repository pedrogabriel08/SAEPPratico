using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject inimigoPrefab;
    public Transform[] pontosSpawn;

    public int quantidadeInimigos = 1;

    private bool criandoWave = false;

    void Update()
    {
        GameObject[] inimigos =
            GameObject.FindGameObjectsWithTag("Enemy");

        if (inimigos.Length == 0 && !criandoWave)
        {
            StartCoroutine(CriarWave());
        }
    }

    IEnumerator CriarWave()
    {
        criandoWave = true;

        yield return new WaitForSeconds(2f);

        for (int i = 0; i < quantidadeInimigos; i++)
        {
            Transform spawn =
                pontosSpawn[Random.Range(0, pontosSpawn.Length)];

            Instantiate(
                inimigoPrefab,
                spawn.position,
                Quaternion.identity
            );
        }

        criandoWave = false;
    }
}