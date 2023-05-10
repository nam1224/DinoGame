using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ShaderScript : MonoBehaviour
{
    public Color color = Color.yellow;

    [Range(0, 16)]
    public int outlineSize = 0;

    private SpriteRenderer spriteRenderer;

    private void OnEnable() //setActive가 true일 때 실행
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        UpdateOutline(true);
    }

    private void OnDisable()//setActive가 false일 때 실행
    {
        UpdateOutline(true);
    }

    void Update()
    {
        UpdateOutline(true);
    }

    void UpdateOutline(bool outline)
    {
        MaterialPropertyBlock mpb = new MaterialPropertyBlock(); //Material의 값 클래스 선언
        spriteRenderer.GetPropertyBlock(mpb); //매터리얼 값 가져오기
        mpb.SetFloat("_Outline", outline ? 1f : 0);
        mpb.SetColor("_OutlineColor", color);
        mpb.SetFloat("_OutlineSize", outlineSize);
        spriteRenderer.SetPropertyBlock(mpb); //매터리얼 값 세팅하기
    }
}
