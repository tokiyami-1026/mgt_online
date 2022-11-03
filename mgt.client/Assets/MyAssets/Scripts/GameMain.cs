using Fusion;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GameMain
{
    /// <summary>
    /// ゲームのエントリーポイント
    /// </summary>
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Main()
    {
        // NetworkRunnerを生成する
        var networkRunnerObject = new GameObject(typeof(NetworkRunner).Name);
        var networkRunner = networkRunnerObject.AddComponent<NetworkRunner>();
        GameObject.DontDestroyOnLoad(networkRunnerObject);

        // ゲーム終了時に呼ばれる関数を引っかけておく
        Application.quitting += OnQuitGame;
    }

    /// <summary>
    /// ゲームが終了するとき
    /// </summary>
    private static void OnQuitGame()
    {
        // 引っかけておいた関数を解除する
        Application.quitting -= OnQuitGame;
    }
}
