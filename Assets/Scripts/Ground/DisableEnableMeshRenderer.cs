using System.Collections;
using UnityEngine;

public class DisableEnableMeshRenderer : MonoBehaviour
{
    // Serialize fields
    [SerializeField] private float _secondsDelay = 1f;

    // Private fields
    private MeshRenderer _meshRenderer;
    private bool _coroutineEnd = true;

    private void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        // Disable/Enable Mesh Renderer
        if (_coroutineEnd)
        {
            StartCoroutine(ChangeState());
            _coroutineEnd = false;
        }
    }

    private IEnumerator ChangeState()
    {
        yield return new WaitForSeconds(_secondsDelay);

        if (_meshRenderer.enabled)
        {
            _meshRenderer.enabled = false;
        }
        else if (!_meshRenderer.enabled)
        {
            _meshRenderer.enabled = true;
        }
        _coroutineEnd = true;
    }
}
