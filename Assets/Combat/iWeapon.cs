using UnityEngine;

namespace Combat
{
    public interface iWeapon
    {
       public void WeaponDamage (int _Damage);
       public void WeaponRange (int _Range);
       public void WeaponType (string _Type);
       public void DamageType(string _DamageType);
                
    }
}