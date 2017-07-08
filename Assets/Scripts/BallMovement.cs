using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallMovement : MonoBehaviour {

    public float Speed = 7f;
    public Rigidbody2D rb;

    Vector2 dir;

	void Start () {
        dir = new Vector2(Random.Range(0, 2)+.5f, Random.Range(0, 2)+.5f);
        rb.velocity = dir.normalized * Speed;
    }
	

	void FixedUpdate () {
        
	}
}
