using UnityEngine;

public class Atirador : MonoBehaviour
{
    public GameObject projetil;
    public Transform pontoSuperior;
    public Transform pontoInferior;
    public AudioSource tiroSom; // Referência ao componente AudioSource para o som do tiro
    public float intervaloTiro = 0.2f;

    private float proximoTiro;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= proximoTiro)
        {
         tiroSom.Play(); // Toca o som do tiro
            proximoTiro = Time.time + intervaloTiro;

            Instantiate(projetil, pontoSuperior.position, transform.rotation);
            Instantiate(projetil, pontoInferior.position, transform.rotation);
        }
    }
}