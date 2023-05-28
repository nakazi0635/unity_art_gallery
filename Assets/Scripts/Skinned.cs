using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// オブジェクトががClothコンポーネントの動きに同期するクラス
public class Skinned : MonoBehaviour
{
    [SerializeField]
    GameObject[] skinnedMeshObjects; // カーテンオブジェクトを保持しておく変数
    [SerializeField]
    GameObject[] targetObjects; // 額縁オブジェクトを保持しておく変数
    [SerializeField]
    float offsetDistance = 0.1f; // カーテンから少し手前に額縁を配置するための距離変数
    [HideInInspector]
    SkinnedMeshRenderer[] skinnedMeshRenderers; // SkinnedMeshRendererクラス配列宣言 
    [HideInInspector]
    Transform[] targetTransforms; // Transformクラス配列宣言 

    private void Start()
    {
        skinnedMeshRenderers = new SkinnedMeshRenderer[skinnedMeshObjects.Length]; // 登録したカーテンオブジェクトの数だけ配列数取得
        targetTransforms = new Transform[targetObjects.Length]; // 登録した額縁オブジェクト数だけ配列数取得

        for (int i = 0; i < skinnedMeshObjects.Length; i++) // 配列の長さ（登録したカーテンオブジェクトの数）だけループさせる
        {
            skinnedMeshRenderers[i] = skinnedMeshObjects[i].GetComponent<SkinnedMeshRenderer>(); // SkinnedMeshRendererクラスを取得
        }

        for (int i = 0; i < targetObjects.Length; i++) // 配列の長さ（登録した額縁オブジェクトの数）だけループさせる
        {
            targetTransforms[i] = targetObjects[i].transform; // 対応する額縁オブジェクトの現在位置を取得
        }
    }
    private void LateUpdate() // 1フレームの最後に呼ばれる関数
    {
        for (int i = 0; i < skinnedMeshRenderers.Length; i++) // 配列の長さ（登録したカーテンオブジェクトの数）だけループさせる
        {
            Vector3 center = skinnedMeshRenderers[i].bounds.center; // SkinnedMeshRendererクラスの中心座標取得
            Vector3 offset = skinnedMeshRenderers[i].transform.forward * offsetDistance; // 少し手前に配置するための計算(Z軸ベクトル*手前に移動するオフセットベクトル)
            targetTransforms[i].position = center + offset; // 額縁オブジェクトの位置を更新
        }
    }
}
