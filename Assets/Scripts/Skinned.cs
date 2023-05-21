using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skinned : MonoBehaviour
{
    public GameObject skinnedMeshObject;
    public GameObject targetObject;
    public float offsetDistance = 0.1f; // 手前に配置する距離

    private SkinnedMeshRenderer skinnedMeshRenderer;
    private Transform targetTransform;

    private void Start()
    {
        skinnedMeshRenderer = skinnedMeshObject.GetComponent<SkinnedMeshRenderer>();
        targetTransform = targetObject.transform;
    }

    private void LateUpdate()
    {
        Vector3 center = skinnedMeshRenderer.bounds.center;
        Vector3 offset = skinnedMeshRenderer.transform.forward * offsetDistance; // 手前に移動するオフセットベクトル
        targetTransform.position = center + offset;
    }
}
