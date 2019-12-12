using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int hp = 100;     //血量
    public Slider hpSlider;  //血量滑桿


    //觸發事件:碰到勾選 IsTrigger 物件會執行一次
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "陷阱")    //血量 扣10
        {
            int d = object.Getcomponent<Trap>().damage;
            hp -= d;               // 血量滑 值 = 血量  
        hpSlider.value = hp;
    }
}
    private void OnParticleCollision(GameObject other)
    { 
        if (other.tag == "陷阱")
    {
        int d = other.
    }

