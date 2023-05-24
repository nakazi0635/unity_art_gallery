using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skinned : MonoBehaviour
{
    // カーテンオブジェクトを保持しておく変数
    public GameObject[] skinnedMeshObjects;
    // 額縁オブジェクトを保持しておく変数
    public GameObject[] targetObjects;
    public float offsetDistance = 0.1f; // 手前に配置する距離

    private SkinnedMeshRenderer[] skinnedMeshRenderers;
    private Transform[] targetTransforms;

    private void Start()
    {
        // 登録した数だけ配列取得
        skinnedMeshRenderers = new SkinnedMeshRenderer[skinnedMeshObjects.Length];
        targetTransforms = new Transform[targetObjects.Length];

        for (int i = 0; i < skinnedMeshObjects.Length; i++)
        {
            // SkinnedMeshRendererクラスを取得
            skinnedMeshRenderers[i] = skinnedMeshObjects[i].GetComponent<SkinnedMeshRenderer>();
        }

        for (int i = 0; i < targetObjects.Length; i++)
        {
            // 対応する額縁オブジェクトの現在位置を取得
            targetTransforms[i] = targetObjects[i].transform;
        }
    }
    // 1フレームの最後に呼ばれる関数
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
