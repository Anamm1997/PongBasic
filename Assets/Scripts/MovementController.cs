using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementController : MonoBehaviour {

    public float Speed = 7.0f;
    public float WallOffset = 1.3f;

    Rigidbody2D rb;
    float screenHeight;
	
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        screenHeight = Camera.main.orthographicSize - WallOffset;
	}

    public void MoveIn(Vector2 input)
    {
        
        var dir = (Vector2)(transform.position + (Vector3)(input * Speed * Time.fixedDeltaTime));
        if (dir.y < screenHeight && dir.y > -screenHeight)
        {
            rb.velocity = input * Speed;
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
        
    }

}
