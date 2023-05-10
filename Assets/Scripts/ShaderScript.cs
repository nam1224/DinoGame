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

    private void OnEnable() //setActive�� true�� �� ����
    {
        spriteRenderer = GetComponent<SpriteRenderer>();

        UpdateOutline(true);
    }

    private void OnDisable()//setActive�� false�� �� ����
    {
        UpdateOutline(true);
    }

    void Update()
    {
        UpdateOutline(true);
    }

    void UpdateOutline(bool outline)
    {
        MaterialPropertyBlock mpb = new MaterialPropertyBlock(); //Material�� �� Ŭ���� ����
        spriteRenderer.GetPropertyBlock(mpb); //���͸��� �� ��������
        mpb.SetFloat("_Outline", outline ? 1f : 0);
        mpb.SetColor("_OutlineColor", color);
        mpb.SetFloat("_OutlineSize", outlineSize);
        spriteRenderer.SetPropertyBlock(mpb); //���͸��� �� �����ϱ�
    }
}
