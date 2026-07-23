using UnityEngine;

public class Apple : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("当たった！");
        if (other.CompareTag("Player"))
        {
           Inventory.Instance.AddApple();

            Destroy(gameObject);
        }
    }
    
    
}
