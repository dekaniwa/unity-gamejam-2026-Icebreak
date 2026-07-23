using UnityEngine;

public class Base : MonoBehaviour
{
    public GameObject applePrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("納品開始！");

            for (int i = 0; i < Inventory.Instance.apple; i++)
            {
                Vector3 pos = transform.position + new Vector3(
                    Random.Range(-1f, 1f),
                    0.5f,
                    Random.Range(-1f, 1f)
                );

                GameObject apple = Instantiate(applePrefab, pos, Quaternion.identity);

                Rigidbody rb = apple.GetComponent<Rigidbody>();

                if (rb != null)
                {
                    Vector3 force = new Vector3(
                        Random.Range(-3f, 3f),
                        5f,
                        Random.Range(-3f, 3f)
                    );

                    rb.AddForce(force, ForceMode.Impulse);
                }
            }
        }
    }
}
