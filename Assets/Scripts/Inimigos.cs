using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public Transform player;
    public float velocidade = 5f;
    public Vector3 destino;
    public GameObject projétil;
    public Transform pontoTiro;
    public float intervaloTiro = 1f;
    private bool chegou;
    private float timer;
    void Update()
    {
        if (!chegou)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                destino,
                velocidade * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, destino) < 0.1f)
            {
                chegou = true;
            }
        }
        else
        {
            MirarPlayer();
            Atirar();
        }
    }

    void MirarPlayer()
    {
        Vector2 direcao = player.position - transform.position;
        float angulo = Mathf.Atan2(direcao.y, direcao.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angulo);
    }

    void Atirar()
    {
        timer += Time.deltaTime;

        if (timer >= intervaloTiro)
        {
            timer = 0;

            Instantiate(
                projétil,
                pontoTiro.position,
                pontoTiro.rotation
            );
        }
    }
}