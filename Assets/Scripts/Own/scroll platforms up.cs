using UnityEngine;

public class PlatformScroller : MonoBehaviour
{

    [SerializeField] private string[] Tags;
    public float scrollSpeed = 1;
    public float move = 1;

    void Update()
    {
        move = scrollSpeed;
        scrollSpeed = scrollSpeed + Time.deltaTime ;
        // Move the platform upwards over time
        transform.position += Vector3.left * move * Time.deltaTime;
	}
}
//change under 50 when goes over 50 
//if scrollspeed < 50 scrollSpeed == 50 