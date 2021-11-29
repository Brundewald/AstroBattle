using UnityEngine;

namespace Assets.Scripts.View
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerView: MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _rigidbody2D;

        public Rigidbody2D PlayerRigidbody => _rigidbody2D;
    }

}