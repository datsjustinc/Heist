using UnityEngine;
using UnityEngine.Serialization;

namespace VLB_Samples
{
    public class Rotater : MonoBehaviour
    {
        [FormerlySerializedAs("m_EulerSpeed")]
        public Vector3 EulerSpeed = Vector3.zero;
        public bool left;

        void Start()
        {
            left = true;
        }
        void Update()
        {
            var euler = transform.rotation.eulerAngles;

            if (transform.rotation.eulerAngles.y > 35)
            {
                left = false;
            }

            if (transform.rotation.eulerAngles.y > 100)
            {
                left = true;
            }

            if (left)
            {
                euler += (EulerSpeed * Time.deltaTime);
            }

            if (!left)
            {
                euler -= (EulerSpeed * Time.deltaTime);
            }

            transform.rotation = Quaternion.Euler(euler);
        }
    }
}
