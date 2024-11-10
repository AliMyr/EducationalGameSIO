using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 3f;

    void Start()
    {
        // ����� ������ �� ����� �� ���� "Player"
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (player != null)
        {
            // ����������� �������� ����� � ������
            Vector3 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
    }
}
