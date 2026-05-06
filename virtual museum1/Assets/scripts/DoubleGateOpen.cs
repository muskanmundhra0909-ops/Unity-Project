using UnityEngine;

public class DoubleGateOpen : MonoBehaviour
{
    public Transform leftGate;
    public Transform rightGate;

    public float moveDistance = 3f;
    public float speed = 2f;

    private Vector3 leftOpenPos;
    private Vector3 rightOpenPos;

    private bool openGate = false;

    void Start()
    {
        leftOpenPos = leftGate.position + Vector3.left * moveDistance;
        rightOpenPos = rightGate.position + Vector3.right * moveDistance;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            openGate = true;
        }

        if (openGate)
        {
            leftGate.position = Vector3.MoveTowards(
                leftGate.position,
                leftOpenPos,
                speed * Time.deltaTime
            );

            rightGate.position = Vector3.MoveTowards(
                rightGate.position,
                rightOpenPos,
                speed * Time.deltaTime
            );
        }
    }
}