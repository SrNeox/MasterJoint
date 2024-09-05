using UnityEngine;

public class Swing : MonoBehaviour
{
    [SerializeField] private HingeJoint _hingeJoint;
    [SerializeField] private float _force = 10f;
    [SerializeField] private float _velocity = 100;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Push(_force, _velocity);
        }
        else
        {
            Push();
        }
    }

    private void Push(float force = 0, float velocity = 0)
    {
        _hingeJoint.useMotor = true;
        JointMotor jointMotor = _hingeJoint.motor;

        jointMotor.force = force;
        jointMotor.targetVelocity = velocity;
        _hingeJoint.motor = jointMotor;
    }
}
