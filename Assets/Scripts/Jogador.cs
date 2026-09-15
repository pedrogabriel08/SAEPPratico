using UnityEngine;

public class Jogador : MonoBehaviour
{
    public float velocidade = 10f;
    public int VidaTotal = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float movimentoHorizontal = Input.GetAxis("Horizontal");
        float movimentoVertical = Input.GetAxis("Vertical");
        Vector3 movimento = new Vector3(movimentoHorizontal, movimentoVertical) * velocidade * Time.fixedDeltaTime;
        transform.Translate(movimento);
    }
    
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Inimigo"))
        {
            
        }
    }

    //public void shoot()
    //{
    //   Input.GetKeycodeDown(Space);
    //}
}
