using UnityEngine;

public class SistemaDeTiro : MonoBehaviour
{
    public GameObject projetilPrefab;
    public int velocidadeProjetil = 10;
    public float tempoEntreTiros = 0.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Atirar()
    {
        GameObject projetil = Instantiate(projetilPrefab, transform.position, transform.rotation);
        Rigidbody rb = projetil.GetComponent<Rigidbody>();
        rb.linearVelocity = transform.forward * velocidadeProjetil;
        Destroy(projetil, 2f);
    }
}
