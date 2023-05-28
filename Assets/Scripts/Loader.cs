using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    [SerializeField]
    private Renderer[] playerRenderer;
    [SerializeField]
    private float[] _canalOfColor;
    [SerializeField] private GameObject[] _hats;
    private int _indexOfhats;
    private void Awake()
    {
        _indexOfhats = PlayerPrefs.GetInt("NumberOfHats");
        _hats[_indexOfhats].SetActive(true);

        _canalOfColor = new float[3];
        _canalOfColor[0] = PlayerPrefs.GetFloat("PlayerColor_R");
        _canalOfColor[1] = PlayerPrefs.GetFloat("PlayerColor_G");
        _canalOfColor[2] = PlayerPrefs.GetFloat("PlayerColor_B");

        for(int i = 0; i < playerRenderer.Length; i++)
        {
            playerRenderer[i].material.color = new Color(_canalOfColor[0], _canalOfColor[1], _canalOfColor[2]);
        }

    }
}
