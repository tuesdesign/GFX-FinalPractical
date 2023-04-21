using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[ExecuteInEditMode, ImageEffectAllowedInSceneView]
public class Bloom : MonoBehaviour
{
    // Start is called before the first frame update
    const int BoxDownPrefilterPass = 0;
    const int BoxDownPass = 1;
    const int BoxUpPass = 2;
    const int ApplyBloomPass = 3;
    const int DebugBloomPass = 4;

    public bool DoBloom = true;

    public Shader bloomShader;
    public bool debug;


    [Range(1, 16)]
    public int iterations = 4;

    [Range(0, 10)]
    public float threshold = 1;
    float thresholdUse = 1;

    [Range(0, 10)]
    public float intensity = 1;

    RenderTexture[] textures = new RenderTexture[16];

    [NonSerialized]
    Material bloom;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (!DoBloom)
        {
            thresholdUse = 100.0f;
        }
        else
        {
            thresholdUse = threshold;
        }

        if (bloom == null)
        {
            bloom = new Material(bloomShader);
            bloom.hideFlags = HideFlags.HideAndDontSave;
        }

        bloom.SetFloat("_Threshold", thresholdUse);
        bloom.SetFloat("_Intensity", Mathf.GammaToLinearSpace(intensity));

        int width = source.width / 2;
        int height = source.height / 2;

        RenderTextureFormat format = source.format;
        RenderTexture currentDestination = textures[0] =

        RenderTexture.GetTemporary(width, height, 0, format);
        Graphics.Blit(source, currentDestination, bloom, BoxDownPrefilterPass);

        RenderTexture currentSource = currentDestination;
        int i = 1;
        for (; i < iterations; i++)
        {
            width /= 2;
            height /= 2;
            if (height < 2)
            {
                break;
            }
            currentDestination = textures[i] =
                RenderTexture.GetTemporary(width, height, 0, format);

            Graphics.Blit(currentSource, currentDestination, bloom, BoxDownPass);
            currentSource = currentDestination;
        }
        for (i -= 2; i >= 0; i--)
        {
            currentDestination = textures[i];
            textures[i] = null;
            Graphics.Blit(currentSource, currentDestination, bloom, BoxUpPass);
            RenderTexture.ReleaseTemporary(currentSource);
            currentSource = currentDestination;
        }
        if (debug)
        {
            Graphics.Blit(currentSource, destination, bloom, DebugBloomPass);
        }
        else
        {
            bloom.SetTexture("_SourceTex", currentSource);
            Graphics.Blit(source, destination, bloom, ApplyBloomPass);
        }
        RenderTexture.ReleaseTemporary(currentSource);
    }

}
