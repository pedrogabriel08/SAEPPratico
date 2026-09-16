using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float velocidade = 10f;
    public float tempoDeVida = 3f;

    void Start()
    {
        // Destrói o projétil após 'tempoDeVida' segundos para limpar a memória
        Destroy(gameObject, tempoDeVida);
    }

    void Update()
    {
        // Move o projétil para a frente (ou para a direita do eixo local)
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        // Aqui você coloca o que acontece ao atingir um inimigo
        Destroy(gameObject); // Destrói o projétil ao colidir
    }
}
