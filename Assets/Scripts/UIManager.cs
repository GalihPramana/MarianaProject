using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject infoPanel;
    public Text nameText;
    public Text descriptionText;
    public Image creatureImage;

    [Header("Sound Effects")]
    public AudioSource audioSource;
    public AudioClip closePanelSFX;
    public AudioClip popUpPanelSFX;
    public float sfxVolume = 1f;

    private bool isPanelOpen = false;

    void Start()
    {
        infoPanel.SetActive(false); // hidden saat awal
    }

    void Update()
    {
        // Tekan Q untuk nutup pop-up
        if (isPanelOpen && Input.GetKeyDown(KeyCode.Q))
        {
            // Play close sound
            if (closePanelSFX != null)
            {
                if (audioSource != null)
                {
                    audioSource.PlayOneShot(closePanelSFX, sfxVolume);
                }
            }
            HideCreatureInfo();
            isPanelOpen = true;
        }
    }

    public void ShowCreatureInfo(HewanLaut creature)
    {
        infoPanel.SetActive(true);
        // Play Pop Up Sound Effect
        if (popUpPanelSFX != null)
        {
            if (audioSource != null)
            {
                audioSource.PlayOneShot(popUpPanelSFX, sfxVolume);
            }
        }
        nameText.text = creature.creatureName;
        descriptionText.text = creature.description;
        creatureImage.sprite = creature.image;
        isPanelOpen = true;
    }

    public void HideCreatureInfo()
    {
        infoPanel.SetActive(false);
        isPanelOpen = false;
    }
}
