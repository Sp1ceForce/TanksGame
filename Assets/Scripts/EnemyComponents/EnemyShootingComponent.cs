using UnityEngine;
using UnityEngine.Events;

//Controller used for enemy's shooting
public class EnemyShootingComponent : MonoBehaviour
{
    //Point where is the shot coming from
    [SerializeField] Transform shootingPoint;
    //Bullet's prefab
    [SerializeField] ProjectileDamageComponent bullet;
    //Damage of every shot
    [SerializeField] int damage = 30;
    //Time between every shot
    [SerializeField] float timeBtwnShoots = 0.25f;
    //Event called on every shot
    [SerializeField] UnityEvent OnShoot;
    //Internal varibable used to count time between shots
    float shootTimer = 0;
    //GameObject controlled by the player, used to count distance between enemy and player
    GameObject playerObject;
    //Stats that define range where enemy see you and where he can shoot
    EnemyStats stats;
    public void Start()
    {
        stats = GetComponent<EnemyStats>();
        playerObject = StaticHelper.Instance.PlayerObject;
    }
    public void SetStats(float fireRate, int damage)
    {
        this.damage = damage;
        timeBtwnShoots = fireRate;
    }
    public void Update()
    {
        if (playerObject == null) return;
        //Check if player is in radius where enemy can shoot
        if (Vector2.Distance(transform.position, playerObject.transform.position) > stats.ShootingRadius) return;
        //If cooldown ran out, then shoot
        if (shootTimer <= 0)
        {
            OnShoot?.Invoke();
            var bulletObj = Instantiate(bullet, shootingPoint.position, shootingPoint.rotation);
            bulletObj.Init(damage);
            shootTimer = timeBtwnShoots;
        }
        //If shot is on cooldown, then decrease cooldown timer
        if (shootTimer > 0) shootTimer -= Time.deltaTime;
    }
}
