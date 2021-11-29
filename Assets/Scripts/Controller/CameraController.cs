using Assets.Scripts.Interface;
using Assets.Scripts.View;
using UnityEngine;

namespace Assets.Scripts.Controller
{
    public class CameraController:ILateExecute
    {
        private readonly Transform _playerTransform;
        private readonly Camera _camera;
        private readonly Vector3 _cameraOffset;

        public CameraController(Camera camera, PlayerView playerView)
        {
            _playerTransform = playerView.transform;
            _camera = camera;
            _cameraOffset = _camera.transform.position - _playerTransform.position;
        }

        public void LateExecute(float lateDeltaTime)
        {
            var destination = _playerTransform.position + _cameraOffset;
            _camera.transform.position = destination;
        }
    }
}