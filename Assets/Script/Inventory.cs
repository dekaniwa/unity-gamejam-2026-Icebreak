using UnityEngine;

public class Inventory : MonoBehaviour
{
 
        public static Inventory Instance;

        public int apple;
        public int mushroom;
        public int banana;

        void Awake()
        {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
        }

        public void AddApple()
        {
            apple++;
        }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
