using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LUTCamera : MonoBehaviour
{
    public Shader myShader = null;
    [SerializeField] List<Material> m_renderMaterials;
    public Material m_renderMaterialCurrent;
    private void Start()
    {
        m_renderMaterialCurrent = m_renderMaterials[0];
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            m_renderMaterialCurrent = m_renderMaterials[0];
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            m_renderMaterialCurrent = m_renderMaterials[1];
        }
        if (Input.GetKeyDown(KeyCode.Keypad6))
        {
            m_renderMaterialCurrent = m_renderMaterials[2];
        }
        if (Input.GetKeyDown(KeyCode.Keypad7))
        {
            m_renderMaterialCurrent = m_renderMaterials[3];
        }
        
    }
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, m_renderMaterialCurrent);
    }
}
