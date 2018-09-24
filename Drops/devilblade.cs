using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
 
namespace TCSSC.Drops
{
    public class devilblade : GlobalNPC
    {
        public override void NPCLoot(NPC npc)
        {
            {
                if (Main.player[Main.myPlayer].ZoneUnderworldHeight) 
                if (Main.hardMode)
                {
              if(Main.rand.Next(400) < 1)
                {
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Blood_Shortsword"));
                }
                }
				
				 if (Main.player[Main.myPlayer].ZoneRockLayerHeight) 
                if (Main.player[Main.myPlayer].ZoneSnow)   
                {
              if(Main.rand.Next(200) < 1)
                {
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Freezing_Bite"));
                }
            }
		}
    }
}}	