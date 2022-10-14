using UnityEngine;

namespace CodeBase.Hero
{
    public class HeroMove : MonoBehaviour
    {
        public CharacterController CharacterController;
        private float MovementSpeed { get; set; }

        private void Update()
        {
            CharacterController.Move(MovementSpeed * movementVector * Time.deltaTime);
        }

    }
}