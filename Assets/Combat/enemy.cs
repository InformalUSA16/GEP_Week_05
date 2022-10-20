using UnityEngine;

namespace Combat
{
    public class enemy : MonoBehaviour,iWeapon
    {
        public Necro_Longsword Weapon = new Necro_Longsword();
        public void WeaponDamage(int _Damage)
        {
            _Damage = Weapon._Damage;
        }
        public void WeaponRange(int _Range)
        {
            _Range = Weapon._Range;
        }
        public void WeaponType(string _Type)
        {
            _Type = Weapon._Type;
        }
        public void DamageType(string _DamageType)
        {
            _DamageType = Weapon._DamageType;
        }
    }
}