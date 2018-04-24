using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    private bool isBreakingStuff;
    private Rigidbody2D rigid;


    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isBreakingStuff)
        {
            PoolInput();
        }
    }

    void PoolInput()
    {
        if (MobileInput.Instance.release)
        {
            SendBallInDirection(MobileInput.Instance.swipeDelta.normalized);
        }
    }

    void SendBallInDirection(Vector3 dir)
    {
        isBreakingStuff = true;
        rigid.velocity = dir * speed;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        isBreakingStuff = false;
        MobileInput.Instance.release = false;

        if (other.gameObject.CompareTag("BottomCollision"))
        {
            rigid.velocity = Vector3.zero;
        }
        else
        {
            Vector3 wallPoint = other.contacts[0].normal;
            Vector3 reflectDir = Vector3.Reflect(rigid.velocity.normalized, wallPoint);
            SendBallInDirection(reflectDir);
        }
    }
}
