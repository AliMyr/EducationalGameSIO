using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // Движение пули вперёд
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Проверка на столкновение с врагом
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // Уничтожаем врага
            Destroy(gameObject); // Уничтожаем пулю
        }
    }
}
