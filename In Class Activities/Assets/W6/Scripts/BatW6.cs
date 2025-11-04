using UnityEngine;

public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _playerTransform;
    
    public void EnableChase(Transform player)
    {
        enabled = true;
        _playerTransform = player; 
    }
    public void DisableChase()
    {
        enabled = false;
    }
    private void Update()
    {
        if (_playerTransform == null) return;
        transform.position = Vector3.MoveTowards(
            transform.position,
            _playerTransform.position,
            _speed * Time.deltaTime
        );
    }
}
