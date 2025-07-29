using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f; // velocidade que o obst�culo anda para a esquerda

    void Update()
    {
        // Move o obst�culo para a esquerda todo frame
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Se o obst�culo sair da tela (x < -10), destr�i para liberar mem�ria
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
