using UnityEngine;

public class Good : MonoBehaviour
{
    [SerializeField, Min(0f)] private float _interval = 1f;

    private float _time = 0f;
    
    private void Update()
    {
        _time += Time.deltaTime;

        if (_time < _interval)
            return;
        
        _time -= _interval;
        Debug.Log("Timer reached");
    }
}
