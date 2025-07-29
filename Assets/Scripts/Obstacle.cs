using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float speed = 5f; // velocidade que o obstáculo anda para a esquerda

    void Update()
    {
        // Move o obstáculo para a esquerda todo frame
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        // Se o obstáculo sair da tela (x < -10), destrói para liberar memória
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
