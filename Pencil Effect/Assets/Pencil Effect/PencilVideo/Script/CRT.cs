using UnityEngine;

[ExecuteInEditMode]
public class CRT : MonoBehaviour
{
    public static Texture2D renderedTexture;
    public Material Mat;

    public void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, Mat);
    }
}