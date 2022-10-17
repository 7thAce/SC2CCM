using ModManager.StarCraft.Base.Enums;

namespace ModManager.StarCraft.Base
{
    public class Mod
    {
        public string Title { get; set; } = "N/A";
        public string Author = "N/A";
        public string Description = "N/A";
        public Campaign Campaign { get; set; } = Campaign.None;
        public string Path { get; set; } = "";
        public string Version { get; set; } = "N/A";
        public string LotVprologue { get; set; } = "no";

        public void SetCampaign(string _campaign)
        {
            _campaign = _campaign.ToLower();
            if (_campaign.Contains("wings") || _campaign.Contains("liberty") || _campaign.Contains("wol"))
            {
                Campaign = Campaign.WoL;
                return;
            }
            if (_campaign.Contains("heart") || _campaign.Contains("swarm") || _campaign.Contains("hots"))
            {
                Campaign = Campaign.HotS;
                return;
            }
            if (_campaign.Contains("legacy") || _campaign.Contains("void") || _campaign.Contains("lotv"))
            {
                Campaign = Campaign.LotV;
                return;
            }
            if (_campaign.Contains("nova") || _campaign.Contains("covert") || _campaign.Contains("ops") || _campaign.Contains("nco"))
            {
                Campaign = Campaign.NCO;
                return;
            }
            Campaign = Campaign.None; //This is a problem!
        }

        public override string ToString()
        {
            return $"{Title} {Version}";
        }
    }
}
