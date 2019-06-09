using System;
using AltV.Net;
using AltV.Net.Elements.Entities;
using AltV.Net.Data;
using AltV.Net.Enums;

namespace GettingStarted
{
    public class Server : Resource
    {
        public override void OnStart()
        {
            Alt.Log("Server is listening!");

            //Events
            Alt.OnPlayerConnect += OnPlayerConnect;
            Alt.OnPlayerDead += OnPlayerDead;
        }

        private void OnPlayerDead(IPlayer player, IEntity killer, uint weapon)
        {
            player.Position = new Position((float)-1070.906250, (float)-2972.122803, (float)13.773568); // LS AIR Position
            player.GiveWeapon(Weapons.AssaultRifle, 9000, true);
        }

        private void OnPlayerConnect(IPlayer player, string reason)
        {
            Alt.Log($"Player has connected! {player.Name}");

            player.Model = 0x3D843282;
            player.Position = new Position((float)-1070.906250, (float)-2972.122803, (float)13.773568); // LS AIR Position
            player.GiveWeapon(Weapons.AssaultRifle, 9000, true);
        }

        public override void OnStop()
        {
            Alt.Log("Server Stopped.");
        }
    }
}
