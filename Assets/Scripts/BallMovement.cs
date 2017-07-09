using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class BallMovement : MonoBehaviour {

    public float Speed = 7f;
    public int[] Scores;

    Rigidbody2D rb;
    Vector2 dir;

	void Start () {
        rb = GetComponent<Rigidbody2D>();

        Scores = new int[2] { 0, 0 };

        SetCourse();
    }

    private void SetCourse()
    {
        transform.position = Vector3.zero;

        var x = Random.Range(-.5f,.5f) + .1f;
        var y = Random.Range(-.5f, .5f) + .1f;

        dir = new Vector2(x, y);

        rb.velocity = dir.normalized * Speed;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "P1")
        {
            Reset(0);
        }
        else if (col.tag == "P2")
        {
            Reset(1);
        }
    }

    void Reset(int winner)
    {
        if (winner >= 0 && winner < Scores.Length)
        {
            Scores[winner]++;
        }
        else
        {
            Debug.LogError("Invalid Winner Index." + winner.ToString());
        }

        SetCourse();
    }
}
