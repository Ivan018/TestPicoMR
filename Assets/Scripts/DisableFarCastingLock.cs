using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class DisableFarCastingLock : MonoBehaviour
{
    public NearFarInteractor nearFarInteractor;

    void Start()
    {
        if (nearFarInteractor == null)
            nearFarInteractor = GetComponent<NearFarInteractor>();

        // 初始化时强制关闭
        if (nearFarInteractor != null)
        {
            nearFarInteractor.enableFarCasting = false;
        }
    }

    void Update()
    {
        // 每帧强制检查，防止被 UI 事件或其他逻辑重新开启
        if (nearFarInteractor != null && nearFarInteractor.enableFarCasting)
        {
            nearFarInteractor.enableFarCasting = false;
        }
    }
}
