using UnityEngine;

public class MobileInput : MonoSingleton<MobileInput>
{
    public bool tap, release, hold;
    public Vector2 swipeDelta;

    private Vector2 initialPos;

    void Start()
    {
    }

    void Update()
    {
//        release = false;
        if (Input.GetMouseButtonDown(0))
        {
            release = false;
            initialPos = Input.mousePosition;
//            hold = tap = true;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            release = true;
            swipeDelta = (Vector2) Input.mousePosition - initialPos;
        }
//        if (release)
//        {

//        }
    }
}
