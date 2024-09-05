using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField] private Rigidbody _projectile;
    [SerializeField] private Transform _launchPoint;
    [SerializeField] private SpringJoint _springJoint;

    private float _launchForce = 10f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchProjectile();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetCatapult();
        }
    }

    private void LaunchProjectile()
    {
        Rigidbody newProjectile = Instantiate(_projectile, _launchPoint.position, _launchPoint.rotation);
        newProjectile.AddForce(_launchPoint.forward * _launchForce, ForceMode.Impulse);
        _springJoint.spring = 50;
    }

    private void ResetCatapult()
    {
        _springJoint.spring = 0; 
    }
}
