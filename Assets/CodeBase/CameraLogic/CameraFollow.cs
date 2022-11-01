using UnityEngine;

namespace CodeBase.CameraLogic
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] private Transform _following;

        [SerializeField] private float _offsetY;

        [SerializeField] private float _distance;

        [SerializeField] private float _rotationAngleX;
        
        [SerializeField] private float _rotationAngleY;

        private void LateUpdate()
        {
            if (_following == null)
                return;

            var rotation = Quaternion.Euler(_rotationAngleX, _rotationAngleY, 0);
            var position = rotation * new Vector3(0, 0, -_distance) + FollowingPointPosition();

            transform.rotation = rotation;
            transform.position = position;
        }

        private Vector3 FollowingPointPosition()
        {
            var followingPosition = _following.position;
            followingPosition.y += _offsetY;

            return followingPosition;
        }

        public void Follow(GameObject following) =>
            _following = following.transform;
    }
}