using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class GameplayTester : MonoBehaviour
{
    #region Variables

    [Header("PLAYER")]
    [SerializeField] private Transform _player;
    [SerializeField] private float _fallThreshold = -10f;

    [Header("DEBUG OPTION")]
    [SerializeField] private bool _logErrors;

    #endregion

    #region Methods

    private void Update() {
        if (_player.position.y < _fallThreshold) {
            if (_logErrors) {
                Debug.LogWarning("¡Player Fall!");
            }
            _player.position = Vector3.zero;
        }
    }

    #endregion
}
