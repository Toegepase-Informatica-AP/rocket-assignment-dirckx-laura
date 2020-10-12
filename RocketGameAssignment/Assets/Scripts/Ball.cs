using System;
using UnityEngine;

namespace UnityStandardAssets.Vehicles.Ball
{
    public class Ball : MonoBehaviour
    {
        [SerializeField] private float m_MovePower = 5; // The force added to the ball to move it.
        [SerializeField] private bool m_UseTorque = true; // Whether or not to use torque to move the ball.
      
        [SerializeField] private float m_JumpPower = 2; // The force added to the ball when it jumps.

        private const float k_GroundRayLength = 1f; // The length of the ray to check if the ball is grounded.
        private Rigidbody m_Rigidbody;


        private void Start()
        {
            m_Rigidbody = GetComponent<Rigidbody>();
           
        }


        public void Move(Vector3 moveDirection, bool jump)
        {
           
                m_Rigidbody.AddForce(moveDirection*m_MovePower);
           
          
            if (Input.GetButton("Jump"))
            {
                m_Rigidbody.velocity = new Vector3(0f, m_JumpPower, 0f);
               
            }
        }
    }
}
