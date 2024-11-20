using UnityEngine;

namespace DDREAMS.CORE
{
    [RequireComponent(typeof(GameObject))]
    public class RotateAroundAxis : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("Axis to rotate around. Each value represents the number of degrees per second. Default: 30 degrees per second on the y-axis.")]
        private Vector3 _RotationAxis = new(0.0f, 30.0f, 0.0f);

        [SerializeField]
        [Tooltip("Rotate around the global (world) axis or the local (self) axis. Default: local.")]
        private bool _GlobalRotation = false;

        private void Update()
        {
            float time = Time.deltaTime;

            transform.Rotate(_RotationAxis.x * time, _RotationAxis.y * time, _RotationAxis.z * time, _GlobalRotation ? Space.World : Space.Self);
        }
    }
}
