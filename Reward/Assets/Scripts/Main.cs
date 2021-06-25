using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField]
    private DailyRewardView _dailyRewardView;

    private DailyRewardController _dailyRewardController;

    private void Awake()
    {
        _dailyRewardController = new DailyRewardController(_dailyRewardView);
    }

    private void Start()
    {
        _dailyRewardController.RefreshView();
    }

    private void OnDestroy()
    {
        _dailyRewardController.Dispose();
    }
}
