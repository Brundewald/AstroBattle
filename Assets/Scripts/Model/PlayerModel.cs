using UnityEngine;

namespace Assets.Scripts.Model
{
    public class PlayerModel
    {
        [SerializeField] private float _speed;

        public float Speed => _speed;
    }
}