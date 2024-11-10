using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        // �������� ���� �����
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // �������� �� ������������ � ������
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject); // ���������� �����
            Destroy(gameObject); // ���������� ����
        }
    }
}
