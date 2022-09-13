using UnityEngine;
using UnityEngine.Events;

public class PlayersCashComponent : MonoBehaviour
{
    public UnityEvent<int> OnCashUpdate;
    public UnityEvent OnCashSpend;
    public UnityEvent OnCashAdd;
    [SerializeField] int _playersCash = 0;
    public int PlayersMoney { get => _playersCash; }

    public void AddCash(int addMoney)
    {
        _playersCash += addMoney;
        OnCashUpdate?.Invoke(_playersCash);
        OnCashAdd?.Invoke();
    }
    public void SpendCash(int spendMoney)
    {
        _playersCash -= spendMoney;
        OnCashSpend?.Invoke();
        OnCashUpdate?.Invoke(_playersCash);
    }
}
