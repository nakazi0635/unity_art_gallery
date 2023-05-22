using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skinned : MonoBehaviour
{
    public GameObject[] skinnedMeshObjects;
    public GameObject[] targetObjects;
    public float offsetDistance = 0.1f; // 手前に配置する距離

    private SkinnedMeshRenderer[] skinnedMeshRenderers;
    private Transform[] targetTransforms;

    private void Start()
    {
        skinnedMeshRenderers = new SkinnedMeshRenderer[skinnedMeshObjects.Length];
        targetTransforms = new Transform[targetObjects.Length];

        for (int i = 0; i < skinnedMeshObjects.Length; i++)
        {
            skinnedMeshRenderers[i] = skinnedMeshObjects[i].GetComponent<SkinnedMeshRenderer>();
        }

        for (int i = 0; i < targetObjects.Length; i++)
        {
            targetTransforms[i] = targetObjects[i].transform;
        }
    }

    private void LateUpdate()
    {
        for (int i = 0; i < skinnedMeshRenderers.Length; i++)
        {
            Vector3 center = skinnedMeshRenderers[i].bounds.center;
            Vector3 offset = skinnedMeshRenderers[i].transform.forward * offsetDistance; // 手前に移動するオフセットベクトル
            targetTransforms[i].position = center + offset;
        }
    }
}
