using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
<<<<<<< HEAD
    public bool button = false;
=======
    bool button;
>>>>>>> afba1359ac10af9534e3838e5a2054fb99759dfd
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

<<<<<<< HEAD
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("pusher")) button = true;
=======
    void FixedUpdate()
    {
        button = false;
    }

    void OnCollisionStay2D(Collision2D other)
    {
        button = true;
>>>>>>> afba1359ac10af9534e3838e5a2054fb99759dfd
    }
}
