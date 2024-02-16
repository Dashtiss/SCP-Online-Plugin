using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCP_Online_Plugin
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;


        [Description("ServerID that will be sent to the database, don't change this cause it could break things")]
        public int ServerID { get; set; }


        public bool Debug { get; set; } = false;
    }
}
