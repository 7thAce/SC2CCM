using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft_Mod_Manager
{
    public enum Campaign : int
    {
        None = 0,
        WoL = 1,
        HotS = 2,
        LotV = 3,
        NCO = 4
    }
    class Mod
    {
        private string title = "N/A";
        private string author = "N/A";
        private string desc = "N/A";
        private int campaign = 0;
        private string path = "";
        private string version = "N/A";
        private string lotvprologue = "no";

        public void SetTitle(string _title)
        {
            title = _title;
        }

        public void SetAuthor(string _author)
        {
            author = _author;
        }

        public void SetDesc(string _desc)
        {
            desc = _desc;
        }

        public void SetPath(string _path)
        {
            path = _path;
        }

        public void SetVersion(string _version)
        {
            version = _version;
        }

        public void SetPrologue(string _prologue)
        {
            lotvprologue = _prologue;
        }

        public int GetCampaign()
        {
            return campaign; 
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetVersion()
        {
            return version;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetDesc()
        {
            return desc;
        }

        public string GetPath()
        {
            return path;
        }

        public string GetPrologue()
        {
            return lotvprologue;
        }


        public void SetCampaign(string _campaign)
        {
            _campaign = _campaign.ToLower();
            if (_campaign.Contains("wings") || _campaign.Contains("liberty") || _campaign.Contains("wol"))
            {
                campaign = (int)Campaign.WoL;
                return;
            }
            if (_campaign.Contains("heart") || _campaign.Contains("swarm") || _campaign.Contains("hots"))
            {
                campaign = (int)Campaign.HotS;
                return;
            }
            if (_campaign.Contains("legacy") || _campaign.Contains("void") || _campaign.Contains("lotv"))
            {
                campaign = (int)Campaign.LotV;
                return;
            }
            if (_campaign.Contains("nova") || _campaign.Contains("covert") || _campaign.Contains("ops") || _campaign.Contains("nco"))
            {
                campaign = (int)Campaign.NCO;
                return;
            }
            campaign = (int)Campaign.None; //This is a problem!
        }
    }
}
