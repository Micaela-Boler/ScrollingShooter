using UnityEngine;

public class Bala : MonoBehaviour
{
    [SerializeField] float velocidad;
    Rigidbody2D _rbBala;


    void Awake()
    {
        _rbBala = GetComponent<Rigidbody2D>();
    }

    
    public void LaunchBullet(Vector2 direction)
    {
        _rbBala.velocity = direction * velocidad;

        Destroy(this.gameObject, 3f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
